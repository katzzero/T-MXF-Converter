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
        Me.Process1 = New System.Diagnostics.Process()
        Me.btnLoadMXF = New System.Windows.Forms.Button()
        Me.txtMXFpath = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.OpenMXFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveOut = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtOutPath = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCodec = New System.Windows.Forms.TabPage()
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
        Me.grpGlobal = New System.Windows.Forms.GroupBox()
        Me.TabConfig = New System.Windows.Forms.TabPage()
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
        Me.lblRes = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblOutName = New System.Windows.Forms.Label()
        Me.lblFileNameCommand = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabCodec.SuspendLayout()
        Me.grpResolution.SuspendLayout()
        Me.grpDumbCodec.SuspendLayout()
        Me.TabConfig.SuspendLayout()
        Me.grpTemp.SuspendLayout()
        Me.grpFFmpeg.SuspendLayout()
        Me.SuspendLayout()
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCodec)
        Me.TabControl1.Controls.Add(Me.TabConfig)
        Me.TabControl1.Location = New System.Drawing.Point(13, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(959, 451)
        Me.TabControl1.TabIndex = 7
        '
        'TabCodec
        '
        Me.TabCodec.Controls.Add(Me.grpResolution)
        Me.TabCodec.Controls.Add(Me.grpDumbCodec)
        Me.TabCodec.Controls.Add(Me.grpGlobal)
        Me.TabCodec.Location = New System.Drawing.Point(4, 22)
        Me.TabCodec.Name = "TabCodec"
        Me.TabCodec.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCodec.Size = New System.Drawing.Size(951, 425)
        Me.TabCodec.TabIndex = 0
        Me.TabCodec.Text = "Codec Config"
        Me.TabCodec.UseVisualStyleBackColor = True
        '
        'grpResolution
        '
        Me.grpResolution.Controls.Add(Me.rdb540)
        Me.grpResolution.Controls.Add(Me.rdb486)
        Me.grpResolution.Controls.Add(Me.rdb720)
        Me.grpResolution.Controls.Add(Me.rdb1080)
        Me.grpResolution.Location = New System.Drawing.Point(295, 7)
        Me.grpResolution.Name = "grpResolution"
        Me.grpResolution.Size = New System.Drawing.Size(118, 155)
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
        Me.grpDumbCodec.Location = New System.Drawing.Point(168, 7)
        Me.grpDumbCodec.Name = "grpDumbCodec"
        Me.grpDumbCodec.Size = New System.Drawing.Size(120, 155)
        Me.grpDumbCodec.TabIndex = 1
        Me.grpDumbCodec.TabStop = False
        Me.grpDumbCodec.Text = "Codec"
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
        'grpGlobal
        '
        Me.grpGlobal.Location = New System.Drawing.Point(6, 6)
        Me.grpGlobal.Name = "grpGlobal"
        Me.grpGlobal.Size = New System.Drawing.Size(155, 156)
        Me.grpGlobal.TabIndex = 0
        Me.grpGlobal.TabStop = False
        Me.grpGlobal.Text = "Global Options"
        '
        'TabConfig
        '
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
        Me.chkDumb.Checked = True
        Me.chkDumb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDumb.Enabled = False
        Me.chkDumb.Location = New System.Drawing.Point(6, 6)
        Me.chkDumb.Name = "chkDumb"
        Me.chkDumb.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.chkDumb.Size = New System.Drawing.Size(99, 32)
        Me.chkDumb.TabIndex = 1
        Me.chkDumb.Text = "Dumb Mode"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 580)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 20)
        Me.TextBox1.TabIndex = 10
        '
        'lblOutName
        '
        Me.lblOutName.AutoSize = True
        Me.lblOutName.Location = New System.Drawing.Point(97, 554)
        Me.lblOutName.Name = "lblOutName"
        Me.lblOutName.Size = New System.Drawing.Size(89, 13)
        Me.lblOutName.TabIndex = 11
        Me.lblOutName.Text = "Output File Name"
        '
        'lblFileNameCommand
        '
        Me.lblFileNameCommand.AutoSize = True
        Me.lblFileNameCommand.Location = New System.Drawing.Point(20, 121)
        Me.lblFileNameCommand.Name = "lblFileNameCommand"
        Me.lblFileNameCommand.Size = New System.Drawing.Size(54, 13)
        Me.lblFileNameCommand.TabIndex = 14
        Me.lblFileNameCommand.Text = "File Name"
        '
        'frmTMXF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.lblOutName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnChk1)
        Me.Controls.Add(Me.btnChk2)
        Me.Controls.Add(Me.btnChk5)
        Me.Controls.Add(Me.btnChk4)
        Me.Controls.Add(Me.btnChk3)
        Me.Controls.Add(Me.TabControl1)
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
        Me.Text = "s"
        Me.TabControl1.ResumeLayout(False)
        Me.TabCodec.ResumeLayout(False)
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
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtMXFpath As System.Windows.Forms.Label
    Friend WithEvents btnLoadMXF As System.Windows.Forms.Button
    Friend WithEvents OpenMXFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtOutPath As System.Windows.Forms.Label
    Friend WithEvents btnSaveOut As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFileNameCommand As System.Windows.Forms.Label

End Class
