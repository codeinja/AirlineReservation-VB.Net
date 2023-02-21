Imports System.Data
Imports System.Data.SqlClient

Public Class Report
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim cust As Object
    Dim res As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
                str = "SELECT * FROM customer WHERE id = '" + TextBox2.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, cust)
            End Using
            TextBox2.Text = ""
            ComboBox1.Text = "--Select--"
        ElseIf ComboBox1.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
                str = "SELECT * FROM ticketres WHERE id = '" + TextBox2.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, res)
            End Using
            TextBox2.Text = ""
            ComboBox1.Text = "--Select--"
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
                str = "SELECT * FROM customer "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, cust)
            End Using
        ElseIf ComboBox1.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
                str = "SELECT * FROM ticketres"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, res)
            End Using
            TextBox2.Text = ""
            ComboBox1.Text = "--Select--"
        End If
    End Sub
End Class