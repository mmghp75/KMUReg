Imports System.Globalization
Imports KMUReg.SharedConstantClasses

Public Class Menu
    Inherits System.Web.UI.Page

    Private odb As New dbDataContext(ConnectionString)
    Private oUser As tblUser
    Public WithEvents txtDateOf As Global.Rayavaran.RWControls.DateTimePicker
    Public WithEvents ddlShift As DropDownList
    Private Sub SetProviderShift()
        Dim oID As Integer = Session("User").ID
        oUser = (From o In odb.tblUsers Where o.ID = oID).FirstOrDefault
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("User") IsNot Nothing Then
                Dim oID As Integer = Session("User").ID
                oUser = (From o In odb.tblUsers Where o.ID = oID).FirstOrDefault

                Dim oDate = SharedMethodClass.Getdate
                txtDateOf.SetFromMiladiValue(SharedMethodClass.Getdate())

                Dim visibleControlList As New List(Of HtmlAnchor)

                visibleControlList.Add(lblNew)
                btnNew.Visible = True
                lblNew.Visible = True
                visibleControlList.Add(lblReports)
                btnReports.Visible = True
                lblReports.Visible = True
                visibleControlList.Add(lblEdit)
                btnEdit.Visible = True
                lblEdit.Visible = True

                rotateControls(visibleControlList)

            Else
                Response.Redirect("~/Login.aspx")
            End If
        End If
    End Sub
    Private Sub rotateControls(visibleControlList As List(Of HtmlAnchor))
        Dim oDegre As Integer = 360 / visibleControlList.Distinct.Count

        Dim i As Integer = 0
        For Each item As HtmlAnchor In visibleControlList.Distinct
            Dim val As Integer = ((i * oDegre) - 90)
            item.Style.Add("transform", "rotate(" & val & "deg) translate(12em) rotate(" & -val & "deg)")
            i += 1
        Next
    End Sub
    Private Sub lblAdmission_ServerClick(sender As Object, e As EventArgs) Handles lblNew.ServerClick
        Dim oID As Integer = Session("User").ID
        oUser = (From o In odb.tblUsers Where o.ID = oID).FirstOrDefault

        Dim _str = "RegPatient.aspx"
        Response.Redirect(_str)
    End Sub
    Private Sub lblReports_ServerClick(sender As Object, e As EventArgs) Handles lblReports.ServerClick
        Dim oID As Integer = Session("User").ID
        oUser = (From o In odb.tblUsers Where o.ID = oID).FirstOrDefault

        Dim _str = "Reports.aspx"
        Response.Redirect(_str)
    End Sub
    Private Sub lblEdit_ServerClick(sender As Object, e As EventArgs) Handles lblEdit.ServerClick
        Dim oID As Integer = Session("User").ID
        oUser = (From o In odb.tblUsers Where o.ID = oID).FirstOrDefault

        Dim _str = "EditData.aspx"
        Response.Redirect(_str)
    End Sub
End Class