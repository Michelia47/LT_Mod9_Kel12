Imports System.Net
Imports System.IO

Public Class Form1
    Public Sub login()
        Try
            Dim url As String = "http://localhost/tugasmod9_12/api/login/" + TextBox1.Text + "/" + TextBox2.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd

            If return_api = "Berhasil Login" Then
                MessageBox.Show(return_api, "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.Show()
                Hide()
                TextBox1.Text = ""
                TextBox2.Text = ""
            ElseIf return_api = "Username atau Password Salah !" Then
                MessageBox.Show(return_api, "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Error")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register.Show()
        Hide()
    End Sub
End Class
