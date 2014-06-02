<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTMXF))
        Me.FFmpegprocess = New System.Diagnostics.Process()
        Me.btnLoadMXF = New System.Windows.Forms.Button()
        Me.txtMXFpath = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.OpenMXFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveOut = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtOutPath = New System.Windows.Forms.Label()
        Me.tabsMain = New System.Windows.Forms.TabControl()
        Me.TabCodec = New System.Windows.Forms.TabPage()
        Me.txtFFoutput = New System.Windows.Forms.TextBox()
        Me.grpAdvanced = New System.Windows.Forms.GroupBox()
        Me.grpTCBurn = New System.Windows.Forms.GroupBox()
        Me.btnTCanalize = New System.Windows.Forms.Button()
        Me.chkTCBurn = New System.Windows.Forms.CheckBox()
        Me.grpFrameRate = New System.Windows.Forms.GroupBox()
        Me.rdbFRdirect = New System.Windows.Forms.RadioButton()
        Me.rdb23 = New System.Windows.Forms.RadioButton()
        Me.rdb29ND = New System.Windows.Forms.RadioButton()
        Me.rdb29D = New System.Windows.Forms.RadioButton()
        Me.grpSRate = New System.Windows.Forms.GroupBox()
        Me.rdbSR96 = New System.Windows.Forms.RadioButton()
        Me.rdbSR48 = New System.Windows.Forms.RadioButton()
        Me.rdbSR44 = New System.Windows.Forms.RadioButton()
        Me.rdbSRDirect = New System.Windows.Forms.RadioButton()
        Me.grpACodec = New System.Windows.Forms.GroupBox()
        Me.rdbACDirect = New System.Windows.Forms.RadioButton()
        Me.rdbAAC = New System.Windows.Forms.RadioButton()
        Me.rdbPCM24 = New System.Windows.Forms.RadioButton()
        Me.rdbPCM16 = New System.Windows.Forms.RadioButton()
        Me.grpACh = New System.Windows.Forms.GroupBox()
        Me.rdbA8Ch = New System.Windows.Forms.RadioButton()
        Me.rdbA4Ch = New System.Windows.Forms.RadioButton()
        Me.rdbA2Ch = New System.Windows.Forms.RadioButton()
        Me.rdbADirect = New System.Windows.Forms.RadioButton()
        Me.grpGlobal = New System.Windows.Forms.GroupBox()
        Me.chkOverwrite = New System.Windows.Forms.CheckBox()
        Me.chkReport = New System.Windows.Forms.CheckBox()
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
        Me.grpFFprobe = New System.Windows.Forms.GroupBox()
        Me.txtFFprobe = New System.Windows.Forms.Label()
        Me.btnFFprobe = New System.Windows.Forms.Button()
        Me.lblLastTempName = New System.Windows.Forms.Label()
        Me.lblSRcommand = New System.Windows.Forms.Label()
        Me.lblFRcommand = New System.Windows.Forms.Label()
        Me.lblFFarguments = New System.Windows.Forms.Label()
        Me.lblASRCommand = New System.Windows.Forms.Label()
        Me.lblACodecCommand = New System.Windows.Forms.Label()
        Me.lblAudioChCommand = New System.Windows.Forms.Label()
        Me.lblFileNameCommand = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblCodecCommand = New System.Windows.Forms.Label()
        Me.lblMXFPathCommand = New System.Windows.Forms.Label()
        Me.chkAdvanced = New System.Windows.Forms.CheckBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.OpenFFprobeDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tabsMain.SuspendLayout()
        Me.TabCodec.SuspendLayout()
        Me.grpTCBurn.SuspendLayout()
        Me.grpFrameRate.SuspendLayout()
        Me.grpSRate.SuspendLayout()
        Me.grpACodec.SuspendLayout()
        Me.grpACh.SuspendLayout()
        Me.grpGlobal.SuspendLayout()
        Me.grpResolution.SuspendLayout()
        Me.grpDumbCodec.SuspendLayout()
        Me.TabConfig.SuspendLayout()
        Me.grpFFprobe.SuspendLayout()
        Me.grpTemp.SuspendLayout()
        Me.grpFFmpeg.SuspendLayout()
        Me.SuspendLayout()
        '
        'FFmpegprocess
        '
        Me.FFmpegprocess.StartInfo.CreateNoWindow = True
        Me.FFmpegprocess.StartInfo.Domain = ""
        Me.FFmpegprocess.StartInfo.LoadUserProfile = False
        Me.FFmpegprocess.StartInfo.Password = Nothing
        Me.FFmpegprocess.StartInfo.RedirectStandardError = True
        Me.FFmpegprocess.StartInfo.RedirectStandardInput = True
        Me.FFmpegprocess.StartInfo.RedirectStandardOutput = True
        Me.FFmpegprocess.StartInfo.StandardErrorEncoding = Nothing
        Me.FFmpegprocess.StartInfo.StandardOutputEncoding = Nothing
        Me.FFmpegprocess.StartInfo.UserName = ""
        Me.FFmpegprocess.StartInfo.UseShellExecute = False
        Me.FFmpegprocess.SynchronizingObject = Me
        '
        'btnLoadMXF
        '
        Me.btnLoadMXF.Location = New System.Drawing.Point(13, 13)
        Me.btnLoadMXF.Name = "btnLoadMXF"
        Me.btnLoadMXF.Size = New System.Drawing.Size(75, 25)
        Me.btnLoadMXF.TabIndex = 0
        Me.btnLoadMXF.Text = "Load MXF"
        Me.btnLoadMXF.UseVisualStyleBackColor = True
        '
        'txtMXFpath
        '
        Me.txtMXFpath.AutoSize = True
        Me.txtMXFpath.Location = New System.Drawing.Point(94, 19)
        Me.txtMXFpath.Name = "txtMXFpath"
        Me.txtMXFpath.Size = New System.Drawing.Size(16, 13)
        Me.txtMXFpath.TabIndex = 1
        Me.txtMXFpath.Text = "..."
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
        Me.btnSaveOut.Location = New System.Drawing.Point(13, 604)
        Me.btnSaveOut.Name = "btnSaveOut"
        Me.btnSaveOut.Size = New System.Drawing.Size(90, 25)
        Me.btnSaveOut.TabIndex = 4
        Me.btnSaveOut.Text = "Output Path"
        Me.btnSaveOut.UseVisualStyleBackColor = True
        '
        'txtOutPath
        '
        Me.txtOutPath.AutoSize = True
        Me.txtOutPath.Location = New System.Drawing.Point(109, 610)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(16, 13)
        Me.txtOutPath.TabIndex = 6
        Me.txtOutPath.Text = "..."
        '
        'tabsMain
        '
        Me.tabsMain.Controls.Add(Me.TabCodec)
        Me.tabsMain.Controls.Add(Me.TabConfig)
        Me.tabsMain.Location = New System.Drawing.Point(13, 44)
        Me.tabsMain.Name = "tabsMain"
        Me.tabsMain.SelectedIndex = 0
        Me.tabsMain.Size = New System.Drawing.Size(959, 535)
        Me.tabsMain.TabIndex = 7
        '
        'TabCodec
        '
        Me.TabCodec.Controls.Add(Me.txtFFoutput)
        Me.TabCodec.Controls.Add(Me.grpAdvanced)
        Me.TabCodec.Controls.Add(Me.grpTCBurn)
        Me.TabCodec.Controls.Add(Me.grpFrameRate)
        Me.TabCodec.Controls.Add(Me.grpSRate)
        Me.TabCodec.Controls.Add(Me.grpACodec)
        Me.TabCodec.Controls.Add(Me.grpACh)
        Me.TabCodec.Controls.Add(Me.grpGlobal)
        Me.TabCodec.Controls.Add(Me.grpResolution)
        Me.TabCodec.Controls.Add(Me.grpDumbCodec)
        Me.TabCodec.Location = New System.Drawing.Point(4, 22)
        Me.TabCodec.Name = "TabCodec"
        Me.TabCodec.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCodec.Size = New System.Drawing.Size(951, 509)
        Me.TabCodec.TabIndex = 0
        Me.TabCodec.Text = "Codec Config"
        Me.TabCodec.UseVisualStyleBackColor = True
        '
        'txtFFoutput
        '
        Me.txtFFoutput.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFFoutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFFoutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFFoutput.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFFoutput.Location = New System.Drawing.Point(385, 8)
        Me.txtFFoutput.Multiline = True
        Me.txtFFoutput.Name = "txtFFoutput"
        Me.txtFFoutput.ReadOnly = True
        Me.txtFFoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFFoutput.Size = New System.Drawing.Size(560, 495)
        Me.txtFFoutput.TabIndex = 6
        Me.txtFFoutput.TabStop = False
        '
        'grpAdvanced
        '
        Me.grpAdvanced.Location = New System.Drawing.Point(259, 330)
        Me.grpAdvanced.Name = "grpAdvanced"
        Me.grpAdvanced.Size = New System.Drawing.Size(120, 166)
        Me.grpAdvanced.TabIndex = 9
        Me.grpAdvanced.TabStop = False
        Me.grpAdvanced.Text = "Advanced"
        '
        'grpTCBurn
        '
        Me.grpTCBurn.Controls.Add(Me.btnTCanalize)
        Me.grpTCBurn.Controls.Add(Me.chkTCBurn)
        Me.grpTCBurn.Enabled = False
        Me.grpTCBurn.Location = New System.Drawing.Point(6, 416)
        Me.grpTCBurn.Name = "grpTCBurn"
        Me.grpTCBurn.Size = New System.Drawing.Size(247, 80)
        Me.grpTCBurn.TabIndex = 8
        Me.grpTCBurn.TabStop = False
        Me.grpTCBurn.Text = "Time Code Burn"
        '
        'btnTCanalize
        '
        Me.btnTCanalize.Enabled = False
        Me.btnTCanalize.Location = New System.Drawing.Point(166, 14)
        Me.btnTCanalize.Name = "btnTCanalize"
        Me.btnTCanalize.Size = New System.Drawing.Size(75, 23)
        Me.btnTCanalize.TabIndex = 1
        Me.btnTCanalize.Text = "Analyze"
        Me.btnTCanalize.UseVisualStyleBackColor = True
        '
        'chkTCBurn
        '
        Me.chkTCBurn.AutoSize = True
        Me.chkTCBurn.Enabled = False
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
        'grpSRate
        '
        Me.grpSRate.Controls.Add(Me.rdbSR96)
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
        'rdbSR96
        '
        Me.rdbSR96.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbSR96.Enabled = False
        Me.rdbSR96.Location = New System.Drawing.Point(6, 121)
        Me.rdbSR96.Name = "rdbSR96"
        Me.rdbSR96.Size = New System.Drawing.Size(104, 24)
        Me.rdbSR96.TabIndex = 3
        Me.rdbSR96.Text = "96 KHz"
        Me.rdbSR96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbSR96.UseVisualStyleBackColor = True
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
        Me.grpACodec.Controls.Add(Me.rdbACDirect)
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
        'rdbACDirect
        '
        Me.rdbACDirect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbACDirect.Location = New System.Drawing.Point(6, 21)
        Me.rdbACDirect.Name = "rdbACDirect"
        Me.rdbACDirect.Size = New System.Drawing.Size(104, 24)
        Me.rdbACDirect.TabIndex = 3
        Me.rdbACDirect.TabStop = True
        Me.rdbACDirect.Text = "Direct"
        Me.rdbACDirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbACDirect.UseVisualStyleBackColor = True
        '
        'rdbAAC
        '
        Me.rdbAAC.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbAAC.Enabled = False
        Me.rdbAAC.Location = New System.Drawing.Point(6, 121)
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
        Me.rdbPCM24.Location = New System.Drawing.Point(6, 87)
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
        Me.rdbPCM16.Location = New System.Drawing.Point(6, 55)
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
        Me.grpGlobal.Controls.Add(Me.chkOverwrite)
        Me.grpGlobal.Controls.Add(Me.chkReport)
        Me.grpGlobal.Location = New System.Drawing.Point(6, 330)
        Me.grpGlobal.Name = "grpGlobal"
        Me.grpGlobal.Size = New System.Drawing.Size(247, 80)
        Me.grpGlobal.TabIndex = 0
        Me.grpGlobal.TabStop = False
        Me.grpGlobal.Text = "Global Options"
        '
        'chkOverwrite
        '
        Me.chkOverwrite.AutoSize = True
        Me.chkOverwrite.Checked = True
        Me.chkOverwrite.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkOverwrite.Enabled = False
        Me.chkOverwrite.Location = New System.Drawing.Point(8, 44)
        Me.chkOverwrite.Name = "chkOverwrite"
        Me.chkOverwrite.Size = New System.Drawing.Size(106, 17)
        Me.chkOverwrite.TabIndex = 1
        Me.chkOverwrite.Text = "Overwrite Output"
        Me.chkOverwrite.UseVisualStyleBackColor = True
        '
        'chkReport
        '
        Me.chkReport.AutoSize = True
        Me.chkReport.Checked = True
        Me.chkReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReport.Location = New System.Drawing.Point(7, 20)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(105, 17)
        Me.chkReport.TabIndex = 0
        Me.chkReport.Text = "Generate Report"
        Me.chkReport.UseVisualStyleBackColor = True
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
        Me.TabConfig.Controls.Add(Me.grpFFprobe)
        Me.TabConfig.Controls.Add(Me.lblLastTempName)
        Me.TabConfig.Controls.Add(Me.lblSRcommand)
        Me.TabConfig.Controls.Add(Me.lblFRcommand)
        Me.TabConfig.Controls.Add(Me.lblFFarguments)
        Me.TabConfig.Controls.Add(Me.lblASRCommand)
        Me.TabConfig.Controls.Add(Me.lblACodecCommand)
        Me.TabConfig.Controls.Add(Me.lblAudioChCommand)
        Me.TabConfig.Controls.Add(Me.lblFileNameCommand)
        Me.TabConfig.Controls.Add(Me.lblRes)
        Me.TabConfig.Controls.Add(Me.lblCodecCommand)
        Me.TabConfig.Controls.Add(Me.lblMXFPathCommand)
        Me.TabConfig.Controls.Add(Me.chkAdvanced)
        Me.TabConfig.Controls.Add(Me.lblFFmpegCommand)
        Me.TabConfig.Controls.Add(Me.grpTemp)
        Me.TabConfig.Controls.Add(Me.grpFFmpeg)
        Me.TabConfig.Location = New System.Drawing.Point(4, 22)
        Me.TabConfig.Name = "TabConfig"
        Me.TabConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfig.Size = New System.Drawing.Size(951, 509)
        Me.TabConfig.TabIndex = 1
        Me.TabConfig.Text = "Software Config"
        Me.TabConfig.UseVisualStyleBackColor = True
        '
        'grpFFprobe
        '
        Me.grpFFprobe.Controls.Add(Me.txtFFprobe)
        Me.grpFFprobe.Controls.Add(Me.btnFFprobe)
        Me.grpFFprobe.Location = New System.Drawing.Point(6, 341)
        Me.grpFFprobe.Name = "grpFFprobe"
        Me.grpFFprobe.Size = New System.Drawing.Size(939, 50)
        Me.grpFFprobe.TabIndex = 21
        Me.grpFFprobe.TabStop = False
        Me.grpFFprobe.Text = "FFprobe Path"
        '
        'txtFFprobe
        '
        Me.txtFFprobe.AutoSize = True
        Me.txtFFprobe.Location = New System.Drawing.Point(87, 24)
        Me.txtFFprobe.Name = "txtFFprobe"
        Me.txtFFprobe.Size = New System.Drawing.Size(55, 13)
        Me.txtFFprobe.TabIndex = 1
        Me.txtFFprobe.Text = "c:FFprobe"
        '
        'btnFFprobe
        '
        Me.btnFFprobe.Location = New System.Drawing.Point(6, 19)
        Me.btnFFprobe.Name = "btnFFprobe"
        Me.btnFFprobe.Size = New System.Drawing.Size(75, 23)
        Me.btnFFprobe.TabIndex = 0
        Me.btnFFprobe.Text = "Set Path"
        Me.btnFFprobe.UseVisualStyleBackColor = True
        '
        'lblLastTempName
        '
        Me.lblLastTempName.AutoSize = True
        Me.lblLastTempName.Location = New System.Drawing.Point(17, 234)
        Me.lblLastTempName.Margin = New System.Windows.Forms.Padding(3)
        Me.lblLastTempName.Name = "lblLastTempName"
        Me.lblLastTempName.Size = New System.Drawing.Size(82, 13)
        Me.lblLastTempName.TabIndex = 20
        Me.lblLastTempName.Text = "LastTempName"
        Me.lblLastTempName.Visible = False
        '
        'lblSRcommand
        '
        Me.lblSRcommand.AutoSize = True
        Me.lblSRcommand.Location = New System.Drawing.Point(17, 215)
        Me.lblSRcommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSRcommand.Name = "lblSRcommand"
        Me.lblSRcommand.Size = New System.Drawing.Size(68, 13)
        Me.lblSRcommand.TabIndex = 19
        Me.lblSRcommand.Text = "Sample Rate"
        Me.lblSRcommand.Visible = False
        '
        'lblFRcommand
        '
        Me.lblFRcommand.AutoSize = True
        Me.lblFRcommand.Location = New System.Drawing.Point(17, 196)
        Me.lblFRcommand.Margin = New System.Windows.Forms.Padding(3)
        Me.lblFRcommand.Name = "lblFRcommand"
        Me.lblFRcommand.Size = New System.Drawing.Size(62, 13)
        Me.lblFRcommand.TabIndex = 18
        Me.lblFRcommand.Text = "Frame Rate"
        Me.lblFRcommand.Visible = False
        '
        'lblFFarguments
        '
        Me.lblFFarguments.AutoSize = True
        Me.lblFFarguments.Location = New System.Drawing.Point(17, 253)
        Me.lblFFarguments.Margin = New System.Windows.Forms.Padding(3)
        Me.lblFFarguments.Name = "lblFFarguments"
        Me.lblFFarguments.Size = New System.Drawing.Size(57, 13)
        Me.lblFFarguments.TabIndex = 13
        Me.lblFFarguments.Text = "Arguments"
        Me.lblFFarguments.Visible = False
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
        Me.lblASRCommand.Visible = False
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
        Me.lblACodecCommand.Visible = False
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
        Me.lblAudioChCommand.Visible = False
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
        Me.lblFileNameCommand.Visible = False
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
        Me.lblRes.Visible = False
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
        Me.lblCodecCommand.Visible = False
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
        Me.lblMXFPathCommand.Visible = False
        '
        'chkAdvanced
        '
        Me.chkAdvanced.AutoSize = True
        Me.chkAdvanced.Enabled = False
        Me.chkAdvanced.Location = New System.Drawing.Point(813, 3)
        Me.chkAdvanced.Name = "chkAdvanced"
        Me.chkAdvanced.Padding = New System.Windows.Forms.Padding(15)
        Me.chkAdvanced.Size = New System.Drawing.Size(135, 47)
        Me.chkAdvanced.TabIndex = 1
        Me.chkAdvanced.Text = "Advanced Mode"
        Me.chkAdvanced.UseVisualStyleBackColor = True
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
        Me.lblFFmpegCommand.Visible = False
        '
        'grpTemp
        '
        Me.grpTemp.Controls.Add(Me.btnTempDefault)
        Me.grpTemp.Controls.Add(Me.txtTemp)
        Me.grpTemp.Controls.Add(Me.btnTemp)
        Me.grpTemp.Location = New System.Drawing.Point(6, 453)
        Me.grpTemp.Name = "grpTemp"
        Me.grpTemp.Size = New System.Drawing.Size(939, 50)
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
        Me.grpFFmpeg.Location = New System.Drawing.Point(6, 397)
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
        Me.OpenFFmpegDialog.Filter = """FFmpeg.exe"" | *.exe"
        Me.OpenFFmpegDialog.InitialDirectory = "computer"
        Me.OpenFFmpegDialog.Title = "Find FFmpeg executable"
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
        Me.btnChk3.Visible = False
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
        Me.btnChk2.Visible = False
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
        Me.btnChk1.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConvert.FlatAppearance.BorderSize = 5
        Me.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConvert.Location = New System.Drawing.Point(897, 589)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 40)
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
        Me.btnChk4.Visible = False
        '
        'btnChk5
        '
        Me.btnChk5.BackColor = System.Drawing.Color.Green
        Me.btnChk5.Enabled = False
        Me.btnChk5.FlatAppearance.BorderSize = 0
        Me.btnChk5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk5.Location = New System.Drawing.Point(961, 635)
        Me.btnChk5.Name = "btnChk5"
        Me.btnChk5.Size = New System.Drawing.Size(10, 15)
        Me.btnChk5.TabIndex = 8
        Me.btnChk5.UseVisualStyleBackColor = False
        Me.btnChk5.Visible = False
        '
        'txtOutFilename
        '
        Me.txtOutFilename.Location = New System.Drawing.Point(109, 585)
        Me.txtOutFilename.Name = "txtOutFilename"
        Me.txtOutFilename.Size = New System.Drawing.Size(169, 20)
        Me.txtOutFilename.TabIndex = 10
        '
        'lblOutName
        '
        Me.lblOutName.AutoSize = True
        Me.lblOutName.Location = New System.Drawing.Point(14, 588)
        Me.lblOutName.Name = "lblOutName"
        Me.lblOutName.Size = New System.Drawing.Size(89, 13)
        Me.lblOutName.TabIndex = 11
        Me.lblOutName.Text = "Output File Name"
        '
        'txtNameDate
        '
        Me.txtNameDate.AutoSize = True
        Me.txtNameDate.Location = New System.Drawing.Point(284, 588)
        Me.txtNameDate.Name = "txtNameDate"
        Me.txtNameDate.Size = New System.Drawing.Size(65, 13)
        Me.txtNameDate.TabIndex = 12
        Me.txtNameDate.Text = "Data e Hora"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'btnAbout
        '
        Me.btnAbout.AutoSize = True
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Location = New System.Drawing.Point(897, 12)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 25)
        Me.btnAbout.TabIndex = 14
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'OpenFFprobeDialog
        '
        Me.OpenFFprobeDialog.DefaultExt = "exe"
        Me.OpenFFprobeDialog.FileName = "FFprobe.exe"
        Me.OpenFFprobeDialog.Filter = """FFprobe""| FFprobe.exe"
        Me.OpenFFprobeDialog.Title = "Find FFprobe Executable"
        '
        'frmTMXF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnAbout)
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
        Me.Controls.Add(Me.txtMXFpath)
        Me.Controls.Add(Me.btnLoadMXF)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.grpGlobal.ResumeLayout(False)
        Me.grpGlobal.PerformLayout()
        Me.grpResolution.ResumeLayout(False)
        Me.grpDumbCodec.ResumeLayout(False)
        Me.TabConfig.ResumeLayout(False)
        Me.TabConfig.PerformLayout()
        Me.grpFFprobe.ResumeLayout(False)
        Me.grpFFprobe.PerformLayout()
        Me.grpTemp.ResumeLayout(False)
        Me.grpTemp.PerformLayout()
        Me.grpFFmpeg.ResumeLayout(False)
        Me.grpFFmpeg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FFmpegprocess As System.Diagnostics.Process
    Friend WithEvents lblVersion As System.Windows.Forms.Label
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
    Friend WithEvents chkAdvanced As System.Windows.Forms.CheckBox
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
    Friend WithEvents rdbACDirect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAAC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPCM24 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPCM16 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSRate As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSR44 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSRDirect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSR48 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSR96 As System.Windows.Forms.RadioButton
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
    Friend WithEvents grpAdvanced As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblSRcommand As System.Windows.Forms.Label
    Friend WithEvents lblLastTempName As System.Windows.Forms.Label
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents grpFFprobe As System.Windows.Forms.GroupBox
    Friend WithEvents txtFFprobe As System.Windows.Forms.Label
    Friend WithEvents btnFFprobe As System.Windows.Forms.Button
    Friend WithEvents OpenFFprobeDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnTCanalize As System.Windows.Forms.Button
    Friend WithEvents chkOverwrite As System.Windows.Forms.CheckBox

End Class
