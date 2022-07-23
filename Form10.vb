Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load()
        con.ConnectionString = Data Source=(LocalDB)\v11.0;AttachDbFilename="ALMIGHTY;Initial Catalog=testDB;Integrated Security=True"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click()
    If MessageBox.Show("Do you really want to delete this record?", "Delete",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
        Windows.Forms.DialogResult.No Then
            MsgBox("operation canceled")
            Exit Sub
        End If
        con.Open()
        cmd = New SqlCommand("Delete from playground WHERE turf_name=" & Label1.Text, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record is successfully deleted")
        Else
            MessageBox.Show("Record id not deleted")
        End If
        con.Close()
    End Sub
End Class