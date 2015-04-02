Imports System.Data.OleDb
Public Class Form5
    Dim connection As OleDb.OleDbConnection
    Dim mydb, mydb1, mystr As String
    Dim i As Integer = 0
    Dim cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, cb11, cb12, cb13, cb14 As String

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Database1DataSet1.Table1)
        mystr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\meghana gupta\Desktop\Pendrive\Database1.accdb';"
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        Dim row2 As ULong = Rnd() * 10000000000
        Dim query As String = "SELECT * FROM Table1"
        Dim ds As New DataSet
        Dim cmd As New OleDbCommand(query, connection)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Table1")
        Dim t1 As DataTable = ds.Tables("Table1")
        Dim row As DataRow
        For Each row In t1.Rows
            If Math.Round(row2) = row(10) Then
                i = 1
            End If
            'MsgBox(row(10))
        Next
        Do Until i = 0
            i = 0
            row2 = Rnd() * 10000000000
            Dim row1 As DataRow
            For Each row1 In t1.Rows
                If Math.Round(row2) = CLng(row1(10)) Then
                    i = 1
                    Exit For
                End If
            Next
        Loop
        Loan_IdTextBox.Text = Math.Round(row2)
        If Form2.RadioButton1.Checked = True Then
            Type_of_employementTextBox.Text = Form2.RadioButton1.Text
        Else
            Type_of_employementTextBox.Text = Form2.RadioButton2.Text
        End If
        Date_of_BirthDateTimePicker.Value = Form2.DateTimePicker1.Value
        Monthly_IncomeTextBox.Text = Form2.TextBox1.Text
        Rate__pa_TextBox.Text = Form2.Label8.Text
        Number_of_MonthsTextBox.Text = Form2.TextBox4.Text
        PrincipalTextBox.Text = Form2.TextBox2.Text

        If Form4.CheckBox1.Checked = True Then
            cb1 = "Provided"
        Else : cb1 = "-"
        End If
        If Form4.CheckBox2.Checked = True Then
            cb3 = "Provided"
        Else : cb3 = "-"
        End If
        If Form4.CheckBox3.Checked = True Then
            cb4 = "Provided"
        Else : cb4 = "-"
        End If
        If Form4.CheckBox4.Checked = True Then
            cb5 = "Provided"
        Else : cb5 = "-"
        End If
        If Form4.CheckBox5.Checked = True Then
            cb6 = "Provided"
        Else : cb6 = "-"
        End If
        If Form4.CheckBox6.Checked = True Then
            cb7 = "Provided"
        Else : cb7 = "-"
        End If
        If Form4.CheckBox7.Checked = True Then
            cb8 = "Provided"
        Else : cb8 = "-"
        End If
        If Form4.CheckBox8.Checked = True Then
            cb9 = "Provided"
        Else : cb9 = "-"
        End If
        If Form4.CheckBox9.Checked = True Then
            cb10 = "Provided"
        Else : cb10 = "-"
        End If
        If Form4.CheckBox10.Checked = True Then
            cb11 = "Provided"
        Else : cb11 = "-"
        End If
        If Form4.CheckBox11.Checked = True Then
            cb12 = "Provided"
        Else : cb12 = "-"
        End If
        If Form4.CheckBox12.Checked = True Then
            cb13 = "Provided"
        Else : cb13 = "-"
        End If
        If Form4.CheckBox13.Checked = True Then
            cb14 = "Provided"
        Else : cb14 = "-"
        End If
        If Form4.CheckBox14.Checked = True Then
            cb2 = "Provided"
        Else : cb2 = "-"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Table1BindingSource.AddNew()
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

        If Mobile_NumberTextBox.Text <> "" Then
            Try
                Dim mobile As ULong
                mobile = CLng(Mobile_NumberTextBox.Text)
            Catch ex As Exception
                MsgBox("Enter a valid mobile number", MsgBoxStyle.Critical, "Error")
            End Try
        End If
        If Voter_IDTextBox.Text.Trim = "" Or First_NameTextBox.Text.Trim = "" Or Current_AddressTextBox.Text.Trim = "" Or Permanent_AddressTextBox.Text.Trim = "" Or Mobile_NumberTextBox.Text.Trim = "" Or Email_IDTextBox.Text.Trim = "" Then
            MsgBox("All fields are mandatory", MsgBoxStyle.Exclamation, "Please check")
        Else
            Dim DateOfApplying As Date = Now.Date
            Dim mydb2 As String
            mydb = "INSERT INTO Table1 VALUES ('" & Voter_IDTextBox.Text & "','" & First_NameTextBox.Text & "','" & Last_NameTextBox.Text & "','" & Current_AddressTextBox.Text & "','" & Permanent_AddressTextBox.Text & "','" & Date_of_BirthDateTimePicker.Text & "','" & Type_of_employementTextBox.Text & "','" & Mobile_NumberTextBox.Text & "','" & Email_IDTextBox.Text & "','" & Monthly_IncomeTextBox.Text & "','" & Loan_IdTextBox.Text & "','" & PrincipalTextBox.Text & "','" & Rate__pa_TextBox.Text & "','" & Number_of_MonthsTextBox.Text & "','" & DateOfApplying & "','" & Branch_NameComboBox.Text & "','" & PrincipalTextBox.Text & "','" & Form8.dealer & "')"
            mydb1 = "INSERT INTO Table4 VALUES ('" & Voter_IDTextBox.Text & "','" & cb1 & "','" & cb2 & "','" & cb3 & "','" & cb4 & "','" & cb5 & "','" & cb6 & "','" & cb7 & "','" & cb8 & "','" & cb9 & "','" & cb10 & "','" & cb11 & "','" & cb12 & "','" & cb13 & "','" & cb14 & "')"
            mydb2 = "INSERT INTO Table3 VALUES ('" & Loan_IdTextBox.Text & "','" & Voter_IDTextBox.Text & "','" & PrincipalTextBox.Text & "','" & 0 & "','" & 0 & "','" & PrincipalTextBox.Text & "','" & Now.Date - Now.TimeOfDay & "','" & 0 & "')"
            Dim run, run1, run2 As New OleDb.OleDbCommand
            Try
                run = New OleDbCommand(mydb, connection)
                run1 = New OleDbCommand(mydb1, connection)
                run2 = New OleDbCommand(mydb2, connection)
                run.ExecuteNonQuery()
                run1.ExecuteNonQuery()
                run2.ExecuteNonQuery()
                MsgBox("Your account has been registered", MsgBoxStyle.Information, "Registered")
                Form2.Close()
                Form4.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Permanent_AddressTextBox.Text = Current_AddressTextBox.Text
        Else
            Permanent_AddressTextBox.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Close()
        Form4.Close()
        Me.Close()
    End Sub

    Private Sub Form5_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class