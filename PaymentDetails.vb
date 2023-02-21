Imports System.Data
Imports System.Data.SqlClient

Public Class PaymentDetails
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim str As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
        If (RadioButton1.Checked = True) Then
            str = "Cheque"
        ElseIf (RadioButton2.Checked = True) Then
            str = "Credit"
        Else
            str = "Cash"
        End If

        com = New SqlCommand("insert into payment(t_id,c_id,f_id,amount,mode)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & str & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Payment Infromation Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class