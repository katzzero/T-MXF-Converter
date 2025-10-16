Imports System.IO
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions

Module MXFProcessor

    Public Class MXFAnalysisResult
        Public Property MXFPath As String
        Public Property MXFSizeMB As String
        Public Property FFprobeOutput As String
        Public Property TimeCode As String
        Public Property FrameRate As String
        Public Property VideoCodec As String
        Public Property AudioCodec As String
        Public Property SampleRate As String
        Public Property Duration As String
        Public Property IsDropFrame As Boolean
        Public Property Success As Boolean
        Public Property ErrorMessage As String

        Public Sub New()
            TimeCode = "## Error ##"
            FrameRate = "## Error ##"
            VideoCodec = "## Error ##"
            AudioCodec = "## Error ##"
            SampleRate = "## Error ##"
            Duration = "## Error ##"
            IsDropFrame = False
            Success = False
            ErrorMessage = ""
        End Sub
    End Class

    ''' <summary>
    ''' Carrega o arquivo MXF, executa o FFprobe e analisa a saída para extrair metadados.
    ''' </summary>
    ''' <param name="mxfPath">Caminho completo do arquivo MXF (com aspas).</param>
    ''' <param name="ffprobePath">Caminho completo do executável ffprobe.</param>
    ''' <param name="tempPath">Caminho para o diretório temporário.</param>
    ''' <param name="isVerbose">Indica se a saída completa do FFprobe deve ser logada.</param>
    ''' <returns>Um objeto MXFAnalysisResult contendo os metadados extraídos e o status da operação.</returns>
    Public Function ProcessMXFFile(ByVal mxfPath As String, ByVal ffprobePath As String, ByVal tempPath As String, ByVal isVerbose As Boolean) As MXFAnalysisResult
        Dim result As New MXFAnalysisResult()
        result.MXFPath = mxfPath.Trim(Chr(34))

        ' 1. Verificação de Arquivo e Tamanho
        Try
            If Not System.IO.File.Exists(result.MXFPath) Then
                result.ErrorMessage = "Arquivo MXF não encontrado. Copie localmente ou escolha outro."
                Return result
            End If

            Dim _mxfinfo As FileInfo = My.Computer.FileSystem.GetFileInfo(result.MXFPath)
            Dim _mxfsize As Integer = CInt((_mxfinfo.Length / 1024) / 1024)
            If _mxfsize > 999 Then
                result.MXFSizeMB = _mxfsize.ToString("###,###")
            Else
                result.MXFSizeMB = _mxfsize.ToString
            End If

        Catch ex As Exception
            result.ErrorMessage = "Problema ao carregar o arquivo MXF ou obter o tamanho: " & ex.Message
            Return result
        End Try

        ' 2. Execução do FFprobe
        Try
            Dim FFprobeProcess As New Process
            Dim FFprobe_arguments As String = " -hide_banner -i " & mxfPath.ToString

            FFprobeProcess.StartInfo.FileName = ffprobePath
            FFprobeProcess.StartInfo.Arguments = FFprobe_arguments
            FFprobeProcess.StartInfo.RedirectStandardError = True
            FFprobeProcess.StartInfo.UseShellExecute = False
            FFprobeProcess.StartInfo.WorkingDirectory = tempPath
            FFprobeProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            FFprobeProcess.StartInfo.CreateNoWindow = True
            FFprobeProcess.Start()

            result.FFprobeOutput = FFprobeProcess.StandardError.ReadToEnd
            FFprobeProcess.WaitForExit()

            If FFprobeProcess.ExitCode <> 0 And Not isVerbose Then
                ' Se o FFprobe falhar e não for verbose, a saída de erro é o que precisamos analisar
                ' No entanto, o FFprobe frequentemente usa stderr para metadados, então continuamos a análise.
            End If

        Catch ex As Exception
            result.ErrorMessage = "Erro ao executar o FFprobe: " & ex.Message
            Return result
        End Try

        ' 3. Análise da Saída do FFprobe (Lógica Original Adaptada)
        Dim io_temp As String = result.FFprobeOutput

        ' Time Code (TC)
        Try
            Dim tcMatch As Match = Regex.Match(io_temp, "timecode\s*:\s*(\d{2}:\d{2}:\d{2}[,;]\d{2})")
            If tcMatch.Success Then
                result.TimeCode = tcMatch.Groups(1).Value
                result.IsDropFrame = result.TimeCode.Contains(";")
            Else
                ' Tenta a lógica original (menos robusta) se o regex falhar
                Dim sTC As Integer = Strings.InStr(io_temp, "timecode") + 18
                If sTC > 18 Then
                    Dim MXFTC As String = Strings.Mid(io_temp, sTC, 11)
                    result.TimeCode = MXFTC.Trim()
                    result.IsDropFrame = result.TimeCode.Contains(";")
                End If
            End If
        Catch ex As Exception
            ' Ignora erro de parsing de TC, mantém o valor padrão "## Error ##"
        End Try

        ' Frame Rate (FR)
        Try
            Dim frMatch As Match = Regex.Match(io_temp, "(\d+(\.\d+)?)\s*fps")
            If frMatch.Success Then
                result.FrameRate = frMatch.Groups(1).Value & " fps"
            Else
                ' Lógica original (menos robusta)
                Dim fFR As Integer = Strings.InStr(io_temp, "fps") - 9
                If fFR > 0 Then
                    Dim mFR As String = Strings.Mid(io_temp, fFR, 12)
                    Dim sFR As Integer = Strings.InStr(mFR, ",") + 1
                    Dim eFR As Integer = Strings.InStrRev(mFR, "fps")
                    If sFR > 1 And eFR > sFR Then
                        result.FrameRate = Strings.Mid(mFR, sFR, eFR).Trim()
                    End If
                End If
            End If
        Catch ex As Exception
            ' Ignora erro de parsing de FR
        End Try

        ' Video Codec (VC)
        Try
            Dim vcMatch As Match = Regex.Match(io_temp, "Video:\s*([^,]+)")
            If vcMatch.Success Then
                result.VideoCodec = vcMatch.Groups(1).Value.Trim()
            Else
                ' Lógica original (menos robusta)
                Dim sVC As Integer = Strings.InStr(io_temp, "Video:") + 7
                If sVC > 7 Then
                    Dim mVC As String = Strings.Mid(io_temp, sVC, 30)
                    Dim eVC As Integer = Strings.InStr(mVC, ",") - 1
                    If eVC > 0 Then
                        result.VideoCodec = Strings.Mid(mVC, 1, eVC).Trim()
                    End If
                End If
            End If
        Catch ex As Exception
            ' Ignora erro de parsing de VC
        End Try

        ' Audio Codec (AC) e Sample Rate (SR)
        Try
            Dim acsrMatch As Match = Regex.Match(io_temp, "Audio:\s*([^,]+),\s*(\d+)\s*Hz")
            If acsrMatch.Success Then
                result.AudioCodec = acsrMatch.Groups(1).Value.Trim()
                result.SampleRate = acsrMatch.Groups(2).Value
            Else
                ' Lógica original (menos robusta)
                Dim sAC As Integer = Strings.InStr(io_temp, "Audio:") + 7
                If sAC > 7 Then
                    Dim mAC As String = Strings.Mid(io_temp, sAC, 50) ' Aumentado o tamanho para capturar SR
                    Dim eAC As Integer = Strings.InStr(mAC, ",") - 1
                    If eAC > 0 Then
                        result.AudioCodec = Strings.Mid(mAC, 1, eAC).Trim()
                        Dim mSR As String = Strings.Mid(mAC, (eAC + 1))
                        Dim srMatch As Match = Regex.Match(mSR, "(\d+)\s*Hz")
                        If srMatch.Success Then
                            result.SampleRate = srMatch.Groups(1).Value
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            ' Ignora erro de parsing de AC/SR
        End Try

        ' Duration (DR)
        Try
            Dim drMatch As Match = Regex.Match(io_temp, "Duration:\s*(\d{2}:\d{2}:\d{2}\.\d{2})")
            If drMatch.Success Then
                result.Duration = drMatch.Groups(1).Value
            Else
                ' Lógica original (menos robusta)
                Dim sDR As Integer = Strings.InStr(io_temp, "Duration:") + 10
                If sDR > 10 Then
                    result.Duration = Strings.Mid(io_temp, sDR, 11).Trim()
                End If
            End If
        Catch ex As Exception
            ' Ignora erro de parsing de DR
        End Try

        ' 4. Finalização
        If result.TimeCode <> "## Error ##" And result.FrameRate <> "## Error ##" Then
            result.Success = True
        Else
            result.ErrorMessage = "Não foi possível extrair metadados essenciais (TC ou FR)."
        End If

        Return result
    End Function

End Module
