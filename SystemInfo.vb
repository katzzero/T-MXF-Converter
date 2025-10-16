Imports System.IO
Imports Microsoft.VisualBasic

Module SystemInfo

    ''' <summary>
    ''' Coleta informações do sistema e retorna uma string formatada para o log de inicialização.
    ''' </summary>
    Public Function GetInitializationLog() As String
        Dim log As New System.Text.StringBuilder()
        Dim _totalmem As Integer = CInt(((My.Computer.Info.TotalPhysicalMemory.ToString) / 1024) / 1024)
        Dim _avaimem As Integer = CInt(((My.Computer.Info.AvailablePhysicalMemory.ToString) / 1024) / 1024)
        Dim _mempercent As Integer = CInt((_avaimem / _totalmem) * 100)

        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " Initializing Systems ... ")
        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " Computer name: " & Environment.MachineName)
        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " Operating system: " & My.Computer.Info.OSFullName & " with " & Environment.ProcessorCount & " Logical Processors.")
        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " Operating system version: " & Environment.OSVersion.ToString)
        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " System memory: " & _totalmem.ToString("####,####") & " MBs total with " & _avaimem.ToString("####,####") & " MBs available. " & _mempercent.ToString("##") & "% of total memory can be used for conversion.")
        log.AppendLine(DateAndTime.Now.ToString("HH:mm:ss") & " Hello " & Environment.UserName & "!")
        
        Return log.ToString()
    End Function

End Module
