Imports System.Data.OleDb
Public Class Form6
    Dim connection As OleDb.OleDbConnection
    Dim mystr As String
    Dim i As Integer
    Dim x As Integer

    Private Sub Table3BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table3BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table3BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Table3' table. You can move, or remove it, as needed.
        'Me.Table3TableAdapter.Fill(Me.Database1DataSet1.Table3)
        PrincipalTextBox.Enabled = False
        InterestTextBox.Enabled = False
        Amount_PaidTextBox.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query As String
        If Loan_IDTextBox.Text.Trim = "" And Voter_IDTextBox.Text.Trim = "" Then
            MsgBox("Enter either loan id or personal id to fetch the details")
        Else
            mystr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geethathangam31\Documents\Database1.accdb"
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()

            'If Loan_IDTextBox.Text.Trim = "" Then
            '    query = "SELECT * FROM Table3"
            'Else
            '    query = "SELECT * FROM Table3"
            'End If
            query = "SELECT * FROM Table3"
            Dim ds As New DataSet
            Dim cmd As New OleDbCommand(query, connection)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "Table3")
            Dim t1 As DataTable = ds.Tables("Table3")
            Dim row As DataRow

            Dim loan As String = ""
            Dim voter As String = ""
            Dim principal As String = ""
            Try
                For Each row In t1.Rows
                    If row(0) = Loan_IDTextBox.Text Or row(1) = Voter_IDTextBox.Text Then
                        loan = row(0)
                        voter = row(1)
                        principal = row(5)
                        x = CInt(row(7))
                    End If
                Next
            Catch ex As Exception
                MsgBox("Enter correct id")
            End Try
            Loan_IDTextBox.Text = loan
            Voter_IDTextBox.Text = voter
            PrincipalTextBox.Text = principal

            Dim SI, EMI, temp, rate, NumOfMon, temp1 As Decimal
            Dim query1 As String = "SELECT * FROM Table1"
            Dim row1 As DataRow
            cmd = New OleDbCommand(query1, connection)
            da = New OleDbDataAdapter(cmd)
            da.Fill(ds, "Table1")
            t1 = ds.Tables("Table1")
            Try
                For Each row1 In t1.Rows
                    If row1(0) = Voter_IDTextBox.Text And row1(10) = Loan_IDTextBox.Text Then
                        rate = row1(12)
                        NumOfMon = row1(13)
                        Exit For
                    End If
                Next
            Catch ex As Exception
                MsgBox("Enter correct id")
            End Try
            SI = principal * rate / 100 / 12
            temp1 = rate / 12 / 100
            temp = Math.Pow((1 + temp1), NumOfMon)
            EMI = principal * temp1 * (temp / (temp - 1))
            TextBox1.Text = Math.Round(SI, 2)
            TextBox2.Text = Math.Round(EMI - SI, 2)
            TextBox3.Text = Math.Round(EMI, 2)
            InterestTextBox.Enabled = True
            Amount_PaidTextBox.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If InterestTextBox.Text.Trim = "" Or Amount_PaidTextBox.Text.Trim = "" Then
            MsgBox("Enter the amount")
        Else
            Dim InstQuery As String
            Dim bal As UInteger = CDec(PrincipalTextBox.Text) - CDec(InterestTextBox.Text) - CDec(Amount_PaidTextBox.Text)

            InstQuery = "INSERT INTO Table3 VALUES ('" & Loan_IDTextBox.Text & "','" & Voter_IDTextBox.Text & "','" & PrincipalTextBox.Text & "','" & InterestTextBox.Text & "','" & Amount_PaidTextBox.Text & "','" & bal & "','" & Now.Date - Now.TimeOfDay & "','" & x + 1 & "')"
                Dim run As New OleDb.OleDbCommand
                Try
                    run = New OleDbCommand(InstQuery, connection)
                    run.ExecuteNonQuery()
                    MsgBox("Your account has been saved", MsgBoxStyle.Information, "Registered")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try

            Dim i As Integer = 0
            Dim query As String
            query = "SELECT * FROM Table3 where  LoanID='" & Loan_IDTextBox.Text & "'" & " and voterID = '" & Voter_IDTextBox.Text & "'"
            Dim ds As New DataSet
            Dim cmd As New OleDbCommand(query, connection)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "Table3")
            Dim row As DataRow
            Dim t1 As DataTable = ds.Tables("Table3")
            For Each row In t1.Rows
                'If row(0) = Loan_IDTextBox.Text Or row(1) = Voter_IDTextBox.Text Then
                If row(5) = 0 Then
                    i = 1
                End If
                'End If
            Next
            If i = 1 Then
                query = "update Table1 set BalancePrincipal=0 where VoterID='" & Voter_IDTextBox.Text & "'" & "and LoanId='" & Loan_IDTextBox.Text & "'"
                Dim run1 As OleDbCommand
                run1 = New OleDbCommand(query, connection)
                run1.ExecuteNonQuery()
            End If
        End If
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Form6_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class