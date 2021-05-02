Imports System.Data.OleDb
Public Class Form10
    Dim con As New OleDbConnection
    Private Sub form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=E:\ind.accdb"
        con.Open()
        showItems()
    End Sub
    Private Sub showItems()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM table1", con)
        da.Fill(dt)
        Label4.Text = dt.Rows(0).Item(3)
       
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Date.Now

    End Sub
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form8.Show()
        Me.Close()
    End Sub
End Class