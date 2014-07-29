Imports System.IO
Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports System.Security.Permissions

Public Class frmTMXF

    Private Sub frmTMXF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _totalmem As Integer = CDec(((My.Computer.Info.TotalPhysicalMemory.ToString) / 1024) / 1024)
        Dim _avaimem As Integer = CDec(((My.Computer.Info.AvailablePhysicalMemory.ToString) / 1024) / 1024)

        txtFFoutput.Text = DateAndTime.Now.ToString("HH:mm:ss") & " Initializing Systems ... "
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Computer name: " & Environment.MachineName
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Operating system: " & My.Computer.Info.OSFullName & " with " & Environment.ProcessorCount & " Logical Processors."
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Operating system version: " & Environment.OSVersion.ToString
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " System memory: " & _totalmem.ToString("####,####") & " MBs total with " & _avaimem.ToString("####,####") & " MBs available."
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Hello " & Environment.UserName & "!"

        'Show version on label
        lblVersion.Text = "V." & Application.ProductVersion
        Try
            If System.IO.File.Exists(Application.StartupPath & "\bin\ffmpeg.exe") = True Then
                txtFFmpeg.Text = Application.StartupPath & "\bin\ffmpeg.exe"
                My.Settings.ffmpegpath = txtFFmpeg.Text
            ElseIf System.IO.File.Exists("c:\ffmpeg\bin\ffmpeg.exe") = True Then
                txtFFmpeg.Text = "c:\ffmpeg\bin\ffmpeg.exe"
                My.Settings.ffmpegpath = txtFFmpeg.Text
            End If
            If System.IO.File.Exists(Application.StartupPath & "\bin\ffprobe.exe") = True Then
                txtFFprobe.Text = Application.StartupPath & "\bin\ffprobe.exe"
                My.Settings.ffprobepath = txtFFprobe.Text
            ElseIf System.IO.File.Exists("c:\ffmpeg\bin\ffprobe.exe") = True Then
                txtFFprobe.Text = "c:\ffmpeg\bin\ffprobe.exe"
                My.Settings.ffprobepath = txtFFprobe.Text

            End If
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " System Critical error parsing system file!"
        End Try

        Try
            If System.IO.File.Exists(My.Settings.ffprobepath.ToString) = True Then
                txtFFprobe.Text = My.Settings.ffprobepath.ToString
            ElseIf My.Settings.ffprobepath = "c:FFprobe" Or My.Settings.ffprobepath.Length <= 0 Then
                OpenFFprobeDialog.ShowDialog()
                txtFFprobe.Text = OpenFFprobeDialog.FileName
                My.Settings.ffprobepath = txtFFprobe.Text
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe.exe Selected ! "
            ElseIf System.IO.File.Exists(My.Settings.ffprobepath.ToString) = False Then
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe.exe Not Found - TC Burn Disabled !"
                txtFFprobe.Text = "c:FFprobe"
                My.Settings.ffprobepath = "c:FFprobe"
            End If

        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## FFprobe.exe Error ## - TC Burn Disabled !"
        End Try

        'Check if FFmpeg path is Ok and if not do this
        Try
            If txtFFmpeg.Text = "c:FFmpeg" Then
                If My.Settings.ffmpegpath.Length = 0 Then
                    OpenFFmpegDialog.ShowDialog()
                    txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
                    My.Settings.ffmpegpath = OpenFFmpegDialog.FileName.ToString
                    btnChk3.BackColor = Color.Green
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFmpeg executable Selected !! "
                ElseIf System.IO.File.Exists(My.Settings.ffmpegpath.ToString) = True Then
                    txtFFmpeg.Text = My.Settings.ffmpegpath.ToString
                    btnChk3.BackColor = Color.Green
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFmpeg.exe found! "
                End If
            End If
        Catch ex As Exception
            My.Settings.ffmpegpath = ""
            txtFFmpeg.Text = "c:FFmpeg"
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## FFmpeg path not found!! ## Please check the path in Software Config Tab or the software will be unable to convert!"
        End Try


        'Check if theres is a path for temp if not set default
        If txtTemp.Text = "c:Temp" Then
            If My.Settings.temppath.Length = 0 Then
                txtTemp.Text = System.IO.Path.GetTempPath
                My.Settings.temppath = txtTemp.Text.ToString
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Using system's default temporary folder."
            Else
                txtTemp.Text = My.Settings.temppath
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Using custom temporary folder."
            End If
        End If

        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Recalling last used settings ..."

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

        'Check Last used Frame Rate and assign it
        If My.Settings.LastFR = "frdirect" Then
            rdbFRdirect.Checked = True
        ElseIf My.Settings.LastFR = "24" Then
            rdb24.Checked = True
        ElseIf My.Settings.LastFR = "29" Then
            rdb29D.Checked = True
        ElseIf My.Settings.LastFR = "23" Then
            rdb23.Checked = True
        End If

        'Check Last used Audio Codec and assign it
        If My.Settings.lastAcodec = "PCM16" Then
            rdbPCM16.Checked = True
        ElseIf My.Settings.lastAcodec = "PCM24" Then
            rdbPCM24.Checked = True
        ElseIf My.Settings.lastAcodec = "AAC" Then
            rdbAAC.Checked = True
        ElseIf My.Settings.lastAcodec = "acdirect" Then
            rdbACDirect.Checked = True
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
        If My.Settings.LastSR = "srdirect" Then
            rdbSRDirect.Checked = True
        ElseIf My.Settings.LastSR = "sr44" Then
            rdbSR44.Checked = True
        ElseIf My.Settings.LastSR = "sr48" Then
            rdbSR48.Checked = True
        ElseIf My.Settings.LastSR = "sr96" Then
            rdbSR96.Checked = True
        End If

        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Settings Loaded OK."

        'Set date and time as part of the output name
        txtNameDate.Text = DateAndTime.Now.ToString("dd-MM-yyyy") & "-" & DateAndTime.Now.ToString("HH-mm")
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Software Started Successfully!"

        If Not My.Settings.LastOutPath.Length = 0 Then
            txtOutPath.Text = My.Settings.LastOutPath.ToString
            btnSaveOut.Enabled = True

        End If

    End Sub

    Private Sub btnLoadMXF_Click(sender As Object, e As EventArgs) Handles btnLoadMXF.Click
        Dim _mxfinfo As FileInfo
        Dim _mxfsize As Integer
        Dim _mxfsize_ok As String = " ## Error Parsing MXF Size ## "


        Try
            If OpenMXFDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtMXFpath.Text = Microsoft.VisualBasic.Chr(34) & OpenMXFDialog.FileName.ToString & Microsoft.VisualBasic.Chr(34)
                btnSaveOut.Enabled = True

                If System.IO.File.Exists(txtMXFpath.Text.Trim(Microsoft.VisualBasic.Chr(34))) Then
                    btnChk1.BackColor = Color.Green
                    lblMXFPathCommand.Text = "-i " & txtMXFpath.Text
                    _mxfinfo = My.Computer.FileSystem.GetFileInfo(txtMXFpath.Text.Trim(Microsoft.VisualBasic.Chr(34)))
                    _mxfsize = CDec((_mxfinfo.Length.ToString / 1024) / 1024)
                    If _mxfsize > 999 Then
                        _mxfsize_ok = _mxfsize.ToString("###,###")
                    Else
                        _mxfsize_ok = _mxfsize.ToString
                    End If
                    Dim _mxfint32
                    lblInt32 = _mxfinfo.OpenRead.BeginRead(_mxfint32, 0, 32, System.AsyncCallback.Combine, OpenMode.Binary)
                    txtOutFilename.Text = System.IO.Path.GetFileNameWithoutExtension(txtMXFpath.Text.Trim(Microsoft.VisualBasic.Chr(34)))
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " MXF file loaded sucessfully ! The MXF have " & _mxfsize_ok.ToString & " MBs of data!"
                End If
            End If
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problem Loading MXF file . Please Try again. "
        End Try




        txtAC.Text = ""
        txtDrop.Text = ""
        txtDur.Text = ""
        txtTC.Text = ""
        txtVC.Text = ""
        txtFR.Text = ""
        txtSR.Text = ""

    End Sub

    Private Sub btnSaveOut_Click(sender As Object, e As EventArgs) Handles btnSaveOut.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOutPath.Text = FolderBrowserDialog.SelectedPath.ToString
            btnChk2.BackColor = Color.Green
        End If
        lblFileNameCommand.Text = txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & ".mov"
        txtNameDate.Text = DateAndTime.Now.ToString("dd-MM-yyyy") & "-" & DateAndTime.Now.ToString("HH-mm")
        My.Settings.LastOutPath = txtOutPath.Text
    End Sub

    Private Sub btnFFmpeg_Click(sender As Object, e As EventArgs) Handles btnFFmpeg.Click
        OpenFFmpegDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If OpenFFmpegDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
            My.Settings.ffmpegpath = txtFFmpeg.Text.ToString
            btnChk3.BackColor = Color.Green
        End If
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
        Dim _ffmpegcheck As String
        If System.IO.File.Exists(txtFFmpeg.Text.ToString) = True Then
            _ffmpegcheck = System.IO.Path.GetDirectoryName(txtFFmpeg.Text.ToString)
            ' MessageBox.Show(_ffprobecheck.ToString & "\ffprobe.exe")
            If txtFFmpeg.Text.ToString = _ffmpegcheck & "\ffmpeg.exe" Then
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFmpeg path is OK."
            ElseIf System.IO.File.Exists(_ffmpegcheck.ToString & "\ffmpeg.exe") = True Then
                txtFFmpeg.Text = _ffmpegcheck.ToString & "\ffmpeg.exe"
                My.Settings.ffprobepath = txtFFmpeg.Text.ToString
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFmpeg path wrong but was able to be auto-corrected."
            End If
        End If
        lblFFmpegCommand.Text = txtFFmpeg.Text
    End Sub

    Private Sub TabConfig_Click(sender As Object, e As EventArgs) Handles TabConfig.Click

    End Sub

    Private Sub txtOutFilename_TextChanged(sender As Object, e As EventArgs) Handles txtOutFilename.TextChanged
        lblFileNameCommand.Text = txtOutFilename.Text.ToString
        txtOutFilename.Text = txtOutFilename.Text.Trim(IO.Path.GetInvalidFileNameChars)

    End Sub

    Private Sub codec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbH264.CheckedChanged, rdbDNxHD.CheckedChanged, rdbProRes.CheckedChanged, rdbWAV.CheckedChanged

        If rdbH264.Checked = True Then
            lblCodecCommand.Text = "-vcodec libx264 -profile:v baseline -tune fastdecode -g 1 -crf 18 -bf 0 -pix_fmt yuv420p -copyts"
            My.Settings.lastVcodec = "h264"
        ElseIf rdbProRes.Checked = True Then
            lblCodecCommand.Text = "-vcodec prores_ks -profile:v 1 -qscale:v 9 -vendor ap10 -copyts"
            My.Settings.lastVcodec = "prores"
        ElseIf rdbDNxHD.Checked = True Then
            lblCodecCommand.Text = "-vcodec dnxhd"
            My.Settings.lastVcodec = "dnxhd"
        ElseIf rdbWAV.Checked = True Then
            lblCodecCommand.Text = "-vn -copyts -map 0:a -filter_complex " & Microsoft.VisualBasic.Chr(34) & "[0:a] amerge=inputs=8" & Microsoft.VisualBasic.Chr(34) & ""

            My.Settings.lastVcodec = "wav"
            rdbACDirect.Checked = False
            rdbACDirect.Enabled = False
            rdbPCM16.Checked = True
        End If
        If rdbWAV.Checked = False Then
            rdbACDirect.Checked = True
            rdbACDirect.Enabled = True
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


    Private Sub rdbACodec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPCM16.CheckedChanged, rdbPCM24.CheckedChanged, rdbAAC.CheckedChanged, rdbACDirect.CheckedChanged

        If rdbPCM16.Checked = True Then
            lblACodecCommand.Text = "-acodec pcm_s16le"
            My.Settings.lastAcodec = "PCM16"
        ElseIf rdbPCM24.Checked = True Then
            lblACodecCommand.Text = "-acodec pcm_s24le"
            My.Settings.lastAcodec = "PCM24"
        ElseIf rdbAAC.Checked = True Then
            lblACodecCommand.Text = "-acodec libfdk_aac -vbr 5"
            My.Settings.lastchannels = "AAC"
        ElseIf rdbACDirect.Checked = True Then
            lblACodecCommand.Text = "-acodec copy"
            My.Settings.lastAcodec = "acdirect"
        End If

    End Sub

    Private Sub rdbFrameRate_CheckedChanged(sender As Object, e As EventArgs) Handles rdb29D.CheckedChanged, rdb24.CheckedChanged, rdb23.CheckedChanged, rdbFRdirect.CheckedChanged

        If rdbFRdirect.Checked = True Then
            lblFRcommand.Text = "FR Command copy"
            My.Settings.LastFR = "frdirect"
        ElseIf rdb23.Checked = True Then
            lblFRcommand.Text = "FR Command 23"
            My.Settings.LastFR = "23"
        ElseIf rdb29D.Checked = True Then
            lblFRcommand.Text = "FR Command 29"
            My.Settings.LastFR = "29"
        ElseIf rdb24.Checked = True Then
            lblFRcommand.Text = "FR Command 24"
            My.Settings.LastFR = "24"
        End If

    End Sub

    Private Sub lblCodecCommand_TextChanged(sender As Object, e As EventArgs) Handles lblCodecCommand.TextChanged
        If rdbH264.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec H.264 Selected."
        ElseIf rdbProRes.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec ProRes Selected."
        ElseIf rdbDNxHD.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec DNxHD Selected."
        ElseIf rdbWAV.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec WAV Selected."
        End If
    End Sub

    Private Sub lblRes_TextChanged(sender As Object, e As EventArgs) Handles lblRes.TextChanged
        If rdb1080.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 1920x1080 Resolution, 16:9 aspect ratio, square pixel."
        ElseIf rdb720.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 1280x720 Resolution, 16:9 aspect ratio, square pixel."
        ElseIf rdb486.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 864x486 Resolution, 16:9 aspect ratio, square pixel."
        ElseIf rdb540.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 720x540 Resolution, 4:3 aspect ratio, square pixel."
        End If
    End Sub

    Private Sub lblAudioChCommand_TextChanged(sender As Object, e As EventArgs) Handles lblAudioChCommand.TextChanged
        If rdbADirect.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Audio channels selected for Direct mapping."
        ElseIf rdbA2Ch.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Audio channels selected for Stereo mapping."
        ElseIf rdbA4Ch.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Audio channels selected for Quad mapping."
        ElseIf rdbA8Ch.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Audio channels selected for 8 Channels mapping."
        End If
    End Sub

    Private Sub lblACodecCommand_TextChanged(sender As Object, e As EventArgs) Handles lblACodecCommand.TextChanged
        If rdbPCM16.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " PCM 16bits Audio codec selected."
        ElseIf rdbPCM24.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " PCM 24bits Audio codec selected."
        ElseIf rdbAAC.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " AAC Low Complexity Audio codec selected."
        ElseIf rdbACDirect.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Audio Codec selected for direct stream copy."
        End If
    End Sub

    Private Sub lblFRcommand_TextChanged(sender As Object, e As EventArgs) Handles lblFRcommand.TextChanged
        If rdbFRdirect.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Frame Rate keep/copy selected."
        ElseIf rdb23.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 23,976 FPS selected."
        ElseIf rdb29D.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 29,97 FPS selected."
        ElseIf rdb24.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 24 FPS selected."
        End If
    End Sub

    Private Sub lblSRcommand_TextChanged(sender As Object, e As EventArgs) Handles lblSRcommand.TextChanged
        If rdbSRDirect.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Sample Rate keep/copy selected."
        ElseIf rdbSR44.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 44.100Hz selected."
        ElseIf rdbSR48.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 48.000Hz selected."
        ElseIf rdbSR96.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " 96.000Hz selected."
        End If
    End Sub


    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim _timeofthelog As String
        Dim _date As Integer
        Dim _time As Integer
        Dim _timestart As Date
        Dim _timeend As Date
        Dim FFmpegprocess As New Process()
        Dim FFarguments As String
        Dim LogReader As StreamReader
        Dim _TimeTotal As TimeSpan
        Dim _lastlog As New System.IO.FileSystemWatcher
        Dim _outinforaw As FileInfo
        Dim _outinfo As Integer
        Dim _ffargReport As String

        _ffargReport = "-loglevel verbose"
        _lastlog.Path = txtTemp.Text
        _lastlog.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        _lastlog.Filter = "*.log"
        AddHandler _lastlog.Created, AddressOf _lastlog_OnChanged
        AddHandler _lastlog.Changed, AddressOf _lastlog_OnChanged
        _lastlog.EnableRaisingEvents = True

        _date = DateAndTime.Now.ToString("yyyyMMdd")
        _time = DateAndTime.Now.ToString("HHmmss")
        _timestart = DateAndTime.Now.ToString("HH:mm:ss")
        _timeofthelog = "ffmpeg-" & _date & "-" & _time & ".log"
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion started ! " & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Waiting for the Conversion to Complete."
        txtNameDate.Text = DateAndTime.Now.ToString("dd-MM-yyyy") & "-" & DateAndTime.Now.ToString("HH-mm")

        If chkTCBurn.Checked = True Then
            lblTCburn.Text = " -vf " & (Microsoft.VisualBasic.Chr(34)) & "drawtext=fontfile=/windows/fonts/cour.ttf: fontsize=42: timecode='" & lblTChour.Text.ToString & "\:" & lblTCminute.Text.ToString & "\:" & lblTCsecond.Text.ToString & "\" & lblTCdrop.Text.ToString & LblTCframe.Text.ToString & "': r=" & txtFR.Text.Trim(" ", "f", "p", "s") & ": x=(w-tw)/2: y=h-(2*lh): fontcolor=0xffffff95: shadowcolor=0x00000075 : shadowx=1 :shadowy=1 " & (Microsoft.VisualBasic.Chr(34)) 'box=1: boxcolor=0x00000075
        Else
            lblTCburn.Text = ""
        End If
        '                                                                                                             01\:57\:00\:00
        If chkReport.Checked = True Then
            _ffargReport = "-report " & "-loglevel verbose -y -hide_banner "
        Else
            _ffargReport = "-loglevel verbose -y -hide_banner "
        End If

        FFarguments = _ffargReport & " -i " & txtMXFpath.Text.ToString & " " & lblCodecCommand.Text.ToString & " " & lblRes.Text.ToString & " " & lblTCburn.Text.ToString & " " & lblACodecCommand.Text.ToString & " " & lblAudioChCommand.Text.ToString & " " & (Microsoft.VisualBasic.Chr(34)) & txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".mov" & (Microsoft.VisualBasic.Chr(34))
        lblFFarguments.Text = FFarguments.ToString
        If rdbWAV.Checked = True Then
            FFarguments = _ffargReport & " -i " & txtMXFpath.Text.ToString & " " & lblCodecCommand.Text.ToString & "  " & lblACodecCommand.Text.ToString & "  " & (Microsoft.VisualBasic.Chr(34)) & txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".wav" & (Microsoft.VisualBasic.Chr(34))
        End If
        Try
            FFmpegprocess.StartInfo.FileName = Me.txtFFmpeg.Text.ToString
            FFmpegprocess.StartInfo.Arguments = FFarguments
            FFmpegprocess.StartInfo.ErrorDialog = True
            FFmpegprocess.StartInfo.WorkingDirectory = Me.txtTemp.Text.ToString
            FFmpegprocess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            FFmpegprocess.Start()
            FFmpegprocess.WaitForExit()
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problem found while trying to execute the convertion!" & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Please check the config tab!"

        End Try
        

        _lastlog.EnableRaisingEvents = False
        _timeend = DateAndTime.Now.ToString("HH:mm:ss")
        _TimeTotal = _timeend - _timestart

        If System.IO.File.Exists(lblLastTempName.Text) Then
            LogReader = New StreamReader(lblLastTempName.Text, True)
            If chkVerbose.Checked = True Then
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " " & LogReader.ReadToEnd
            End If
        End If

        Try
            _outinforaw = My.Computer.FileSystem.GetFileInfo(txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".mov")
            _outinfo = CDec((_outinforaw.Length.ToString / 1024) / 1024)
            If _outinfo > 999 Then
                _outinfo = _outinfo.ToString("###,###")
            End If
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion to Completed !" & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion Started At " & _timestart & " And Ended at " & _timeend & " Taking " & _TimeTotal.Minutes.ToString & " minutes to finish." & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " The file was saved as " & txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".mov" & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Output File have " & _outinfo.ToString & " MBs."
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problem finding the output file. Please check if it's ok."
        End Try

    End Sub

    Private Sub _lastlog_OnChanged(source As Object, e As FileSystemEventArgs)
        'Specify what is done when a file is changed, created, or deleted.
        lblLastTempName.Text = e.FullPath
        'MessageBox.Show(e.FullPath)
    End Sub

    Private Sub txtFFoutput_TextChanged(sender As Object, e As EventArgs) Handles txtFFoutput.TextChanged, txtFFoutput.GotFocus
        txtFFoutput.Focus()
        txtFFoutput.SelectionStart = txtFFoutput.Text.Length
        txtFFoutput.ScrollToCaret()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub btnFFprobe_Click(sender As Object, e As EventArgs) Handles btnFFprobe.Click
        If OpenFFprobeDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFFprobe.Text = OpenFFprobeDialog.FileName.ToString
            My.Settings.ffprobepath = txtFFmpeg.Text.ToString
            btnChk3.BackColor = Color.Green
        End If
    End Sub

    Private Sub txtFFprobe_textchanged(sender As Object, e As EventArgs) Handles txtFFprobe.TextChanged
        Dim _ffprobecheck As String
        If System.IO.File.Exists(txtFFprobe.Text.ToString) = True Then
            _ffprobecheck = System.IO.Path.GetDirectoryName(txtFFprobe.Text.ToString)
            ' MessageBox.Show(_ffprobecheck.ToString & "\ffprobe.exe")
            If txtFFprobe.Text.ToString = _ffprobecheck & "\ffprobe.exe" Then
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe path is OK."
            ElseIf System.IO.File.Exists(_ffprobecheck.ToString & "\ffprobe.exe") = True Then
                txtFFprobe.Text = _ffprobecheck.ToString & "\ffprobe.exe"
                My.Settings.ffprobepath = txtFFprobe.Text.ToString
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe path wrong but was able to be corrected."
            End If
        End If


    End Sub


    Private Sub btnTCanalize_Click(sender As Object, e As EventArgs) Handles btnTCanalize.Click
        If System.IO.File.Exists(txtMXFpath.Text.Trim(Microsoft.VisualBasic.Chr(34))) = True Then
            Dim FFprobeProcess As New Process
            Dim FFprobe_arguments As String
            Dim io As StreamReader
            Dim io_temp As String
            io_temp = Nothing
            FFprobe_arguments = " -hide_banner " & txtMXFpath.Text.ToString

            Try
                FFprobeProcess.StartInfo.FileName = Me.txtFFprobe.Text.ToString
                FFprobeProcess.StartInfo.Arguments = FFprobe_arguments
                FFprobeProcess.StartInfo.ErrorDialog = True
                FFprobeProcess.StartInfo.RedirectStandardError = True
                FFprobeProcess.StartInfo.UseShellExecute = False
                FFprobeProcess.StartInfo.WorkingDirectory = Me.txtTemp.Text.ToString
                FFprobeProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                FFprobeProcess.StartInfo.CreateNoWindow = True
                FFprobeProcess.Start()
                io = FFprobeProcess.StandardError

                FFprobeProcess.WaitForExit()
                io_temp = io.ReadToEnd
                If chkVerbose.Checked = True Then
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & io_temp
                End If



                Try
                    Dim sTC As String = Strings.InStr(io_temp, "timecode") + 18
                    If sTC = 18 Then
                        txtTC.Text = "## Error ##"
                        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Parsing Time Code data!! ##"
                        chkTCBurn.Enabled = False
                    Else
                        Dim eTC As String = (sTC + 11)
                        Dim MXFTC As String = Strings.Mid(io_temp, sTC, (eTC - sTC))
                        txtTC.Text = MXFTC.ToString
                    End If
                Catch ex As Exception
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Parsing Time Code data!! ##"
                    txtTC.Text = "## Error ##"
                    chkTCBurn.Enabled = False
                End Try

                Try
                    Dim fFR As String = Strings.InStr(io_temp, "fps") - 9
                    'MessageBox.Show(FFR & " FFR")
                    Dim mFR As String = Strings.Mid(io_temp, fFR, 12)
                    'MessageBox.Show(mFR & " mfr")
                    Dim sFR As String = Strings.InStr(mFR, ",") + 1
                    Dim eFR As String = Strings.InStrRev(mFR, "fps")
                    'MessageBox.Show(sFR & " sfr")
                    Dim MXFFR As String = Strings.Mid(mFR, sFR, eFR)
                    'MessageBox.Show(MXFFR & " mxffr")
                    txtFR.Text = MXFFR.ToString
                Catch ex As Exception
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Parsing Frame Rate data!! ##"
                    txtFR.Text = "## Error ##"
                End Try

                Try
                    Dim sVC As String = Strings.InStr(io_temp, "Video:") + 7
                    Dim mVC As String = Strings.Mid(io_temp, sVC, sVC + 30)
                    Dim eVC As String = Strings.InStr(mVC, ",") - 1
                    Dim MXFVC As String = Strings.Mid(mVC, 1, eVC)
                    txtVC.Text = MXFVC.ToString

                Catch ex As Exception
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Parsing Video Codec data!! ##"
                    txtVC.Text = "## Error ##"
                End Try

                Try
                    Dim sAC As String = Strings.InStr(io_temp, "Audio:") + 7
                    Dim mAC As String = Strings.Mid(io_temp, sAC, sAC + 30)
                    'MessageBox.Show(mAC)
                    Dim eAC As String = Strings.InStr(mAC, ",") - 1
                    'MessageBox.Show(eAC)
                    Dim MXFAC As String = Strings.Mid(mAC, 1, eAC)
                    Dim mSR As String = Strings.Mid(mAC, (eAC + 1), 15)
                    Dim eSR As String = Strings.InStr(mSR, "Hz") - 1
                    Dim MXFSR As String = Strings.Mid(mSR, 3, eSR)
                    'MessageBox.Show(MXFSR & vbCrLf & mSR)
                    txtAC.Text = MXFAC.ToString
                    txtSR.Text = MXFSR.ToString
                Catch ex As Exception
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Parsing Audio Codec and Sample Rate data!! ##"
                    txtAC.Text = "## Error ##"
                    txtSR.Text = "## Error ##"
                End Try

                Try
                    Dim sDR As String = Strings.InStr(io_temp, "Duration:") + 10
                    If sDR = 10 Then
                        txtTC.Text = "## Error ##"
                        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Finding Duration data!! ##"
                    Else
                        Dim eDR As String = (sDR + 11)
                        Dim MXFDR As String = Strings.Mid(io_temp, sDR, (eDR - sDR))
                        txtDur.Text = MXFDR.ToString
                    End If
                Catch ex As Exception
                    txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Finding Duration data!! ##"
                    txtDur.Text = "## Error ##"
                End Try

                If txtTC.Text.Contains(";") = True Then
                    txtDrop.Text = "Yes"
                Else
                    txtDrop.Text = "No"
                End If

            Catch ex As Exception
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Retrieving Information Data!! ##"
                chkTCBurn.Enabled = False
            End Try

        Else
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Select a MXF file first!! ##"
        End If

    End Sub

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTC.TextChanged
        Dim hourTC As String = Strings.Mid(txtTC.Text.ToString, 1, 2)
        lblTChour.Text = hourTC.ToString
        Dim minuteTC As String = Strings.Mid(txtTC.Text.ToString, 4, 2)
        lblTCminute.Text = minuteTC.ToString
        Dim secondTC As String = Strings.Mid(txtTC.Text.ToString, 7, 2)
        lblTCsecond.Text = secondTC.ToString
        Dim frameTC As String = Strings.Mid(txtTC.Text.ToString, 10, 2)
        LblTCframe.Text = frameTC.ToString
        If txtTC.Text.ToString.Contains(";") Then
            lblTCdrop.Text = ";"
        Else
            lblTCdrop.Text = ":"
        End If

        If System.IO.File.Exists(txtFFprobe.Text.ToString) Then
            If txtTC.Text.Length > 0 Then
                chkTCBurn.Enabled = True
            Else
                chkTCBurn.Enabled = False
            End If
        Else
            chkTCBurn.Enabled = False
        End If
            'txtTC.Text = txtTC.Text.Replace(" ", "")
            'txtTC.Text = txtTC.Text.Remove(0, 1)
    End Sub

    Private Sub chkVerbose_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerbose.CheckedChanged
        If chkVerbose.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Verbose Mode selected."
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " All Messages will now be displayed."
        Else
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Verbose Mode off."
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Only essencial Messages will be displayed."
        End If
    End Sub

    Private Sub chkTCBurn_chkChanged(sender As Object, e As EventArgs) Handles chkTCBurn.CheckedChanged
        If chkTCBurn.Checked = True Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Timecode Burn On."
        Else
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Timecode Burn Off."
        End If
    End Sub

    Private Sub chkTCBurn_enbChanged(sender As Object, e As EventArgs) Handles chkTCBurn.EnabledChanged
        If chkTCBurn.Enabled = False Then
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Timecode Burn Disabled."
        Else
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Timecode Burn Enabled."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFFoutput.Text = DateAndTime.Now.ToString("HH:mm:ss") & " Clean!!"
    End Sub

    Private Sub chkToolTip_CheckedChanged(sender As Object, e As EventArgs) Handles chkToolTip.CheckedChanged
        If chkToolTip.Checked = True Then
            ToolTip.Active = True
        Else
            ToolTip.Active = False
        End If
    End Sub
End Class
