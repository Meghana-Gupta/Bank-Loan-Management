Public Class Form8
    Public dealer As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Form1.i = 0 And TextBox1.Text = "11111") Or (Form1.i = 1 And TextBox1.Text = "22222") Or (Form1.i = 1 And TextBox1.Text = "33333") Then
            If Form1.i = 0 Then
                dealer = "Ramesh"
            ElseIf Form1.i = 1 And TextBox1.Text = "22222" Then
                dealer = "Vijay"
            Else
                dealer = "Suriya"
            End If
            Form3.Show()
            'Me.Hide()
        Else
            MsgBox("It seems that you are not the correct user", MsgBoxStyle.Exclamation, "Enter the password correctly")
        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Me.Location = New Point(300, 300)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Me.Close()
    End Sub
End Class