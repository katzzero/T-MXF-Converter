Imports System.Windows.Forms

Module DNxHDCalculator

    Public Class DNxHDResult
        Public Property Bitrate As String
        Public Property FrameRate As String
    End Class

    ''' <summary>
    ''' Calcula o Bitrate e o Frame Rate corretos para o codec DNxHD com base no Frame Rate detectado e na resolução selecionada.
    ''' </summary>
    ''' <param name="detectedFR">O Frame Rate detectado pelo FFprobe (ex: "23.976 fps").</param>
    ''' <param name="is1080p">True se 1080p estiver selecionado, False se 720p estiver selecionado.</param>
    ''' <returns>Um objeto DNxHDResult com o Bitrate e Frame Rate calculados.</returns>
    Public Function CalculateDNxHDParams(ByVal detectedFR As String, ByVal is1080p As Boolean) As DNxHDResult
        Dim result As New DNxHDResult With {.Bitrate = "45M", .FrameRate = "30000/1001"} ' Valores padrão

        Dim fr As String = detectedFR.Trim()

        If fr.Contains("23") Or fr.Contains("24") Then
            ' 23.976 ou 24.000
            result.FrameRate = "24000/1001" ' 23.976
            If is1080p Then
                result.Bitrate = "36M"
            Else ' 720p
                result.Bitrate = "60M"
            End If
        ElseIf fr.Contains("29") Or fr.Contains("30") Then
            ' 29.97 ou 30.000
            result.FrameRate = "30000/1001" ' 29.97
            If is1080p Then
                result.Bitrate = "45M"
            Else ' 720p
                result.Bitrate = "75M"
            End If
        ElseIf fr.Contains("25") Then
            ' 25.000
            result.FrameRate = "25/1" ' 25.00
            If is1080p Then
                result.Bitrate = "36M"
            Else ' 720p
                result.Bitrate = "60M"
            End If
        End If

        Return result
    End Function

End Module
