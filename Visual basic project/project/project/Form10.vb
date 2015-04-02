Imports System.Data.OleDb

Public Class Form10
    Dim connection As OleDb.OleDbConnection
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geethathangam31\Documents\Database1.accdb"
        connection = New OleDb.OleDbConnection(str)
        connection.Open()
        Dim query As String = "delete from Table1 where VoterID='" & Voter_IDTextBox.Text & "'and LoanId='" & Loan_IdTextBox.Text & "'"
        Dim query1 As String = "delete from Table4 where voterid='" & Voter_IDTextBox.Text & "'"
        Dim query2 As String = "delete from Table3 where voterID='" & Voter_IDTextBox.Text & "' and LoanId='" & Loan_IdTextBox.Text & "'"
        'Dim ds As New DataSet
        Dim cmd, cmd1, cmd2 As New OleDbCommand
        cmd = New OleDbCommand(query, connection)
        cmd1 = New OleDbCommand(query1, connection)
        cmd2 = New OleDbCommand(query2, connection)
        'Dim da As New OleDbDataAdapter(cmd)
        'da.Fill(ds, "Table1")
        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MsgBox("All documents of selected rows are deleted")
        Me.Close()

    End Sub

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Database1DataSet1.Table1)

    End Sub
End Class