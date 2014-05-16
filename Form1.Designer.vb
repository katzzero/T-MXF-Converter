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
        Me.TabConfig = New System.Windows.Forms.TabPage()
        Me.btnFFmpeg = New System.Windows.Forms.Button()
        Me.grpFFmpeg = New System.Windows.Forms.GroupBox()
        Me.txtFFmpeg = New System.Windows.Forms.Label()
        Me.grpTemp = New System.Windows.Forms.GroupBox()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.Label()
        Me.OpenFFmpegDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnChk3 = New System.Windows.Forms.Button()
        Me.btnTempDefault = New System.Windows.Forms.Button()
        Me.btnChk2 = New System.Windows.Forms.Button()
        Me.btnChk1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabConfig.SuspendLayout()
        Me.grpFFmpeg.SuspendLayout()
        Me.grpTemp.SuspendLayout()
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
        Me.txtOutPath.Location = New System.Drawing.Point(94, 583)
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
        Me.TabCodec.Location = New System.Drawing.Point(4, 22)
        Me.TabCodec.Name = "TabCodec"
        Me.TabCodec.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCodec.Size = New System.Drawing.Size(951, 425)
        Me.TabCodec.TabIndex = 0
        Me.TabCodec.Text = "Codec Config"
        Me.TabCodec.UseVisualStyleBackColor = True
        '
        'TabConfig
        '
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
        'btnFFmpeg
        '
        Me.btnFFmpeg.Location = New System.Drawing.Point(6, 19)
        Me.btnFFmpeg.Name = "btnFFmpeg"
        Me.btnFFmpeg.Size = New System.Drawing.Size(75, 23)
        Me.btnFFmpeg.TabIndex = 0
        Me.btnFFmpeg.Text = "Set Path"
        Me.btnFFmpeg.UseVisualStyleBackColor = True
        '
        'grpFFmpeg
        '
        Me.grpFFmpeg.Controls.Add(Me.txtFFmpeg)
        Me.grpFFmpeg.Controls.Add(Me.btnFFmpeg)
        Me.grpFFmpeg.Location = New System.Drawing.Point(6, 6)
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
        'grpTemp
        '
        Me.grpTemp.Controls.Add(Me.btnTempDefault)
        Me.grpTemp.Controls.Add(Me.txtTemp)
        Me.grpTemp.Controls.Add(Me.btnTemp)
        Me.grpTemp.Location = New System.Drawing.Point(7, 63)
        Me.grpTemp.Name = "grpTemp"
        Me.grpTemp.Size = New System.Drawing.Size(938, 50)
        Me.grpTemp.TabIndex = 2
        Me.grpTemp.TabStop = False
        Me.grpTemp.Text = "Temporary Folder"
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
        'txtTemp
        '
        Me.txtTemp.AutoSize = True
        Me.txtTemp.Location = New System.Drawing.Point(87, 24)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(43, 13)
        Me.txtTemp.TabIndex = 1
        Me.txtTemp.Text = "c:Temp"
        '
        'OpenFFmpegDialog
        '
        Me.OpenFFmpegDialog.DefaultExt = "exe"
        Me.OpenFFmpegDialog.FileName = "FFmpeg.exe"
        Me.OpenFFmpegDialog.Filter = "Executable | *.exe"
        Me.OpenFFmpegDialog.InitialDirectory = "c:\"
        Me.OpenFFmpegDialog.Title = "Find FFmpeg EXE"
        '
        'btnChk3
        '
        Me.btnChk3.BackColor = System.Drawing.Color.Red
        Me.btnChk3.Enabled = False
        Me.btnChk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk3.Location = New System.Drawing.Point(952, 635)
        Me.btnChk3.Name = "btnChk3"
        Me.btnChk3.Size = New System.Drawing.Size(20, 15)
        Me.btnChk3.TabIndex = 8
        Me.btnChk3.UseVisualStyleBackColor = False
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
        'btnChk2
        '
        Me.btnChk2.BackColor = System.Drawing.Color.Red
        Me.btnChk2.Enabled = False
        Me.btnChk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk2.Location = New System.Drawing.Point(923, 635)
        Me.btnChk2.Name = "btnChk2"
        Me.btnChk2.Size = New System.Drawing.Size(23, 15)
        Me.btnChk2.TabIndex = 8
        Me.btnChk2.UseVisualStyleBackColor = False
        '
        'btnChk1
        '
        Me.btnChk1.BackColor = System.Drawing.Color.Red
        Me.btnChk1.Enabled = False
        Me.btnChk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk1.Location = New System.Drawing.Point(897, 635)
        Me.btnChk1.Name = "btnChk1"
        Me.btnChk1.Size = New System.Drawing.Size(20, 15)
        Me.btnChk1.TabIndex = 8
        Me.btnChk1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(897, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTMXF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnChk1)
        Me.Controls.Add(Me.btnChk2)
        Me.Controls.Add(Me.btnChk3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtOutPath)
        Me.Controls.Add(Me.Button1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabConfig.ResumeLayout(False)
        Me.grpFFmpeg.ResumeLayout(False)
        Me.grpFFmpeg.PerformLayout()
        Me.grpTemp.ResumeLayout(False)
        Me.grpTemp.PerformLayout()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
