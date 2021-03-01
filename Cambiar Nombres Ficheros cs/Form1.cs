// ------------------------------------------------------------------------------
// Cambiar los nombres de los ficheros                               (25/feb/21)
// 
// ©Guillermo Som (elGuille), 2021
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cambiar_Nombres_Ficheros_cs
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cuantosFinalizados;
        private int cuantosProcesos;

        private List<string> ficheros = new List<string>();

        private elGuille.Util.Config cfg;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarCfg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            LabelStatus.Text = $"{Application.ProductName} v{Application.ProductVersion} - ©Guillermo Som (elGuille), 2005-2008, 2021";
            LabelStatus.Tag = LabelStatus.Text;

            ProgressBar1.Visible = false;

            txtDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            habilitarSimple(grbGrupo1, false, chkProces1);
            habilitarSimple(grbGrupo2, false, chkProces2);
            habilitarSimple(grbGrupo3, false, chkProces3);

            string ficConfig = System.Reflection.Assembly.GetExecutingAssembly().Location + ".cfg";
            cfg = new elGuille.Util.Config(ficConfig);
            cfg.Read();
            leerCfg();
        }

        private void guardarCfg()
        {
            cfg.SetKeyValue("Grupo0", "Dir", txtDir.Text);
            cfg.SetKeyValue("Grupo1", "Dir", txtDir1.Text);
            cfg.SetKeyValue("Grupo2", "Dir", txtDir2.Text);
            cfg.SetKeyValue("Grupo3", "Dir", txtDir3.Text);
            cfg.SetKeyValue("Grupo1", "Comprobar", this.chkProces1.Checked);
            cfg.SetKeyValue("Grupo2", "Comprobar", this.chkProces2.Checked);
            cfg.SetKeyValue("Grupo3", "Comprobar", this.chkProces3.Checked);
            cfg.SetValue("Grupo0", "Filtro", txtExtensiones.Text);
            cfg.SetValue("Grupo1", "Filtro", txtExtensiones1.Text);
            cfg.SetValue("Grupo2", "Filtro", txtExtensiones2.Text);
            cfg.SetValue("Grupo3", "Filtro", txtExtensiones3.Text);
            cfg.SetValue("PonerCambiar", "Texto1", txtTexto1.Text);
            cfg.SetValue("PonerCambiar", "Texto2", txtTexto2.Text);
            cfg.SetValue("PonerCambiar", "AlPrincipio", optAñadirPrincipio.Checked);
            cfg.SetValue("PonerCambiar", "AlFinal", optAñadirFinal.Checked);
            cfg.SetValue("PonerCambiar", "NoDuplicar", chkNoDuplicar.Checked);
            cfg.SetValue("PonerCambiar", "Cambiar", optCambiar.Checked);
            cfg.SetValue("PonerCambiar", "QuitarPrincipio", optQuitarPrincipio.Checked);
            cfg.SetValue("PonerCambiar", "QuitarFinal", optQuitarFinal.Checked);

            cfg.Save();
        }

        private void leerCfg()
        {
            txtDir.Text = cfg.GetValue("Grupo0", "Dir", "");
            txtDir1.Text = cfg.GetValue("Grupo1", "Dir", "");
            txtDir2.Text = cfg.GetValue("Grupo2", "Dir", "");
            txtDir3.Text = cfg.GetValue("Grupo3", "Dir", "");
            this.chkProces1.Checked = cfg.GetValue("Grupo1", "Comprobar", false);
            this.chkProces2.Checked = cfg.GetValue("Grupo2", "Comprobar", false);
            this.chkProces3.Checked = cfg.GetValue("Grupo3", "Comprobar", false);
            txtExtensiones.Text = cfg.GetValue("Grupo0", "Filtro", "");
            txtExtensiones1.Text = cfg.GetValue("Grupo1", "Filtro", "");
            txtExtensiones2.Text = cfg.GetValue("Grupo2", "Filtro", "");
            txtExtensiones3.Text = cfg.GetValue("Grupo3", "Filtro", "");
            txtTexto1.Text = cfg.GetValue("PonerCambiar", "Texto1", "");
            txtTexto2.Text = cfg.GetValue("PonerCambiar", "Texto2", "");
            optAñadirPrincipio.Checked = cfg.GetValue("PonerCambiar", "AlPrincipio", true);
            optAñadirFinal.Checked = cfg.GetValue("PonerCambiar", "AlFinal", false);
            chkNoDuplicar.Checked = cfg.GetValue("PonerCambiar", "NoDuplicar", true);
            optCambiar.Checked = cfg.GetValue("PonerCambiar", "Cambiar", false);
            optQuitarPrincipio.Checked = cfg.GetValue("PonerCambiar", "QuitarPrincipio", false);
            optQuitarFinal.Checked = cfg.GetValue("PonerCambiar", "QuitarFinal", false);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog bf = new FolderBrowserDialog();
            TextBox txt;

            if (sender == btnExaminar1)
                txt = this.txtDir1;
            else if (sender == btnExaminar2)
                txt = this.txtDir2;
            else if (sender == btnExaminar3)
                txt = this.txtDir3;
            else
                txt = this.txtDir;
            {
                bf.Description = "Selecciona el directorio con los ficheros a procesar";
                bf.RootFolder = Environment.SpecialFolder.MyComputer;
                bf.SelectedPath = txt.Text;
                if (bf.ShowDialog() == DialogResult.OK)
                    txt.Text = bf.SelectedPath;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ficheros.Clear();
            cuantosFinalizados = 0;
            cuantosProcesos = 1;

            // Si al final del texto a buscar/poner
            // hay más de un espacio, cambiarlo por solo 1
            if (txtTexto1.Text.EndsWith(" "))
                txtTexto1.Text = txtTexto1.Text.TrimEnd(' ') + " ";
            if (txtTexto2.Text.EndsWith(" "))
                txtTexto2.Text = txtTexto2.Text.TrimEnd(' ') + " ";

            if (chkProces1.Checked)
            {
                cuantosProcesos += 1;
                bgwProc1.RunWorkerAsync();
            }
            if (chkProces2.Checked)
            {
                cuantosProcesos += 1;
                bgwProc2.RunWorkerAsync();
            }
            if (chkProces3.Checked)
            {
                cuantosProcesos += 1;
                bgwProc3.RunWorkerAsync();
            }

            // Este siempre se procesa
            // Hacer esta llamada al final para que se restauren los valores
            // al terminar el trabajo.
            bgwProc.RunWorkerAsync();
        }

        private void RenameFile(string oldFile, string newFile)
        {
            // Añadir el path del fichero de origen
            var ficDest = Path.Combine(Path.GetDirectoryName(oldFile), newFile);
            File.Copy(oldFile, ficDest, true);
            // Solo borrar si se ha hecho la copia
            if(File.Exists(ficDest))
                File.Delete(oldFile);
        }

        private void cambiarNombres(string file)
        {
            System.IO.FileInfo fi = new FileInfo(file);
            string s = file;
            // fi.Name contiene también la extensión                     (01/Mar/21)
            // Al hacer el cambio del principio o final,
            // NO buscar el texto a cambiar no tener en cuenta la extensión.
            var fiSoloNombre = System.IO.Path.GetFileNameWithoutExtension(file);
            var ext = fi.Extension;

            LabelStatus.Text = $"{fi.Name}";
            Application.DoEvents();

            if (optCambiar.Checked)
            {
                s = fi.Name.Replace(txtTexto1.Text, txtTexto2.Text);
                if (s != fi.Name)
                    RenameFile(file, s);
            }
            else if (optAñadirPrincipio.Checked)
            {
                if (chkNoDuplicar.Checked)
                {
                    if (fiSoloNombre.StartsWith(txtTexto1.Text) == false)
                    {
                        s = txtTexto1.Text + fi.Name;
                        RenameFile(file, s);
                    }
                }
                else
                {
                    s = txtTexto1.Text + fi.Name;
                    RenameFile(file, s);
                }
            }
            else if (optAñadirFinal.Checked)
            {
                if (chkNoDuplicar.Checked)
                {
                    if (fiSoloNombre.EndsWith(txtTexto1.Text) == false)
                    {
                        s = fiSoloNombre + txtTexto1.Text + ext;
                        RenameFile(file, s);
                    }
                }
                else
                {
                    s = fiSoloNombre + txtTexto1.Text + ext;
                    RenameFile(file, s);
                }
            }
            else if (optQuitarPrincipio.Checked)
            {
                if (fiSoloNombre.StartsWith(txtTexto1.Text))
                {
                    s = fiSoloNombre.Replace(txtTexto1.Text, "") + ext;
                    RenameFile(file, s);
                }
            }
            else if (optQuitarFinal.Checked)
            {
                if (fiSoloNombre.EndsWith(txtTexto1.Text))
                {
                    s = fiSoloNombre.Replace(txtTexto1.Text, "") + ext;
                    RenameFile(file, s);
                }
            }

            LabelStatus.Text += $" --> {s}";
            Application.DoEvents();
        }

        /// <summary>
        /// Método usado por el método DoWork de los BackgroundWorkers.
        /// </summary>
        /// <param name="txtDir">El directorio a usar.</param>
        /// <param name="filtro">El filtro de los ficheros a usar.</param>
        private void backgroundWorker_DoWork(TextBox txtDir, string filtro)
        {
            // Aquí se acumulan los ficheros en la colección
            // y se procesarán todos al final.
            // De esta forma sabemos cuántos ficheros se procesan en total.
            var fileEnum = Directory.EnumerateFiles(txtDir.Text, filtro);
            ficheros.AddRange(fileEnum);
        }

        private void bgwProc_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorker_DoWork(txtDir, txtExtensiones.Text);
        }

        private void bgwProc_RunWorkerCompleted(object sender, 
                                                System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            cuantosFinalizados += 1;
            // Cuando estén todos los procesos finalizados, hacer los cambios.
            if (cuantosFinalizados == cuantosProcesos)
                finalizarCopia();
        }

        private void finalizarCopia()
        {
            // Procesar los ficheros acumulados en la colección
            ProgressBar1.Visible = true;
            ProgressBar1.Maximum = ficheros.Count;
            ProgressBar1.Value = 0;

            for (var i = 0; i <= ficheros.Count - 1; i++)
            {
                cambiarNombres(ficheros[i]);
                ProgressBar1.Value = i + 1;
            }

            string s;
            if (ficheros.Count == 1)
                s = "el nombre al fichero.";
            else
                s = $"los {ficheros.Count} nombres.";
            LabelStatus.Text = $"Finalizado el proceso de cambiar {s}";
            Application.DoEvents();

            // Mostrar ese mensaje por 3 segundos
            timer1.Interval = 3000;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            ProgressBar1.Visible = false;
            LabelStatus.Text = LabelStatus.Tag.ToString();
            Application.DoEvents();
        }

        private void bgwProc1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorker_DoWork(txtDir1, txtExtensiones1.Text);
        }

        private void bgwProc2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorker_DoWork(txtDir2, txtExtensiones2.Text);
        }

        private void bgwProc3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorker_DoWork(txtDir3, txtExtensiones3.Text);
        }

        private void txtDir_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                var txt = sender as TextBox;
                if (txt == null)
                    return;

                var d = (string[])e.Data.GetData("FileDrop", true);
                string s = d[0];
                txt.Text = s;

                if (sender == this.txtDir1)
                    this.chkProces1.Checked = true;
                else if (sender == this.txtDir2)
                    this.chkProces2.Checked = true;
                else if (sender == this.txtDir3)
                    this.chkProces3.Checked = true;
            }
        }

        private void txtDir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
                e.Effect = DragDropEffects.Copy;
        }

        private void optAñadir_CheckedChanged(object sender, EventArgs e)
        {
            var opt = sender as RadioButton;
            if (opt == null)
                return;

            txtTexto2.Enabled = !opt.Checked;
            chkNoDuplicar.Enabled = opt.Checked;
        }

        private void optQuitar_CheckedChanged(object sender, EventArgs e)
        {
            var opt = sender as RadioButton;
            if (opt == null)
                return;

            txtTexto2.Enabled = !opt.Checked;
            if (opt.Checked)
                chkNoDuplicar.Enabled = false;
        }

        private void optCambiar_CheckedChanged(object sender, EventArgs e)
        {
            var opt = sender as RadioButton;
            if (opt == null)
                return;

            txtTexto2.Enabled = opt.Checked;
            if (opt.Checked)
                chkNoDuplicar.Enabled = false;
        }

        private void chkProces1_CheckedChanged(object sender, EventArgs e)
        {
            // grbGrupo1.Enabled = chkProces1.Checked
            habilitarSimple(grbGrupo1, chkProces1.Checked, chkProces1);
        }

        private void chkProces2_CheckedChanged(object sender, EventArgs e)
        {
            habilitarSimple(grbGrupo2, chkProces2.Checked, chkProces2);
        }

        private void chkProces3_CheckedChanged(object sender, EventArgs e)
        {
            habilitarSimple(grbGrupo3, chkProces3.Checked, chkProces3);
        }

        private void habilitarSimple(Control ctr, bool h, Control cSaltar)
        {
            for (var i = 0; i <= ctr.Controls.Count - 1; i++)
            {
                if (ctr.Controls[i] == cSaltar)
                    continue;
                ctr.Controls[i].Enabled = h;
            }
        }
    }
}
