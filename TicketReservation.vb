Imports System.Data
Imports System.Data.SqlClient

Public Class TicketReservation
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim gettick As String
    Dim getcust As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")


        com = New SqlCommand("insert into ticketres(c_id,name,f_name,gen,dob,mob,addr,doj,f_id,s_no)values('" & TextBox2.Text & "','" & Label13.Text & "','" & Label14.Text & "','" & Label15.Text & "','" & Label16.Text & "','" & Label17.Text & "','" & Label18.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Ticket Reservation Infromation Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label25.Text = ""

    End Sub

    Private Sub TicketReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
        con.Open()

        Try
            gettick = "SELECT nextID=MAX(Id)+1 FROM ticketres"
            com = New SqlCommand(gettick, con)
            dr = com.ExecuteReader()
            If dr.Read() Then

                TextBox1.Text = dr.GetValue(0).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Try
            getcust = "select name,f_name,gen,dob,mob,addr from customer where id='" & TextBox2.Text & "'"
            com = New SqlCommand(getcust, con)
            dr = com.ExecuteReader()
            If dr.Read() Then


                Label20.Text = dr.GetValue(0).ToString()
                Label21.Text = dr.GetValue(1).ToString()
                Label22.Text = dr.GetValue(2).ToString()
                Label23.Text = dr.GetValue(3).ToString()
                Label24.Text = dr.GetValue(4).ToString()
                Label25.Text = dr.GetValue(5).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label25.Text = ""
    End Sub

End Class