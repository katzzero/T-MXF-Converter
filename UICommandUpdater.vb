Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Module UICommandUpdater

    ''' <summary>
    ''' Atualiza os comandos de Codec de Vídeo e as configurações da UI.
    ''' </summary>
    Public Sub UpdateVideoCodec(ByRef form As frmTMXF)
        If form.rdbH264.Checked Then
            form.lblCodecCommand.Text = "-vcodec libx264 -profile:v baseline -tune fastdecode -g 1 -crf 18 -bf 0 -pix_fmt yuv420p -copyts"
            form.My.Settings.lastVcodec = "h264"
            form.rdb486.Enabled = True
            form.rdb360.Enabled = True
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec H.264 Selected."
            form.lblCodecn.Text = " H.264"
        ElseIf form.rdbVCcopy.Checked Then
            form.lblCodecCommand.Text = " -vcodec copy "
        ElseIf form.rdbProRes.Checked Then
            form.lblCodecCommand.Text = "-vcodec prores_ks -profile:v 1 -qscale:v 9 -copyts"
            form.My.Settings.lastVcodec = "prores"
            form.rdb486.Enabled = True
            form.rdb360.Enabled = True
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec ProRes Selected."
            form.lblCodecn.Text = " ProRes"
        ElseIf form.rdbDNxHD.Checked Then
            form.lblCodecCommand.Text = "-vcodec dnxhd"
            form.My.Settings.lastVcodec = "dnxhd"
            form.rdb486.Enabled = False
            form.rdb486.Checked = False
            form.rdb360.Enabled = False
            form.rdb360.Checked = False
            form.rdb720.Checked = True
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec DNxHD Selected."
            form.lblCodecn.Text = " DNxHD"
        End If

        ' Lógica específica para WAV
        If form.rdbWAV.Checked Then
            form.lblCodecCommand.Text = "-vn -copyts -map 0:a -filter_complex " & Microsoft.VisualBasic.Chr(34) & "[0:a] amerge=inputs=8" & Microsoft.VisualBasic.Chr(34) & ""
            form.lblACodecCommand.Text = "-acodec pcm_s24le"
            form.My.Settings.lastVcodec = "wav"
            form.grpResolution.Enabled = False
            form.grpVCodec.Enabled = False
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Codec WAV Selected."
        Else
            form.grpResolution.Enabled = True
            form.grpVCodec.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Atualiza os comandos de Resolução e os labels da UI.
    ''' </summary>
    Public Sub UpdateResolution(ByRef form As frmTMXF)
        If form.rdb1080.Checked Then
            form.lblRes.Text = " -s 1920x1080"
            form.My.Settings.lastres = "1080"
            form.lblNameRes.Text = " 1080p"
        ElseIf form.rdb720.Checked Then
            form.lblRes.Text = "-s 1280x720"
            form.My.Settings.lastres = "720"
            form.lblNameRes.Text = " 720p"
        ElseIf form.rdb486.Checked Then
            form.lblRes.Text = " -s 864x486"
            form.My.Settings.lastres = "486"
            form.lblNameRes.Text = " 486p"
        ElseIf form.rdb360.Checked Then
            form.lblRes.Text = "-s 640x360"
            form.My.Settings.lastres = "360"
            form.lblNameRes.Text = " 360p"
        End If
    End Sub

    ''' <summary>
    ''' Atualiza os comandos de Sample Rate.
    ''' </summary>
    Public Sub UpdateSampleRate(ByRef form As frmTMXF)
        If form.rdbSRDirect.Checked Then
            form.lblSRcommand.Text = "SR Command copy"
            form.My.Settings.LastSR = "srdirect"
        ElseIf form.rdbSR44.Checked Then
            form.lblSRcommand.Text = "SR Command 44.1"
            form.My.Settings.LastSR = "sr44"
        ElseIf form.rdbSR48.Checked Then
            form.lblSRcommand.Text = "SR Command 48"
            form.My.Settings.LastSR = "sr48"
        ElseIf form.rdbSR96.Checked Then
            form.lblSRcommand.Text = "SR Command 96"
            form.My.Settings.LastSR = "sr96"
        End If
    End Sub

    ''' <summary>
    ''' Atualiza os comandos de Canais de Áudio.
    ''' </summary>
    Public Sub UpdateAudioChannels(ByRef form As frmTMXF)
        If form.rdbADirect.Checked Then
            form.lblAudioChCommand.Text = "-map 0 -map -0:d"
            form.My.Settings.lastchannels = "direct"
        ElseIf form.rdbA2Ch.Checked Then
            form.lblAudioChCommand.Text = "2 channels map"
            form.My.Settings.lastchannels = "2ch"
        ElseIf form.rdbA4Ch.Checked Then
            form.lblAudioChCommand.Text = "4 Channels map"
            form.My.Settings.lastchannels = "4ch"
        ElseIf form.rdbA8Ch.Checked Then
            form.lblAudioChCommand.Text = "8 Channels map"
            form.My.Settings.lastchannels = "8ch"
        End If
    End Sub

    ''' <summary>
    ''' Atualiza os comandos de Codec de Áudio.
    ''' </summary>
    Public Sub UpdateAudioCodec(ByRef form As frmTMXF)
        If form.rdbPCM16.Checked Then
            form.lblACodecCommand.Text = "-acodec pcm_s16le"
            form.My.Settings.lastAcodec = "PCM16"
        ElseIf form.rdbPCM24.Checked Then
            form.lblACodecCommand.Text = "-acodec pcm_s24le"
            form.My.Settings.lastAcodec = "PCM24"
        ElseIf form.rdbACDirect.Checked Then
            form.lblACodecCommand.Text = "-acodec copy"
            form.My.Settings.lastAcodec = "acdirect"
        End If
    End Sub

    ''' <summary>
    ''' Atualiza os comandos de Frame Rate.
    ''' </summary>
    Public Sub UpdateFrameRate(ByRef form As frmTMXF)
        If form.rdbFRdirect.Checked Then
            form.lblFRcommand.Text = "FR Command copy"
            form.My.Settings.LastFR = "frdirect"
        ElseIf form.rdb23.Checked Then
            form.lblFRcommand.Text = "FR Command 23"
            form.My.Settings.LastFR = "23"
        ElseIf form.rdb29D.Checked Then
            form.lblFRcommand.Text = "FR Command 29"
            form.My.Settings.LastFR = "29"
        ElseIf form.rdb24.Checked Then
            form.lblFRcommand.Text = "FR Command 24"
            form.My.Settings.LastFR = "24"
        End If
    End Sub

    ''' <summary>
    ''' Lógica de log para mudança de Frame Rate.
    ''' </summary>
    Public Sub LogFrameRateChange(ByRef form As frmTMXF)
        If form.txtFR.Text.Contains(23) Or form.txtFR.ToString.Contains(29) Then
            If form.rdbDNxHD.Checked Then
                form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problematic Frame Rate Detected !! Recommended use of DNxHD Codec. Proceed with Care."
            End If
        End If
        If form.txtFR.ToString.Contains("23") Then
            form.txtCFR.Text = "24000/1001"
        ElseIf form.txtFR.ToString.Contains("29") Then
            form.txtCFR.Text = "30000/1001"
        ElseIf form.txtFR.ToString.Contains("30") Then
            form.txtCFR.Text = "30/1"
        ElseIf form.txtFR.ToString.Contains("25") Then
            form.txtCFR.Text = "25/1"
        ElseIf form.txtFR.ToString.Contains("24") Then
            form.txtCFR.Text = "24/1"
        End If
    End Sub

End Module
