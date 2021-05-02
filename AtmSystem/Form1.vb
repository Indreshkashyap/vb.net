Option Explicit On
Imports System.Data.OleDb


Public Class Form1
    Dim objcon As New OleDbConnection
    Dim strSQL As String
    Dim strconnection As String = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=E:\ind.accdb"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Date.Now

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If (TextBox1.Text = "") And (TextBox2.Text = "") Then

            MsgBox("please input username and password!")

        ElseIf (TextBox1.Text = "") Then

            MsgBox("please input username!")
        ElseIf (TextBox2.Text = "") Then

            MsgBox("please input password!")
        Else
            Dim strName = TextBox1.Text
            Dim strpass = TextBox2.Text
            With objcon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strconnection
                    .Open()
                End If
            End With
            ds.Clear()
            strSQL = "select * from table1 where username ='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' "
            da = New OleDbDataAdapter(strSQL, objcon)
            da.Fill(ds, "table1")
            If ds.Tables("table1").Rows.Count <> 0 Then


                Form2.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            Else

                MsgBox("username and password invalid")


            End If
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
