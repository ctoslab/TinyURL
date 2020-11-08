Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LongURL As String = TextBox1.Text
        Dim webclient As New System.Net.WebClient
        Dim request As String = String.Format("https://tinyurl.com/api-create.php?url=" + LongURL)
        Dim result As String = webclient.DownloadString(request)
        TextBox2.Text = result
    End Sub
End Class
