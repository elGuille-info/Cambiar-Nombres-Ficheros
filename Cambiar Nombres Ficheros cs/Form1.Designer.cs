
namespace Cambiar_Nombres_Ficheros_cs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgwProc = new System.ComponentModel.BackgroundWorker();
            this.bgwProc1 = new System.ComponentModel.BackgroundWorker();
            this.bgwProc2 = new System.ComponentModel.BackgroundWorker();
            this.bgwProc3 = new System.ComponentModel.BackgroundWorker();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.optQuitarFinal = new System.Windows.Forms.RadioButton();
            this.optQuitarPrincipio = new System.Windows.Forms.RadioButton();
            this.chkNoDuplicar = new System.Windows.Forms.CheckBox();
            this.optAñadirFinal = new System.Windows.Forms.RadioButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.optCambiar = new System.Windows.Forms.RadioButton();
            this.optAñadirPrincipio = new System.Windows.Forms.RadioButton();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.grbGrupo0 = new System.Windows.Forms.GroupBox();
            this.txtExtensiones = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbGrupo3 = new System.Windows.Forms.GroupBox();
            this.txtExtensiones3 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.chkProces3 = new System.Windows.Forms.CheckBox();
            this.btnExaminar3 = new System.Windows.Forms.Button();
            this.txtDir3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.grbGrupo2 = new System.Windows.Forms.GroupBox();
            this.txtExtensiones2 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkProces2 = new System.Windows.Forms.CheckBox();
            this.btnExaminar2 = new System.Windows.Forms.Button();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.grbGrupo1 = new System.Windows.Forms.GroupBox();
            this.txtExtensiones1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.chkProces1 = new System.Windows.Forms.CheckBox();
            this.btnExaminar1 = new System.Windows.Forms.Button();
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox4.SuspendLayout();
            this.grbGrupo0.SuspendLayout();
            this.grbGrupo3.SuspendLayout();
            this.grbGrupo2.SuspendLayout();
            this.grbGrupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bgwProc
            // 
            this.bgwProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProc_DoWork);
            this.bgwProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProc_RunWorkerCompleted);
            // 
            // bgwProc1
            // 
            this.bgwProc1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProc1_DoWork);
            this.bgwProc1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProc_RunWorkerCompleted);
            // 
            // bgwProc2
            // 
            this.bgwProc2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProc2_DoWork);
            this.bgwProc2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProc_RunWorkerCompleted);
            // 
            // bgwProc3
            // 
            this.bgwProc3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProc3_DoWork);
            this.bgwProc3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProc_RunWorkerCompleted);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStatus.BackColor = System.Drawing.SystemColors.Info;
            this.LabelStatus.Location = new System.Drawing.Point(12, 586);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(3);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(508, 23);
            this.LabelStatus.TabIndex = 6;
            this.LabelStatus.Text = "Label11";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Controls.Add(this.optQuitarFinal);
            this.GroupBox4.Controls.Add(this.optQuitarPrincipio);
            this.GroupBox4.Controls.Add(this.chkNoDuplicar);
            this.GroupBox4.Controls.Add(this.optAñadirFinal);
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Controls.Add(this.Label9);
            this.GroupBox4.Controls.Add(this.txtTexto2);
            this.GroupBox4.Controls.Add(this.optCambiar);
            this.GroupBox4.Controls.Add(this.optAñadirPrincipio);
            this.GroupBox4.Controls.Add(this.txtTexto1);
            this.GroupBox4.Location = new System.Drawing.Point(12, 371);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(589, 172);
            this.GroupBox4.TabIndex = 4;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Texto a poner o cambiar";
            // 
            // optQuitarFinal
            // 
            this.optQuitarFinal.AutoSize = true;
            this.optQuitarFinal.Location = new System.Drawing.Point(126, 143);
            this.optQuitarFinal.Name = "optQuitarFinal";
            this.optQuitarFinal.Size = new System.Drawing.Size(92, 17);
            this.optQuitarFinal.TabIndex = 7;
            this.optQuitarFinal.Text = "Quitar del final";
            this.toolTip1.SetToolTip(this.optQuitarFinal, "Quitar del final del nombre del fichero el texto indicado en \'Texto 1\'");
            this.optQuitarFinal.UseVisualStyleBackColor = true;
            this.optQuitarFinal.CheckedChanged += new System.EventHandler(this.optQuitar_CheckedChanged);
            // 
            // optQuitarPrincipio
            // 
            this.optQuitarPrincipio.AutoSize = true;
            this.optQuitarPrincipio.Location = new System.Drawing.Point(126, 120);
            this.optQuitarPrincipio.Name = "optQuitarPrincipio";
            this.optQuitarPrincipio.Size = new System.Drawing.Size(112, 17);
            this.optQuitarPrincipio.TabIndex = 6;
            this.optQuitarPrincipio.Text = "Quitar del principio";
            this.toolTip1.SetToolTip(this.optQuitarPrincipio, "Quitar del principio del nombre del fichero el texto indicado en \'Texto 1\'");
            this.optQuitarPrincipio.UseVisualStyleBackColor = true;
            this.optQuitarPrincipio.CheckedChanged += new System.EventHandler(this.optQuitar_CheckedChanged);
            // 
            // chkNoDuplicar
            // 
            this.chkNoDuplicar.AutoSize = true;
            this.chkNoDuplicar.Checked = true;
            this.chkNoDuplicar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoDuplicar.Location = new System.Drawing.Point(359, 75);
            this.chkNoDuplicar.Name = "chkNoDuplicar";
            this.chkNoDuplicar.Size = new System.Drawing.Size(156, 17);
            this.chkNoDuplicar.TabIndex = 8;
            this.chkNoDuplicar.Text = "No añadir si ya está el texto";
            this.toolTip1.SetToolTip(this.chkNoDuplicar, resources.GetString("chkNoDuplicar.ToolTip"));
            this.chkNoDuplicar.UseVisualStyleBackColor = true;
            // 
            // optAñadirFinal
            // 
            this.optAñadirFinal.AutoSize = true;
            this.optAñadirFinal.Location = new System.Drawing.Point(126, 97);
            this.optAñadirFinal.Name = "optAñadirFinal";
            this.optAñadirFinal.Size = new System.Drawing.Size(88, 17);
            this.optAñadirFinal.TabIndex = 5;
            this.optAñadirFinal.Text = "Añadir al final";
            this.toolTip1.SetToolTip(this.optAñadirFinal, "Añadir al final del nombre del fichero el texto indicado en \'Texto 1\'");
            this.optAñadirFinal.UseVisualStyleBackColor = true;
            this.optAñadirFinal.CheckedChanged += new System.EventHandler(this.optAñadir_CheckedChanged);
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(12, 51);
            this.Label10.Margin = new System.Windows.Forms.Padding(3);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(106, 20);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Texto 2 (poner):";
            this.toolTip1.SetToolTip(this.Label10, "Al final se puede indicar un espacio, \r\nsi se indica más de un espacio, se dejará" +
        " solo uno.\r\n");
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(12, 25);
            this.Label9.Margin = new System.Windows.Forms.Padding(3);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(106, 20);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Texto 1:";
            this.toolTip1.SetToolTip(this.Label9, "Al final se puede indicar un espacio, \r\nsi se indica más de un espacio, se dejará" +
        " solo uno.");
            // 
            // txtTexto2
            // 
            this.txtTexto2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto2.Location = new System.Drawing.Point(126, 48);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(425, 20);
            this.txtTexto2.TabIndex = 3;
            // 
            // optCambiar
            // 
            this.optCambiar.AutoSize = true;
            this.optCambiar.Checked = true;
            this.optCambiar.Location = new System.Drawing.Point(359, 120);
            this.optCambiar.Name = "optCambiar";
            this.optCambiar.Size = new System.Drawing.Size(155, 17);
            this.optCambiar.TabIndex = 9;
            this.optCambiar.TabStop = true;
            this.optCambiar.Text = "Cambiar \'Text 1\' por \'Text 2\'";
            this.toolTip1.SetToolTip(this.optCambiar, "Si el contenido del primer cuadro de texto (Text 1) está en el nombre del fichero" +
        ", \r\nse cambiará por el indicado en el segundo cuadro de texto  (Texto 2).\r\nSi no" +
        " está, no se hará nada.");
            this.optCambiar.UseVisualStyleBackColor = true;
            this.optCambiar.CheckedChanged += new System.EventHandler(this.optCambiar_CheckedChanged);
            // 
            // optAñadirPrincipio
            // 
            this.optAñadirPrincipio.AutoSize = true;
            this.optAñadirPrincipio.Location = new System.Drawing.Point(126, 74);
            this.optAñadirPrincipio.Name = "optAñadirPrincipio";
            this.optAñadirPrincipio.Size = new System.Drawing.Size(108, 17);
            this.optAñadirPrincipio.TabIndex = 4;
            this.optAñadirPrincipio.Text = "Añadir al principio";
            this.toolTip1.SetToolTip(this.optAñadirPrincipio, "Añadir al principio del nombre del fichero el texto indicado en \'Texto 1\'");
            this.optAñadirPrincipio.UseVisualStyleBackColor = true;
            this.optAñadirPrincipio.CheckedChanged += new System.EventHandler(this.optAñadir_CheckedChanged);
            // 
            // txtTexto1
            // 
            this.txtTexto1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto1.Location = new System.Drawing.Point(126, 22);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(425, 20);
            this.txtTexto1.TabIndex = 1;
            // 
            // grbGrupo0
            // 
            this.grbGrupo0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGrupo0.Controls.Add(this.txtExtensiones);
            this.grbGrupo0.Controls.Add(this.Label7);
            this.grbGrupo0.Controls.Add(this.CheckBox1);
            this.grbGrupo0.Controls.Add(this.btnExaminar);
            this.grbGrupo0.Controls.Add(this.txtDir);
            this.grbGrupo0.Controls.Add(this.Label8);
            this.grbGrupo0.Location = new System.Drawing.Point(12, 14);
            this.grbGrupo0.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grbGrupo0.Name = "grbGrupo0";
            this.grbGrupo0.Size = new System.Drawing.Size(589, 81);
            this.grbGrupo0.TabIndex = 0;
            this.grbGrupo0.TabStop = false;
            // 
            // txtExtensiones
            // 
            this.txtExtensiones.Location = new System.Drawing.Point(126, 48);
            this.txtExtensiones.Name = "txtExtensiones";
            this.txtExtensiones.Size = new System.Drawing.Size(142, 20);
            this.txtExtensiones.TabIndex = 5;
            this.txtExtensiones.Text = "*.txt; *.md";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(12, 51);
            this.Label7.Margin = new System.Windows.Forms.Padding(3);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 20);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Filtro:";
            this.toolTip1.SetToolTip(this.Label7, "Filtro a usar, con comodines * o ?");
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoCheck = false;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(6, -1);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(194, 17);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.TabStop = false;
            this.CheckBox1.Text = "Este directorio SIEMPRE se incluirá";
            this.toolTip1.SetToolTip(this.CheckBox1, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ");
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.Location = new System.Drawing.Point(557, 20);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(26, 23);
            this.btnExaminar.TabIndex = 3;
            this.btnExaminar.Text = "...";
            this.toolTip1.SetToolTip(this.btnExaminar, " Selecciona el directorio con los mp3 a procesar ");
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDir
            // 
            this.txtDir.AllowDrop = true;
            this.txtDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDir.Location = new System.Drawing.Point(126, 22);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(425, 20);
            this.txtDir.TabIndex = 2;
            this.txtDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir_DragDrop);
            this.txtDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir_DragEnter);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(12, 25);
            this.Label8.Margin = new System.Windows.Forms.Padding(3);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(109, 20);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Directorio:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar1.Location = new System.Drawing.Point(12, 561);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(508, 19);
            this.ProgressBar1.TabIndex = 5;
            // 
            // grbGrupo3
            // 
            this.grbGrupo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGrupo3.Controls.Add(this.txtExtensiones3);
            this.grbGrupo3.Controls.Add(this.Label6);
            this.grbGrupo3.Controls.Add(this.chkProces3);
            this.grbGrupo3.Controls.Add(this.btnExaminar3);
            this.grbGrupo3.Controls.Add(this.txtDir3);
            this.grbGrupo3.Controls.Add(this.Label3);
            this.grbGrupo3.Location = new System.Drawing.Point(12, 284);
            this.grbGrupo3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grbGrupo3.Name = "grbGrupo3";
            this.grbGrupo3.Size = new System.Drawing.Size(585, 81);
            this.grbGrupo3.TabIndex = 3;
            this.grbGrupo3.TabStop = false;
            // 
            // txtExtensiones3
            // 
            this.txtExtensiones3.Location = new System.Drawing.Point(126, 48);
            this.txtExtensiones3.Name = "txtExtensiones3";
            this.txtExtensiones3.Size = new System.Drawing.Size(142, 20);
            this.txtExtensiones3.TabIndex = 5;
            this.txtExtensiones3.Text = "*.md";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(12, 51);
            this.Label6.Margin = new System.Windows.Forms.Padding(3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(106, 20);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Filtro:";
            this.toolTip1.SetToolTip(this.Label6, "Filtro a usar, con comodines * o ?");
            // 
            // chkProces3
            // 
            this.chkProces3.AutoSize = true;
            this.chkProces3.Location = new System.Drawing.Point(6, -1);
            this.chkProces3.Name = "chkProces3";
            this.chkProces3.Size = new System.Drawing.Size(218, 17);
            this.chkProces3.TabIndex = 0;
            this.chkProces3.Text = "Incluir también este directorio al procesar";
            this.toolTip1.SetToolTip(this.chkProces3, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ");
            this.chkProces3.UseVisualStyleBackColor = true;
            this.chkProces3.CheckedChanged += new System.EventHandler(this.chkProces3_CheckedChanged);
            // 
            // btnExaminar3
            // 
            this.btnExaminar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar3.Location = new System.Drawing.Point(557, 20);
            this.btnExaminar3.Name = "btnExaminar3";
            this.btnExaminar3.Size = new System.Drawing.Size(26, 23);
            this.btnExaminar3.TabIndex = 3;
            this.btnExaminar3.Text = "...";
            this.toolTip1.SetToolTip(this.btnExaminar3, " Selecciona el directorio con los mp3 a procesar ");
            this.btnExaminar3.UseVisualStyleBackColor = true;
            this.btnExaminar3.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDir3
            // 
            this.txtDir3.AllowDrop = true;
            this.txtDir3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDir3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDir3.Location = new System.Drawing.Point(126, 22);
            this.txtDir3.Name = "txtDir3";
            this.txtDir3.Size = new System.Drawing.Size(425, 20);
            this.txtDir3.TabIndex = 2;
            this.txtDir3.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir_DragDrop);
            this.txtDir3.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir_DragEnter);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(12, 25);
            this.Label3.Margin = new System.Windows.Forms.Padding(3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(109, 20);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Directorio:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.Location = new System.Drawing.Point(526, 586);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.toolTip1.SetToolTip(this.btnProcesar, " Procesar los ficheros de los directorios indicados ");
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // grbGrupo2
            // 
            this.grbGrupo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGrupo2.Controls.Add(this.txtExtensiones2);
            this.grbGrupo2.Controls.Add(this.Label5);
            this.grbGrupo2.Controls.Add(this.chkProces2);
            this.grbGrupo2.Controls.Add(this.btnExaminar2);
            this.grbGrupo2.Controls.Add(this.txtDir2);
            this.grbGrupo2.Controls.Add(this.Label2);
            this.grbGrupo2.Location = new System.Drawing.Point(12, 194);
            this.grbGrupo2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grbGrupo2.Name = "grbGrupo2";
            this.grbGrupo2.Size = new System.Drawing.Size(589, 81);
            this.grbGrupo2.TabIndex = 2;
            this.grbGrupo2.TabStop = false;
            // 
            // txtExtensiones2
            // 
            this.txtExtensiones2.Location = new System.Drawing.Point(126, 48);
            this.txtExtensiones2.Name = "txtExtensiones2";
            this.txtExtensiones2.Size = new System.Drawing.Size(142, 20);
            this.txtExtensiones2.TabIndex = 5;
            this.txtExtensiones2.Text = "*.txt";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(12, 51);
            this.Label5.Margin = new System.Windows.Forms.Padding(3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 20);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Filtro:";
            this.toolTip1.SetToolTip(this.Label5, "Filtro a usar, con comodines * o ?");
            // 
            // chkProces2
            // 
            this.chkProces2.AutoSize = true;
            this.chkProces2.Location = new System.Drawing.Point(6, -1);
            this.chkProces2.Name = "chkProces2";
            this.chkProces2.Size = new System.Drawing.Size(218, 17);
            this.chkProces2.TabIndex = 0;
            this.chkProces2.Text = "Incluir también este directorio al procesar";
            this.toolTip1.SetToolTip(this.chkProces2, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ");
            this.chkProces2.UseVisualStyleBackColor = true;
            this.chkProces2.CheckedChanged += new System.EventHandler(this.chkProces2_CheckedChanged);
            // 
            // btnExaminar2
            // 
            this.btnExaminar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar2.Location = new System.Drawing.Point(557, 20);
            this.btnExaminar2.Name = "btnExaminar2";
            this.btnExaminar2.Size = new System.Drawing.Size(26, 23);
            this.btnExaminar2.TabIndex = 3;
            this.btnExaminar2.Text = "...";
            this.toolTip1.SetToolTip(this.btnExaminar2, " Selecciona el directorio con los mp3 a procesar ");
            this.btnExaminar2.UseVisualStyleBackColor = true;
            this.btnExaminar2.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDir2
            // 
            this.txtDir2.AllowDrop = true;
            this.txtDir2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDir2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDir2.Location = new System.Drawing.Point(126, 22);
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(425, 20);
            this.txtDir2.TabIndex = 2;
            this.txtDir2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir_DragDrop);
            this.txtDir2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir_DragEnter);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 25);
            this.Label2.Margin = new System.Windows.Forms.Padding(3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Directorio:";
            // 
            // grbGrupo1
            // 
            this.grbGrupo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGrupo1.Controls.Add(this.txtExtensiones1);
            this.grbGrupo1.Controls.Add(this.Label4);
            this.grbGrupo1.Controls.Add(this.chkProces1);
            this.grbGrupo1.Controls.Add(this.btnExaminar1);
            this.grbGrupo1.Controls.Add(this.txtDir1);
            this.grbGrupo1.Controls.Add(this.Label1);
            this.grbGrupo1.Location = new System.Drawing.Point(12, 104);
            this.grbGrupo1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grbGrupo1.Name = "grbGrupo1";
            this.grbGrupo1.Size = new System.Drawing.Size(589, 81);
            this.grbGrupo1.TabIndex = 1;
            this.grbGrupo1.TabStop = false;
            // 
            // txtExtensiones1
            // 
            this.txtExtensiones1.Location = new System.Drawing.Point(126, 48);
            this.txtExtensiones1.Name = "txtExtensiones1";
            this.txtExtensiones1.Size = new System.Drawing.Size(142, 20);
            this.txtExtensiones1.TabIndex = 5;
            this.txtExtensiones1.Text = "*.mp3";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(12, 51);
            this.Label4.Margin = new System.Windows.Forms.Padding(3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Filtro:";
            this.toolTip1.SetToolTip(this.Label4, "Filtro a usar, con comodines * o ?");
            // 
            // chkProces1
            // 
            this.chkProces1.AutoSize = true;
            this.chkProces1.Location = new System.Drawing.Point(6, -1);
            this.chkProces1.Name = "chkProces1";
            this.chkProces1.Size = new System.Drawing.Size(218, 17);
            this.chkProces1.TabIndex = 0;
            this.chkProces1.Text = "Incluir también este directorio al procesar";
            this.toolTip1.SetToolTip(this.chkProces1, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ");
            this.chkProces1.UseVisualStyleBackColor = true;
            this.chkProces1.CheckedChanged += new System.EventHandler(this.chkProces1_CheckedChanged);
            // 
            // btnExaminar1
            // 
            this.btnExaminar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar1.Location = new System.Drawing.Point(557, 20);
            this.btnExaminar1.Name = "btnExaminar1";
            this.btnExaminar1.Size = new System.Drawing.Size(26, 23);
            this.btnExaminar1.TabIndex = 3;
            this.btnExaminar1.Text = "...";
            this.toolTip1.SetToolTip(this.btnExaminar1, " Selecciona el directorio con los mp3 a procesar ");
            this.btnExaminar1.UseVisualStyleBackColor = true;
            this.btnExaminar1.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDir1
            // 
            this.txtDir1.AllowDrop = true;
            this.txtDir1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDir1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDir1.Location = new System.Drawing.Point(126, 22);
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(425, 20);
            this.txtDir1.TabIndex = 2;
            this.txtDir1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir_DragDrop);
            this.txtDir1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir_DragEnter);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 25);
            this.Label1.Margin = new System.Windows.Forms.Padding(3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Directorio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 622);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.grbGrupo0);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.grbGrupo3);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.grbGrupo2);
            this.Controls.Add(this.grbGrupo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar los nombres de los ficheros (C#)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.grbGrupo0.ResumeLayout(false);
            this.grbGrupo0.PerformLayout();
            this.grbGrupo3.ResumeLayout(false);
            this.grbGrupo3.PerformLayout();
            this.grbGrupo2.ResumeLayout(false);
            this.grbGrupo2.PerformLayout();
            this.grbGrupo1.ResumeLayout(false);
            this.grbGrupo1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker bgwProc;
        private System.ComponentModel.BackgroundWorker bgwProc1;
        private System.ComponentModel.BackgroundWorker bgwProc2;
        private System.ComponentModel.BackgroundWorker bgwProc3;
        internal System.Windows.Forms.Label LabelStatus;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.RadioButton optQuitarFinal;
        internal System.Windows.Forms.RadioButton optQuitarPrincipio;
        internal System.Windows.Forms.CheckBox chkNoDuplicar;
        internal System.Windows.Forms.RadioButton optAñadirFinal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtTexto2;
        internal System.Windows.Forms.RadioButton optCambiar;
        internal System.Windows.Forms.RadioButton optAñadirPrincipio;
        internal System.Windows.Forms.TextBox txtTexto1;
        internal System.Windows.Forms.GroupBox grbGrupo0;
        internal System.Windows.Forms.TextBox txtExtensiones;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button btnExaminar;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.GroupBox grbGrupo3;
        internal System.Windows.Forms.TextBox txtExtensiones3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckBox chkProces3;
        internal System.Windows.Forms.Button btnExaminar3;
        internal System.Windows.Forms.TextBox txtDir3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.GroupBox grbGrupo2;
        internal System.Windows.Forms.TextBox txtExtensiones2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox chkProces2;
        internal System.Windows.Forms.Button btnExaminar2;
        internal System.Windows.Forms.TextBox txtDir2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox grbGrupo1;
        internal System.Windows.Forms.TextBox txtExtensiones1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox chkProces1;
        internal System.Windows.Forms.Button btnExaminar1;
        internal System.Windows.Forms.TextBox txtDir1;
        internal System.Windows.Forms.Label Label1;
    }
}

