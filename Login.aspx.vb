
Imports System.Globalization

Partial Class Login
    Inherits System.Web.UI.Page

    Private odb As New dbDataContext(ConnectionString)
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUserName.Focus()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim oUser = (From o In odb.tblUsers Where o.UserName = txtUserName.Text And o.Password = txtPassword.Text).FirstOrDefault
        If oUser Is Nothing Then
            divMessage.Visible = True
            Session("User") = Nothing
        Else
            Session("User") = oUser
            Server.Transfer("~/Menu.aspx")
        End If
    End Sub
End Class
