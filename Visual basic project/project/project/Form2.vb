Public Class Form2
    Dim age As Integer
    Dim EMI As Decimal
    Dim rate As Decimal
    Dim NoOfMonths As Decimal
    Dim a(1), b(1) As Double

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        GroupBox2.Enabled = False
        a(0) = 0
        b(0) = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim age1 As Integer
        Dim temp As Decimal
        Dim temp1 As Decimal
        Dim x(1) As Double
        Dim y(1) As Double
        Button3.Enabled = False
        If TextBox1.Text = "" Then
            TextBox1.Text = 0
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = 0
        End If
        If TextBox3.Text = "" Then
            TextBox3.Text = 0
        End If
        age1 = age + CDec(TextBox4.Text) / 12
        If CDec(TextBox4.Text) < 6 Then
            MsgBox("Number of months should be atleast 5")
        ElseIf RadioButton1.Checked = True And CDec(TextBox1.Text) - CDec(TextBox3.Text) < 15000 Then
            MsgBox("You are not eligible for having the loan. Since your monthly income(except EMI) must be greater than 15000")
        ElseIf RadioButton2.Checked = True And CDec(TextBox1.Text) - CDec(TextBox3.Text) < 17000 Then
            MsgBox("You are not eligible for having the loan. Since your monthly income(except EMI) must be greater than 17000")
        ElseIf RadioButton1.Checked = True And age1 > 58 Then
            MsgBox("You are not eligible for having the loan. Since your age exceeds the limited period before your last due date")
        ElseIf RadioButton2.Checked = True And age1 > 65 Then
            MsgBox("You are not eligible for having the loan. Since your age exceeds the limited period before your last due date")
        Else
            temp = CDec(TextBox1.Text) - CDec(TextBox3.Text)
            EMI = temp / 100 * (40)
            rate = CDec(Label8.Text) / 12 / 100
            NoOfMonths = CDec(TextBox4.Text)
            temp1 = Math.Pow((1 + rate), NoOfMonths)
            Label12.Text = Math.Round(EMI * (temp1 - 1) / rate / temp1, 2)
            x(0) = CDec(Label12.Text)
            y(0) = CDec(TextBox2.Text)
            Chart2.Series.Item(0).Points.Item(1).YValues = x
            Chart2.Series(0).Points(0).YValues = y
            If CDec(TextBox2.Text) < CDec(Label12.Text) Then
                Label16.Text = "Surplus"
                Label17.Text = CDec(Label12.Text) - CDec(TextBox2.Text)
                Button3.Enabled = True
            Else
                Label16.Text = "Deficit"
                Label17.Text = CDec(TextBox2.Text) - CDec(Label12.Text)
                MsgBox("you are not eligible for your requested amount cannot be issued")
                Button3.Enabled = False
            End If
        End If
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox4.Text = HScrollBar2.Value
    End Sub

    Private Sub HScrollBar3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        TextBox2.Text = HScrollBar3.Value
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = 0
        End If
        Try
            HScrollBar1.Value = TextBox1.Text
        Catch ex As Exception
            MsgBox("Enter the vlaue within 10000000")
        End Try
        Button3.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.Text = 0
        End If
        Try
            HScrollBar2.Value = TextBox4.Text
        Catch ex As Exception
            MsgBox("Enter the months within 500")
        End Try
        Button3.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox2.Text = 0
        End If
        Try
            HScrollBar3.Value = TextBox2.Text
        Catch ex As Exception
            MsgBox("ENter the value below 10000000")
            HScrollBar3.Value = 0
            TextBox2.Text = 0
        End Try


        Button3.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With DateTimePicker1.Value
            Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
            age = Now.Year - .Year
            If celebrate > Now Then age -= 1
        End With
        If RadioButton1.Checked = True And (age < 21 Or age > 58) Then
            MsgBox("You are not eligible for having the loan. Since your age must be within 21-58")
        ElseIf RadioButton2.Checked = True And (age < 25 Or age > 65) Then
            MsgBox("You are not eligible for having the loan. Since your age must be within 25-65")
        Else
            GroupBox2.Enabled = True
            Button3.Enabled = False
        End If
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
        Label12.Text = 0
        GroupBox2.Enabled = False
        Label17.Text = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label12.Text = 0
        GroupBox2.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label12.Text = 0
        GroupBox2.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            TextBox3.Text = "0"
        End If
        Button3.Enabled = False
        Chart2.Series(0).Points(0).YValues = a
        Chart2.Series(0).Points(1).YValues = b
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        RadioButton1.Checked = True
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        GroupBox2.Enabled = False
        Label12.Text = "0"
        Label17.Text = "0"
        Label16.Text = "Surplus"
        DateTimePicker1.Value = Now.Date
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.ShowDialog()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Chart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart2.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class