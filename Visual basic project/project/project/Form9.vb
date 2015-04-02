Imports System.Data.OleDb

Public Class Form9
    Dim connection As OleDb.OleDbConnection
    Dim mystr As String
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mystr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\meghana gupta\Desktop\Pendrive\Database1.accdb';"
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()
        Dim query As String
        query = "SELECT VoterID,FirstName,LastName,DateOfBirth,TypeOfemployement,MobileNumber,EmailID,MonthlyIncome,Principal,LoanId FROM Table1 where BalancePrincipal=0"
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Dim cmd As New OleDbCommand(query, connection)
        Dim da As New OleDbDataAdapter(cmd)
        'da.Fill(ds, "Table3")
        'Dim t1 As DataTable = ds.Tables("Table3")
        Dim cmdbuilder As New OleDbCommandBuilder(da)
        da.Fill(ds, "Table1")
        bs.DataSource = ds.Tables(0)
        DataGridView1.DataSource = bs
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form10.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query As String
        query = "SELECT VoterID,FirstName,LastName,DateOfBirth,TypeOfemployement,MobileNumber,EmailID,MonthlyIncome,Principal,LoanId FROM Table1 where BalancePrincipal=0"
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Dim cmd As New OleDbCommand(query, connection)
        Dim da As New OleDbDataAdapter(cmd)
        'da.Fill(ds, "Table3")
        'Dim t1 As DataTable = ds.Tables("Table3")
        Dim cmdbuilder As New OleDbCommandBuilder(da)
        da.Fill(ds, "Table1")
        bs.DataSource = ds.Tables(0)
        DataGridView1.DataSource = bs
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class