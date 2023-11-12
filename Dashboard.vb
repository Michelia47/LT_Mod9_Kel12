Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Dashboard
    Public Sub update()
        Try
            Dim url As String = "http://localhost/tugasmod9_12/api/register/" + TextBox1.Text + "/" + TextBox2.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("Berhasil Update", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Error")
        End Try
    End Sub
    Public Sub delete()
        Try
            Dim url As String = "http://localhost/tugasmod9_12/api/register/" + TextBox1.Text + "/" + TextBox2.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "DELETE"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("Berhasil Delete", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Error")
        End Try
    End Sub
    Public Sub logout()
        Form1.Show()
        Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        logout()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        update()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete()
    End Sub
End Class