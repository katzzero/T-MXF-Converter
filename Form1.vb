Imports System.IO
Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports System.Security.Permissions
Imports System.Windows.Forms ' Adicionado para garantir que os controles do Form sejam reconhecidos pelos módulos

Public Class frmTMXF

    Private Sub frmTMXF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFFoutput.Text = SystemInfo.GetInitializationLog()

        'Show version on label
        lblVersion.Text = "V." & Application.ProductVersion

        ' Configuração de caminhos FFmpeg/FFprobe e Temp
        FFmpegConfig.ConfigureFFmpegPaths(txtFFmpeg, txtFFprobe, txtFFoutput)
        FFmpegConfig.ConfigureTempPath(txtTemp, txtFFoutput)

        ' Carregamento das últimas configurações
        SettingsLoader.LoadLastSettings(Me)

        ' Set date and time as part of the output name
        txtNameDate.Text = DateAndTime.Now.ToString("dd-MM-yyyy") & "-" & DateAndTime.Now.ToString("HH-mm")
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Software Started Successfully!"

    End Sub

    Private Sub btnLoadMXF_Click(sender As Object, e As EventArgs) Handles btnLoadMXF.Click
        ' Limpar campos de metadados
        txtAC.Text = ""
        txtDrop.Text = ""
        txtDur.Text = ""
        txtTC.Text = ""
        txtVC.Text = ""
        txtFR.Text = ""
        txtSR.Text = ""

        ' 1. Abrir diálogo e obter caminho do arquivo
        If OpenMXFDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Seleção de arquivo MXF cancelada. ##"
            Return
        End If

        Dim mxfPathWithQuotes As String = Microsoft.VisualBasic.Chr(34) & OpenMXFDialog.FileName.ToString & Microsoft.VisualBasic.Chr(34)
        txtMXFpath.Text = mxfPathWithQuotes
        btnSaveOut.Enabled = True

        Dim mxfPath As String = mxfPathWithQuotes.Trim(Microsoft.VisualBasic.Chr(34))

        If Not System.IO.File.Exists(mxfPath) Then
            txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problem Loading MXF file . Copy locally or choose another one. "
            Return
        End If

        ' 2. Processar o arquivo MXF usando o novo módulo
        Dim result As MXFProcessor.MXFAnalysisResult = MXFProcessor.ProcessMXFFile( _
            mxfPathWithQuotes, _
            Me.txtFFprobe.Text.ToString, _
            Me.txtTemp.Text.ToString, _
            Me.chkVerbose.Checked _
        )

        ' 3. Atualizar a interface com os resultados
        If result.Success Then
            btnChk1.BackColor = Color.Green
            lblMXFPathCommand.Text = "-i " & mxfPathWithQuotes
            txtOutFilename.Text = System.IO.Path.GetFileNameWithoutExtension(mxfPath)
            txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " MXF file loaded sucessfully ! The MXF have " & result.MXFSizeMB & " MBs of data!"

            ' Atualizar campos de metadados
            txtTC.Text = result.TimeCode
            txtFR.Text = result.FrameRate
            txtVC.Text = result.VideoCodec
            txtAC.Text = result.AudioCodec
            txtSR.Text = result.SampleRate
            txtDur.Text = result.Duration
            txtDrop.Text = If(result.IsDropFrame, "Yes", "No")

            ' Lógica de log verbose
            If chkVerbose.Checked Then
                txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe Output: " & vbCrLf & result.FFprobeOutput
            End If

            ' A lógica de Analize_sub foi movida para MXFProcessor.ProcessMXFFile.
            ' A chamada é redundante e foi removida.

            ' Desabilitar TC Burn se houver erro no TimeCode
            chkTCBurn.Enabled = (result.TimeCode <> "## Error ##")

        Else
            ' Lidar com erros de processamento
            txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## Error Retrieving Information Data!! ##"
            txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Detalhe: " & result.ErrorMessage
            chkTCBurn.Enabled = False
        End If

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

    Private Sub codec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbH264.CheckedChanged, rdbDNxHD.CheckedChanged, rdbProRes.CheckedChanged, rdbWAV.CheckedChanged, rdbVCcopy.CheckedChanged
        UICommandUpdater.UpdateVideoCodec(Me)
    End Sub

    Private Sub resolution_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1080.CheckedChanged, rdb486.CheckedChanged, rdb360.CheckedChanged, rdb720.CheckedChanged
        UICommandUpdater.UpdateResolution(Me)
    End Sub

    Private Sub rdbSRDirect_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSRDirect.CheckedChanged, rdbSR44.CheckedChanged, rdbSR48.CheckedChanged, rdbSR96.CheckedChanged
        UICommandUpdater.UpdateSampleRate(Me)
    End Sub

    Private Sub rdbAchannels_CheckedChanged(sender As Object, e As EventArgs) Handles rdbADirect.CheckedChanged, rdbA2Ch.CheckedChanged, rdbA4Ch.CheckedChanged, rdbA8Ch.CheckedChanged
        UICommandUpdater.UpdateAudioChannels(Me)
    End Sub


    Private Sub rdbACodec_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPCM16.CheckedChanged, rdbPCM24.CheckedChanged, rdbACDirect.CheckedChanged
        UICommandUpdater.UpdateAudioCodec(Me)
    End Sub

    Private Sub rdbFrameRate_CheckedChanged(sender As Object, e As EventArgs) Handles rdb29D.CheckedChanged, rdb24.CheckedChanged, rdb23.CheckedChanged, rdbFRdirect.CheckedChanged
        UICommandUpdater.UpdateFrameRate(Me)
    End Sub

    ' Lógica movida para UICommandUpdater.UpdateVideoCodec

    Private Sub lblRes_TextChanged(sender As Object, e As EventArgs) Handles lblRes.TextChanged
        UICommandUpdater.LogResolutionChange(Me)
    End Sub

    Private Sub lblAudioChCommand_TextChanged(sender As Object, e As EventArgs) Handles lblAudioChCommand.TextChanged
        UICommandUpdater.LogAudioChannelChange(Me)
    End Sub

    Private Sub lblACodecCommand_TextChanged(sender As Object, e As EventArgs) Handles lblACodecCommand.TextChanged
        UICommandUpdater.LogAudioCodecChange(Me)
    End Sub

    Private Sub lblFRcommand_TextChanged(sender As Object, e As EventArgs) Handles lblFRcommand.TextChanged
        UICommandUpdater.LogFrameRateCommandChange(Me)
    End Sub

    Private Sub lblSRcommand_TextChanged(sender As Object, e As EventArgs) Handles lblSRcommand.TextChanged
        UICommandUpdater.LogSampleRateChange(Me)
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

        ' 1. Configuração do FileSystemWatcher para o log do FFmpeg
        _lastlog.Path = txtTemp.Text
        _lastlog.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        _lastlog.Filter = "*.log"
        AddHandler _lastlog.Created, AddressOf _lastlog_OnChanged
        AddHandler _lastlog.Changed, AddressOf _lastlog_OnChanged
        _lastlog.EnableRaisingEvents = True

        ' 2. Inicialização do Log e Tempo
        _date = DateAndTime.Now.ToString("yyyyMMdd")
        _time = DateAndTime.Now.ToString("HHmmss")
        _timestart = DateAndTime.Now.ToString("HH:mm:ss")
        _timeofthelog = "ffmpeg-" & _date & "-" & _time & ".log"
        txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion started ! " & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Waiting for the Conversion to Complete."
        txtNameDate.Text = DateAndTime.Now.ToString("dd-MM-yyyy") & "-" & DateAndTime.Now.ToString("HH-mm")

        ' 3. Geração do Comando FFmpeg usando o novo módulo
        FFarguments = FFmpegCommandBuilder.BuildCommand(Me)

        ' 4. Execução do FFmpeg
        Try
            FFmpegprocess.StartInfo.FileName = Me.txtFFmpeg.Text.ToString
            FFmpegprocess.StartInfo.Arguments = FFarguments
            FFmpegprocess.StartInfo.ErrorDialog = True
            FFmpegprocess.StartInfo.WorkingDirectory = Me.txtTemp.Text.ToString
            FFmpegprocess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            FFmpegprocess.Start()
            FFmpegprocess.WaitForExit()
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " A problem was found while trying to execute the convertion!" & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Please check the config tab!"

        End Try

        ' 5. Finalização e Log
        _lastlog.EnableRaisingEvents = False
        _timeend = DateAndTime.Now.ToString("HH:mm:ss")
        _TimeTotal = _timeend - _timestart

        If System.IO.File.Exists(lblLastTempName.Text) Then
            LogReader = New StreamReader(lblLastTempName.Text, True)
            If chkVerbose.Checked = True Then
                txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " " & LogReader.ReadToEnd
            End If
        End If

        ' 6. Verificação do Arquivo de Saída
        Try
            Dim outputFileName As String
            If rdbWAV.Checked Then
                outputFileName = txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".wav"
            ElseIf chkCustom.Checked Then
                outputFileName = txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & ".mov"
            Else
                outputFileName = txtOutPath.Text.ToString & "\" & txtOutFilename.Text.ToString & "-" & txtNameDate.Text.ToString & lblCodecn.Text.ToString & lblNameRes.Text.ToString & ".mov"
            End If

            _outinforaw = My.Computer.FileSystem.GetFileInfo(outputFileName)
            _outinfo = CInt((_outinforaw.Length / 1024) / 1024)
            Dim _outinfo_str As String
            If _outinfo > 999 Then
                _outinfo_str = _outinfo.ToString("###,###")
            Else
                _outinfo_str = _outinfo.ToString
            End If

            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion to Completed !" & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Conversion Started At " & _timestart & " And Ended at " & _timeend & " Taking " & _TimeTotal.Minutes.ToString & " minutes to finish." & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " The file was saved as " & outputFileName & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Output File have " & _outinfo_str & " MBs."
        Catch ex As Exception
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problem finding the output file. Please check if it's ok."
        End Try

        ' 7. Salvar Configurações Customizadas
        If chkCustom.Checked = True Then
            My.Settings.custom = txtCustom.Text
        ElseIf My.Settings.custom.Length > 0 Then
        Else
            My.Settings.custom = ""
        End If

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
            My.Settings.verbose = True
        Else
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Verbose Mode off."
            txtFFoutput.Text = txtFFoutput.Text & vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Only essencial Messages will be displayed."
            My.Settings.verbose = False
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

    Private Sub txtFR_TextChanged(sender As Object, e As EventArgs) Handles txtFR.TextChanged
        UICommandUpdater.LogFrameRateChange(Me)
    End Sub

    Private Sub chkCorrect_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorrect.CheckedChanged
        If chkCorrect.Checked = True Then
            My.Settings.Correct = True
        Else
            My.Settings.Correct = False
        End If
    End Sub

    Private Sub chkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustom.CheckedChanged
        If chkCustom.Checked = True Then
            txtCustom.Enabled = True
        Else
            txtCustom.Enabled = False

        End If
    End Sub

    Private Sub btnTCanalize_Click(sender As Object, e As EventArgs) Handles btnTCanalize.Click
        ' A função Analize_sub foi removida e sua lógica foi consolidada no btnLoadMXF_Click.
        ' Chamando btnLoadMXF_Click para reanalisar o arquivo.
        btnLoadMXF_Click(sender, e)
    End Sub

    Private Sub chkadvanced_checkedchanged(sender As Object, e As EventArgs) Handles chkAdvanced.CheckedChanged

        If _chk.checked = True Then
            chkAdvanced.Checked = True
            _chk2.Visible = True
        Else
            chkAdvanced.Checked = False
            _chk2.Visible = False
        End If

    End Sub

    Private Sub _chk2_CheckedChanged(sender As Object, e As EventArgs) Handles _chk2.CheckedChanged
        If _chk2.Checked = True Then
            chkCustom.Enabled = True
            rdbVCcopy.Enabled = True
        Else
            chkCustom.Enabled = False
            rdbVCcopy.Enabled = False

        End If
    End Sub

End Class
