Imports System.Data.SqlClient
Imports System.IO

Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fullName As String = txtFullName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim row As Integer


        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30")

        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("insert into RegisterTable([FullName],[UserName],[Password]) values ('" & txtFullName.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "') ", con)
        ' Dim a As New SqlDataAdapter(cmd)
        row = cmd.ExecuteNonQuery()
        Dim dt As New DataTable

        con.Close()
        ' a.Fill(dt)

        If Not String.IsNullOrEmpty(fullName) AndAlso Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            ' Check if the user already exists
            If Not UserExists(username) Then
                ' Append the new user data to a text file (e.g., users.txt)
                Using writer As StreamWriter = File.AppendText("users.txt")
                    writer.WriteLine($"{fullName}:{username}:{password}")
                End Using
                MessageBox.Show("Registration successful.")
                ClearFields()


            Else
                MessageBox.Show("Username already exists. Please choose another.")
            End If
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub
    Private Function UserExists(username As String) As Boolean
        ' Check if the username already exists in the user data file
        If File.Exists("users.txt") Then
            Dim lines As String() = File.ReadAllLines("users.txt")
            For Each line As String In lines
                Dim userData As String() = line.Split(":")
                If userData.Length >= 2 AndAlso userData(1) = username Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub ClearFields()
        ' Clear the input fields
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub llLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLogin.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub chkShowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowpassword.CheckedChanged
        If chkShowpassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class