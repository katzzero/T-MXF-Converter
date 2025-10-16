Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Windows.Forms ' Necessário para File.Exists, Application.StartupPath, etc.

Module FFmpegConfig

    ''' <summary>
    ''' Tenta localizar e configurar os caminhos para FFmpeg e FFprobe.
    ''' </summary>
    ''' <param name="ffmpegPath">TextBox para exibir o caminho do FFmpeg.</param>
    ''' <param name="ffprobePath">TextBox para exibir o caminho do FFprobe.</param>
    ''' <param name="outputLog">TextBox para log de saída.</param>
    ''' <returns>True se a configuração inicial for bem-sucedida, False caso contrário.</returns>
    Public Function ConfigureFFmpegPaths(ByRef ffmpegPath As TextBox, ByRef ffprobePath As TextBox, ByRef outputLog As TextBox) As Boolean
        Dim success As Boolean = True

        ' 1. Configuração inicial de FFmpeg e FFprobe
        Try
            ' Tenta encontrar FFmpeg
            If System.IO.File.Exists(Application.StartupPath & "\bin\ffmpeg.exe") Then
                ffmpegPath.Text = Application.StartupPath & "\bin\ffmpeg.exe"
                My.Settings.ffmpegpath = ffmpegPath.Text
            ElseIf System.IO.File.Exists("c:\ffmpeg\bin\ffmpeg.exe") Then
                ffmpegPath.Text = "c:\ffmpeg\bin\ffmpeg.exe"
                My.Settings.ffmpegpath = ffmpegPath.Text
            End If

            ' Tenta encontrar FFprobe
            If System.IO.File.Exists(Application.StartupPath & "\bin\ffprobe.exe") Then
                ffprobePath.Text = Application.StartupPath & "\bin\ffprobe.exe"
                My.Settings.ffprobepath = ffprobePath.Text
            ElseIf System.IO.File.Exists("c:\ffmpeg\bin\ffprobe.exe") Then
                ffprobePath.Text = "c:\ffmpeg\bin\ffprobe.exe"
                My.Settings.ffprobepath = ffprobePath.Text
            End If
        Catch ex As Exception
            outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " System Critical error parsing core files!"
            success = False
        End Try

        ' 2. Verificação e solicitação de caminho para FFprobe (lógica original)
        Try
            If System.IO.File.Exists(My.Settings.ffprobepath.ToString) Then
                ffprobePath.Text = My.Settings.ffprobepath.ToString
            ElseIf My.Settings.ffprobepath = "c:FFprobe" Or My.Settings.ffprobepath.Length <= 0 Then
                ' A lógica de OpenFFprobeDialog.ShowDialog() deve ser tratada na Form1
                ' ou o diálogo deve ser passado como parâmetro. Por enquanto, apenas logamos o erro.
                outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFprobe.exe Not Found - TC Burn Disabled !"
                ffprobePath.Text = "c:FFprobe"
                My.Settings.ffprobepath = "c:FFprobe"
            End If
        Catch ex As Exception
            outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## FFprobe.exe Error ## - TC Burn Disabled !"
            success = False
        End Try

        ' 3. Verificação e solicitação de caminho para FFmpeg (lógica original)
        Try
            If ffmpegPath.Text = "c:FFmpeg" Then
                If My.Settings.ffmpegpath.Length = 0 Then
                    ' A lógica de OpenFFmpegDialog.ShowDialog() deve ser tratada na Form1
                    ' ou o diálogo deve ser passado como parâmetro. Por enquanto, apenas logamos o erro.
                    outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## FFmpeg path not found!! ## Please check the path in Software Config Tab or the software will be unable to convert!"
                    ffmpegPath.Text = "c:FFmpeg"
                    My.Settings.ffmpegpath = ""
                    success = False
                ElseIf System.IO.File.Exists(My.Settings.ffmpegpath.ToString) Then
                    ffmpegPath.Text = My.Settings.ffmpegpath.ToString
                    outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " FFmpeg.exe found! "
                End If
            End If
        Catch ex As Exception
            My.Settings.ffmpegpath = ""
            ffmpegPath.Text = "c:FFmpeg"
            outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " ## FFmpeg path not found!! ## Please check the path in Software Config Tab or the software will be unable to convert!"
            success = False
        End Try

        Return success
    End Function

    ''' <summary>
    ''' Configura o caminho temporário.
    ''' </summary>
    Public Sub ConfigureTempPath(ByRef tempPath As TextBox, ByRef outputLog As TextBox)
        If tempPath.Text = "c:Temp" Then
            If My.Settings.temppath.Length = 0 Then
                tempPath.Text = System.IO.Path.GetTempPath
                My.Settings.temppath = tempPath.Text.ToString
                outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Using system's default temporary folder."
            Else
                tempPath.Text = My.Settings.temppath
                outputLog.Text &= vbCrLf & DateAndTime.Now.ToString("HH:mm:ss") & " Using custom temporary folder."
            End If
        End If
    End Sub

End Module
