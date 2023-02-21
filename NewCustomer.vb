Imports System.Data
Imports System.Data.SqlClient

Public Class NewCustomer
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim str As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True;Connect Timeout=30")
        If (RadioButton1.Checked = True) Then
            Str = "Male"
        Else
            Str = "Female"
        End If

        com = New SqlCommand("insert into customer(name,f_name,gen,dob,mob,addr)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & str & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("New Customer Infromation Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class