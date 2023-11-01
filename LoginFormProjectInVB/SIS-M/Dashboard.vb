Public Class Dashboard
    Private ReadOnly _username, _password As String

    Public Sub New(username As String, password As String)
        InitializeComponent()
        '_fullname = fullname
        _username = username
        _password = password
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can customize the dashboard based on the user's data
        'lbfFullName.Text = _fullname

        ' Populate the dashboard with user-specific data here
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class