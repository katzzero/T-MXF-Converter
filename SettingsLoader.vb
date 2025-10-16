Imports System.Windows.Forms

Module SettingsLoader

    ''' <summary>
    ''' Carrega as últimas configurações de usuário salvas e aplica aos controles do formulário.
    ''' </summary>
    ''' <param name="form">A instância do formulário principal (frmTMXF) para acessar seus controles.</param>
    Public Sub LoadLastSettings(ByRef form As frmTMXF)
        ' Check last used codec and assign it
        Select Case My.Settings.lastVcodec
            Case "h264"
                form.rdbH264.Checked = True
            Case "prores"
                form.rdbProRes.Checked = True
            Case "dnxhd"
                form.rdbDNxHD.Checked = True
            Case "wav"
                form.rdbWAV.Checked = True
        End Select

        ' Check Last used Resolution and assign it
        Select Case My.Settings.lastres
            Case "1080"
                form.rdb1080.Checked = True
            Case "720"
                form.rdb720.Checked = True
            Case "486"
                form.rdb486.Checked = True
            Case "360"
                form.rdb360.Checked = True
        End Select

        ' Check Last used Frame Rate and assign it
        Select Case My.Settings.LastFR
            Case "frdirect"
                form.rdbFRdirect.Checked = True
            Case "24"
                form.rdb24.Checked = True
            Case "29"
                form.rdb29D.Checked = True
            Case "23"
                form.rdb23.Checked = True
        End Select

        ' Check Last used Audio Codec and assign it
        Select Case My.Settings.lastAcodec
            Case "PCM16"
                form.rdbPCM16.Checked = True
            Case "PCM24"
                form.rdbPCM24.Checked = True
            Case "wav"
                form.rdbWAV.Checked = True
            Case "acdirect"
                form.rdbACDirect.Checked = True
        End Select

        ' Check Last used Audio Channels and assign it
        Select Case My.Settings.lastchannels
            Case "direct"
                form.rdbADirect.Checked = True
            Case "2ch"
                form.rdbA2Ch.Checked = True
            Case "4ch"
                form.rdbA4Ch.Checked = True
            Case "8ch"
                form.rdbA8Ch.Checked = True
        End Select

        ' Check Last used Sample Rate and assign it
        Select Case My.Settings.LastSR
            Case "srdirect"
                form.rdbSRDirect.Checked = True
            Case "sr44"
                form.rdbSR44.Checked = True
            Case "sr48"
                form.rdbSR48.Checked = True
            Case "sr96"
                form.rdbSR96.Checked = True
        End Select

        ' Outras configurações
        If Not My.Settings.LastOutPath.Length = 0 Then
            form.txtOutPath.Text = My.Settings.LastOutPath.ToString
            form.btnSaveOut.Enabled = True
        End If

        If My.Settings.Correct = True Then
            form.chkCorrect.Checked = True
        End If

        If My.Settings.verbose = True Then
            form.chkVerbose.Checked = True
        End If

        If My.Settings.custom.Length = 0 Then
            form.txtCustom.Text = "Enter Here !"
        Else
            form.txtCustom.Text = My.Settings.custom
        End If

        ' Log de carregamento
        If My.Settings.last = False Then
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " No settings detected from previous use."
        ElseIf My.Settings.last = True Then
            form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Settings Loaded OK."
        End If

    End Sub

End Module
