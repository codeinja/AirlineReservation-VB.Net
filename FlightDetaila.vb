Imports System.Data
Imports System.Data.SqlClient

Public Class FlightDetaila
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getflight As String
    Dim str As String
    Dim getflight1 As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True;Connect Timeout=30")

        com = New SqlCommand("insert into flight(name,source,dest,d_time,a_time,clas,charg,seats)values('" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Flight Infromation Inserted Successfullyy..")

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        ComboBox3.Text = "--Select--"
        ComboBox4.Text = "--Select--"
        ComboBox5.Text = "--Select--"
        Hide()
        con.Close()
    End Sub

    Private Sub FlightDetaila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Try
            getflight = "SELECT nextID=MAX(Id)+1 FROM flight"
            com = New SqlCommand(getflight, con)
            dr = com.ExecuteReader()
            If dr.Read() Then

                TextBox1.Text = dr.GetValue(0).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
            con.Open()
            str = "DELETE FROM flight WHERE id = '" & TextBox1.Text & "'"

            com = New SqlCommand(Str, con)
            com.ExecuteNonQuery()
            con.Close()
            MsgBox(" Flight Record Delete Successfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = "--Select--"
            ComboBox2.Text = "--Select--"
            ComboBox3.Text = "--Select--"
            ComboBox4.Text = "--Select--"
            ComboBox5.Text = "--Select--"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\OneDrive\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True")
        com = New SqlCommand(" update flight set name='" + TextBox2.Text + "',source='" + ComboBox1.Text + "',dest='" + ComboBox3.Text + "',d_time='" + ComboBox2.Text + "',a_time='" + ComboBox4.Text + "',clas='" + ComboBox5.Text + "',charg='" + TextBox3.Text + "',seats='" + TextBox4.Text + "'", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Flight Record updated Successfully..")
        Hide()
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        ComboBox3.Text = "--Select--"
        ComboBox4.Text = "--Select--"
        ComboBox5.Text = "--Select--"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Desktop\AirlineReservationSystem\AirlineReservationSystem\airline.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Try
            getflight1 = "select name,source,dest,d_time,a_time,clas,charg,seats from flight where id='" & TextBox1.Text & "'"
            com = New SqlCommand(getflight1, con)
            dr = com.ExecuteReader()
            If dr.Read() Then


                TextBox2.Text = dr.GetValue(0).ToString()
                ComboBox1.Text = dr.GetValue(1).ToString()
                ComboBox3.Text = dr.GetValue(2).ToString()
                ComboBox2.Text = dr.GetValue(3).ToString()
                ComboBox4.Text = dr.GetValue(4).ToString()
                ComboBox5.Text = dr.GetValue(5).ToString()
                TextBox3.Text = dr.GetValue(6).ToString()
                TextBox4.Text = dr.GetValue(7).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class