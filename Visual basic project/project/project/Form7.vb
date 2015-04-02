Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form7
    Dim connection As OleDb.OleDbConnection
    Dim mystr As String
    Private Sub Table3BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table3BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table3BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'Database1DataSet1.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Database1DataSet1.Table1)
        ''TODO: This line of code loads data into the 'Database1DataSet1.Table3' table. You can move, or remove it, as needed.
        'Me.Table3TableAdapter.Fill(Me.Database1DataSet1.Table3)
        Me.Size = New Size(474, 399)
        First_NameTextBox.Enabled = False
        Balance_PrincipalTextBox.Enabled = False
        mystr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=&quot;C:\Users\meghana gupta\Desktop\Pendrive\Database1.accdb&quot;"
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Loan_IDTextBox.Text.Trim = "" And Voter_IDTextBox.Text.Trim = "" Then
            MsgBox("Enter either loan id or personal id to fetch the details")
        Else
            Dim query As String
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
                    End If
                Next
            Catch ex As Exception
                MsgBox("Enter correct id")
            End Try
            Loan_IDTextBox.Text = loan
            Voter_IDTextBox.Text = voter
            Balance_PrincipalTextBox.Text = principal
            Dim query1 As String = "SELECT * FROM Table1"
            Dim row1 As DataRow
            cmd = New OleDbCommand(query1, connection)
            da = New OleDbDataAdapter(cmd)
            da.Fill(ds, "Table1")
            t1 = ds.Tables("Table1")
            Try
                For Each row1 In t1.Rows
                    If row1(0) = Voter_IDTextBox.Text And row1(10) = Loan_IDTextBox.Text Then
                        First_NameTextBox.Text = row1(1)
                        Exit For
                    End If
                Next
            Catch ex As Exception
                MsgBox("Enter correct id")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Size = New Size(877, 399)
        Dim query As String
        query = "SELECT Months,Principal,Interest,AmountPaid,DateOfPayment FROM Table3 where LoanID='" & Loan_IDTextBox.Text & "'" & " and voterID = '" & Voter_IDTextBox.Text & "'"
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Dim cmd As New OleDbCommand(query, connection)
        Dim da As New OleDbDataAdapter(cmd)
        'da.Fill(ds, "Table3")
        'Dim t1 As DataTable = ds.Tables("Table3")
        Dim cmdbuilder As New OleDbCommandBuilder(da)
        da.Fill(ds, "Table3")
        bs.DataSource = ds.Tables(0)
        DataGridView1.DataSource = bs
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Loan_IDTextBox.Text = ""
        Voter_IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        Balance_PrincipalTextBox.Text = ""
        Me.Size = New Size(474, 399)
    End Sub
End Class