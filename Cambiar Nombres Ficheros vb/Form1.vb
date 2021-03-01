'------------------------------------------------------------------------------
' Cambiar los nombres de los ficheros                               (25/feb/21)
'
' El nuevo funcionamiento será:
'   Indicar el directorio a procesar.
'   Las extensiones a procesar separadas por ;
'       guardar en una colección (en formato *.*, *.doc, etc.) 
'   Qué buscar y qué poner
'       Opción para añadir al principio (y no cambiar)
'           O cambiar lo indicado en buscar por lo que haya en poner.
'
' Basado en:
' Cambiar los nombres de las canciones                              (19/Nov/05)
' Para añadirle el nombre del artista y quitarle caracteres, etc.
'
' Nota:
'   Esto lo usaba para las canciones descargadas con AllOfMp3 (RIP)
'   Y filtraba texto que tenían las canciones descargadas, etc.
'
' Compilado con Visual Basic 2008                                   (30/Oct/08)
'
' ©Guillermo 'guille' Som, 2005-2006, 2008, 2021
'------------------------------------------------------------------------------
Option Strict On
Option Infer On

Imports Microsoft.VisualBasic
'Imports vb = Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
'Imports System.IO
Imports System.Collections.Generic
Imports System.Linq

Public Class Form1
    Private cuantosFinalizados As Integer
    Private cuantosProcesos As Integer

    Private ficheros As New List(Of String)

    Private cfg As elGuille.Util.Config

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        guardarCfg()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        LabelStatus.Text = $"{Application.ProductName} v{Application.ProductVersion} - {My.Application.Info.Copyright}"
        LabelStatus.Tag = LabelStatus.Text

        ProgressBar1.Visible = False

        txtDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        habilitarSimple(grbGrupo1, False, chkProces1)
        habilitarSimple(grbGrupo2, False, chkProces2)
        habilitarSimple(grbGrupo3, False, chkProces3)

        Dim ficConfig As String = System.Reflection.Assembly.GetExecutingAssembly.Location & ".cfg"
        cfg = New elGuille.Util.Config(ficConfig)
        cfg.Read()
        leerCfg()

    End Sub

    Private Sub guardarCfg()
        cfg.SetKeyValue("Grupo0", "Dir", txtDir.Text)
        cfg.SetKeyValue("Grupo1", "Dir", txtDir1.Text)
        cfg.SetKeyValue("Grupo2", "Dir", txtDir2.Text)
        cfg.SetKeyValue("Grupo3", "Dir", txtDir3.Text)
        cfg.SetKeyValue("Grupo1", "Comprobar", Me.chkProces1.Checked)
        cfg.SetKeyValue("Grupo2", "Comprobar", Me.chkProces2.Checked)
        cfg.SetKeyValue("Grupo3", "Comprobar", Me.chkProces3.Checked)
        cfg.SetValue("Grupo0", "Filtro", txtExtensiones.Text)
        cfg.SetValue("Grupo1", "Filtro", txtExtensiones1.Text)
        cfg.SetValue("Grupo2", "Filtro", txtExtensiones2.Text)
        cfg.SetValue("Grupo3", "Filtro", txtExtensiones3.Text)
        cfg.SetValue("PonerCambiar", "Texto1", txtTexto1.Text)
        cfg.SetValue("PonerCambiar", "Texto2", txtTexto2.Text)
        cfg.SetValue("PonerCambiar", "AlPrincipio", optAñadirPrincipio.Checked)
        cfg.SetValue("PonerCambiar", "AlFinal", optAñadirFinal.Checked)
        cfg.SetValue("PonerCambiar", "NoDuplicar", chkNoDuplicar.Checked)
        cfg.SetValue("PonerCambiar", "Cambiar", optCambiar.Checked)
        cfg.SetValue("PonerCambiar", "QuitarPrincipio", optQuitarPrincipio.Checked)
        cfg.SetValue("PonerCambiar", "QuitarFinal", optQuitarFinal.Checked)

        cfg.Save()
    End Sub

    Private Sub leerCfg()
        txtDir.Text = cfg.GetValue("Grupo0", "Dir", "")
        txtDir1.Text = cfg.GetValue("Grupo1", "Dir", "")
        txtDir2.Text = cfg.GetValue("Grupo2", "Dir", "")
        txtDir3.Text = cfg.GetValue("Grupo3", "Dir", "")
        Me.chkProces1.Checked = cfg.GetValue("Grupo1", "Comprobar", False)
        Me.chkProces2.Checked = cfg.GetValue("Grupo2", "Comprobar", False)
        Me.chkProces3.Checked = cfg.GetValue("Grupo3", "Comprobar", False)
        txtExtensiones.Text = cfg.GetValue("Grupo0", "Filtro", "")
        txtExtensiones1.Text = cfg.GetValue("Grupo1", "Filtro", "")
        txtExtensiones2.Text = cfg.GetValue("Grupo2", "Filtro", "")
        txtExtensiones3.Text = cfg.GetValue("Grupo3", "Filtro", "")
        txtTexto1.Text = cfg.GetValue("PonerCambiar", "Texto1", "")
        txtTexto2.Text = cfg.GetValue("PonerCambiar", "Texto2", "")
        optAñadirPrincipio.Checked = cfg.GetValue("PonerCambiar", "AlPrincipio", True)
        optAñadirFinal.Checked = cfg.GetValue("PonerCambiar", "AlFinal", False)
        chkNoDuplicar.Checked = cfg.GetValue("PonerCambiar", "NoDuplicar", True)
        optCambiar.Checked = cfg.GetValue("PonerCambiar", "Cambiar", False)
        optQuitarPrincipio.Checked = cfg.GetValue("PonerCambiar", "QuitarPrincipio", False)
        optQuitarFinal.Checked = cfg.GetValue("PonerCambiar", "QuitarFinal", False)

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click,
                                                                            btnExaminar1.Click,
                                                                            btnExaminar3.Click,
                                                                            btnExaminar2.Click
        Dim bf As New FolderBrowserDialog
        Dim txt As TextBox

        If sender Is btnExaminar1 Then
            txt = Me.txtDir1
        ElseIf sender Is btnExaminar2 Then
            txt = Me.txtDir2
        ElseIf sender Is btnExaminar3 Then
            txt = Me.txtDir3
        Else
            txt = Me.txtDir
        End If
        With bf
            .Description = "Selecciona el directorio con los ficheros a procesar"
            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = txt.Text
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txt.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        ficheros.Clear()
        cuantosFinalizados = 0
        cuantosProcesos = 1

        ' Si al final del texto a buscar/poner
        ' hay más de un espacio, cambiarlo por solo 1
        If txtTexto1.Text.EndsWith(" ") Then
            txtTexto1.Text = txtTexto1.Text.TrimEnd(" "c) & " "
        End If
        If txtTexto2.Text.EndsWith(" ") Then
            txtTexto2.Text = txtTexto2.Text.TrimEnd(" "c) & " "
        End If

        If chkProces1.Checked Then
            cuantosProcesos += 1
            bgwProc1.RunWorkerAsync()
        End If
        If chkProces2.Checked Then
            cuantosProcesos += 1
            bgwProc2.RunWorkerAsync()
        End If
        If chkProces3.Checked Then
            cuantosProcesos += 1
            bgwProc3.RunWorkerAsync()
        End If

        ' Este siempre se procesa
        ' Hacer esta llamada al final para que se restauren los valores
        ' al terminar el trabajo.
        bgwProc.RunWorkerAsync()
    End Sub

    Private Sub cambiarNombres(file As String)
        Dim fi As New System.IO.FileInfo(file)
        Dim s As String = file
        ' fi.Name contiene también la extensión                     (01/Mar/21)
        ' Al hacer el cambio del principio o final,
        ' NO buscar el texto a cambiar no tener en cuenta la extensión.
        Dim fiSoloNombre = System.IO.Path.GetFileNameWithoutExtension(file)
        Dim ext = fi.Extension

        LabelStatus.Text = $"{fi.Name}"
        Application.DoEvents()

        If optCambiar.Checked Then
            s = fi.Name.Replace(txtTexto1.Text, txtTexto2.Text)
            If s <> fi.Name Then
                My.Computer.FileSystem.RenameFile(file, s)
            End If
        ElseIf optAñadirPrincipio.Checked Then
            If chkNoDuplicar.Checked Then
                If fiSoloNombre.StartsWith(txtTexto1.Text) = False Then
                    s = txtTexto1.Text & fi.Name
                    My.Computer.FileSystem.RenameFile(file, s)
                End If
            Else
                s = txtTexto1.Text & fi.Name
                My.Computer.FileSystem.RenameFile(file, s)
            End If
        ElseIf optAñadirFinal.Checked Then
            If chkNoDuplicar.Checked Then
                If fiSoloNombre.EndsWith(txtTexto1.Text) = False Then
                    s = fiSoloNombre & txtTexto1.Text & ext
                    My.Computer.FileSystem.RenameFile(file, s)
                End If
            Else
                s = fiSoloNombre & txtTexto1.Text & ext
                My.Computer.FileSystem.RenameFile(file, s)
            End If
        ElseIf optQuitarPrincipio.Checked Then
            If fiSoloNombre.StartsWith(txtTexto1.Text) Then
                s = fiSoloNombre.Replace(txtTexto1.Text, "") & ext
                My.Computer.FileSystem.RenameFile(file, s)
            End If
        ElseIf optQuitarFinal.Checked Then
            If fiSoloNombre.EndsWith(txtTexto1.Text) Then
                s = fiSoloNombre.Replace(txtTexto1.Text, "") & ext
                My.Computer.FileSystem.RenameFile(file, s)
            End If
        End If

        LabelStatus.Text &= $" --> {s}"
        Application.DoEvents()
    End Sub

    ''' <summary>
    ''' Método usado por el método DoWork de los BackgroundWorkers.
    ''' </summary>
    ''' <param name="txtDir">El directorio a usar.</param>
    ''' <param name="filtro">El filtro de los ficheros a usar.</param>
    Private Sub backgroundWorker_DoWork(txtDir As TextBox,
                                        filtro As String)
        ' Aquí se acumulan los ficheros en la colección
        ' y se procesarán todos al final.
        ' De esta forma sabemos cuántos ficheros se procesan en total.
        Dim fileEnum = System.IO.Directory.EnumerateFiles(txtDir.Text, filtro)
        ficheros.AddRange(fileEnum)

    End Sub

    Private Sub bgwProc_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProc.DoWork
        backgroundWorker_DoWork(txtDir, txtExtensiones.Text)
    End Sub

    Private Sub bgwProc_RunWorkerCompleted(sender As Object,
                                           e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                           Handles bgwProc.RunWorkerCompleted,
                                                   bgwProc3.RunWorkerCompleted,
                                                   bgwProc2.RunWorkerCompleted,
                                                   bgwProc1.RunWorkerCompleted
        cuantosFinalizados += 1
        ' Cuando estén todos los procesos finalizados, hacer los cambios.
        If cuantosFinalizados = cuantosProcesos Then
            finalizarCopia()
        End If
    End Sub

    Private Sub finalizarCopia()
        ' Procesar los ficheros acumulados en la colección
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = ficheros.Count
        ProgressBar1.Value = 0

        For i = 0 To ficheros.Count - 1
            cambiarNombres(ficheros(i))
            ProgressBar1.Value = i + 1
        Next

        Dim s As String
        If ficheros.Count = 1 Then
            s = "el nombre al fichero."
        Else
            s = $"los {ficheros.Count} nombres."
        End If
        LabelStatus.Text = $"Finalizado el proceso de cambiar {s}"
        Application.DoEvents()

        ' Mostrar ese mensaje por 3 segundos
        timer1.Interval = 3000
        timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        timer1.Enabled = False

        ProgressBar1.Visible = False
        LabelStatus.Text = LabelStatus.Tag.ToString()
        Application.DoEvents()

    End Sub

    Private Sub bgwProc1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProc1.DoWork
        backgroundWorker_DoWork(txtDir1, txtExtensiones1.Text)
    End Sub

    Private Sub bgwProc2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProc2.DoWork
        backgroundWorker_DoWork(txtDir2, txtExtensiones2.Text)
    End Sub

    Private Sub bgwProc3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProc3.DoWork
        backgroundWorker_DoWork(txtDir3, txtExtensiones3.Text)
    End Sub

    Private Sub txtDir_DragDrop(sender As Object, e As DragEventArgs) Handles txtDir1.DragDrop,
                                                                              txtDir3.DragDrop,
                                                                              txtDir2.DragDrop,
                                                                              txtDir.DragDrop
        If e.Data.GetDataPresent("FileDrop") Then
            Dim txt = TryCast(sender, TextBox)
            If txt Is Nothing Then Return

            Dim s As String = CType(e.Data.GetData("FileDrop", True), String())(0)
            txt.Text = s

            If sender Is Me.txtDir1 Then
                Me.chkProces1.Checked = True
            ElseIf sender Is Me.txtDir2 Then
                Me.chkProces2.Checked = True
            ElseIf sender Is Me.txtDir3 Then
                Me.chkProces3.Checked = True
            End If
        End If
    End Sub

    Private Sub txtDir_DragEnter(sender As Object, e As DragEventArgs) Handles txtDir1.DragEnter,
                                                                               txtDir3.DragEnter,
                                                                               txtDir2.DragEnter,
                                                                               txtDir.DragEnter
        If e.Data.GetDataPresent("FileDrop") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub optAñadir_CheckedChanged(sender As Object, e As EventArgs) Handles optAñadirPrincipio.CheckedChanged,
                                                                                   optAñadirFinal.CheckedChanged
        Dim opt = TryCast(sender, RadioButton)
        If opt Is Nothing Then Return

        txtTexto2.Enabled = Not opt.Checked
        chkNoDuplicar.Enabled = opt.Checked
        'If opt.Checked Then chkNoDuplicar.Enabled = False
    End Sub

    Private Sub optQuitar_CheckedChanged(sender As Object, e As EventArgs) Handles optQuitarPrincipio.CheckedChanged,
                                                                                   optQuitarFinal.CheckedChanged
        Dim opt = TryCast(sender, RadioButton)
        If opt Is Nothing Then Return

        txtTexto2.Enabled = Not opt.Checked
        If opt.Checked Then chkNoDuplicar.Enabled = False
    End Sub

    Private Sub optCambiar_CheckedChanged(sender As Object, e As EventArgs) Handles optCambiar.CheckedChanged
        Dim opt = TryCast(sender, RadioButton)
        If opt Is Nothing Then Return

        txtTexto2.Enabled = opt.Checked
        'chkNoDuplicar.Enabled = Not opt.Checked
        If opt.Checked Then chkNoDuplicar.Enabled = False
    End Sub

    Private Sub chkProces1_CheckedChanged(sender As Object, e As EventArgs) Handles chkProces1.CheckedChanged
        'grbGrupo1.Enabled = chkProces1.Checked
        habilitarSimple(grbGrupo1, chkProces1.Checked, chkProces1)
    End Sub

    Private Sub chkProces2_CheckedChanged(sender As Object, e As EventArgs) Handles chkProces2.CheckedChanged
        habilitarSimple(grbGrupo2, chkProces2.Checked, chkProces2)
    End Sub

    Private Sub chkProces3_CheckedChanged(sender As Object, e As EventArgs) Handles chkProces3.CheckedChanged
        habilitarSimple(grbGrupo3, chkProces3.Checked, chkProces3)
    End Sub

    Private Sub habilitarSimple(ctr As Control, h As Boolean, cSaltar As Control)
        For i = 0 To ctr.Controls.Count - 1
            If ctr.Controls(i) Is cSaltar Then Continue For
            ctr.Controls(i).Enabled = h
        Next
    End Sub
End Class
