﻿Imports KMUReg.SharedConstantClasses
Imports KMUReg.SharedMethodClass
Public Class RegPatient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack Then
            'hfActivePanelId.Value = Request.Form(hfActivePanelId.UniqueID)
            'MsgBox(hfActivePanelId.Value)

            pnlDemographicMessage.Visible = False
            pnlHistoryMessage.Visible = False
            pnlPhysicalExamMessage.Visible = False
            pnlLabResultsMessage.Visible = False
            pnlPrescriptionMessage.Visible = False

            pnlSore01MSG.Visible = False
            pnlLaser01MSG.Visible = False
            pnlDebrid01MSG.Visible = False
            pnlSurg01MSG.Visible = False
            pnlGang01MSG.Visible = False
            pnlAmp01MSG.Visible = False
            pnlInPatient01MSG.Visible = False
            pnlSore02MSG.Visible = False
            pnlInfect01MSG.Visible = False
            pnlSwell01MSG.Visible = False
        Else
            btnCancelReg.Width = btnCancelPrescription.Width
            btnOK.Width = btnCancelPrescription.Width
            txtNationalCode.Focus()
            Session("Demographic") = Nothing
        End If
    End Sub
    Private Sub SetActiveTab(tabId As String)
        If Not String.IsNullOrEmpty(tabId) Then
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "SetActiveTabServerSide", "$('#" & tabId & " > a[data-toggle=tab]').click();", True)
        End If
    End Sub
    Private Sub cbxSore01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSore01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxSore01.Checked = Not cbxSore01.Checked
        If cbxSore01.Checked Then
            ShowModalPopup(Me, "pnlSore01")
            hfNewPanelVisibility.Value = 1

            pnlSore01.Style.Item("display") = "block"
            pnlSore01.Attributes("aria-hidden") = "false"
            pnlSore01.CssClass = "modal fade in"
            pnlSore01Back.Visible = True

            txtDuration01.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If

        'GetStep2Panels()
    End Sub
    Private Sub cbxLaser01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLaser01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxLaser01.Checked = Not cbxLaser01.Checked
        If cbxLaser01.Checked Then
            ShowModalPopup(Me, "pnlLaser01")
            hfNewPanelVisibility.Value = 1

            pnlLaser01.Style.Item("display") = "block"
            pnlLaser01.Attributes("aria-hidden") = "false"
            pnlLaser01.CssClass = "modal fade in"
            pnlLaser01Back.Visible = True

            txtDuration02.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxDebrid01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDebrid01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxDebrid01.Checked = Not cbxDebrid01.Checked
        If cbxDebrid01.Checked Then
            ShowModalPopup(Me, "pnlDebrid01")
            hfNewPanelVisibility.Value = 1

            pnlDebrid01.Style.Item("display") = "block"
            pnlDebrid01.Attributes("aria-hidden") = "false"
            pnlDebrid01.CssClass = "modal fade in"
            pnlDebrid01Back.Visible = True

            txtDuration03.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxGang01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGang01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxGang01.Checked = Not cbxGang01.Checked
        If cbxGang01.Checked Then
            ShowModalPopup(Me, "pnlGang01")
            hfNewPanelVisibility.Value = 1

            pnlGang01.Style.Item("display") = "block"
            pnlGang01.Attributes("aria-hidden") = "false"
            pnlGang01.CssClass = "modal fade in"
            pnlGang01Back.Visible = True

            txtDuration04.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxSurg01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSurg01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxSurg01.Checked = Not cbxSurg01.Checked
        If cbxSurg01.Checked Then
            ShowModalPopup(Me, "pnlSurg01")
            hfNewPanelVisibility.Value = 1

            pnlSurg01.Style.Item("display") = "block"
            pnlSurg01.Attributes("aria-hidden") = "false"
            pnlSurg01.CssClass = "modal fade in"
            pnlSurg01Back.Visible = True

            txtDuration05.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxAmp01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAmp01.CheckedChanged
        If Session("History") IsNot Nothing Then cbxAmp01.Checked = Not cbxAmp01.Checked
        If cbxAmp01.Checked Then
            ShowModalPopup(Me, "pnlAmp01")
            hfNewPanelVisibility.Value = 1

            pnlAmp01.Style.Item("display") = "block"
            pnlAmp01.Attributes("aria-hidden") = "false"
            pnlAmp01.CssClass = "modal fade in"
            pnlAmp01Back.Visible = True

            txtDuration06.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxInPatient01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxInPatient.CheckedChanged
        If Session("History") IsNot Nothing Then cbxInPatient.Checked = Not cbxInPatient.Checked
        If cbxInPatient.Checked Then
            ShowModalPopup(Me, "pnlInPatient01")
            hfNewPanelVisibility.Value = 1

            pnlInPatient01.Style.Item("display") = "block"
            pnlInPatient01.Attributes("aria-hidden") = "false"
            pnlInPatient01.CssClass = "modal fade in"
            pnlInPatient01Back.Visible = True
            txtSurg01Cause.Focus()
            hfActivePanelId.Value = tabHistory.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxLaser02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLaser02.CheckedChanged
        If cbxLaser02.Checked Then
            ShowModalPopup(Me, "pnlLaser02")
            hfNewPanelVisibility.Value = 1

            pnlLaser02.Style.Item("display") = "block"
            pnlLaser02.Attributes("aria-hidden") = "false"
            pnlLaser02.CssClass = "modal fade in"
            pnlLaser02Back.Visible = True

            txtDuration02.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxDebrid02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDebrid02.CheckedChanged
        If cbxDebrid02.Checked Then
            ShowModalPopup(Me, "pnlDebrid02")
            hfNewPanelVisibility.Value = 1

            pnlDebrid02.Style.Item("display") = "block"
            pnlDebrid02.Attributes("aria-hidden") = "false"
            pnlDebrid02.CssClass = "modal fade in"
            pnlDebrid02Back.Visible = True

            txtDuration03.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxGang02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGang02.CheckedChanged
        If cbxGang02.Checked Then
            ShowModalPopup(Me, "pnlGang02")
            hfNewPanelVisibility.Value = 1

            pnlGang02.Style.Item("display") = "block"
            pnlGang02.Attributes("aria-hidden") = "false"
            pnlGang02.CssClass = "modal fade in"
            pnlGang02Back.Visible = True

            txtDuration04.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxSurg02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSurg02.CheckedChanged
        If cbxSurg02.Checked Then
            ShowModalPopup(Me, "pnlSurg02")
            hfNewPanelVisibility.Value = 1

            pnlSurg02.Style.Item("display") = "block"
            pnlSurg02.Attributes("aria-hidden") = "false"
            pnlSurg02.CssClass = "modal fade in"
            pnlSurg02Back.Visible = True

            txtDuration05.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxAmp02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAmp02.CheckedChanged
        If cbxAmp02.Checked Then
            ShowModalPopup(Me, "pnlAmp02")
            hfNewPanelVisibility.Value = 1

            pnlAmp02.Style.Item("display") = "block"
            pnlAmp02.Attributes("aria-hidden") = "false"
            pnlAmp02.CssClass = "modal fade in"
            pnlAmp02Back.Visible = True

            txtDuration06.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub cbxInPatient02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxInPatient.CheckedChanged
        If cbxInPatient.Checked Then
            ShowModalPopup(Me, "pnlInPatient02")
            hfNewPanelVisibility.Value = 1

            pnlInPatient02.Style.Item("display") = "block"
            pnlInPatient02.Attributes("aria-hidden") = "false"
            pnlInPatient02.CssClass = "modal fade in"
            pnlInPatient02Back.Visible = True
            txtSurg02Cause.Focus()
            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub btnOKSore01_Click(sender As Object, e As EventArgs) Handles btnOKSore01.Click
        If Not CheckpnlSore01() Then Exit Sub
        btnCancelSore01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSore01_Click(sender As Object, e As EventArgs) Handles btnCancelSore01.Click
        hfNewPanelVisibility.Value = 0
        pnlSore01.Style.Item("display") = "none"
        pnlSore01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxSore01.Checked = False

        'GetStep2Panels()
    End Sub
    Private Sub btnOKLaser01_Click(sender As Object, e As EventArgs) Handles btnOKLaser01.Click
        If Not CheckpnlLaser01() Then Exit Sub
        btnCancelLaser01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelLaser01_Click(sender As Object, e As EventArgs) Handles btnCancelLaser01.Click
        hfNewPanelVisibility.Value = 0
        pnlLaser01.Style.Item("display") = "none"
        pnlLaser01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxLaser01.Checked = False
    End Sub
    Private Sub btnOKDebrid01_Click(sender As Object, e As EventArgs) Handles btnOKDebrid01.Click
        If Not CheckpnlDebrid01() Then Exit Sub
        btnCancelDebrid01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelDebrid01_Click(sender As Object, e As EventArgs) Handles btnCancelDebrid01.Click
        hfNewPanelVisibility.Value = 0
        pnlDebrid01.Style.Item("display") = "none"
        pnlDebrid01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxDebrid01.Checked = False
    End Sub
    Private Sub btnOKSurg01_Click(sender As Object, e As EventArgs) Handles btnOKSurg01.Click
        If Not CheckpnlSurg01() Then Exit Sub
        btnCancelSurg01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSurg01_Click(sender As Object, e As EventArgs) Handles btnCancelSurg01.Click
        hfNewPanelVisibility.Value = 0
        pnlSurg01.Style.Item("display") = "none"
        pnlSurg01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxSurg01.Checked = False
    End Sub
    Private Sub btnOKGang01_Click(sender As Object, e As EventArgs) Handles btnOKGang01.Click
        If Not CheckpnlGang01() Then Exit Sub
        btnCancelGang01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelGang01_Click(sender As Object, e As EventArgs) Handles btnCancelGang01.Click
        hfNewPanelVisibility.Value = 0
        pnlGang01.Style.Item("display") = "none"
        pnlGang01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxGang01.Checked = False
    End Sub
    Private Sub btnOKAmp01_Click(sender As Object, e As EventArgs) Handles btnOKAmp01.Click
        If Not CheckpnlAmp01() Then Exit Sub
        btnCancelAmp01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelAmp01_Click(sender As Object, e As EventArgs) Handles btnCancelAmp01.Click
        hfNewPanelVisibility.Value = 0
        pnlAmp01.Style.Item("display") = "none"
        pnlAmp01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxAmp01.Checked = False
    End Sub
    Private Sub btnOKInPatient01_Click(sender As Object, e As EventArgs) Handles btnOKInPatient01.Click
        If Not CheckpnlInPatient01() Then Exit Sub

        btnCancelInPatient01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelInPatient01_Click(sender As Object, e As EventArgs) Handles btnCancelInPatient01.Click
        hfNewPanelVisibility.Value = 0
        pnlInPatient01.Style.Item("display") = "none"
        pnlInPatient01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxInPatient.Checked = False
    End Sub

    Private Sub cbxSore02_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSore02.CheckedChanged
        If cbxSore02.Checked Then
            ShowModalPopup(Me, "pnlSore02")
            hfNewPanelVisibility.Value = 1

            pnlSore02.Style.Item("display") = "block"
            pnlSore02.Attributes("aria-hidden") = "false"
            pnlSore02.CssClass = "modal fade in"
            pnlSore02Back.Visible = True

            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
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

            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
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

            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
        End If
    End Sub
    Private Sub btnOKSore02_Click(sender As Object, e As EventArgs) Handles btnOKSore02.Click
        If Not CheckpnlNewSore() Then Exit Sub
        btnCancelSore02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSore02_Click(sender As Object, e As EventArgs) Handles btnCancelSore02.Click
        hfNewPanelVisibility.Value = 0
        pnlSore02.Style.Item("display") = "none"
        pnlSore02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSore02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKInfect01_Click(sender As Object, e As EventArgs) Handles btnOKInfect01.Click
        If Not CheckpnlNewInfection() Then Exit Sub
        btnCancelInfect01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelInfect01_Click(sender As Object, e As EventArgs) Handles btnCancelInfect01.Click
        hfNewPanelVisibility.Value = 0
        pnlInfect01.Style.Item("display") = "none"
        pnlInfect01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxInfect01.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKSwell01_Click(sender As Object, e As EventArgs) Handles btnOKSwell01.Click
        If Not CheckpnlNewSwell() Then Exit Sub
        btnCancelSwell01_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSwell01_Click(sender As Object, e As EventArgs) Handles btnCancelSwell01.Click
        hfNewPanelVisibility.Value = 0
        pnlSwell01.Style.Item("display") = "none"
        pnlSwell01Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing Then cbxSwell01.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKLaser02_Click(sender As Object, e As EventArgs) Handles btnOKLaser02.Click
        If Not CheckpnlLaser02() Then Exit Sub
        btnCancelLaser02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelLaser02_Click(sender As Object, e As EventArgs) Handles btnCancelLaser02.Click
        hfNewPanelVisibility.Value = 0
        pnlLaser02.Style.Item("display") = "none"
        pnlLaser02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxLaser02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKDebrid02_Click(sender As Object, e As EventArgs) Handles btnOKDebrid02.Click
        If Not CheckpnlDebrid02() Then Exit Sub
        btnCancelDebrid02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelDebrid02_Click(sender As Object, e As EventArgs) Handles btnCancelDebrid02.Click
        hfNewPanelVisibility.Value = 0
        pnlDebrid02.Style.Item("display") = "none"
        pnlDebrid02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxDebrid02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKSurg02_Click(sender As Object, e As EventArgs) Handles btnOKSurg02.Click
        If Not CheckpnlSurg02() Then Exit Sub
        btnCancelSurg02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelSurg02_Click(sender As Object, e As EventArgs) Handles btnCancelSurg02.Click
        hfNewPanelVisibility.Value = 0
        pnlSurg02.Style.Item("display") = "none"
        pnlSurg02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxSurg02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKGang02_Click(sender As Object, e As EventArgs) Handles btnOKGang02.Click
        If Not CheckpnlGang02() Then Exit Sub
        btnCancelGang02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelGang02_Click(sender As Object, e As EventArgs) Handles btnCancelGang02.Click
        hfNewPanelVisibility.Value = 0
        pnlGang02.Style.Item("display") = "none"
        pnlGang02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxGang02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKAmp02_Click(sender As Object, e As EventArgs) Handles btnOKAmp02.Click
        If Not CheckpnlAmp02() Then Exit Sub
        btnCancelAmp02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelAmp02_Click(sender As Object, e As EventArgs) Handles btnCancelAmp02.Click
        hfNewPanelVisibility.Value = 0
        pnlAmp02.Style.Item("display") = "none"
        pnlAmp02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxAmp02.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOKInPatient02_Click(sender As Object, e As EventArgs) Handles btnOKInPatient02.Click
        If Not CheckpnlInPatient02() Then Exit Sub

        btnCancelInPatient02_Click(Nothing, Nothing)
    End Sub
    Private Sub btnCancelInPatient02_Click(sender As Object, e As EventArgs) Handles btnCancelInPatient02.Click
        hfNewPanelVisibility.Value = 0
        pnlInPatient02.Style.Item("display") = "none"
        pnlInPatient02Back.Visible = False
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "RemoveModalClass", "$('body').removeClass('modal-open');", True)
        If sender IsNot Nothing AndAlso Session("History") Is Nothing Then cbxInPatient.Checked = False
        hfActivePanelId.Value = tabPhysicalExam.ClientID
        SetActiveTab(hfActivePanelId.Value)
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
        rblMarriage.SelectedIndex = -1
        txtCellNo.Text = ""
        txtPhoneNo.Text = ""
        rblEducation.SelectedIndex = -1
        txtAddress.Text = ""
        txtNationalCode.Focus()
        Session("History") = Nothing
    End Sub
    Private Sub btnContinueDemographic_Click(sender As Object, e As EventArgs) Handles btnContinueDemographic.Click
        If CheckDemographicPanelData() Then Exit Sub

        pnlDemographic.Visible = False
        pnlDemographicFooter.Visible = False

        pnlHistory.Visible = True
        pnlHistoryFooter.Visible = True
        pnlPages.Visible = True

        btnCancelHistory_Click(Nothing, Nothing)
        btnCancelPhysicalExam_Click(Nothing, Nothing)
        btnCacelLabResults_Click(Nothing, Nothing)
        btnCancelPrescription_Click(Nothing, Nothing)
        UpdateDemographicData()

        If Session("Demographic") IsNot Nothing Then
            hfActivePanelId.Value = tabHistory.ClientID
        Else
            hfActivePanelId.Value = tabPhysicalExam.ClientID
        End If

        SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Function CheckDemographicPanelData() As Boolean
        If Session("Demographic") IsNot Nothing Then Return False

        If txtNationalCode.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "کد ملی را وارد نکرده اید."

            txtNationalCode.Focus()
            Return True
        ElseIf txtFirstName.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "نام را وارد نکرده اید."

            txtFirstName.Focus()
            Return True
        ElseIf txtLastName.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "نام خانوادگی را وارد نکرده اید."

            txtLastName.Focus()
            Return True
        ElseIf rblGender.SelectedIndex = -1 Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "جنسیت را انتخاب نکرده اید."

            rblGender.Focus()
            Return True
        ElseIf txtAgeOf.Text = "" AndAlso Not dpBirthDateOf.GetMiladiValue.HasValue AndAlso CType(dpBirthDateOf.Controls(3).Controls(0), TextBox).Text <> "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "تاریخ تولد یا سن را تعیین نکرده اید."

            txtAgeOf.Focus()
            Return True
        ElseIf isNotValidDateOf(Val(txtAgeOf.Text.Trim), 10, 150, CType(dpBirthDateOf.Controls(3).Controls(0), TextBox).Text, "Y") Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "مقدار نامناسبی برای تاریخ تولد یا سن ثبت کرده اید."

            txtAgeOf.Focus()
            Return True
        ElseIf txtHeight.Text.Trim <> "" AndAlso Val(txtHeight.Text.Trim) < 50 AndAlso Val(txtHeight.Text.Trim) > 250 Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "مقدار نامناسبی برای قد وارد کرده اید."

            txtHeight.Focus()
            Return True
        ElseIf txtWeight.Text.Trim <> "" AndAlso Val(txtWeight.Text.Trim) < 5 AndAlso Val(txtWeight.Text.Trim) > 200 Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "مقدار نامناسبی برای وزن وارد کرده اید."

            txtWeight.Focus()
            Return True
        ElseIf txtCellNo.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "تلفن همراه را وارد نکرده اید."

            txtCellNo.Focus()
            Return True
        ElseIf txtPhoneNo.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "تلفن را وارد نکرده اید."

            txtPhoneNo.Focus()
            Return True
        ElseIf txtAddress.Text.Trim = "" Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "آدرس را وارد نکرده اید."

            txtAddress.Focus()
            Return True
        End If

        Return False
    End Function
    Private Sub UpdateDemographicData()
        Dim odb As New dbDataContext(ConnectionStringDemographic)
        Dim oDemographic As New tblDemographic
        If txtFileNo.Text.Trim <> "" Then
            oDemographic = odb.tblDemographics.Where(Function(f) f.FileNo = txtFileNo.Text.Trim).FirstOrDefault
            'pnlHistory.Enabled = False
            FillHistory()
        Else
            oDemographic = odb.tblDemographics.Where(Function(f) f.NationalID = txtNationalCode.Text.Trim).FirstOrDefault
            If oDemographic Is Nothing Then
                oDemographic = New tblDemographic
                odb.tblDemographics.InsertOnSubmit(oDemographic)
                oDemographic.FileNo = GetNextFileNo()
                pnlHistory.Enabled = True
            Else
                'pnlHistory.Enabled = False
            End If
        End If
        With oDemographic
            .AddressOf = txtAddress.Text.Trim

            If CType(dpBirthDateOf.Controls(3).Controls(0), TextBox).Text <> "" Then
                .BirthDateOf = dpBirthDateOf.GetMiladiValue
            Else
                .BirthDateOf = Getdate().AddYears(-Val(txtAgeOf.Text.Trim))
            End If
            .CellNo = txtCellNo.Text.Trim
            If rblEducation.SelectedIndex >= 0 Then
                .EducationLU = rblEducation.SelectedValue
            Else
                .EducationLU = Nothing
            End If
            .FirstNameOf = txtFirstName.Text.Trim
            .GenderLU = rblGender.SelectedValue
            If txtHeight.Text.Trim <> "" Then
                .HeightOf = Val(txtHeight.Text)
            Else
                .HeightOf = Nothing
            End If
            .LastNameOf = txtLastName.Text.Trim
            If rblMarriage.SelectedIndex >= 0 Then
                .MarriageLU = rblMarriage.SelectedValue
            Else
                .MarriageLU = Nothing
            End If
            .NationalID = txtNationalCode.Text.Trim
            .PhoneNo = txtPhoneNo.Text.Trim
            If txtWeight.Text.Trim <> "" Then
                .WeightOf = Val(txtWeight.Text)
            Else
                .WeightOf = Nothing
            End If
        End With
        odb.SubmitChanges()
        Session("Demographic") = oDemographic
    End Sub

    Private Sub btnCancelHistory_Click(sender As Object, e As EventArgs) Handles btnCancelHistory.Click
        If Session("History") IsNot Nothing Then Exit Sub
        'History
        rblDiabetTypeOf.SelectedIndex = -1
        txtDateOf01.Text = ""
        dpDateOf01.Clear()
        cbxSore01.Checked = False
        cbxLaser01.Checked = False
        cbxDebrid01.Checked = False
        cbxSurg01.Checked = False
        cbxGang01.Checked = False
        cbxAmp01.Checked = False
        cblDisease.SelectedIndex = -1
        cbxAlcohol.Checked = False
        cbxSigarret.Checked = False
        cbxInPatient.Checked = False

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
    End Sub
    Private Sub btnCancelPhysicalExam_Click(sender As Object, e As EventArgs) Handles btnCancelPhysicalExam.Click
        'Physical Exam
        txtCC.Text = ""
        cbxSore02.Checked = False
        cbxInfect01.Checked = False
        cbxSwell01.Checked = False
        cbxAmp02.Checked = False
        cbxDebrid02.Checked = False
        cbxGang02.Checked = False
        cbxInPatient02.Checked = False
        cbxSurg02.Checked = False
        cbxLaser02.Checked = False
        For Each oItem As ListItem In cblNeuropathy.Items
            oItem.Selected = False
        Next
        rblDry.SelectedIndex = -1
        rblTemp.SelectedIndex = -1
        cbxLaser02.Checked = False
        cbxDebrid02.Checked = False
        cbxSurg02.Checked = False
        cbxGang02.Checked = False
        cbxAmp02.Checked = False
        cbxInPatient02.Checked = False

        'Modal Panels
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
        txtDuration11.Text = ""
        dpLastLaser02.Clear()
        For Each oItem As ListItem In cblLaser02.Items
            oItem.Selected = False
        Next
        txtDuration12.Text = ""
        dpLastDebrid02.Clear()
        For Each oItem As ListItem In cblDebrid02.Items
            oItem.Selected = False
        Next
        txtDuration13.Text = ""
        dpLastSurg02.Clear()
        For Each oItem As ListItem In cblSurg02L.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblSurg02R.Items
            oItem.Selected = False
        Next
        txtDuration14.Text = ""
        dpLastGang02.Clear()
        For Each oItem As ListItem In cblGang02.Items
            oItem.Selected = False
        Next
        txtDuration15.Text = ""
        dpLastAmp02.Clear()
        For Each oItem As ListItem In cblAmp02L.Items
            oItem.Selected = False
        Next
        For Each oItem As ListItem In cblAmp02R.Items
            oItem.Selected = False
        Next
        txtDuration16.Text = ""
        dpLastInPatient02.Clear()
        txtSurg02Cause.Text = ""

        hfActivePanelId.Value = tabPhysicalExam.ClientID
        If sender IsNot Nothing Then SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnCacelLabResults_Click(sender As Object, e As EventArgs) Handles btnCacelLabResults.Click
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

        hfActivePanelId.Value = tabLabResults.ClientID
        If sender IsNot Nothing Then SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnCancelPrescription_Click(sender As Object, e As EventArgs) Handles btnCancelPrescription.Click
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
        txtFreeText.Text = ""
        hfActivePanelId.Value = tabPrescription.ClientID
        If sender IsNot Nothing Then SetActiveTab(hfActivePanelId.Value)
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If Session("History") Is Nothing Then
            If rblDiabetTypeOf.SelectedIndex = -1 Then
                pnlHistoryMessage.Visible = True
                lbllHistoryMessage.Text = "نوع دیابت را تعیین نکرده اید."

                hfActivePanelId.Value = tabHistory.ClientID
                SetActiveTab(hfActivePanelId.Value)
                rblDiabetTypeOf.Focus()
                Exit Sub
            ElseIf txtDateOf01.Text = "" AndAlso Not dpDateOf01.GetMiladiValue.HasValue Then
                pnlHistoryMessage.Visible = True
                lbllHistoryMessage.Text = "مدت یا تاریخ ابتلا به دیابت را تعیین نکرده اید."

                hfActivePanelId.Value = tabHistory.ClientID
                SetActiveTab(hfActivePanelId.Value)
                txtDateOf01.Focus()
                Exit Sub
            ElseIf isNotValidDateOf(Val(txtDateOf01.Text.Trim), 0, 1000, CType(dpDateOf01.Controls(3).Controls(0), TextBox).Text, "Y") Then
                pnlHistoryMessage.Visible = True
                lbllHistoryMessage.Text = "مدت یا تاریخ ابتلا به دیابت در محدوده‌ی قابل قبول نمی‌باشد."

                hfActivePanelId.Value = tabHistory.ClientID
                SetActiveTab(hfActivePanelId.Value)
                txtDateOf01.Focus()
                Exit Sub
            End If
        End If

        If txtCC.Text.Trim = "" Then
            pnlPhysicalExamMessage.Visible = True
            lblPhysicalExamMessage.Text = "علت مراجعه را ثبت نکرده اید."

            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
            txtCC.Focus()
            Exit Sub
        ElseIf Not dpContract.GetMiladiValue.HasValue Then
            pnlPhysicalExamMessage.Visible = True
            lblPhysicalExamMessage.Text = "تاریخ مراجعه را تعیین نکرده اید."

            hfActivePanelId.Value = tabPhysicalExam.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpContract.Focus()
            Exit Sub
        ElseIf txtFBS.Text = "" Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار FBS را ثبت نکرده اید."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            txtFBS.Focus()
            Exit Sub
        ElseIf txtA1C.Text = "" Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار A1C را ثبت نکرده اید."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            txtA1C.Focus()
            Exit Sub
        ElseIf Not dpDateOf02.GetMiladiValue.HasValue Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "تاریخ انجام آزمایشات را ثبت نکرده اید."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf02.Focus()
            Exit Sub
        ElseIf (txtSystol.Text <> "" OrElse txtDyastol.Text <> "" OrElse txtHR.Text <> "" OrElse txtRR.Text <> "" OrElse txtO2.Text <> "") AndAlso Not dpDateOf03.GetMiladiValue.HasValue Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار تاریخ ثبت علائم حیاتی را وارد نکرده اید."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtFBS.Text) < 0 OrElse Val(txtFBS.Text) > 999 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار FBS باید عددی کوچکتر از 1000 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtA1C.Text) < 0 OrElse Val(txtA1C.Text) >= 10 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار Hb A1C باید عددی کوچکتر از 10 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtSystol.Text) < 0 OrElse Val(txtSystol.Text) > 300 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار فشارخون سیستولی باید عددی کوچکتر از 300 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtDyastol.Text) < 0 OrElse Val(txtDyastol.Text) > 300 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار فشارخون دیاستولی باید عددی کوچکتر از 300 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtO2.Text) < 0 OrElse Val(txtO2.Text) > 100 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار درصد اشباع اکسیژن خون حداکثر می‌تواند 100 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtHR.Text) < 0 OrElse Val(txtHR.Text) > 999 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار تعداد ضربان قلب در دقیقه باید عددی کوچکتر از 999 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        ElseIf Val(txtRR.Text) < 0 OrElse Val(txtRR.Text) > 100 Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار تعداد تنفس در دقیقه باید عددی کوچکتر از 100 باشد."

            hfActivePanelId.Value = tabLabResults.ClientID
            SetActiveTab(hfActivePanelId.Value)
            dpDateOf03.Focus()
            Exit Sub
        End If
        If Session("History") Is Nothing Then
            SaveHistory()
        End If

        SaveContract()
        'ShowMessage(litMessage, "داده‌های مراجعه جدید ذخیره شد.", eMessageType.success, False)
        Dim oScript = "alert('داده‌های مراجعه جدید ذخیره شد.');"
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "AlertScript", oScript, True)

        btnCancelReg_Click(Nothing, Nothing)
    End Sub

    Private Function isNotValidDateOf(oNumber As Integer, oNMin As Integer, oNMax As Integer, ostrDateOf As String, oDatePart As String) As Boolean
        If Not String.IsNullOrEmpty(ostrDateOf) Then
            Dim oNow = Getdate()
            Dim _Number As Long = 0
            If oDatePart.ToLower = "Y".ToLower Then
                _Number = DateDiff(DateInterval.Year, CType(ostrDateOf, Date), oNow)
            ElseIf oDatePart.ToLower = "M".ToLower Then
                _Number = DateDiff(DateInterval.Month, CType(ostrDateOf, Date), oNow)
            ElseIf oDatePart.ToLower = "D".ToLower Then
                _Number = DateDiff(DateInterval.Day, CType(ostrDateOf, Date), oNow)
            End If
            If (oNumber < oNMin OrElse oNumber > oNMax) AndAlso (_Number < oNMin OrElse _Number > oNMax) Then
                Return True
            End If
        Else
            If (oNumber < oNMin OrElse oNumber > oNMax) Then
                Return True
            End If
        End If

        Return False
    End Function
    Private Sub txtFileNo_TextChanged(sender As Object, e As EventArgs) Handles txtFileNo.TextChanged
        If txtFileNo.Text.Trim = "" Then
            btnCancelDemographic_Click(Nothing, Nothing)
            Exit Sub
        End If
        SetDemoGraphicReadonly(FillDemographic("FileNo"))
    End Sub
    Private Sub txtNationalCode_TextChanged(sender As Object, e As EventArgs) Handles txtNationalCode.TextChanged
        If txtNationalCode.Text.Trim = "" Then
            btnCancelDemographic_Click(Nothing, Nothing)
            Exit Sub
        End If

        SetDemoGraphicReadonly(FillDemographic("NationalID"))
    End Sub
    Private Sub SetDemoGraphicReadonly(Optional _readonly As Boolean = True)
        txtFirstName.Enabled = _readonly
        txtLastName.Enabled = _readonly
        rblGender.Enabled = _readonly
        pnlBirthDateOf.Enabled = _readonly
        txtHeight.Enabled = _readonly
        txtWeight.Enabled = _readonly
        rblMarriage.Enabled = _readonly
        txtCellNo.Enabled = _readonly
        txtPhoneNo.Enabled = _readonly
        rblEducation.Enabled = _readonly
        txtAddress.Enabled = _readonly
        btnContinueDemographic.Focus()
    End Sub
    Private Function FillDemographic(oFieldName As String) As Boolean
        Dim odb As New dbDataContext(ConnectionStringDemographic)
        Dim oDemographic As tblDemographic = Nothing
        If oFieldName.ToLower = "FileNo".ToLower Then
            oDemographic = odb.tblDemographics.Where(Function(f) f.FileNo = txtFileNo.Text.Trim).FirstOrDefault
        ElseIf oFieldName.ToLower = "NationalID".ToLower Then
            oDemographic = odb.tblDemographics.Where(Function(f) f.NationalID = txtNationalCode.Text.Trim).FirstOrDefault
        End If
        Session("Demographic") = oDemographic
        If oDemographic IsNot Nothing Then
            With oDemographic
                txtFileNo.Text = .FileNo
                txtNationalCode.Text = .NationalID
                txtFirstName.Text = .FirstNameOf
                txtLastName.Text = .LastNameOf
                dpBirthDateOf.SetFromMiladiValue(.BirthDateOf)
                If .WeightOf.HasValue Then txtWeight.Text = .WeightOf
                If .HeightOf.HasValue Then txtHeight.Text = .HeightOf
                rblGender.SelectedIndex = .GenderLU - 1
                If .MarriageLU.HasValue Then rblMarriage.SelectedIndex = .MarriageLU - 1
                If .EducationLU.HasValue Then rblEducation.SelectedIndex = .EducationLU - 1
                txtCellNo.Text = .CellNo
                txtPhoneNo.Text = .PhoneNo
                txtAddress.Text = .AddressOf
            End With
            Return (oDemographic Is Nothing)
        ElseIf oFieldName.ToLower = "FileNo".ToLower Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "پرونده‌ای با شماره " & txtFileNo.Text.Trim & " یافت نشد."
        End If

        If oFieldName.ToLower = "FileNo".ToLower Then
            ClearDemographicButTop()
            txtNationalCode.Text = ""
        ElseIf oFieldName.ToLower = "NationalID".ToLower Then
            ClearDemographicButTop()
            txtFileNo.Text = ""
        End If

        Return (oDemographic Is Nothing)
    End Function
    Private Sub ClearDemographicButTop()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        rblGender.SelectedIndex = -1
        txtAgeOf.Text = ""
        dpBirthDateOf.Clear()
        txtHeight.Text = ""
        txtWeight.Text = ""
        rblMarriage.SelectedIndex = -1
        txtCellNo.Text = ""
        txtPhoneNo.Text = ""
        rblEducation.SelectedIndex = -1
        txtAddress.Text = ""

    End Sub
    Private Sub btnCancelReg_Click(sender As Object, e As EventArgs) Handles btnCancelReg.Click
        pnlHistory.Visible = False
        pnlHistoryFooter.Visible = False
        pnlPages.Visible = False

        pnlDemographic.Visible = True
        pnlDemographicFooter.Visible = True

        btnCancelDemographic_Click(Nothing, Nothing)
        btnCancelHistory_Click(Nothing, Nothing)
        btnCancelPhysicalExam_Click(Nothing, Nothing)
        btnCacelLabResults_Click(Nothing, Nothing)

        Session("Demographic") = Nothing
        pnlSore01Body.Enabled = True
        pnlLaser01Body.Enabled = True
        pnlDebrid01Body.Enabled = True
        pnlGang01Body.Enabled = True
        pnlAmp01Body.Enabled = True
        pnlSurg01Body.Enabled = True
        pnlInPatient01Body.Enabled = True

    End Sub

    Private Sub FillHistory()
        Dim _DemographicID As Integer = Session("Demographic").ID
        Dim odb As New dbDataContext(ConnectionStringDiabeticFoot)
        Dim oRegistery = odb.tblRegisteries.Where(Function(f) f.DemographicID = _DemographicID).FirstOrDefault
        If oRegistery IsNot Nothing AndAlso oRegistery.tblHistories.Count = 1 Then
            With oRegistery.tblHistories(0)
                Session("History") = oRegistery.tblHistories(0)
                rblDiabetTypeOf.SelectedIndex = .DiabetTypeLU - 1
                Dim oNow = Getdate()
                txtDateOf01.Text = DateDiff(DateInterval.Year, .StartDateOf, oNow)
                dpDateOf01.SetFromMiladiValue(.StartDateOf)
                cbxSore01.Checked = .Sore
                If cbxSore01.Checked Then
                    txtDuration01.Text = DateDiff(DateInterval.Month, .SoreDateOf.Value, oNow)
                    dpLastSore01.SetFromMiladiValue(.SoreDateOf)
                    Dim _SoreLocationSLeft = .SoreLocationLeft.Split(",")
                    For Each oitem As ListItem In cblSoreLocationL01.Items
                        oitem.Selected = _SoreLocationSLeft.Contains(oitem.Value)
                    Next
                    Dim _SoreLocationSRight = .SoreLocationRight.Split(",")
                    For Each oitem As ListItem In cblSoreLocationR01.Items
                        oitem.Selected = _SoreLocationSRight.Contains(oitem.Value)
                    Next
                End If

                cbxLaser01.Checked = .Laser
                If cbxLaser01.Checked Then
                    txtDuration02.Text = DateDiff(DateInterval.Month, .LaserDateOf.Value, oNow)
                    dpLastLaser01.SetFromMiladiValue(.LaserDateOf)
                    Dim _Location = .LaserLocation.Split(",")
                    For Each oitem As ListItem In cblLaser.Items
                        oitem.Selected = _Location.Contains(oitem.Value)
                    Next
                End If

                cbxDebrid01.Checked = .Debrid
                If cbxDebrid01.Checked Then
                    txtDuration03.Text = DateDiff(DateInterval.Month, .DebridDateOf.Value, oNow)
                    dpLastDebrid01.SetFromMiladiValue(.DebridDateOf)
                    Dim _Location = .DebridLocation.Split(",")
                    For Each oitem As ListItem In cblDebrid.Items
                        oitem.Selected = _Location.Contains(oitem.Value)
                    Next
                End If
                cbxSurg01.Checked = .Surgery
                If cbxSurg01.Checked Then
                    txtDuration04.Text = DateDiff(DateInterval.Month, .SurgeryDateOf.Value, oNow)
                    dpLastSurg01.SetFromMiladiValue(.SurgeryDateOf)
                    Dim _LocationLeft = .SurgeryLocationLeft.Split(",")
                    For Each oitem As ListItem In cblSurgL.Items
                        oitem.Selected = _LocationLeft.Contains(oitem.Value)
                    Next
                    Dim _LocationRight = .SurgeryLocationRight.Split(",")
                    For Each oitem As ListItem In cblSurgR.Items
                        oitem.Selected = _LocationRight.Contains(oitem.Value)
                    Next
                End If
                cbxGang01.Checked = .Gangrene
                If cbxGang01.Checked Then
                    txtDuration05.Text = DateDiff(DateInterval.Month, .GangreneDateOf.Value, oNow)
                    dpLastGang01.SetFromMiladiValue(.GangreneDateOf)
                    Dim _Location = .GangreneLocation.Split(",")
                    For Each oitem As ListItem In cblGang.Items
                        oitem.Selected = _Location.Contains(oitem.Value)
                    Next
                End If
                cbxAmp01.Checked = .Amputation
                If cbxAmp01.Checked Then
                    txtDuration06.Text = DateDiff(DateInterval.Month, .AmputationDateOf.Value, oNow)
                    dpLastAmp01.SetFromMiladiValue(.AmputationDateOf)
                    Dim _LocationL = .AmputationLocationLeft.Split(",")
                    For Each oitem As ListItem In cblAmpL.Items
                        oitem.Selected = _LocationL.Contains(oitem.Value)
                    Next
                    Dim _Locationr = .AmputationLocationRight.Split(",")
                    For Each oitem As ListItem In cblAmpR.Items
                        oitem.Selected = _LocationL.Contains(oitem.Value)
                    Next
                End If
                If cbxInPatient.Checked Then
                    txtDuration07.Text = DateDiff(DateInterval.Month, .InPatientDateOf.Value, oNow)
                    dpLastInPatient01.SetFromMiladiValue(.InPatientDateOf)
                    txtSurg01Cause.Text = .InPatientReason
                End If
            End With
            pnlSore01Body.Enabled = False
            pnlLaser01Body.Enabled = False
            pnlDebrid01Body.Enabled = False
            pnlGang01Body.Enabled = False
            pnlAmp01Body.Enabled = False
            pnlSurg01Body.Enabled = False
            pnlInPatient01Body.Enabled = False
        End If

    End Sub
    Private Sub SaveHistory()
        If Session("History") IsNot Nothing Then Exit Sub
        Dim odb As New dbDataContext(ConnectionStringDiabeticFoot)
        Dim _DemographicID As Integer = Session("Demographic").ID

        Dim oRegistery = odb.tblRegisteries.Where(Function(f) f.DemographicID = _DemographicID).FirstOrDefault
        If oRegistery Is Nothing Then
            oRegistery = New tblRegistery With {.RegDateOf = Getdate(), .DemographicID = _DemographicID}
            odb.tblRegisteries.InsertOnSubmit(oRegistery)
            odb.SubmitChanges()
        End If

        Dim oHistory As New tblHistory
        odb.tblHistories.InsertOnSubmit(oHistory)
        With oHistory
            .Alcohol = cbxAlcohol.Checked
            .Amputation = cbxAmp01.Checked
            If CType(dpLastAmp01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .AmputationDateOf = dpLastAmp01.GetMiladiValue
            Else
                .AmputationDateOf = Getdate().AddMonths(-Val(txtDuration06.Text.Trim))
            End If
            Dim _str = ""
            For Each oitem As ListItem In cblAmpL.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .AmputationLocationLeft = _str
            _str = ""
            For Each oitem As ListItem In cblAmpR.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .AmputationLocationRight = _str
            .Debrid = cbxDebrid01.Checked
            If CType(dpLastDebrid01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .DebridDateOf = dpLastDebrid01.GetMiladiValue
            Else
                .DebridDateOf = Getdate().AddMonths(-Val(txtDuration03.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblDebrid.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .DebridLocation = _str
            .DiabetTypeLU = rblDiabetTypeOf.SelectedValue
            _str = ""
            For Each oitem As ListItem In cblDisease.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .Diseases = _str
            .Gangrene = cbxGang01.Checked
            If CType(dpLastGang01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .GangreneDateOf = dpLastGang01.GetMiladiValue
            Else
                .GangreneDateOf = Getdate().AddMonths(-Val(txtDuration05.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblGang.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .GangreneLocation = _str
            .InPatient = cbxInPatient.Checked
            If CType(dpLastInPatient01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .InPatientDateOf = dpLastInPatient01.GetMiladiValue
            Else
                .InPatientDateOf = Getdate().AddMonths(-Val(txtDuration07.Text.Trim))
            End If
            .InPatientReason = txtSurg01Cause.Text
            .Laser = cbxLaser01.Checked
            If CType(dpLastLaser01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .LaserDateOf = dpLastLaser01.GetMiladiValue
            Else
                .LaserDateOf = Getdate().AddMonths(-Val(txtDuration02.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblLaser.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .LaserLocation = _str
            .RegisteryID = oRegistery.ID
            .Sigarret = cbxSigarret.Checked
            .Sore = cbxSore01.Checked
            If CType(dpLastSore01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .SoreDateOf = dpLastSore01.GetMiladiValue
            Else
                .SoreDateOf = Getdate().AddMonths(-Val(txtDuration01.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblSoreLocationL01.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SoreLocationLeft = _str
            _str = ""
            For Each oitem As ListItem In cblSoreLocationR01.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SoreLocationRight = _str
            If CType(dpDateOf01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .StartDateOf = dpDateOf01.GetMiladiValue
            Else
                .StartDateOf = Getdate().AddMonths(-Val(txtDateOf01.Text.Trim))
            End If
            .Surgery = cbxSurg01.Checked
            If CType(dpLastSurg01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .SurgeryDateOf = dpLastSurg01.GetMiladiValue
            Else
                .SurgeryDateOf = Getdate().AddMonths(-Val(txtDuration04.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblSurgL.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SurgeryLocationLeft = _str
            For Each oitem As ListItem In cblSurgR.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SurgeryLocationRight = _str
        End With

        odb.SubmitChanges()
        Session("History") = oHistory
    End Sub
    Private Sub SaveContract()
        Dim odb As New dbDataContext(ConnectionStringDiabeticFoot)
        Dim oContract As tblContract = New tblContract
        If Session("Contract") Is Nothing Then
            oContract.HistoryID = Session("History").ID
            odb.tblContracts.InsertOnSubmit(oContract)
        End If
        Dim _str = ""
        With oContract
            'Physical Exam
            .CC = txtCC.Text.Trim
            .ContractDateOf = dpContract.GetMiladiValue
            If rblDry.SelectedIndex > -1 Then .DryLU = rblDry.SelectedValue
            If rblTemp.SelectedIndex > -1 Then .HeatLU = rblTemp.SelectedValue
            If cbxInfect01.Checked Then
                If CType(dpNewInfect.Controls(3).Controls(0), TextBox).Text <> "" Then
                    .InfectionDateOf = dpNewInfect.GetMiladiValue
                Else
                    .InfectionDateOf = Getdate().AddMonths(-Val(txtDuration10.Text.Trim))
                End If
                _str = ""
                For Each oitem As ListItem In cblNewInfectL.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .InfectionLocationLeft = _str
                _str = ""
                For Each oitem As ListItem In cblNewInfectR.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .InfectionLocationRight = _str
            End If
            .LargestLength = Val(txtNewMaxLength.Text)
            _str = ""
            For Each oitem As ListItem In cblNeuropathy.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .Neuropathy = _str
            .Sore = cbxSore02.Checked
            If cbxSore02.Checked Then
                .SoreCountLeft = Val(txtNewSoreCountOfL.Text)
                .SoreCountRight = Val(txtNewSoreCountOfR.Text)
                If CType(dpNewSore.Controls(3).Controls(0), TextBox).Text <> "" Then
                    .SoreDateOf = dpNewSore.GetMiladiValue
                Else
                    .SoreDateOf = Getdate().AddMonths(-Val(txtDuration08.Text.Trim))
                End If
                If rblNewWorstSoreL.SelectedIndex > -1 Then .WorstLeftSoreLU = rblNewWorstSoreL.SelectedValue
                If rblNewWorstSoreR.SelectedIndex > -1 Then .WorstRightSoreLU = rblNewWorstSoreR.SelectedValue
                _str = ""
                For Each oitem As ListItem In cblNewSoreL.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .SoreLocationLeft = _str
                _str = ""
                For Each oitem As ListItem In cblNewSoreR.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .SoreLocationRight = _str
            End If
            .Swell = cbxSwell01.Checked
            If cbxSwell01.Checked Then
                If CType(dpNewSwell.Controls(3).Controls(0), TextBox).Text <> "" Then
                    .SwellDateOf = dpNewSore.GetMiladiValue
                Else
                    .SwellDateOf = Getdate().AddMonths(-Val(txtDuration09.Text.Trim))
                End If
                _str = ""
                For Each oitem As ListItem In cblNewSwellL.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .SwellLocationLeft = _str
                _str = ""
                For Each oitem As ListItem In cblNewSwellR.Items
                    If oitem.Selected Then
                        If _str = "" Then
                            _str &= oitem.Value
                        Else
                            _str &= "," & oitem.Value
                        End If
                    End If
                Next
                .SwellLocationRight = _str
            End If
            .Amputation1 = cbxAmp02.Checked
            If CType(dpLastAmp02.Controls(3).Controls(0), TextBox).Text <> "" Then
                .AmputationDateOf = dpLastAmp02.GetMiladiValue
            Else
                .AmputationDateOf = Getdate().AddMonths(-Val(txtDuration15.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblAmp02L.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .AmputationLocationLeft = _str
            _str = ""
            For Each oitem As ListItem In cblAmp02R.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .AmputationLocationRight = _str
            .Debrid1 = cbxDebrid02.Checked
            If CType(dpLastDebrid01.Controls(3).Controls(0), TextBox).Text <> "" Then
                .DebridDateOf = dpLastDebrid02.GetMiladiValue
            Else
                .DebridDateOf = Getdate().AddMonths(-Val(txtDuration12.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblDebrid02.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .DebridLocation = _str
            .Gangrene = cbxGang02.Checked
            If CType(dpLastGang02.Controls(3).Controls(0), TextBox).Text <> "" Then
                .GangreneDateOf = dpLastGang02.GetMiladiValue
            Else
                .GangreneDateOf = Getdate().AddMonths(-Val(txtDuration14.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblGang02.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .GangreneLocation = _str
            .InPatient = cbxInPatient02.Checked
            If CType(dpLastInPatient02.Controls(3).Controls(0), TextBox).Text <> "" Then
                .InPatientDateOf = dpLastInPatient02.GetMiladiValue
            Else
                .InPatientDateOf = Getdate().AddMonths(-Val(txtDuration16.Text.Trim))
            End If
            .InPatientReason = txtSurg02Cause.Text
            .Laser = cbxLaser02.Checked
            If CType(dpLastLaser02.Controls(3).Controls(0), TextBox).Text <> "" Then
                .LaserDateOf = dpLastLaser02.GetMiladiValue
            Else
                .LaserDateOf = Getdate().AddMonths(-Val(txtDuration11.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblLaser.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .LaserLocation = _str
            .Surgery1 = cbxSurg02.Checked
            If CType(dpLastSurg02.Controls(3).Controls(0), TextBox).Text <> "" Then
                .SurgeryDateOf = dpLastSurg02.GetMiladiValue
            Else
                .SurgeryDateOf = Getdate().AddMonths(-Val(txtDuration13.Text.Trim))
            End If
            _str = ""
            For Each oitem As ListItem In cblSurg02L.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SurgeryLocationLeft = _str
            For Each oitem As ListItem In cblSurg02R.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .SurgeryLocationRight = _str


            'Lab Results
            .FBS = Val(txtFBS.Text)
            .A1C = Val(txtA1C.Text)
            .LabDateOf = dpDateOf02.GetMiladiValue
            If txtSystol.Text <> "" Then .Systol = Val(txtSystol.Text)
            If txtDyastol.Text <> "" Then .Dyastol = Val(txtDyastol.Text)
            If txtO2.Text <> "" Then .O2 = Val(txtO2.Text)
            If txtHR.Text <> "" Then .HR = Val(txtHR.Text)
            If txtRR.Text <> "" Then .RR = Val(txtRR.Text)
            If CType(dpDateOf03.Controls(3).Controls(0), TextBox).Text <> "" Then .VitalSignDateOf = dpDateOf03.GetMiladiValue

            'Prescription
            .Amputation = cbxNeedAmp.Checked
            .Surgery = cbxNeedSurg.Checked
            .Debrid = cbxDebrid01.Checked
            .Shoe = cbxNeedShoe.Checked
            .Visit = cbxNeedVisit.Checked
            .Cover = cbxNeedCover.Checked
            .Consult = cbxNeedEducation.Checked
            .Rehabilitation = cbxNeedRehab.Checked
            _str = ""
            For Each oitem As ListItem In cblDrugs.Items
                If oitem.Selected Then
                    If _str = "" Then
                        _str &= oitem.Value
                    Else
                        _str &= "," & oitem.Value
                    End If
                End If
            Next
            .Drug = _str
            .FreeText = txtFreeText.Text.Trim
        End With

        odb.SubmitChanges()
    End Sub
    Private Function CheckboxListisChecked(cbl As CheckBoxList) As Boolean
        For Each o As ListItem In cbl.Items
            If o.Selected Then Return True
        Next
        Return False
    End Function
    Private Function CheckpnlSore01() As Boolean
        If txtDuration01.Text = "" AndAlso Not dpLastSore01.GetMiladiValue.HasValue AndAlso CType(dpLastSore01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlSore01MSG.Visible = True
            lblSore01MSG.Text = "زمان ابتلا یا تاریخ آخرین زخم را تعیین نکرده اید."

            txtDuration01.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration01.Text.Trim), 0, 2000, CType(dpLastSore01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlSore01MSG.Visible = True
            lblSore01MSG.Text = "مقدار نامناسبی برای تاریخ آخرین زخم یا زمان ابتلا ثبت کرده اید."

            txtDuration01.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblSoreLocationL01) AndAlso Not CheckboxListisChecked(cblSoreLocationR01) Then
            pnlSore01MSG.Visible = True
            lblSore01MSG.Text = "محل زخم‌های قبلی را تعیین نکرده اید."

            cblSoreLocationL01.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlLaser01() As Boolean
        If txtDuration02.Text = "" AndAlso Not dpLastLaser01.GetMiladiValue.HasValue AndAlso CType(dpLastLaser01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlLaser01MSG.Visible = True
            lblLaser01MSG.Text = "زمان درمان یا تاریخ درمان با لیزر را تعیین نکرده اید."

            txtDuration02.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration02.Text.Trim), 0, 2000, CType(dpLastLaser01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlLaser01MSG.Visible = True
            lblLaser01MSG.Text = "مقدار نامناسبی برای زمان درمان یا تاریخ آخرین درمان با لیزر را ثبت کرده اید."

            txtDuration02.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblLaser) Then
            pnlLaser01MSG.Visible = True
            lblLaser01MSG.Text = "محل لیزرتراپی‌های قبلی را تعیین نکرده اید."

            cblLaser.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlDebrid01() As Boolean
        If txtDuration03.Text = "" AndAlso Not dpLastDebrid01.GetMiladiValue.HasValue AndAlso CType(dpLastDebrid01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlDebrid01MSG.Visible = True
            lblDebrid01MSG.Text = "زمان دبرید یا تاریخ آخرین دبریدمان را تعیین نکرده اید."

            txtDuration03.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration03.Text.Trim), 0, 2000, CType(dpLastDebrid01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlDebrid01MSG.Visible = True
            lblDebrid01MSG.Text = "مقدار نامناسبی برای زمان درمان یا تاریخ آخرین دبریدمان را ثبت کرده اید."

            txtDuration03.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblDebrid) Then
            pnlDebrid01MSG.Visible = True
            lblDebrid01MSG.Text = "محل دبریدمان‌های قبلی را تعیین نکرده اید."

            cblDebrid.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlSurg01() As Boolean
        If txtDuration04.Text = "" AndAlso Not dpLastSurg01.GetMiladiValue.HasValue AndAlso CType(dpLastSurg01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlSurg01MSG.Visible = True
            lblSurg01MSG.Text = "زمان جراحی یا تاریخ آخرین جراحی را تعیین نکرده اید."

            txtDuration04.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration04.Text.Trim), 0, 2000, CType(dpLastSurg01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlSurg01MSG.Visible = True
            lblSurg01MSG.Text = "مقدار نامناسبی برای زمان جراحی یا تاریخ آخرین جراحی را ثبت کرده اید."

            txtDuration04.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblSurgL) AndAlso Not CheckboxListisChecked(cblSurgR) Then
            pnlSurg01MSG.Visible = True
            lblSurg01MSG.Text = "محل جراحی‌های قبلی را تعیین نکرده اید."

            cblSurgL.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlGang01() As Boolean
        If txtDuration05.Text = "" AndAlso Not dpLastGang01.GetMiladiValue.HasValue AndAlso CType(dpLastGang01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlGang01MSG.Visible = True
            lblGang01MSG.Text = "زمان گانگرن یا تاریخ آخرین گانگرن را تعیین نکرده اید."

            txtDuration05.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration05.Text.Trim), 0, 2000, CType(dpLastGang01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlGang01MSG.Visible = True
            lblGang01MSG.Text = "مقدار نامناسبی برای زمان جراحی یا تاریخ آخرین گانگرن را ثبت کرده اید."

            txtDuration05.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblGang) Then
            pnlGang01MSG.Visible = True
            lblGang01MSG.Text = "محل گانگرن‌های قبلی را تعیین نکرده اید."

            cblGang.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlAmp01() As Boolean
        If txtDuration06.Text = "" AndAlso Not dpLastAmp01.GetMiladiValue.HasValue AndAlso CType(dpLastAmp01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlAmp01MSG.Visible = True
            lblAmp01MSG.Text = "زمان آمپوتاسیون یا تاریخ آخرین آمپوتاسیون را تعیین نکرده اید."

            txtDuration06.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration06.Text.Trim), 0, 2000, CType(dpLastAmp01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlAmp01MSG.Visible = True
            lblAmp01MSG.Text = "مقدار نامناسبی برای زمان آمپوتاسیون یا تاریخ آخرین آمپوتاسیون را ثبت کرده اید."

            txtDuration06.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblAmpL) AndAlso Not CheckboxListisChecked(cblAmpR) Then
            pnlAmp01MSG.Visible = True
            lblAmp01MSG.Text = "محل آمپوتاسیون‌های قبلی را تعیین نکرده اید."

            cblAmpL.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlInPatient01() As Boolean
        If txtDuration07.Text = "" AndAlso Not dpLastInPatient01.GetMiladiValue.HasValue AndAlso CType(dpLastInPatient01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlInPatient01MSG.Visible = True
            lblInPatient01MSG.Text = "زمان بستری یا تاریخ آخرین بستری را تعیین نکرده اید."

            txtDuration07.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration07.Text.Trim), 0, 2000, CType(dpLastInPatient01.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlInPatient01MSG.Visible = True
            lblInPatient01MSG.Text = "مقدار نامناسبی برای زمان بستری یا تاریخ آخرین بستری را ثبت کرده اید."

            txtDuration07.Focus()
            Return False
        ElseIf txtSurg01Cause.Text.Trim = "" Then
            pnlInPatient01MSG.Visible = True
            lblInPatient01MSG.Text = "علت بستری را تعیین نکرده اید."

            txtSurg01Cause.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlNewSore() As Boolean
        If txtDuration08.Text = "" AndAlso Not dpNewSore.GetMiladiValue.HasValue AndAlso CType(dpNewSore.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "زمان زخم یا تاریخ ایجاد زخم را تعیین نکرده اید."

            txtDuration08.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration08.Text.Trim), 0, 2000, CType(dpNewSore.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "مقدار نامناسبی برای زمان زخم یا تاریخ ایجاد زخم را ثبت کرده اید."

            txtDuration08.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblNewSoreL) AndAlso Not CheckboxListisChecked(cblNewSoreR) Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "محل زخم‌های جدید را تعیین نکرده اید."

            cblNewSoreL.Focus()

            Return False
        ElseIf txtNewSoreCountOfL.Text.Trim = "" Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "تعداد زخم‌های پای چپ را تعیین نکرده اید."

            txtNewSoreCountOfL.Focus()

            Return False
        ElseIf txtNewSoreCountOfR.Text.Trim = "" Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "تعداد زخم‌های پای راست را تعیین نکرده اید."

            txtNewSoreCountOfR.Focus()

            Return False
        ElseIf txtNewMaxLength.Text.Trim = "" Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "طول بزرگترین زخم را تعیین نکرده اید."

            txtNewMaxLength.Focus()

            Return False
        ElseIf rblNewWorstSoreL.SelectedIndex = -1 AndAlso rblNewWorstSoreR.SelectedIndex = -1 Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "شدت زخم‌های جدید را تعیین نکرده اید."

            rblNewWorstSoreL.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlNewInfection() As Boolean
        If txtDuration09.Text = "" AndAlso Not dpNewInfect.GetMiladiValue.HasValue AndAlso CType(dpNewInfect.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlInfect01MSG.Visible = True
            lblInfect01MSG.Text = "زمان عفونت یا تاریخ ایجاد عفونت را تعیین نکرده اید."

            txtDuration09.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration09.Text.Trim), 0, 2000, CType(dpNewInfect.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlInfect01MSG.Visible = True
            lblInfect01MSG.Text = "مقدار نامناسبی برای زمان عفونت یا تاریخ ایجاد عفونت را ثبت کرده اید."

            txtDuration09.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblNewInfectL) AndAlso Not CheckboxListisChecked(cblNewInfectR) Then
            pnlInfect01MSG.Visible = True
            lblInfect01MSG.Text = "محل عفونت جدید را تعیین نکرده اید."

            cblNewInfectL.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlNewSwell() As Boolean
        If txtDuration10.Text = "" AndAlso Not dpNewSwell.GetMiladiValue.HasValue AndAlso CType(dpNewSwell.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlSwell01MSG.Visible = True
            lblSwell01MSG.Text = "زمان تورم، تاول و قرمزی یا تاریخ آن‌ها را تعیین نکرده اید."

            txtDuration10.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration10.Text.Trim), 0, 2000, CType(dpNewSwell.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlSwell01MSG.Visible = True
            lblSwell01MSG.Text = "مقدار نامناسبی برای زمان تورم، تاول و قرمزی یا تاریخ ایجاد آن‌ها را ثبت کرده اید."

            txtDuration10.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblNewSwellL) AndAlso Not CheckboxListisChecked(cblNewSwellR) Then
            pnlSwell01MSG.Visible = True
            lblSwell01MSG.Text = "محل تورم، تاول و قرمزی‌های جدید را تعیین نکرده اید."

            cblNewSwellL.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlLaser02() As Boolean
        If txtDuration11.Text = "" AndAlso Not dpLastLaser02.GetMiladiValue.HasValue AndAlso CType(dpLastLaser02.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlLaser02MSG.Visible = True
            lblLaser02MSG.Text = "زمان یا تاریخ درمان با لیزر را تعیین نکرده اید."

            txtDuration11.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration11.Text.Trim), 0, 2000, CType(dpLastLaser02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlLaser02MSG.Visible = True
            lblLaser02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ درمان با لیزر را ثبت کرده اید."

            txtDuration11.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblLaser02) Then
            pnlLaser02MSG.Visible = True
            lblLaser02MSG.Text = "محل لیزرتراپی را تعیین نکرده اید."

            cblLaser02.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlDebrid02() As Boolean
        If txtDuration12.Text = "" AndAlso Not dpLastDebrid02.GetMiladiValue.HasValue AndAlso CType(dpLastDebrid02.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlDebrid02MSG.Visible = True
            lblDebrid02MSG.Text = "زمان یا تاریخ دبریدمان را تعیین نکرده اید."

            txtDuration12.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration12.Text.Trim), 0, 2000, CType(dpLastDebrid02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlDebrid02MSG.Visible = True
            lblDebrid02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ دبریدمان را ثبت کرده اید."

            txtDuration12.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblDebrid02) Then
            pnlDebrid02MSG.Visible = True
            lblDebrid02MSG.Text = "محل دبریدمان را تعیین نکرده اید."

            cblDebrid02.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlSurg02() As Boolean
        If txtDuration13.Text = "" AndAlso Not dpLastSurg01.GetMiladiValue.HasValue AndAlso CType(dpLastSurg01.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlSurg02MSG.Visible = True
            lblSurg02MSG.Text = "زمان یا تاریخ جراحی را تعیین نکرده اید."

            txtDuration13.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration13.Text.Trim), 0, 2000, CType(dpLastSurg02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlSurg02MSG.Visible = True
            lblSurg02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ جراحی را ثبت کرده اید."

            txtDuration13.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblSurg02L) AndAlso Not CheckboxListisChecked(cblSurg02R) Then
            pnlSurg02MSG.Visible = True
            lblSurg02MSG.Text = "محل جراحی را تعیین نکرده اید."

            cblSurg02L.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlGang02() As Boolean
        If txtDuration14.Text = "" AndAlso Not dpLastGang02.GetMiladiValue.HasValue AndAlso CType(dpLastGang02.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlGang02MSG.Visible = True
            lblGang02MSG.Text = "زمان یا تاریخ گانگرن را تعیین نکرده اید."

            txtDuration14.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration14.Text.Trim), 0, 2000, CType(dpLastGang02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlGang02MSG.Visible = True
            lblGang02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ گانگرن را ثبت کرده اید."

            txtDuration14.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblGang02) Then
            pnlGang02MSG.Visible = True
            lblGang02MSG.Text = "محل گانگرن را تعیین نکرده اید."

            cblGang02.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlAmp02() As Boolean
        If txtDuration15.Text = "" AndAlso Not dpLastAmp02.GetMiladiValue.HasValue AndAlso CType(dpLastAmp02.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlAmp02MSG.Visible = True
            lblAmp02MSG.Text = "زمان یا تاریخ آمپوتاسیون را تعیین نکرده اید."

            txtDuration15.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration15.Text.Trim), 0, 2000, CType(dpLastAmp02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlAmp02MSG.Visible = True
            lblAmp02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ آمپوتاسیون را ثبت کرده اید."

            txtDuration15.Focus()
            Return False
        ElseIf Not CheckboxListisChecked(cblAmp02L) AndAlso Not CheckboxListisChecked(cblAmp02R) Then
            pnlAmp02MSG.Visible = True
            lblAmp02MSG.Text = "محل آمپوتاسیون را تعیین نکرده اید."

            cblAmp02L.Focus()

            Return False
        End If

        Return True
    End Function
    Private Function CheckpnlInPatient02() As Boolean
        If txtDuration16.Text = "" AndAlso Not dpLastInPatient02.GetMiladiValue.HasValue AndAlso CType(dpLastInPatient02.Controls(3).Controls(0), TextBox).Text = "" Then
            pnlInPatient02MSG.Visible = True
            lblInPatient02MSG.Text = "زمان یا تاریخ بستری را تعیین نکرده اید."

            txtDuration16.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration16.Text.Trim), 0, 2000, CType(dpLastInPatient02.Controls(3).Controls(0), TextBox).Text, "M") Then
            pnlInPatient02MSG.Visible = True
            lblInPatient02MSG.Text = "مقدار نامناسبی برای زمان یا تاریخ بستری را ثبت کرده اید."

            txtDuration16.Focus()
            Return False
        ElseIf txtSurg02Cause.Text.Trim = "" Then
            pnlInPatient02MSG.Visible = True
            lblInPatient02MSG.Text = "علت بستری را تعیین نکرده اید."

            txtSurg02Cause.Focus()

            Return False
        End If

        Return True
    End Function

End Class