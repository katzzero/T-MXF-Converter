Imports System.IO
Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports System.Security.Permissions

Public Class frmTMXF

    Private Sub frmTMXF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show version on label
        lblVersion.Text = "V." & Application.ProductVersion

        'Check if FFmpeg path is Ok and if not do this
        If txtFFmpeg.Text = "c:FFmpeg" Then
            If System.IO.File.Exists("\Resources\ffmpeg.exe") Then
                txtFFmpeg.Text = System.IO.Path.GetFileName("\Resources\ffmpeg.exe")
            ElseIf My.Settings.ffmpegpath.Length = 0 Then
                OpenFFmpegDialog.ShowDialog()
                txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
                My.Settings.ffmpegpath = OpenFFmpegDialog.FileName.ToString
                btnChk3.BackColor = Color.Green
            ElseIf System.IO.File.Exists(My.Settings.ffmpegpath.ToString) Then
                txtFFmpeg.Text = My.Settings.ffmpegpath.ToString
                btnChk3.BackColor = Color.Green
            Else
                My.Settings.ffmpegpath = ""
                txtFFmpeg.Text = "c:FFmpeg"
                MessageBox.Show("FFmpeg Not Found!" & vbCrLf & "Please check the path in Software Config Tab")
            End If
        End If

        'Check if theres is a path for temp if not set default
        If txtTemp.Text = "c:Temp" Then
            If My.Settings.temppath.Length = 0 Then
                txtTemp.Text = System.IO.Path.GetTempPath
                My.Settings.temppath = txtTemp.Text.ToString
            Else
                txtTemp.Text = My.Settings.temppath
            End If
        End If

        'Check last used codec and assign it
        If My.Settings.lastVcodec = "h264" Then
            rdbH264.Checked = True
        ElseIf My.Settings.lastVcodec = "prores" Then
            rdbProRes.Checked = True
        ElseIf My.Settings.lastVcodec = "dnxhd" Then
            rdbDNxHD.Checked = True
        ElseIf My.Settings.lastVcodec = "wav" Then
            rdbWAV.Checked = True
        End If

        'Check Last used Resolution and assign it
        If My.Settings.lastres = "1080" Then
            rdb1080.Checked = True
        ElseIf My.Settings.lastres = "720" Then
            rdb720.Checked = True
        ElseIf My.Settings.lastres = "486" Then
            rdb486.Checked = True
        ElseIf My.Settings.lastres = "540" Then
            rdb540.Checked = True
        End If

        'Check Last used Audio Codec and assign it
        If My.Settings.lastAcodec = "PCM16" Then
            rdbPCM16.Checked = True
        ElseIf My.Settings.lastAcodec = "PCM24" Then
            rdbPCM24.Checked = True
        ElseIf My.Settings.lastAcodec = "AAC" Then
            rdbAAC.Checked = True
        ElseIf My.Settings.lastAcodec = "MP3" Then
            rdbMP3.Checked = True
        End If

        'Check Last used Audio Channels and assign it
        If My.Settings.lastchannels = "direct" Then
            rdbADirect.Checked = True
        ElseIf My.Settings.lastchannels = "2ch" Then
            rdbA2Ch.Checked = True
        ElseIf My.Settings.lastchannels = "4ch" Then
            rdbA4Ch.Checked = True
        ElseIf My.Settings.lastchannels = "8ch" Then
            rdbA8Ch.Checked = True
        End If

        'Check Last used Frame Rate and assign it
        If My.Settings.LastFR = "frdirect" Then
            rdbFRdirect.Checked = True
        ElseIf My.Settings.LastFR = "29nd" Then
            rdb29ND.Checked = True
        ElseIf My.Settings.LastFR = "29d" Then
            rdb29D.Checked = True
        ElseIf My.Settings.LastFR = "23" Then
            rdb23.Checked = True
        End If

        'Check Last used Frame Rate and assign it
        If My.Settings.LastSR = "srdirect" Then
            rdbSRDirect.Checked = True
        ElseIf My.Settings.LastSR = "sr44" Then
            rdbSR44.Checked = True
        ElseIf My.Settings.LastSR = "sr48" Then
            rdbSR48.Checked = True
        ElseIf My.Settings.LastSR = "sr96" Then
            rdbSR96.Checked = True
        End If

        'Set date and time as part of the output name
        txtNameDate.Text = DateAndTime.Now.Day & "-" & DateAndTime.Now.Month & "-" & DateAndTime.Now.Year & "-" & DateAndTime.Now.Hour & DateAndTime.Now.Minute

        If Not My.Settings.LastOutPath.Length = 0 Then
            txtOutPath.Text = My.Settings.LastOutPath.ToString
            btnSaveOut.Enabled = True

        End If

    End Sub

    Private Sub btnLoadMXF_Click(sender As Object, e As EventArgs) Handles btnLoadMXF.Click
        If OpenMXFDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMXFpath.Text = Microsoft.VisualBasic.Chr(34) & OpenMXFDialog.FileName.ToString & Microsoft.VisualBasic.Chr(34)
            btnSaveOut.Enabled = True

            If System.IO.File.Exists(txtMXFpath.Text) Then
                btnChk1.BackColor = Color.Green
                lblMXFPathCommand.Text = "-i " & txtMXFpath.Text
                txtOutFilename.Text = System.IO.Path.GetFileNameWithoutExtension(txtMXFpath.Text)
            End If
        End If
        txtNameDate.Text = DateAndTime.Now.Day & "-" & DateAndTime.Now.Month & "-" & DateAndTime.Now.Year & "-" & DateAndTime.Now.Hour & DateAndTime.Now.Minute
    End Sub

    Private Sub btnSaveOut_Click(sender As Object, e As EventArgs) Handles btnSaveOut.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOutPath.Text = FolderBrowserDialog.SelectedPath.ToString
            btnChk2.BackColor = Color.Green
        End If
        lblFileNameCommand.Text = txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & ".mov"
        txtNameDate.Text = DateAndTime.Now.Day & "-" & DateAndTime.Now.Month & "-" & DateAndTime.Now.Year & "-" & DateAndTime.Now.Hour & DateAndTime.Now.Minute
        My.Settings.LastOutPath = txtOutPath.Text
    End Sub

    Private Sub btnFFmpeg_Click(sender As Object, e As EventArgs) Handles btnFFmpeg.Click
        Do
            OpenFFmpegDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If OpenFFmpegDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
                My.Settings.ffmpegpath = txtFFmpeg.Text.ToString
                btnChk3.BackColor = Color.Green
            End If
        Loop Until System.IO.File.Exists(txtFFmpeg.Text.ToString) = True Or Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnTemp_Click(sender As Object, e As EventArgs) Handles btnTemp.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtTemp.Text = FolderBrowserDialog.SelectedPath.ToString
            My.Settings.temppath = txtTemp.Text.ToString
        End If
    End Sub

    Private Sub btnTempDefault_Click(sender As Object, e As EventArgs) Handles btnTempDefault.Click
        txtTemp.Text = System.IO.Path.GetTempPath
        My.Settings.temppath = System.IO.Path.GetTempPath

    End Sub

    Private Sub txtFFmpeg_TextChanged(sender As Object, e As EventArgs) Handles txtFFmpeg.TextChanged
        lblFFmpegCommand.Text = txtFFmpeg.Text

    End Sub

    Private Sub TabConfig_Click(sender As Object, e As EventArgs) Handles TabConfig.Click

    End Sub

    Private Sub txtOutFilename_TextChanged(sender As Object, e As EventArgs) Handles txtOutFilename.TextChanged
        lblFileNameCommand.Text = txtOutFilename.Text.ToString
        txtOutFilename.Text = txtOutFilename.Text.Trim(IO.Path.GetInvalidFileNameChars)

    End Sub

    Private Sub btnChk3_BackColorChanged(sender As Object, e As EventArgs) Handles btnChk3.BackColorChanged
        If txtFFmpeg.Text = "FFmpeg.exe" Then
            My.Settings.ffmpegpath = ""
            txtFFmpeg.Text = "c:FFmpeg"
            MessageBox.Show("FFmpeg Not Selected" & vbCrLf & "Please, choose a path in Software Config Tab")
            btnChk3.BackColor = Color.Red
        End If

    End Sub

    Private Sub codec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbH264.CheckedChanged, rdbDNxHD.CheckedChanged, rdbProRes.CheckedChanged, rdbWAV.CheckedChanged

        If rdbH264.Checked = True Then
            lblCodecCommand.Text = "-vcodec libx264 -profile:v baseline -tune fastdecode -g 1 -crf 16 -bf 0 -pix_fmt yuv420p -copyts"
            My.Settings.lastVcodec = "h264"
        ElseIf rdbProRes.Checked = True Then
            lblCodecCommand.Text = "-vcodec prores -profile:v 1 -qscale:v 5 -copyts"
            My.Settings.lastVcodec = "prores"
        ElseIf rdbDNxHD.Checked = True Then
            lblCodecCommand.Text = "-vcodec dnxhd"
            My.Settings.lastVcodec = "dnxhd"
        ElseIf rdbWAV.Checked = True Then
            lblCodecCommand.Text = "-vn -acodec pcm_s24le -map 0:a -filter_complex " & Microsoft.VisualBasic.Chr(34) & "[0:a] amerge=inputs=8" & Microsoft.VisualBasic.Chr(34) & ""
            My.Settings.lastVcodec = "wav"
        End If

    End Sub

    Private Sub resolution_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1080.CheckedChanged, rdb486.CheckedChanged, rdb540.CheckedChanged, rdb720.CheckedChanged

        If rdb1080.Checked = True Then
            lblRes.Text = " -s 1920x1080"
            My.Settings.lastres = "1080"
        ElseIf rdb720.Checked = True Then
            lblRes.Text = "-s 1280x720"
            My.Settings.lastres = "720"
        ElseIf rdb486.Checked = True Then
            lblRes.Text = " -s 864x486"
            My.Settings.lastres = "486"
        ElseIf rdb540.Checked = True Then
            lblRes.Text = "-s 720x540"
            My.Settings.lastres = "540"
        End If

    End Sub

    Private Sub rdbSRDirect_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSRDirect.CheckedChanged, rdbSR44.CheckedChanged, rdbSR48.CheckedChanged, rdbSR96.CheckedChanged

        If rdbSRDirect.Checked = True Then
            lblSRcommand.Text = "SR Command copy"
            My.Settings.LastSR = "srdirect"
        ElseIf rdbSR44.Checked = True Then
            lblSRcommand.Text = "SR Command 44.1"
            My.Settings.LastSR = "sr44"
        ElseIf rdbSR48.Checked = True Then
            lblSRcommand.Text = "SR Command 48"
            My.Settings.LastSR = "sr48"
        ElseIf rdbSR96.Checked = True Then
            lblSRcommand.Text = "SR Command 96"
            My.Settings.LastSR = "sr96"
        End If

    End Sub

    Private Sub rdbAchannels_CheckedChanged(sender As Object, e As EventArgs) Handles rdbADirect.CheckedChanged, rdbA2Ch.CheckedChanged, rdbA4Ch.CheckedChanged, rdbA8Ch.CheckedChanged

        If rdbADirect.Checked = True Then
            lblAudioChCommand.Text = "-map 0 -map -0:d"
            My.Settings.lastchannels = "direct"
        ElseIf rdbA2Ch.Checked = True Then
            lblAudioChCommand.Text = "2 channels map"
            My.Settings.lastchannels = "2ch"
        ElseIf rdbA4Ch.Checked = True Then
            lblAudioChCommand.Text = "4 Channels map"
            My.Settings.lastchannels = "4ch"
        ElseIf rdbA8Ch.Checked = True Then
            lblAudioChCommand.Text = "8 Channels map"
            My.Settings.lastchannels = "8ch"
        End If

    End Sub


    Private Sub rdbACodec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPCM16.CheckedChanged, rdbPCM24.CheckedChanged, rdbAAC.CheckedChanged, rdbMP3.CheckedChanged

        If rdbPCM16.Checked = True Then
            lblACodecCommand.Text = "-acodec pcm_s16le"
            My.Settings.lastAcodec = "PCM16"
        ElseIf rdbPCM24.Checked = True Then
            lblACodecCommand.Text = "-acodec pcm_s24le"
            My.Settings.lastAcodec = "PCM24"
        ElseIf rdbAAC.Checked = True Then
            lblACodecCommand.Text = "-acodec libfdk_aac -vbr 5"
            My.Settings.lastchannels = "AAC"
        ElseIf rdbMP3.Checked = True Then
            lblACodecCommand.Text = "-acodec libmp3lame -b:a 320k"
            My.Settings.lastAcodec = "MP3"
        End If

    End Sub

    Private Sub rdbFrameRate_CheckedChanged(sender As Object, e As EventArgs) Handles rdb29D.CheckedChanged, rdb29ND.CheckedChanged, rdb23.CheckedChanged, rdbFRdirect.CheckedChanged

        If rdbFRdirect.Checked = True Then
            lblFRcommand.Text = "FR Command copy"
            My.Settings.LastFR = "frdirect"
        ElseIf rdb23.Checked = True Then
            lblFRcommand.Text = "FR Command 23"
            My.Settings.LastFR = "23"
        ElseIf rdb29D.Checked = True Then
            lblFRcommand.Text = "FR Command 29D"
            My.Settings.LastFR = "29d"
        ElseIf rdb29ND.Checked = True Then
            lblFRcommand.Text = "FR Command 29ND"
            My.Settings.LastFR = "29nd"
        End If

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim _timeofthelog As String
        Dim _date As Integer
        Dim _time As Integer
        Dim FFmpegprocess As New Process()
        Dim FFarguments As String

        Dim _lastlog As New System.IO.FileSystemWatcher
        _lastlog.Path = txtTemp.Text
        _lastlog.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        _lastlog.Filter = "*.log"
        AddHandler _lastlog.Created, AddressOf _lastlog_OnChanged
        AddHandler _lastlog.Changed, AddressOf _lastlog_OnChanged
        _lastlog.EnableRaisingEvents = True

        _date = DateAndTime.Now.ToString("yyyyMMdd")
        _time = DateAndTime.Now.ToString("HHmmss")
        _timeofthelog = "ffmpeg-" & _date & "-" & _time & ".log"
        txtFFoutput.Text = "Waiting for the Conversion to Complete." & vbCrLf & " Conversion started at " & DateAndTime.Now.ToString("HH:mm:ss")

        txtNameDate.Text = DateAndTime.Now.ToString("dd") & "-" & DateAndTime.Now.ToString("MM") & "-" & DateAndTime.Now.ToString("yyyy") & "-" & DateAndTime.Now.ToString("HH") & DateAndTime.Now.ToString("mm")

        FFarguments = "-report " & "-loglevel verbose" & " -i " & txtMXFpath.Text.ToString & " " & lblCodecCommand.Text.ToString & " " & lblRes.Text.ToString & " " & lblACodecCommand.Text.ToString & " " & lblAudioChCommand.Text.ToString & " " & txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".mov"
        lblFFarguments.Text = FFarguments.ToString

        FFmpegprocess.StartInfo.FileName = Me.txtFFmpeg.Text.ToString
        FFmpegprocess.StartInfo.Arguments = FFarguments
        FFmpegprocess.StartInfo.ErrorDialog = True
        FFmpegprocess.StartInfo.WorkingDirectory = Me.txtTemp.Text.ToString
        FFmpegprocess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        FFmpegprocess.Start()
        FFmpegprocess.WaitForExit()

        _lastlog.EnableRaisingEvents = False

        Threading.Thread.Sleep(1000)

        Dim LogReader As StreamReader
        If System.IO.File.Exists(lblLastTempName.Text) Then
            LogReader = New StreamReader(lblLastTempName.Text, True)
            txtFFoutput.Text = LogReader.ReadToEnd
        End If

    End Sub

    Private Sub _lastlog_OnChanged(source As Object, e As FileSystemEventArgs)
        'Specify what is done when a file is changed, created, or deleted.
        lblLastTempName.Text = e.FullPath
        'MessageBox.Show(e.FullPath)
    End Sub

    Private Sub txtFFoutput_TextChanged(sender As Object, e As EventArgs) Handles txtFFoutput.TextChanged
        txtFFoutput.Focus()
        txtFFoutput.SelectionStart = txtFFoutput.Text.Length
        txtFFoutput.ScrollToCaret()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub
End Class
