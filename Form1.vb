Public Class frmTMXF

    Private Sub frmTMXF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show version on label
        lblVersion.Text = "V." & Application.ProductVersion

        'Check if FFmpeg path is Ok and if not do this
        If txtFFmpeg.Text = "c:FFmpeg" Then
            If My.Settings.ffmpegpath.Length = 0 Then
                OpenFFmpegDialog.ShowDialog()
                txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
                My.Settings.ffmpegpath = OpenFFmpegDialog.FileName.ToString
                btnChk3.BackColor = Color.Green
            Else
                txtFFmpeg.Text = My.Settings.ffmpegpath.ToString
                btnChk3.BackColor = Color.Green
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

    End Sub

    Private Sub btnLoadMXF_Click(sender As Object, e As EventArgs) Handles btnLoadMXF.Click
        If OpenMXFDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMXFpath.Text = OpenMXFDialog.FileName.ToString
            btnSaveOut.Enabled = True
        End If
        If System.IO.File.Exists(txtMXFpath.Text) Then
            btnChk1.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnSaveOut_Click(sender As Object, e As EventArgs) Handles btnSaveOut.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOutPath.Text = FolderBrowserDialog.SelectedPath.ToString
            btnChk2.BackColor = Color.Green
        End If

    End Sub

    Private Sub btnFFmpeg_Click(sender As Object, e As EventArgs) Handles btnFFmpeg.Click
        If OpenFFmpegDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFFmpeg.Text = OpenFFmpegDialog.FileName.ToString
            My.Settings.ffmpegpath = txtFFmpeg.Text.ToString

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
End Class
