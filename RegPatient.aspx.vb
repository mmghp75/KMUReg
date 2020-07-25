Imports KMUReg.SharedMethodClass
Public Class RegPatient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim value = hfExpanedPanelIds.Value
    End Sub
    Private Sub cbxSore01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSore01.CheckedChanged
        If cbxSore01.Checked Then
            ShowModalPopup(Me, "pnlSore01")
            hfNewPanelVisibility.Value = 1

            pnlSore01.Style.Item("display") = "block"
            pnlSore01.Attributes("aria-hidden") = "false"
            pnlSore01.CssClass = "modal fade in"
            pnlSore01Back.Visible = True
        End If

        GetStep2Panels()
    End Sub
    Private Sub cbxLaser01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLaser01.CheckedChanged
        If cbxLaser01.Checked Then
            ShowModalPopup(Me, "pnlLaser01")
            hfNewPanelVisibility.Value = 1

            pnlLaser01.Style.Item("display") = "block"
            pnlLaser01.Attributes("aria-hidden") = "false"
            pnlLaser01.CssClass = "modal fade in"
            pnlLaser01Back.Visible = True
        End If
    End Sub
    Private Sub cbxDebrid01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDebrid01.CheckedChanged
        If cbxDebrid01.Checked Then
            ShowModalPopup(Me, "pnlDebrid01")
            hfNewPanelVisibility.Value = 1

            pnlDebrid01.Style.Item("display") = "block"
            pnlDebrid01.Attributes("aria-hidden") = "false"
            pnlDebrid01.CssClass = "modal fade in"
            pnlDebrid01Back.Visible = True
        End If
    End Sub
    Private Sub cbxGangrene01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGangrene01.CheckedChanged
        If cbxGangrene01.Checked Then
            ShowModalPopup(Me, "pnlGang01")
            hfNewPanelVisibility.Value = 1

            pnlGang01.Style.Item("display") = "block"
            pnlGang01.Attributes("aria-hidden") = "false"
            pnlGang01.CssClass = "modal fade in"
            pnlGang01Back.Visible = True
        End If
    End Sub
    Private Sub cbxSurgery01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSurgery01.CheckedChanged
        If cbxSurgery01.Checked Then
            ShowModalPopup(Me, "pnlSurg01")
            hfNewPanelVisibility.Value = 1

            pnlSurg01.Style.Item("display") = "block"
            pnlSurg01.Attributes("aria-hidden") = "false"
            pnlSurg01.CssClass = "modal fade in"
            pnlSurg01Back.Visible = True
        End If
    End Sub
    Private Sub cbxAmp01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAmp01.CheckedChanged
        If cbxAmp01.Checked Then
            ShowModalPopup(Me, "pnlAmp01")
            hfNewPanelVisibility.Value = 1

            pnlAmp01.Style.Item("display") = "block"
            pnlAmp01.Attributes("aria-hidden") = "false"
            pnlAmp01.CssClass = "modal fade in"
            pnlAmp01Back.Visible = True
        End If
    End Sub
    Private Sub cbxInPatient01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxInPatient.CheckedChanged
        If cbxInPatient.Checked Then
            ShowModalPopup(Me, "pnlInPatient01")
            hfNewPanelVisibility.Value = 1

            pnlInPatient01.Style.Item("display") = "block"
            pnlInPatient01.Attributes("aria-hidden") = "false"
            pnlInPatient01.CssClass = "modal fade in"
            pnlInPatient01Back.Visible = True
        End If
    End Sub
    Private Sub btnOKSore01_Click(sender As Object, e As EventArgs) Handles btnOKSore01.Click
        If lblSore01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlSore01.Style.Item("display") = "none"
            pnlSore01Back.Visible = False
        End If

        btnCancelSore01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSore01_Click(sender As Object, e As EventArgs) Handles btnCancelSore01.Click
        hfNewPanelVisibility.Value = 0
        pnlSore01.Style.Item("display") = "none"
        pnlSore01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSore01.Checked = False

        GetStep2Panels()
    End Sub

    Private Sub GetStep2Panels()
        Dim panels = {
            New CollapsePanelGroup(pnlHistory, lblHistoryTitle, collapseHistoryMessage),
            New CollapsePanelGroup(pnlPhysicalExam, lblPhysicalExamTitle, collapsePhysicalExam),
            New CollapsePanelGroup(pnlLabResults, lblLabResultsTitle, collapseLabResults),
            New CollapsePanelGroup(pnlPrescription, lblPrescriptionTitle, collapsePrescription)
        }
        ExpandPanel(Me, panels, hfExpanedPanelIds.Value.Split(" "))
    End Sub

    Private Sub btnOKLaser01_Click(sender As Object, e As EventArgs) Handles btnOKLaser01.Click
        If lblLaser01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlLaser01.Style.Item("display") = "none"
            pnlLaser01Back.Visible = False
        End If

        btnCancelLaser01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelLaser01_Click(sender As Object, e As EventArgs) Handles btnCancelLaser01.Click
        hfNewPanelVisibility.Value = 0
        pnlLaser01.Style.Item("display") = "none"
        pnlLaser01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxLaser01.Checked = False
    End Sub
    Private Sub btnOKDebrid01_Click(sender As Object, e As EventArgs) Handles btnOKDebrid01.Click
        If lblDebrid01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlDebrid01.Style.Item("display") = "none"
            pnlDebrid01Back.Visible = False
        End If

        btnCancelDebrid01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelDebrid01_Click(sender As Object, e As EventArgs) Handles btnCancelDebrid01.Click
        hfNewPanelVisibility.Value = 0
        pnlDebrid01.Style.Item("display") = "none"
        pnlDebrid01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxDebrid01.Checked = False
    End Sub
    Private Sub btnOKSurg01_Click(sender As Object, e As EventArgs) Handles btnOKSurg01.Click
        If lblSurg01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlSurg01.Style.Item("display") = "none"
            pnlSurg01Back.Visible = False
        End If

        btnCancelSurg01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSurg01_Click(sender As Object, e As EventArgs) Handles btnCancelSurg01.Click
        hfNewPanelVisibility.Value = 0
        pnlSurg01.Style.Item("display") = "none"
        pnlSurg01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSurgery01.Checked = False
    End Sub
    Private Sub btnOKGang01_Click(sender As Object, e As EventArgs) Handles btnOKGang01.Click
        If lblGang01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlGang01.Style.Item("display") = "none"
            pnlGang01Back.Visible = False
        End If

        btnCancelGang01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelGang01_Click(sender As Object, e As EventArgs) Handles btnCancelGang01.Click
        hfNewPanelVisibility.Value = 0
        pnlGang01.Style.Item("display") = "none"
        pnlGang01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxGangrene01.Checked = False
    End Sub
    Private Sub btnOKAmp01_Click(sender As Object, e As EventArgs) Handles btnOKAmp01.Click
        If lblAmp01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlAmp01.Style.Item("display") = "none"
            pnlAmp01Back.Visible = False
        End If

        btnCancelAmp01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelAmp01_Click(sender As Object, e As EventArgs) Handles btnCancelAmp01.Click
        hfNewPanelVisibility.Value = 0
        pnlAmp01.Style.Item("display") = "none"
        pnlAmp01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxAmp01.Checked = False
    End Sub
    Private Sub btnOKInPatient01_Click(sender As Object, e As EventArgs) Handles btnOKInPatient01.Click
        If lblInPatient01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlInPatient01.Style.Item("display") = "none"
            pnlInPatient01Back.Visible = False
        End If

        btnCancelInPatient01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelInPatient01_Click(sender As Object, e As EventArgs) Handles btnCancelInPatient01.Click
        hfNewPanelVisibility.Value = 0
        pnlInPatient01.Style.Item("display") = "none"
        pnlInPatient01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxInPatient.Checked = False
    End Sub
    Private Sub cbxSore02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSore02.CheckedChanged
        If cbxSore02.Checked Then
            ShowModalPopup(Me, "pnlSore02")
            hfNewPanelVisibility.Value = 1

            pnlSore02.Style.Item("display") = "block"
            pnlSore02.Attributes("aria-hidden") = "false"
            pnlSore02.CssClass = "modal fade in"
            pnlSore02Back.Visible = True
        End If
    End Sub
    Private Sub cbxInfect01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxInfect01.CheckedChanged
        If cbxInfect01.Checked Then
            ShowModalPopup(Me, "pnlInfect01")
            hfNewPanelVisibility.Value = 1

            pnlInfect01.Style.Item("display") = "block"
            pnlInfect01.Attributes("aria-hidden") = "false"
            pnlInfect01.CssClass = "modal fade in"
            pnlInfect01Back.Visible = True
        End If
    End Sub
    Private Sub cbxSwell01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSwell01.CheckedChanged
        If cbxSwell01.Checked Then
            ShowModalPopup(Me, "pnlSwell01")
            hfNewPanelVisibility.Value = 1

            pnlSwell01.Style.Item("display") = "block"
            pnlSwell01.Attributes("aria-hidden") = "false"
            pnlSwell01.CssClass = "modal fade in"
            pnlSwell01Back.Visible = True
        End If
    End Sub
    Private Sub btnOKSore02_Click(sender As Object, e As EventArgs) Handles btnOKSore02.Click
        If lblSore02MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlSore02.Style.Item("display") = "none"
            pnlSore02Back.Visible = False
        End If

        btnCancelSore02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSore02_Click(sender As Object, e As EventArgs) Handles btnCancelSore02.Click
        hfNewPanelVisibility.Value = 0
        pnlSore02.Style.Item("display") = "none"
        pnlSore02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSore02.Checked = False
    End Sub
    Private Sub btnOKInfect01_Click(sender As Object, e As EventArgs) Handles btnOKInfect01.Click
        If lblInfect01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlInfect01.Style.Item("display") = "none"
            pnlInfect01Back.Visible = False
        End If

        btnCancelInfect01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelInfect01_Click(sender As Object, e As EventArgs) Handles btnCancelInfect01.Click
        hfNewPanelVisibility.Value = 0
        pnlInfect01.Style.Item("display") = "none"
        pnlInfect01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxInfect01.Checked = False
    End Sub
    Private Sub btnOKSwell01_Click(sender As Object, e As EventArgs) Handles btnOKSwell01.Click
        If lblSwell01MSG.Text = "" Then
            hfNewPanelVisibility.Value = 0
            pnlSwell01.Style.Item("display") = "none"
            pnlSwell01Back.Visible = False
        End If

        btnCancelSwell01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSwell01_Click(sender As Object, e As EventArgs) Handles btnCancelSwell01.Click
        hfNewPanelVisibility.Value = 0
        pnlSwell01.Style.Item("display") = "none"
        pnlSwell01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSwell01.Checked = False
    End Sub
    Private Sub btnCancelDemographic_Click(sender As Object, e As EventArgs) Handles btnCancelDemographic.Click
        txtFileNo.Text = ""
        txtNationalCode.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        rblGender.SelectedIndex = -1
        txtAgeOf.Text = ""
        dpBirthDateOf.Clear()
        txtWeight.Text = ""
        txtHeight.Text = ""
        rbMarriage.SelectedIndex = -1
        txtCellNo.Text = ""
        txtPhoneNo.Text = ""
        rbEducation.SelectedIndex = -1
        txtAddress.Text = ""
    End Sub
    Private Sub btnContinueDemographic_Click(sender As Object, e As EventArgs) Handles btnContinueDemographic.Click
        pnlDemographic.Visible = False
        pnlDemographicFooter.Visible = False

        pnlHistory.Visible = True
        pnlPhysicalExam.Visible = True
        pnlLabResults.Visible = True
        pnlPrescription.Visible = True
        pnlMainFooter.Visible = True
        btnCancel_Click(Nothing, Nothing)

        hfExpanedPanelIds.Value = "pnlHistory"
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'History
        rblDiabetTypeOf.SelectedIndex = -1
        txtDateOf01.Text = ""
        dpDateOf01.Clear()
        cbxSore01.Checked = False
        cbxLaser01.Checked = False
        cbxDebrid01.Checked = False
        cbxSurgery01.Checked = False
        cbxGangrene01.Checked = False
        cbxAmp01.Checked = False
        rblDesease.SelectedIndex = -1
        cbxAlcohol.Checked = False
        cbxSigarret.Checked = False
        cbxInPatient.Checked = False

        'Physical Exam
        txtCC.Text = ""
        cbxSore02.Checked = False
        cbxInfect01.Checked = False
        cbxSwell01.Checked = False
        For Each oItem As ListItem In cblNeuropathy.Items
            oItem.Selected = False
        Next
        rblDry.SelectedIndex = -1
        rblTemp.SelectedIndex = -1

        'Lab Results
        txtFBS.Text = ""
        txtA1C.Text = ""
        dpDateOf02.Clear()
        txtSystol.Text = ""
        txtDyastol.Text = ""
        txtO2.Text = ""
        txtHR.Text = ""
        txtRR.Text = ""
        dpDateOf03.Clear()

        'Prescriptions
        cbxNeedAmp.Checked = False
        cbxNeedCover.Checked = False
        cbxNeedDebrid.Checked = False
        cbxNeedEducation.Checked = False
        cbxNeedRehab.Checked = False
        cbxNeedShoe.Checked = False
        cbxNeedSurg.Checked = False
        cbxNeedVisit.Checked = False
        For Each oItem As ListItem In cblDrugs.Items
            oItem.Selected = False
        Next

        'Modal Panels
        txtDuration01.Text = ""
        dpLastSore01.Clear()
        For Each oItem As ListItem In cblSoreLocationL01.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblSoreLocationR01.Items
            oItem.Selected = False
        Next
        txtDuration02.Text = ""
        dpLastLaser01.Clear()
        For Each oItem As ListItem In cblLaser.Items
            oItem.Selected = False
        Next
        txtDuration03.Text = ""
        dpLastDebrid01.Clear()
        For Each oItem As ListItem In cblDebrid.Items
            oItem.Selected = False
        Next
        txtDuration04.Text = ""
        dpLastSurg01.Clear()
        For Each oItem As ListItem In cblSurgL.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblSurgR.Items
            oItem.Selected = False
        Next
        txtDuration05.Text = ""
        dpLastGang01.Clear()
        For Each oItem As ListItem In cblGang.Items
            oItem.Selected = False
        Next
        txtDuration06.Text = ""
        dpLastAmp01.Clear()
        For Each oItem As ListItem In cblAmpL.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblAmpR.Items
            oItem.Selected = False
        Next
        txtDuration07.Text = ""
        dpLastInPatient01.Clear()
        txtSurg01Cause.Text = ""

        txtDuration08.Text = ""
        dpNewSore.Clear()
        txtNewSoreCountOfL.Text = ""
        txtNewSoreCountOfR.Text = ""
        txtNewMaxLength.Text = ""
        For Each oItem As ListItem In cblNewSoreL.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblNewSoreR.Items
            oItem.Selected = False
        Next
        rblNewWorstSoreL.SelectedIndex = -1
        rblNewWorstSoreR.SelectedIndex = -1
        txtDuration09.Text = ""
        dpNewInfect.Clear()
        For Each oItem As ListItem In cblNewInfectL.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblNewInfectR.Items
            oItem.Selected = False
        Next
        txtDuration10.Text = ""
        dpNewSwell.Clear()
        For Each oItem As ListItem In cblNewSwellL.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblNewSwellR.Items
            oItem.Selected = False
        Next


    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        pnlHistory.Visible = False
        pnlPhysicalExam.Visible = False
        pnlLabResults.Visible = False
        pnlPrescription.Visible = False
        pnlMainFooter.Visible = False

        pnlDemographic.Visible = True
        pnlDemographicFooter.Visible = True
        btnCancelDemographic_Click(Nothing, Nothing)
    End Sub
End Class