Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Text.RegularExpressions ' Necessário para o DNxHDCalculator

Module FFmpegCommandBuilder

    ''' <summary>
    ''' Constrói o comando completo do FFmpeg com base nas configurações do formulário.
    ''' </summary>
    ''' <param name="form">A instância do formulário principal (frmTMXF) para acessar seus controles.</param>
    ''' <returns>A string completa de argumentos do FFmpeg.</returns>
    Public Function BuildCommand(ByRef form As frmTMXF) As String
        Dim FFarguments As String = ""
        Dim _ffargReport As String = "-loglevel verbose -y -hide_banner "
        Dim _GPU As String = ""
        ' 1. Lógica de cálculo de Bitrate e Frame Rate para DNxHD
        Dim _dnxhdFR As String = ""
        Dim _FR_CORR As String = ""

        If form.rdbDNxHD.Checked Then
            Dim dnxHDResult As DNxHDCalculator.DNxHDResult = DNxHDCalculator.CalculateDNxHDParams(form.txtFR.Text.Trim(), form.rdb1080.Checked)
            _dnxhdFR = dnxHDResult.FrameRate
            Dim _dnxhdBT As String = dnxHDResult.Bitrate

            ' Atualiza o lblCodecCommand para DNxHD com os valores calculados
            form.lblCodecCommand.Text = "-vcodec dnxhd -b:v " & _dnxhdBT.ToString & " -r " & _dnxhdFR.ToString

            ' 2. Lógica de Correção de Frame Rate (Apenas para DNxHD)
            If form.chkCorrect.Checked Then
                If form.txtFR.Text.Contains("23") Or form.txtFR.Text.Contains("29") Then
                    form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Video Frame Rate need to be corrected for perfectly recognition, applying it now!! "
                    _FR_CORR = " -r " & _dnxhdFR
                Else
                    form.txtFFoutput.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Problematic Frame Rate detected for use in Post-Production! "
                End If
            End If
        End If

        ' 3. Lógica de Report e Log Level
        If form.chkReport.Checked Then
            _ffargReport = "-report " & _ffargReport
        End If

        ' 4. Lógica de Aceleração de Hardware
        If form.chkHWaccel.Checked Then
            _GPU = " -hwaccel auto "
        End If

        ' 5. Lógica de Timecode Burn-in
        Dim _TCBurnCommand As String = ""
        If form.chkTCBurn.Checked Then
            ' O comando original usa lblTChour, lblTCminute, lblTCsecond, LblTCframe, lblTCdrop
            ' Assumindo que estes Labels são atualizados em outro lugar do código.
            ' Usaremos o valor de _dnxhdFR para o rate do drawtext, conforme o original.
            _TCBurnCommand = " -vf " & (Chr(34)) & "drawtext=fontfile=/windows/fonts/cour.ttf: fontsize=56: timecode='" & form.lblTChour.Text.ToString & "\:" & form.lblTCminute.Text.ToString & "\:" & form.lblTCsecond.Text.ToString & "\" & form.lblTCdrop.Text.ToString & form.LblTCframe.Text.ToString & "': r=" & _dnxhdFR & ": x=(w-tw)/2: y=h-(3.5*lh): box=1: boxcolor=0x00000075: fontcolor=0xffffff85: shadowcolor=0x00000065 : shadowx=2 :shadowy=2 " & (Chr(34))
        End If

        ' 6. Construção do Comando Base
        Dim outputFileName As String = form.txtOutPath.Text.ToString & "\" & form.txtOutFilename.Text.ToString & "-" & form.txtNameDate.Text.ToString & form.lblCodecn.Text.ToString & form.lblNameRes.Text.ToString & ".mov"
        Dim outputFileNameQuoted As String = Chr(34) & outputFileName & Chr(34)

        FFarguments = _ffargReport & _GPU & " -i " & form.txtMXFpath.Text.ToString & _FR_CORR & " " & form.lblCodecCommand.Text.ToString & " " & form.lblRes.Text.ToString & " " & _TCBurnCommand & " " & form.lblACodecCommand.Text.ToString & " " & form.lblAudioChCommand.Text.ToString & " " & outputFileNameQuoted

        ' 7. Exceção para WAV (Apenas Áudio)
        If form.rdbWAV.Checked Then
            outputFileName = form.txtOutPath.Text.ToString & "\" & form.txtOutFilename.Text.ToString & "-" & form.txtNameDate.Text.ToString & ".wav"
            outputFileNameQuoted = Chr(34) & outputFileName & Chr(34)
            FFarguments = _ffargReport & " -i " & form.txtMXFpath.Text.ToString & " " & form.lblCodecCommand.Text.ToString & "  " & form.lblACodecCommand.Text.ToString & "  " & outputFileNameQuoted
        End If

        ' 8. Exceção para Comando Customizado
        If form.chkCustom.Checked Then
            outputFileName = form.txtOutPath.Text.ToString & "\" & form.txtOutFilename.Text.ToString & "-" & form.txtNameDate.Text.ToString & ".mov"
            outputFileNameQuoted = Chr(34) & outputFileName & Chr(34)
            FFarguments = _ffargReport & " -i " & form.txtMXFpath.Text.ToString & " " & form.txtCustom.Text.ToString & "  " & outputFileNameQuoted
        End If

        ' Atualiza o Label de argumentos no formulário (para debug/visualização)
        form.lblFFarguments.Text = FFarguments.ToString

        Return FFarguments
    End Function

End Module
