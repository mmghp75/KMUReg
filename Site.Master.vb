Imports KMUReg.SharedConstantClasses
Imports KMUReg.SharedMethodClass

Partial Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Timeout = 120

        If Not Request.PhysicalPath.ToLower.Contains("Login.aspx".ToLower) AndAlso
            Not Request.PhysicalPath.ToLower.Contains("TV.aspx".ToLower) AndAlso
            Session("User") Is Nothing Then
            Response.Redirect("Login.aspx")
        ElseIf lblUser IsNot Nothing And Session("User") IsNot Nothing Then
            lblUser.Text = "کاربر : " & Session("User").FirstNameOf & " " & Session("User").LastNameOf
        End If
        If Me.Parent.Page.AppRelativeVirtualPath.ToLower.Contains("Menu.aspx".ToLower) Then btnMainmenu.Visible = False
    End Sub

    Private Sub btnCancelChangeUserPass_Click(sender As Object, e As EventArgs) Handles btnCancelChangeUserPass.Click
        'hfNewPanelVisibility.Value = 0
        pnlChangeUserPass.Style.Item("display") = "none"
        pnlChangeUserPassBack.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
    End Sub

    Private Sub btnChangeUserPass_Click(sender As Object, e As EventArgs) Handles btnChangeUserPass.Click
        ShowModalPopup(Me, "pnlChangeUserPass", eFocusType.click, ControlIdForFocus:=txtUserName.ClientID)
        'hfNewPanelVisibility.Value = 1

        pnlChangeUserPass.Style.Item("display") = "block"
        pnlChangeUserPass.Attributes("aria-hidden") = "false"
        pnlChangeUserPass.CssClass = "modal fade in"
        pnlChangeUserPassBack.Visible = True
        pnlChangeUserPassMSG.Visible = False
    End Sub

    Private Sub btnLogOff1_Click(sender As Object, e As EventArgs) Handles btnLogOff1.Click, btnLogOff2.Click, btnLogOff3.Click
        Session("User") = Nothing
        Response.Redirect("Login.aspx")
    End Sub

    Private Sub btnMainmenu_Click(sender As Object, e As EventArgs) Handles btnMainmenu.Click
        Server.Transfer("~/Menu.aspx")
    End Sub

    Private Sub btnOKChangeUserPass_Click(sender As Object, e As EventArgs) Handles btnOKChangeUserPass.Click
        If txtUserName.Text.Trim = String.Empty Then
            lblpnlChangeUserPassMSG.Text = "نام کاربری نمی‌تواند خالی باشد."
            pnlChangeUserPassMSG.Visible = True
            txtUserName.Focus()
            Exit Sub
        End If
        If txtPassword.Text.Trim = String.Empty Then
            lblpnlChangeUserPassMSG.Text = "کلمه عبور نمی‌تواند خالی باشد."
            pnlChangeUserPassMSG.Visible = True
            txtPassword.Focus()
            Exit Sub
        End If

        Dim odb As New dbDataContext(ConnectionString)
        Dim oUser = odb.tblUsers.Where(Function(f) f.UserName = txtUserName.Text.Trim.ToLower).FirstOrDefault
        If oUser IsNot Nothing AndAlso oUser.ID <> Session("User").ID Then
            lblpnlChangeUserPassMSG.Text = "نام کاربری انتخاب شده تکراری است. لطفاً یک نام کاربری دیگر انتخاب کنید."
            pnlChangeUserPassMSG.Visible = True
            txtUserName.Focus()
            Exit Sub
        End If

        Dim oID As Integer = Session("User").ID
        oUser = odb.tblUsers.Where(Function(f) f.ID = oID).FirstOrDefault
        oUser.UserName = txtUserName.Text.Trim.ToLower
        oUser.Password = txtPassword.Text
        odb.SubmitChanges()

        btnCancelChangeUserPass_Click(Nothing, Nothing)
    End Sub
End Class

