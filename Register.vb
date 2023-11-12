Imports System.IO
Imports System.Net

Public Class Register
    Public Sub register()
        Try
            Dim url As String = "http://localhost/tugasmod9_12/api/register/" + TextBox1.Text + "/" + TextBox2.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("Berhasil Register", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Error")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        register()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class