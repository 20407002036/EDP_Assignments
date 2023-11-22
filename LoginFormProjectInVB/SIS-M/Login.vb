Imports System.Data.SqlClient
Imports System.IO
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30")

        Dim cmd As SqlCommand = New SqlCommand("select * from RegisterTable", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)


        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            ' Check if the user exists and the password matches
            con.Open()
            ' If UserExists(username, password) Then
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("Login successful.")
                ClearFields()
                con.Close()

                ' Open the dashboard form and pass user data
                Dim dashboardForm As New Dashboard(username, password)
                dashboardForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub
    Private Function UserExists(username As String, password As String) As Boolean
        ' Check if the username and password match the data in the user data file
        If File.Exists("users.txt") Then
            Dim lines As String() = File.ReadAllLines("users.txt")
            For Each line As String In lines
                Dim userData As String() = line.Split(":")
                If userData.Length >= 3 AndAlso userData(1) = username AndAlso userData(2) = password Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub ClearFields()
        ' Clear the input fields
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub llRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llRegister.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub chkShowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowpassword.CheckedChanged
        If chkShowpassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
