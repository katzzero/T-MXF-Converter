﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTMXF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProcessFFmpeg = New System.Diagnostics.Process()
        Me.btnLoadMXF = New System.Windows.Forms.Button()
        Me.txtMXFpath = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.OpenMXFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveOut = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtOutPath = New System.Windows.Forms.Label()
        Me.tabsMain = New System.Windows.Forms.TabControl()
        Me.TabCodec = New System.Windows.Forms.TabPage()
        Me.grpTCBurn = New System.Windows.Forms.GroupBox()
        Me.chkTCBurn = New System.Windows.Forms.CheckBox()
        Me.grpFrameRate = New System.Windows.Forms.GroupBox()
        Me.rdbFRdirect = New System.Windows.Forms.RadioButton()
        Me.rdb23 = New System.Windows.Forms.RadioButton()
        Me.rdb29ND = New System.Windows.Forms.RadioButton()
        Me.rdb29D = New System.Windows.Forms.RadioButton()
        Me.txtFFoutput = New System.Windows.Forms.TextBox()
        Me.grpSRate = New System.Windows.Forms.GroupBox()
        Me.rdb96 = New System.Windows.Forms.RadioButton()
        Me.rdbSR48 = New System.Windows.Forms.RadioButton()
        Me.rdbSR44 = New System.Windows.Forms.RadioButton()
        Me.rdbSRDirect = New System.Windows.Forms.RadioButton()
        Me.grpACodec = New System.Windows.Forms.GroupBox()
        Me.rdbMP3 = New System.Windows.Forms.RadioButton()
        Me.rdbAAC = New System.Windows.Forms.RadioButton()
        Me.rdbPCM24 = New System.Windows.Forms.RadioButton()
        Me.rdbPCM16 = New System.Windows.Forms.RadioButton()
        Me.grpACh = New System.Windows.Forms.GroupBox()
        Me.rdbA8Ch = New System.Windows.Forms.RadioButton()
        Me.rdbA4Ch = New System.Windows.Forms.RadioButton()
        Me.rdbA2Ch = New System.Windows.Forms.RadioButton()
        Me.rdbADirect = New System.Windows.Forms.RadioButton()
        Me.grpGlobal = New System.Windows.Forms.GroupBox()
        Me.grpResolution = New System.Windows.Forms.GroupBox()
        Me.rdb540 = New System.Windows.Forms.RadioButton()
        Me.rdb486 = New System.Windows.Forms.RadioButton()
        Me.rdb720 = New System.Windows.Forms.RadioButton()
        Me.rdb1080 = New System.Windows.Forms.RadioButton()
        Me.grpDumbCodec = New System.Windows.Forms.GroupBox()
        Me.rdbWAV = New System.Windows.Forms.RadioButton()
        Me.rdbDNxHD = New System.Windows.Forms.RadioButton()
        Me.rdbProRes = New System.Windows.Forms.RadioButton()
        Me.rdbH264 = New System.Windows.Forms.RadioButton()
        Me.TabConfig = New System.Windows.Forms.TabPage()
        Me.lblFRcommand = New System.Windows.Forms.Label()
        Me.lblFFarguments = New System.Windows.Forms.Label()
        Me.lblASRCommand = New System.Windows.Forms.Label()
        Me.lblACodecCommand = New System.Windows.Forms.Label()
        Me.lblAudioChCommand = New System.Windows.Forms.Label()
        Me.lblFileNameCommand = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblCodecCommand = New System.Windows.Forms.Label()
        Me.lblMXFPathCommand = New System.Windows.Forms.Label()
        Me.chkDumb = New System.Windows.Forms.CheckBox()
        Me.lblFFmpegCommand = New System.Windows.Forms.Label()
        Me.grpTemp = New System.Windows.Forms.GroupBox()
        Me.btnTempDefault = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.Label()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.grpFFmpeg = New System.Windows.Forms.GroupBox()
        Me.txtFFmpeg = New System.Windows.Forms.Label()
        Me.btnFFmpeg = New System.Windows.Forms.Button()
        Me.OpenFFmpegDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnChk3 = New System.Windows.Forms.Button()
        Me.btnChk2 = New System.Windows.Forms.Button()
        Me.btnChk1 = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnChk4 = New System.Windows.Forms.Button()
        Me.btnChk5 = New System.Windows.Forms.Button()
        Me.txtOutFilename = New System.Windows.Forms.TextBox()
        Me.lblOutName = New System.Windows.Forms.Label()
        Me.txtNameDate = New System.Windows.Forms.Label()
        Me.grpDumb = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabsMain.SuspendLayout()
        Me.TabCodec.SuspendLayout()
        Me.grpTCBurn.SuspendLayout()
        Me.grpFrameRate.SuspendLayout()
        Me.grpSRate.SuspendLayout()
        Me.grpACodec.SuspendLayout()
        Me.grpACh.SuspendLayout()
        Me.grpResolution.SuspendLayout()
        Me.grpDumbCodec.SuspendLayout()
        Me.TabConfig.SuspendLayout()
        Me.grpTemp.SuspendLayout()
        Me.grpFFmpeg.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessFFmpeg
        '
        Me.ProcessFFmpeg.StartInfo.CreateNoWindow = True
        Me.ProcessFFmpeg.StartInfo.Domain = ""
        Me.ProcessFFmpeg.StartInfo.LoadUserProfile = False
        Me.ProcessFFmpeg.StartInfo.Password = Nothing
        Me.ProcessFFmpeg.StartInfo.RedirectStandardError = True
        Me.ProcessFFmpeg.StartInfo.RedirectStandardInput = True
        Me.ProcessFFmpeg.StartInfo.RedirectStandardOutput = True
        Me.ProcessFFmpeg.StartInfo.StandardErrorEncoding = Nothing
        Me.ProcessFFmpeg.StartInfo.StandardOutputEncoding = Nothing
        Me.ProcessFFmpeg.StartInfo.UserName = ""
        Me.ProcessFFmpeg.StartInfo.UseShellExecute = False
        Me.ProcessFFmpeg.SynchronizingObject = Me
        '
        'btnLoadMXF
        '
        Me.btnLoadMXF.Location = New System.Drawing.Point(13, 13)
        Me.btnLoadMXF.Name = "btnLoadMXF"
        Me.btnLoadMXF.Size = New System.Drawing.Size(75, 75)
        Me.btnLoadMXF.TabIndex = 0
        Me.btnLoadMXF.Text = "Load MXF"
        Me.btnLoadMXF.UseVisualStyleBackColor = True
        '
        'txtMXFpath
        '
        Me.txtMXFpath.AutoSize = True
        Me.txtMXFpath.Location = New System.Drawing.Point(94, 44)
        Me.txtMXFpath.Name = "txtMXFpath"
        Me.txtMXFpath.Size = New System.Drawing.Size(16, 13)
        Me.txtMXFpath.TabIndex = 1
        Me.txtMXFpath.Text = "..."
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(83, 640)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(127, 13)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Thiago de Oliveira Neves"
        Me.lblAuthor.Visible = False
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(10, 640)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(67, 13)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Version Error"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenMXFDialog
        '
        Me.OpenMXFDialog.DefaultExt = "mxf"
        Me.OpenMXFDialog.FileName = "*.MXF"
        Me.OpenMXFDialog.Filter = "MXF Files |*.MXF"
        Me.OpenMXFDialog.Title = "Load MXF"
        '
        'btnSaveOut
        '
        Me.btnSaveOut.Enabled = False
        Me.btnSaveOut.Location = New System.Drawing.Point(12, 552)
        Me.btnSaveOut.Name = "btnSaveOut"
        Me.btnSaveOut.Size = New System.Drawing.Size(75, 75)
        Me.btnSaveOut.TabIndex = 4
        Me.btnSaveOut.Text = "Output Path"
        Me.btnSaveOut.UseVisualStyleBackColor = True
        '
        'txtOutPath
        '
        Me.txtOutPath.AutoSize = True
        Me.txtOutPath.Location = New System.Drawing.Point(94, 614)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(16, 13)
        Me.txtOutPath.TabIndex = 6
        Me.txtOutPath.Text = "..."
        '
        'tabsMain
        '
        Me.tabsMain.Controls.Add(Me.TabCodec)
        Me.tabsMain.Controls.Add(Me.TabConfig)
        Me.tabsMain.Location = New System.Drawing.Point(13, 95)
        Me.tabsMain.Name = "tabsMain"
        Me.tabsMain.SelectedIndex = 0
        Me.tabsMain.Size = New System.Drawing.Size(959, 451)
        Me.tabsMain.TabIndex = 7
        '
        'TabCodec
        '
        Me.TabCodec.Controls.Add(Me.grpDumb)
        Me.TabCodec.Controls.Add(Me.grpTCBurn)
        Me.TabCodec.Controls.Add(Me.grpFrameRate)
        Me.TabCodec.Controls.Add(Me.txtFFoutput)
        Me.TabCodec.Controls.Add(Me.grpSRate)
        Me.TabCodec.Controls.Add(Me.grpACodec)
        Me.TabCodec.Controls.Add(Me.grpACh)
        Me.TabCodec.Controls.Add(Me.grpGlobal)
        Me.TabCodec.Controls.Add(Me.grpResolution)
        Me.TabCodec.Controls.Add(Me.grpDumbCodec)
        Me.TabCodec.Location = New System.Drawing.Point(4, 22)
        Me.TabCodec.Name = "TabCodec"
        Me.TabCodec.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCodec.Size = New System.Drawing.Size(951, 425)
        Me.TabCodec.TabIndex = 0
        Me.TabCodec.Text = "Codec Config"
        Me.TabCodec.UseVisualStyleBackColor = True
        '
        'grpTCBurn
        '
        Me.grpTCBurn.Controls.Add(Me.chkTCBurn)
        Me.grpTCBurn.Location = New System.Drawing.Point(259, 330)
        Me.grpTCBurn.Name = "grpTCBurn"
        Me.grpTCBurn.Size = New System.Drawing.Size(247, 89)
        Me.grpTCBurn.TabIndex = 8
        Me.grpTCBurn.TabStop = False
        Me.grpTCBurn.Text = "Time Code Burn"
        '
        'chkTCBurn
        '
        Me.chkTCBurn.AutoSize = True
        Me.chkTCBurn.Location = New System.Drawing.Point(7, 20)
        Me.chkTCBurn.Name = "chkTCBurn"
        Me.chkTCBurn.Size = New System.Drawing.Size(65, 17)
        Me.chkTCBurn.TabIndex = 0
        Me.chkTCBurn.Text = "Burn TC"
        Me.chkTCBurn.UseVisualStyleBackColor = True
        '
        'grpFrameRate
        '
        Me.grpFrameRate.Controls.Add(Me.rdbFRdirect)
        Me.grpFrameRate.Controls.Add(Me.rdb23)
        Me.grpFrameRate.Controls.Add(Me.rdb29ND)
        Me.grpFrameRate.Controls.Add(Me.rdb29D)
        Me.grpFrameRate.Location = New System.Drawing.Point(259, 8)
        Me.grpFrameRate.Name = "grpFrameRate"
        Me.grpFrameRate.Size = New System.Drawing.Size(120, 155)
        Me.grpFrameRate.TabIndex = 7
        Me.grpFrameRate.TabStop = False
        Me.grpFrameRate.Text = "Frame Rate"
        '
        'rdbFRdirect
        '
        Me.rdbFRdirect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbFRdirect.Location = New System.Drawing.Point(6, 21)
        Me.rdbFRdirect.Name = "rdbFRdirect"
        Me.rdbFRdirect.Size = New System.Drawing.Size(104, 24)
        Me.rdbFRdirect.TabIndex = 0
        Me.rdbFRdirect.TabStop = True
        Me.rdbFRdirect.Text = "Direct"
        Me.rdbFRdirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbFRdirect.UseVisualStyleBackColor = True
        '
        'rdb23
        '
        Me.rdb23.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb23.Enabled = False
        Me.rdb23.Location = New System.Drawing.Point(6, 119)
        Me.rdb23.Name = "rdb23"
        Me.rdb23.Size = New System.Drawing.Size(104, 24)
        Me.rdb23.TabIndex = 0
        Me.rdb23.TabStop = True
        Me.rdb23.Text = "23,976"
        Me.rdb23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb23.UseVisualStyleBackColor = True
        '
        'rdb29ND
        '
        Me.rdb29ND.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb29ND.Enabled = False
        Me.rdb29ND.Location = New System.Drawing.Point(6, 89)
        Me.rdb29ND.Name = "rdb29ND"
        Me.rdb29ND.Size = New System.Drawing.Size(104, 24)
        Me.rdb29ND.TabIndex = 0
        Me.rdb29ND.TabStop = True
        Me.rdb29ND.Text = "29,97 Non Drop"
        Me.rdb29ND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb29ND.UseVisualStyleBackColor = True
        '
        'rdb29D
        '
        Me.rdb29D.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb29D.Enabled = False
        Me.rdb29D.Location = New System.Drawing.Point(6, 55)
        Me.rdb29D.Name = "rdb29D"
        Me.rdb29D.Size = New System.Drawing.Size(104, 24)
        Me.rdb29D.TabIndex = 0
        Me.rdb29D.TabStop = True
        Me.rdb29D.Text = "29,97 Drop"
        Me.rdb29D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb29D.UseVisualStyleBackColor = True
        '
        'txtFFoutput
        '
        Me.txtFFoutput.BackColor = System.Drawing.SystemColors.Window
        Me.txtFFoutput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFFoutput.Location = New System.Drawing.Point(512, 8)
        Me.txtFFoutput.Multiline = True
        Me.txtFFoutput.Name = "txtFFoutput"
        Me.txtFFoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFFoutput.Size = New System.Drawing.Size(433, 411)
        Me.txtFFoutput.TabIndex = 6
        '
        'grpSRate
        '
        Me.grpSRate.Controls.Add(Me.rdb96)
        Me.grpSRate.Controls.Add(Me.rdbSR48)
        Me.grpSRate.Controls.Add(Me.rdbSR44)
        Me.grpSRate.Controls.Add(Me.rdbSRDirect)
        Me.grpSRate.Location = New System.Drawing.Point(259, 169)
        Me.grpSRate.Name = "grpSRate"
        Me.grpSRate.Size = New System.Drawing.Size(120, 155)
        Me.grpSRate.TabIndex = 5
        Me.grpSRate.TabStop = False
        Me.grpSRate.Text = "Sample Rate"
        '
        'rdb96
        '
        Me.rdb96.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb96.Enabled = False
        Me.rdb96.Location = New System.Drawing.Point(6, 121)
        Me.rdb96.Name = "rdb96"
        Me.rdb96.Size = New System.Drawing.Size(104, 24)
        Me.rdb96.TabIndex = 3
        Me.rdb96.Text = "96 KHz"
        Me.rdb96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb96.UseVisualStyleBackColor = True
        '
        'rdbSR48
        '
        Me.rdbSR48.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbSR48.Enabled = False
        Me.rdbSR48.Location = New System.Drawing.Point(6, 89)
        Me.rdbSR48.Name = "rdbSR48"
        Me.rdbSR48.Size = New System.Drawing.Size(104, 24)
        Me.rdbSR48.TabIndex = 2
        Me.rdbSR48.Text = "48 KHz"
        Me.rdbSR48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbSR48.UseVisualStyleBackColor = True
        '
        'rdbSR44
        '
        Me.rdbSR44.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbSR44.Enabled = False
        Me.rdbSR44.Location = New System.Drawing.Point(6, 55)
        Me.rdbSR44.Name = "rdbSR44"
        Me.rdbSR44.Size = New System.Drawing.Size(104, 24)
        Me.rdbSR44.TabIndex = 1
        Me.rdbSR44.Text = "44.1 KHz"
        Me.rdbSR44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbSR44.UseVisualStyleBackColor = True
        '
        'rdbSRDirect
        '
        Me.rdbSRDirect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbSRDirect.Location = New System.Drawing.Point(6, 19)
        Me.rdbSRDirect.Name = "rdbSRDirect"
        Me.rdbSRDirect.Size = New System.Drawing.Size(104, 24)
        Me.rdbSRDirect.TabIndex = 0
        Me.rdbSRDirect.Text = "Direct"
        Me.rdbSRDirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbSRDirect.UseVisualStyleBackColor = True
        '
        'grpACodec
        '
        Me.grpACodec.Controls.Add(Me.rdbMP3)
        Me.grpACodec.Controls.Add(Me.rdbAAC)
        Me.grpACodec.Controls.Add(Me.rdbPCM24)
        Me.grpACodec.Controls.Add(Me.rdbPCM16)
        Me.grpACodec.Location = New System.Drawing.Point(6, 169)
        Me.grpACodec.Name = "grpACodec"
        Me.grpACodec.Size = New System.Drawing.Size(120, 155)
        Me.grpACodec.TabIndex = 4
        Me.grpACodec.TabStop = False
        Me.grpACodec.Text = "Audio Codec"
        '
        'rdbMP3
        '
        Me.rdbMP3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbMP3.Enabled = False
        Me.rdbMP3.Location = New System.Drawing.Point(7, 121)
        Me.rdbMP3.Name = "rdbMP3"
        Me.rdbMP3.Size = New System.Drawing.Size(104, 24)
        Me.rdbMP3.TabIndex = 3
        Me.rdbMP3.TabStop = True
        Me.rdbMP3.Text = "MP3 320 kbps"
        Me.rdbMP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbMP3.UseVisualStyleBackColor = True
        '
        'rdbAAC
        '
        Me.rdbAAC.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbAAC.Enabled = False
        Me.rdbAAC.Location = New System.Drawing.Point(7, 89)
        Me.rdbAAC.Name = "rdbAAC"
        Me.rdbAAC.Size = New System.Drawing.Size(104, 24)
        Me.rdbAAC.TabIndex = 2
        Me.rdbAAC.TabStop = True
        Me.rdbAAC.Text = "AAC_LC"
        Me.rdbAAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbAAC.UseVisualStyleBackColor = True
        '
        'rdbPCM24
        '
        Me.rdbPCM24.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbPCM24.Location = New System.Drawing.Point(6, 55)
        Me.rdbPCM24.Name = "rdbPCM24"
        Me.rdbPCM24.Size = New System.Drawing.Size(104, 24)
        Me.rdbPCM24.TabIndex = 1
        Me.rdbPCM24.TabStop = True
        Me.rdbPCM24.Text = "PCM 24 bits"
        Me.rdbPCM24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbPCM24.UseVisualStyleBackColor = True
        '
        'rdbPCM16
        '
        Me.rdbPCM16.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbPCM16.Location = New System.Drawing.Point(7, 21)
        Me.rdbPCM16.Name = "rdbPCM16"
        Me.rdbPCM16.Size = New System.Drawing.Size(104, 24)
        Me.rdbPCM16.TabIndex = 0
        Me.rdbPCM16.TabStop = True
        Me.rdbPCM16.Text = "PCM 16 bits"
        Me.rdbPCM16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbPCM16.UseVisualStyleBackColor = True
        '
        'grpACh
        '
        Me.grpACh.Controls.Add(Me.rdbA8Ch)
        Me.grpACh.Controls.Add(Me.rdbA4Ch)
        Me.grpACh.Controls.Add(Me.rdbA2Ch)
        Me.grpACh.Controls.Add(Me.rdbADirect)
        Me.grpACh.Location = New System.Drawing.Point(133, 169)
        Me.grpACh.Name = "grpACh"
        Me.grpACh.Size = New System.Drawing.Size(120, 155)
        Me.grpACh.TabIndex = 3
        Me.grpACh.TabStop = False
        Me.grpACh.Text = "Audio Channels"
        '
        'rdbA8Ch
        '
        Me.rdbA8Ch.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbA8Ch.Enabled = False
        Me.rdbA8Ch.Location = New System.Drawing.Point(6, 121)
        Me.rdbA8Ch.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbA8Ch.Name = "rdbA8Ch"
        Me.rdbA8Ch.Size = New System.Drawing.Size(104, 24)
        Me.rdbA8Ch.TabIndex = 3
        Me.rdbA8Ch.TabStop = True
        Me.rdbA8Ch.Text = "8 Channels"
        Me.rdbA8Ch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbA8Ch.UseVisualStyleBackColor = True
        '
        'rdbA4Ch
        '
        Me.rdbA4Ch.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbA4Ch.Enabled = False
        Me.rdbA4Ch.Location = New System.Drawing.Point(6, 87)
        Me.rdbA4Ch.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbA4Ch.Name = "rdbA4Ch"
        Me.rdbA4Ch.Size = New System.Drawing.Size(104, 24)
        Me.rdbA4Ch.TabIndex = 2
        Me.rdbA4Ch.TabStop = True
        Me.rdbA4Ch.Text = "4 Channels"
        Me.rdbA4Ch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbA4Ch.UseVisualStyleBackColor = True
        '
        'rdbA2Ch
        '
        Me.rdbA2Ch.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbA2Ch.Enabled = False
        Me.rdbA2Ch.Location = New System.Drawing.Point(6, 55)
        Me.rdbA2Ch.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbA2Ch.Name = "rdbA2Ch"
        Me.rdbA2Ch.Size = New System.Drawing.Size(104, 24)
        Me.rdbA2Ch.TabIndex = 1
        Me.rdbA2Ch.TabStop = True
        Me.rdbA2Ch.Text = "2 Channels"
        Me.rdbA2Ch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbA2Ch.UseVisualStyleBackColor = True
        '
        'rdbADirect
        '
        Me.rdbADirect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbADirect.Location = New System.Drawing.Point(6, 21)
        Me.rdbADirect.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbADirect.Name = "rdbADirect"
        Me.rdbADirect.Size = New System.Drawing.Size(104, 24)
        Me.rdbADirect.TabIndex = 0
        Me.rdbADirect.TabStop = True
        Me.rdbADirect.Text = "Direct"
        Me.rdbADirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbADirect.UseVisualStyleBackColor = True
        '
        'grpGlobal
        '
        Me.grpGlobal.Location = New System.Drawing.Point(6, 330)
        Me.grpGlobal.Name = "grpGlobal"
        Me.grpGlobal.Size = New System.Drawing.Size(247, 89)
        Me.grpGlobal.TabIndex = 0
        Me.grpGlobal.TabStop = False
        Me.grpGlobal.Text = "Global Options"
        '
        'grpResolution
        '
        Me.grpResolution.Controls.Add(Me.rdb540)
        Me.grpResolution.Controls.Add(Me.rdb486)
        Me.grpResolution.Controls.Add(Me.rdb720)
        Me.grpResolution.Controls.Add(Me.rdb1080)
        Me.grpResolution.Location = New System.Drawing.Point(133, 8)
        Me.grpResolution.Name = "grpResolution"
        Me.grpResolution.Size = New System.Drawing.Size(120, 155)
        Me.grpResolution.TabIndex = 2
        Me.grpResolution.TabStop = False
        Me.grpResolution.Text = "Resolution"
        '
        'rdb540
        '
        Me.rdb540.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb540.Location = New System.Drawing.Point(7, 121)
        Me.rdb540.Name = "rdb540"
        Me.rdb540.Size = New System.Drawing.Size(104, 24)
        Me.rdb540.TabIndex = 3
        Me.rdb540.TabStop = True
        Me.rdb540.Text = "720 x540 | 4:3"
        Me.rdb540.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb540.UseVisualStyleBackColor = True
        '
        'rdb486
        '
        Me.rdb486.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb486.Location = New System.Drawing.Point(7, 89)
        Me.rdb486.Name = "rdb486"
        Me.rdb486.Size = New System.Drawing.Size(104, 24)
        Me.rdb486.TabIndex = 2
        Me.rdb486.TabStop = True
        Me.rdb486.Text = "864 x486 | 16:9"
        Me.rdb486.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb486.UseVisualStyleBackColor = True
        '
        'rdb720
        '
        Me.rdb720.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb720.Location = New System.Drawing.Point(7, 55)
        Me.rdb720.Name = "rdb720"
        Me.rdb720.Size = New System.Drawing.Size(104, 24)
        Me.rdb720.TabIndex = 1
        Me.rdb720.TabStop = True
        Me.rdb720.Text = "1280 x720 | 16:9"
        Me.rdb720.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb720.UseVisualStyleBackColor = True
        '
        'rdb1080
        '
        Me.rdb1080.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdb1080.Location = New System.Drawing.Point(7, 21)
        Me.rdb1080.Name = "rdb1080"
        Me.rdb1080.Size = New System.Drawing.Size(104, 24)
        Me.rdb1080.TabIndex = 0
        Me.rdb1080.TabStop = True
        Me.rdb1080.Text = "1920 x1080 | 16:9"
        Me.rdb1080.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdb1080.UseVisualStyleBackColor = True
        '
        'grpDumbCodec
        '
        Me.grpDumbCodec.Controls.Add(Me.rdbWAV)
        Me.grpDumbCodec.Controls.Add(Me.rdbDNxHD)
        Me.grpDumbCodec.Controls.Add(Me.rdbProRes)
        Me.grpDumbCodec.Controls.Add(Me.rdbH264)
        Me.grpDumbCodec.Location = New System.Drawing.Point(6, 8)
        Me.grpDumbCodec.Name = "grpDumbCodec"
        Me.grpDumbCodec.Size = New System.Drawing.Size(120, 155)
        Me.grpDumbCodec.TabIndex = 1
        Me.grpDumbCodec.TabStop = False
        Me.grpDumbCodec.Text = "Video Codec"
        '
        'rdbWAV
        '
        Me.rdbWAV.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbWAV.Location = New System.Drawing.Point(8, 121)
        Me.rdbWAV.Name = "rdbWAV"
        Me.rdbWAV.Size = New System.Drawing.Size(104, 24)
        Me.rdbWAV.TabIndex = 3
        Me.rdbWAV.Text = "WAV"
        Me.rdbWAV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbWAV.UseVisualStyleBackColor = True
        '
        'rdbDNxHD
        '
        Me.rdbDNxHD.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbDNxHD.Enabled = False
        Me.rdbDNxHD.Location = New System.Drawing.Point(8, 89)
        Me.rdbDNxHD.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbDNxHD.Name = "rdbDNxHD"
        Me.rdbDNxHD.Size = New System.Drawing.Size(104, 24)
        Me.rdbDNxHD.TabIndex = 2
        Me.rdbDNxHD.Text = "DNxHD"
        Me.rdbDNxHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDNxHD.UseVisualStyleBackColor = True
        '
        'rdbProRes
        '
        Me.rdbProRes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbProRes.Location = New System.Drawing.Point(8, 55)
        Me.rdbProRes.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbProRes.Name = "rdbProRes"
        Me.rdbProRes.Size = New System.Drawing.Size(104, 24)
        Me.rdbProRes.TabIndex = 1
        Me.rdbProRes.Text = "ProRes"
        Me.rdbProRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbProRes.UseVisualStyleBackColor = True
        '
        'rdbH264
        '
        Me.rdbH264.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbH264.Location = New System.Drawing.Point(8, 21)
        Me.rdbH264.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbH264.Name = "rdbH264"
        Me.rdbH264.Size = New System.Drawing.Size(104, 24)
        Me.rdbH264.TabIndex = 0
        Me.rdbH264.Text = "H.264 I-frame"
        Me.rdbH264.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbH264.UseVisualStyleBackColor = True
        '
        'TabConfig
        '
        Me.TabConfig.Controls.Add(Me.lblFRcommand)
        Me.TabConfig.Controls.Add(Me.lblFFarguments)
        Me.TabConfig.Controls.Add(Me.lblASRCommand)
        Me.TabConfig.Controls.Add(Me.lblACodecCommand)
        Me.TabConfig.Controls.Add(Me.lblAudioChCommand)
        Me.TabConfig.Controls.Add(Me.lblFileNameCommand)
        Me.TabConfig.Controls.Add(Me.lblRes)
        Me.TabConfig.Controls.Add(Me.lblCodecCommand)
        Me.TabConfig.Controls.Add(Me.lblMXFPathCommand)
        Me.TabConfig.Controls.Add(Me.chkDumb)
        Me.TabConfig.Controls.Add(Me.lblFFmpegCommand)
        Me.TabConfig.Controls.Add(Me.grpTemp)
        Me.TabConfig.Controls.Add(Me.grpFFmpeg)
        Me.TabConfig.Location = New System.Drawing.Point(4, 22)
        Me.TabConfig.Name = "TabConfig"
        Me.TabConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfig.Size = New System.Drawing.Size(951, 425)
        Me.TabConfig.TabIndex = 1
        Me.TabConfig.Text = "Software Config"
        Me.TabConfig.UseVisualStyleBackColor = True
        '
        'lblFRcommand
        '
        Me.lblFRcommand.AutoSize = True
        Me.lblFRcommand.Location = New System.Drawing.Point(20, 197)
        Me.lblFRcommand.Name = "lblFRcommand"
        Me.lblFRcommand.Size = New System.Drawing.Size(62, 13)
        Me.lblFRcommand.TabIndex = 18
        Me.lblFRcommand.Text = "Frame Rate"
        '
        'lblFFarguments
        '
        Me.lblFFarguments.AutoSize = True
        Me.lblFFarguments.Location = New System.Drawing.Point(17, 297)
        Me.lblFFarguments.Name = "lblFFarguments"
        Me.lblFFarguments.Size = New System.Drawing.Size(57, 13)
        Me.lblFFarguments.TabIndex = 13
        Me.lblFFarguments.Text = "Arguments"
        '
        'lblASRCommand
        '
        Me.lblASRCommand.AutoSize = True
        Me.lblASRCommand.Location = New System.Drawing.Point(17, 177)
        Me.lblASRCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblASRCommand.Name = "lblASRCommand"
        Me.lblASRCommand.Size = New System.Drawing.Size(98, 13)
        Me.lblASRCommand.TabIndex = 17
        Me.lblASRCommand.Text = "Audio Sample Rate"
        '
        'lblACodecCommand
        '
        Me.lblACodecCommand.AutoSize = True
        Me.lblACodecCommand.Location = New System.Drawing.Point(17, 158)
        Me.lblACodecCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblACodecCommand.Name = "lblACodecCommand"
        Me.lblACodecCommand.Size = New System.Drawing.Size(68, 13)
        Me.lblACodecCommand.TabIndex = 16
        Me.lblACodecCommand.Text = "Audio Codec"
        '
        'lblAudioChCommand
        '
        Me.lblAudioChCommand.AutoSize = True
        Me.lblAudioChCommand.Location = New System.Drawing.Point(17, 139)
        Me.lblAudioChCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAudioChCommand.Name = "lblAudioChCommand"
        Me.lblAudioChCommand.Size = New System.Drawing.Size(50, 13)
        Me.lblAudioChCommand.TabIndex = 15
        Me.lblAudioChCommand.Text = "Audio Ch"
        '
        'lblFileNameCommand
        '
        Me.lblFileNameCommand.AutoSize = True
        Me.lblFileNameCommand.Location = New System.Drawing.Point(17, 120)
        Me.lblFileNameCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblFileNameCommand.Name = "lblFileNameCommand"
        Me.lblFileNameCommand.Size = New System.Drawing.Size(54, 13)
        Me.lblFileNameCommand.TabIndex = 14
        Me.lblFileNameCommand.Text = "File Name"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(17, 101)
        Me.lblRes.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(57, 13)
        Me.lblRes.TabIndex = 13
        Me.lblRes.Text = "Resolution"
        '
        'lblCodecCommand
        '
        Me.lblCodecCommand.AutoSize = True
        Me.lblCodecCommand.Location = New System.Drawing.Point(17, 82)
        Me.lblCodecCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCodecCommand.Name = "lblCodecCommand"
        Me.lblCodecCommand.Size = New System.Drawing.Size(38, 13)
        Me.lblCodecCommand.TabIndex = 10
        Me.lblCodecCommand.Text = "Codec"
        '
        'lblMXFPathCommand
        '
        Me.lblMXFPathCommand.AutoSize = True
        Me.lblMXFPathCommand.Location = New System.Drawing.Point(17, 63)
        Me.lblMXFPathCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMXFPathCommand.Name = "lblMXFPathCommand"
        Me.lblMXFPathCommand.Size = New System.Drawing.Size(45, 13)
        Me.lblMXFPathCommand.TabIndex = 12
        Me.lblMXFPathCommand.Text = "MXF file"
        '
        'chkDumb
        '
        Me.chkDumb.AutoSize = True
        Me.chkDumb.Enabled = False
        Me.chkDumb.Location = New System.Drawing.Point(813, 3)
        Me.chkDumb.Name = "chkDumb"
        Me.chkDumb.Padding = New System.Windows.Forms.Padding(15)
        Me.chkDumb.Size = New System.Drawing.Size(135, 47)
        Me.chkDumb.TabIndex = 1
        Me.chkDumb.Text = "Advanced Mode"
        Me.chkDumb.UseVisualStyleBackColor = True
        '
        'lblFFmpegCommand
        '
        Me.lblFFmpegCommand.AutoSize = True
        Me.lblFFmpegCommand.Location = New System.Drawing.Point(17, 44)
        Me.lblFFmpegCommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblFFmpegCommand.Name = "lblFFmpegCommand"
        Me.lblFFmpegCommand.Size = New System.Drawing.Size(70, 13)
        Me.lblFFmpegCommand.TabIndex = 11
        Me.lblFFmpegCommand.Text = "FFmpeg Path"
        '
        'grpTemp
        '
        Me.grpTemp.Controls.Add(Me.btnTempDefault)
        Me.grpTemp.Controls.Add(Me.txtTemp)
        Me.grpTemp.Controls.Add(Me.btnTemp)
        Me.grpTemp.Location = New System.Drawing.Point(6, 369)
        Me.grpTemp.Name = "grpTemp"
        Me.grpTemp.Size = New System.Drawing.Size(938, 50)
        Me.grpTemp.TabIndex = 2
        Me.grpTemp.TabStop = False
        Me.grpTemp.Text = "Temporary Folder"
        '
        'btnTempDefault
        '
        Me.btnTempDefault.Location = New System.Drawing.Point(857, 19)
        Me.btnTempDefault.Name = "btnTempDefault"
        Me.btnTempDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnTempDefault.TabIndex = 2
        Me.btnTempDefault.Text = "Set Default"
        Me.btnTempDefault.UseVisualStyleBackColor = True
        '
        'txtTemp
        '
        Me.txtTemp.AutoSize = True
        Me.txtTemp.Location = New System.Drawing.Point(87, 24)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(43, 13)
        Me.txtTemp.TabIndex = 1
        Me.txtTemp.Text = "c:Temp"
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(6, 19)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(75, 23)
        Me.btnTemp.TabIndex = 0
        Me.btnTemp.Text = "Set Folder"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'grpFFmpeg
        '
        Me.grpFFmpeg.Controls.Add(Me.txtFFmpeg)
        Me.grpFFmpeg.Controls.Add(Me.btnFFmpeg)
        Me.grpFFmpeg.Location = New System.Drawing.Point(6, 313)
        Me.grpFFmpeg.Name = "grpFFmpeg"
        Me.grpFFmpeg.Size = New System.Drawing.Size(939, 50)
        Me.grpFFmpeg.TabIndex = 1
        Me.grpFFmpeg.TabStop = False
        Me.grpFFmpeg.Text = "FFmpeg Path"
        '
        'txtFFmpeg
        '
        Me.txtFFmpeg.AutoSize = True
        Me.txtFFmpeg.Location = New System.Drawing.Point(87, 24)
        Me.txtFFmpeg.Name = "txtFFmpeg"
        Me.txtFFmpeg.Size = New System.Drawing.Size(54, 13)
        Me.txtFFmpeg.TabIndex = 1
        Me.txtFFmpeg.Text = "c:FFmpeg"
        '
        'btnFFmpeg
        '
        Me.btnFFmpeg.Location = New System.Drawing.Point(6, 19)
        Me.btnFFmpeg.Name = "btnFFmpeg"
        Me.btnFFmpeg.Size = New System.Drawing.Size(75, 23)
        Me.btnFFmpeg.TabIndex = 0
        Me.btnFFmpeg.Text = "Set Path"
        Me.btnFFmpeg.UseVisualStyleBackColor = True
        '
        'OpenFFmpegDialog
        '
        Me.OpenFFmpegDialog.DefaultExt = "exe"
        Me.OpenFFmpegDialog.FileName = "FFmpeg.exe"
        Me.OpenFFmpegDialog.Filter = "Executable | *.exe"
        Me.OpenFFmpegDialog.InitialDirectory = "computer"
        Me.OpenFFmpegDialog.Title = "Find FFmpeg EXE"
        '
        'btnChk3
        '
        Me.btnChk3.BackColor = System.Drawing.Color.Red
        Me.btnChk3.Enabled = False
        Me.btnChk3.FlatAppearance.BorderSize = 0
        Me.btnChk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk3.Location = New System.Drawing.Point(929, 635)
        Me.btnChk3.Name = "btnChk3"
        Me.btnChk3.Size = New System.Drawing.Size(10, 15)
        Me.btnChk3.TabIndex = 8
        Me.btnChk3.UseVisualStyleBackColor = False
        '
        'btnChk2
        '
        Me.btnChk2.BackColor = System.Drawing.Color.Red
        Me.btnChk2.Enabled = False
        Me.btnChk2.FlatAppearance.BorderSize = 0
        Me.btnChk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk2.Location = New System.Drawing.Point(913, 635)
        Me.btnChk2.Name = "btnChk2"
        Me.btnChk2.Size = New System.Drawing.Size(10, 15)
        Me.btnChk2.TabIndex = 8
        Me.btnChk2.UseVisualStyleBackColor = False
        '
        'btnChk1
        '
        Me.btnChk1.BackColor = System.Drawing.Color.Red
        Me.btnChk1.Enabled = False
        Me.btnChk1.FlatAppearance.BorderSize = 0
        Me.btnChk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk1.Location = New System.Drawing.Point(897, 635)
        Me.btnChk1.Name = "btnChk1"
        Me.btnChk1.Size = New System.Drawing.Size(10, 15)
        Me.btnChk1.TabIndex = 8
        Me.btnChk1.UseVisualStyleBackColor = False
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(897, 554)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 75)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnChk4
        '
        Me.btnChk4.BackColor = System.Drawing.Color.Red
        Me.btnChk4.Enabled = False
        Me.btnChk4.FlatAppearance.BorderSize = 0
        Me.btnChk4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk4.Location = New System.Drawing.Point(945, 635)
        Me.btnChk4.Name = "btnChk4"
        Me.btnChk4.Size = New System.Drawing.Size(10, 15)
        Me.btnChk4.TabIndex = 8
        Me.btnChk4.UseVisualStyleBackColor = False
        '
        'btnChk5
        '
        Me.btnChk5.BackColor = System.Drawing.Color.Red
        Me.btnChk5.Enabled = False
        Me.btnChk5.FlatAppearance.BorderSize = 0
        Me.btnChk5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk5.Location = New System.Drawing.Point(961, 635)
        Me.btnChk5.Name = "btnChk5"
        Me.btnChk5.Size = New System.Drawing.Size(10, 15)
        Me.btnChk5.TabIndex = 8
        Me.btnChk5.UseVisualStyleBackColor = False
        '
        'txtOutFilename
        '
        Me.txtOutFilename.Location = New System.Drawing.Point(93, 568)
        Me.txtOutFilename.Name = "txtOutFilename"
        Me.txtOutFilename.Size = New System.Drawing.Size(169, 20)
        Me.txtOutFilename.TabIndex = 10
        '
        'lblOutName
        '
        Me.lblOutName.AutoSize = True
        Me.lblOutName.Location = New System.Drawing.Point(94, 552)
        Me.lblOutName.Name = "lblOutName"
        Me.lblOutName.Size = New System.Drawing.Size(89, 13)
        Me.lblOutName.TabIndex = 11
        Me.lblOutName.Text = "Output File Name"
        '
        'txtNameDate
        '
        Me.txtNameDate.AutoSize = True
        Me.txtNameDate.Location = New System.Drawing.Point(268, 571)
        Me.txtNameDate.Name = "txtNameDate"
        Me.txtNameDate.Size = New System.Drawing.Size(65, 13)
        Me.txtNameDate.TabIndex = 12
        Me.txtNameDate.Text = "Data e Hora"
        '
        'grpDumb
        '
        Me.grpDumb.Location = New System.Drawing.Point(385, 8)
        Me.grpDumb.Name = "grpDumb"
        Me.grpDumb.Size = New System.Drawing.Size(121, 320)
        Me.grpDumb.TabIndex = 9
        Me.grpDumb.TabStop = False
        Me.grpDumb.Text = "Dumb Mode"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'frmTMXF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.txtNameDate)
        Me.Controls.Add(Me.lblOutName)
        Me.Controls.Add(Me.txtOutFilename)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnChk1)
        Me.Controls.Add(Me.btnChk2)
        Me.Controls.Add(Me.btnChk5)
        Me.Controls.Add(Me.btnChk4)
        Me.Controls.Add(Me.btnChk3)
        Me.Controls.Add(Me.tabsMain)
        Me.Controls.Add(Me.txtOutPath)
        Me.Controls.Add(Me.btnSaveOut)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.txtMXFpath)
        Me.Controls.Add(Me.btnLoadMXF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTMXF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "T MXF Converter"
        Me.tabsMain.ResumeLayout(False)
        Me.TabCodec.ResumeLayout(False)
        Me.TabCodec.PerformLayout()
        Me.grpTCBurn.ResumeLayout(False)
        Me.grpTCBurn.PerformLayout()
        Me.grpFrameRate.ResumeLayout(False)
        Me.grpSRate.ResumeLayout(False)
        Me.grpACodec.ResumeLayout(False)
        Me.grpACh.ResumeLayout(False)
        Me.grpResolution.ResumeLayout(False)
        Me.grpDumbCodec.ResumeLayout(False)
        Me.TabConfig.ResumeLayout(False)
        Me.TabConfig.PerformLayout()
        Me.grpTemp.ResumeLayout(False)
        Me.grpTemp.PerformLayout()
        Me.grpFFmpeg.ResumeLayout(False)
        Me.grpFFmpeg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProcessFFmpeg As System.Diagnostics.Process
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtMXFpath As System.Windows.Forms.Label
    Friend WithEvents btnLoadMXF As System.Windows.Forms.Button
    Friend WithEvents OpenMXFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtOutPath As System.Windows.Forms.Label
    Friend WithEvents btnSaveOut As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tabsMain As System.Windows.Forms.TabControl
    Friend WithEvents TabCodec As System.Windows.Forms.TabPage
    Friend WithEvents TabConfig As System.Windows.Forms.TabPage
    Friend WithEvents grpFFmpeg As System.Windows.Forms.GroupBox
    Friend WithEvents txtFFmpeg As System.Windows.Forms.Label
    Friend WithEvents btnFFmpeg As System.Windows.Forms.Button
    Friend WithEvents grpTemp As System.Windows.Forms.GroupBox
    Friend WithEvents txtTemp As System.Windows.Forms.Label
    Friend WithEvents btnTemp As System.Windows.Forms.Button
    Friend WithEvents OpenFFmpegDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnChk3 As System.Windows.Forms.Button
    Friend WithEvents btnTempDefault As System.Windows.Forms.Button
    Friend WithEvents btnChk2 As System.Windows.Forms.Button
    Friend WithEvents btnChk1 As System.Windows.Forms.Button
    Friend WithEvents grpGlobal As System.Windows.Forms.GroupBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents grpDumbCodec As System.Windows.Forms.GroupBox
    Friend WithEvents rdbWAV As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDNxHD As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProRes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbH264 As System.Windows.Forms.RadioButton
    Friend WithEvents chkDumb As System.Windows.Forms.CheckBox
    Friend WithEvents lblCodecCommand As System.Windows.Forms.Label
    Friend WithEvents lblMXFPathCommand As System.Windows.Forms.Label
    Friend WithEvents lblFFmpegCommand As System.Windows.Forms.Label
    Friend WithEvents btnChk5 As System.Windows.Forms.Button
    Friend WithEvents btnChk4 As System.Windows.Forms.Button
    Friend WithEvents grpResolution As System.Windows.Forms.GroupBox
    Friend WithEvents rdb540 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb486 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb720 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1080 As System.Windows.Forms.RadioButton
    Friend WithEvents lblRes As System.Windows.Forms.Label
    Friend WithEvents lblOutName As System.Windows.Forms.Label
    Friend WithEvents txtOutFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblFileNameCommand As System.Windows.Forms.Label
    Friend WithEvents grpACodec As System.Windows.Forms.GroupBox
    Friend WithEvents grpACh As System.Windows.Forms.GroupBox
    Friend WithEvents rdbA8Ch As System.Windows.Forms.RadioButton
    Friend WithEvents rdbA4Ch As System.Windows.Forms.RadioButton
    Friend WithEvents rdbA2Ch As System.Windows.Forms.RadioButton
    Friend WithEvents rdbADirect As System.Windows.Forms.RadioButton
    Friend WithEvents lblAudioChCommand As System.Windows.Forms.Label
    Friend WithEvents rdbMP3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAAC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPCM24 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPCM16 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSRate As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSR44 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSRDirect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSR48 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb96 As System.Windows.Forms.RadioButton
    Friend WithEvents lblACodecCommand As System.Windows.Forms.Label
    Friend WithEvents txtNameDate As System.Windows.Forms.Label
    Friend WithEvents lblASRCommand As System.Windows.Forms.Label
    Friend WithEvents txtFFoutput As System.Windows.Forms.TextBox
    Friend WithEvents lblFFarguments As System.Windows.Forms.Label
    Friend WithEvents grpFrameRate As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFRdirect As System.Windows.Forms.RadioButton
    Friend WithEvents rdb23 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb29ND As System.Windows.Forms.RadioButton
    Friend WithEvents rdb29D As System.Windows.Forms.RadioButton
    Friend WithEvents grpTCBurn As System.Windows.Forms.GroupBox
    Friend WithEvents chkTCBurn As System.Windows.Forms.CheckBox
    Friend WithEvents lblFRcommand As System.Windows.Forms.Label
    Friend WithEvents grpDumb As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
