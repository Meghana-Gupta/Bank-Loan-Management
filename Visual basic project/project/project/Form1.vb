Public Class Form1
    Public i As Integer
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        i = 0
        Form8.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Size = New Size(190, 160)
        PictureBox1.Size = New Size(170, 110)
    End Sub


    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(134, 50)
        PictureBox1.Size = New Size(124, 87)
        'TextBox1.Visible = False
        'TextBox2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        i = 0
        Form8.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox3.Size = New Size(154, 60)
        PictureBox1.Size = New Size(134, 97)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox3.Size = New Size(134, 50)
        PictureBox1.Size = New Size(124, 87)
        'TextBox1.Visible = False
        'TextBox2.Visible = False
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox4.Size = New Size(154, 60)
        PictureBox2.Size = New Size(134, 97)
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox4.Size = New Size(134, 50)
        PictureBox2.Size = New Size(124, 87)
        'TextBox1.Visible = False
        'TextBox2.Visible = False
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Size = New Size(154, 60)
        PictureBox2.Size = New Size(134, 97)
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(134, 50)
        PictureBox2.Size = New Size(124, 87)
        'TextBox1.Visible = False
        'TextBox2.Visible = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        i = 1
        Form8.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        i = 1
        Form8.ShowDialog()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox3.Size = New Size(154, 60)
        PictureBox1.Size = New Size(134, 97)
        PictureBox4.Size = New Size(134, 50)
        PictureBox2.Size = New Size(124, 87)
    End Sub



    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox4.Size = New Size(154, 60)
        PictureBox2.Size = New Size(134, 97)
        PictureBox3.Size = New Size(134, 50)
        PictureBox1.Size = New Size(124, 87)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
