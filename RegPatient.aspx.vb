﻿Imports KMUReg.SharedMethodClass
Public Class RegPatient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack Then
            hfActivePanelId.Value = Request.Form(hfActivePanelId.UniqueID)
            'MsgBox(hfActivePanelId.Value)

            pnlDemographicMessage.Visible = False
            pnlHistoryMessage.Visible = False
            pnlPhysicalExamMessage.Visible = False
            pnlLabResultsMessage.Visible = False
            pnlPrescriptionMessage.Visible = False
        Else
            txtNationalCode.Focus()
        End If
    End Sub
    Private Sub cbxSore01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSore01.CheckedChanged
        If cbxSore01.Checked Then
            ShowModalPopup(Me, "pnlSore01")
            hfNewPanelVisibility.Value = 1

            pnlSore01.Style.Item("display") = "block"
            pnlSore01.Attributes("aria-hidden") = "false"
            pnlSore01.CssClass = "modal fade in"
            pnlSore01Back.Visible = True

            hfActivePanelId.Value = "History"
        End If

        'GetStep2Panels()
    End Sub
    Private Sub cbxLaser01_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLaser01.CheckedChanged
        If cbxLaser01.Checked Then
            ShowModalPopup(Me, "pnlLaser01")
            hfNewPanelVisibility.Value = 1

            pnlLaser01.Style.Item("display") = "block"
            pnlLaser01.Attributes("aria-hidden") = "false"
            pnlLaser01.CssClass = "modal fade in"
            pnlLaser01Back.Visible = True

            hfActivePanelId.Value = "History"
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

            hfActivePanelId.Value = "History"
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

            hfActivePanelId.Value = "History"
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

            hfActivePanelId.Value = "History"
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

            hfActivePanelId.Value = "History"
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

            hfActivePanelId.Value = "History"
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

        'GetStep2Panels()
    End Sub

    'Private Sub GetStep2Panels()
    '    Dim panels = {
    '        New CollapsePanelGroup(pnlHistory, lblHistoryTitle, collapseHistoryMessage),
    '        New CollapsePanelGroup(pnlPhysicalExam, lblPhysicalExamTitle, collapsePhysicalExam),
    '        New CollapsePanelGroup(pnlLabResults, lblLabResultsTitle, collapseLabResults),
    '        New CollapsePanelGroup(pnlPrescription, lblPrescriptionTitle, collapsePrescription)
    '    }
    '    ExpandPanel(Me, panels, hfExpanedPanelIds.Value.Split(" "))
    'End Sub

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

            hfActivePanelId.Value = "PhysicalExam"
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

            hfActivePanelId.Value = "PhysicalExam"
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

            hfActivePanelId.Value = "PhysicalExam"
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
        rblMarriage.SelectedIndex = -1
        txtCellNo.Text = ""
        txtPhoneNo.Text = ""
        rblEducation.SelectedIndex = -1
        txtAddress.Text = ""
        txtNationalCode.Focus()
    End Sub
    Private Sub btnContinueDemographic_Click(sender As Object, e As EventArgs) Handles btnContinueDemographic.Click
        If CheckDemographicPanelDate() Then Exit Sub

        pnlDemographic.Visible = False
        pnlDemographicFooter.Visible = False

        pnlHistory.Visible = True
        pnlHistoryFooter.Visible = True
        pnlPages.Visible = True

        btnCancelHistory_Click(Nothing, Nothing)
        btnCancelPhysicalExam_Click(Nothing, Nothing)
        btnCacelLabResults_Click(Nothing, Nothing)
        btnCancelPrescription_Click(Nothing, Nothing)

        'hfExpanedPanelIds.Value = "pnlHistory"
        hfActivePanelId.Value = "History"
        UpdateDemographicData()
    End Sub
    Private Function CheckDemographicPanelDate() As Boolean
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
        ElseIf txtAgeOf.Text = "" AndAlso Not dpBirthDateOf.GetMiladiValue.HasValue Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "تاریخ تولد یا سن را تعیین نکرده اید."

            txtAgeOf.Focus()
            Return True
        ElseIf isNotValidDateOf(Val(txtAgeOf.Text.Trim), 10, 150, dpBirthDateOf.GetMiladiValue, "Y") Then
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
    End Sub
    Private Sub btnCancelHistory_Click(sender As Object, e As EventArgs) Handles btnCancelHistory.Click
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

        hfActivePanelId.Value = "History"
    End Sub
    Private Sub btnCancelPhysicalExam_Click(sender As Object, e As EventArgs) Handles btnCancelPhysicalExam.Click
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

        hfActivePanelId.Value = "PhysicalExam"
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

        hfActivePanelId.Value = "LabResults"
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

        hfActivePanelId.Value = "Prescription"
        Dim oScript As String = "var selectedTab = $(""#<%=hfActivePanelId.ClientID%>"");" & vbCrLf &
                                "var tabId = selectedTab.val() != """" ? selectedTab.val() : ""PhysicalExam"";" & vbCrLf &
                                "$('#dvTab a[href=""#' + tabId + '""]').tab('show');" & vbCrLf &
                                "$(""#dvTab a"").click(function () {" & vbCrLf &
                                "    selectedTab.val($(this).attr(""href"").substring(1));" & vbCrLf &
                                "});"
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "ActiveLastTab", oScript, True)
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If rblDiabetTypeOf.SelectedIndex = -1 Then
            pnlHistoryMessage.Visible = True
            lbllHistoryMessage.Text = "نوع دیابت را تعیین نکرده اید."

            rblDiabetTypeOf.Focus()
            Exit Sub
        ElseIf txtDateOf01.Text = "" AndAlso Not dpDateOf01.GetMiladiValue.HasValue Then
            pnlHistoryMessage.Visible = True
            lbllHistoryMessage.Text = "مدت یا تاریخ ابتلا به دیابت را تعیین نکرده اید."

            txtDateOf01.Focus()
            Exit Sub
        ElseIf isNotValidDateOf(Val(txtDateOf01.Text.Trim), 0, 1000, dpDateOf01.GetMiladiValue, "Y") Then
            pnlHistoryMessage.Visible = True
            lbllHistoryMessage.Text = "مدت یا تاریخ ابتلا به دیابت در محدوده‌ی قابل قبول نمی‌باشد."

            txtDateOf01.Focus()
            Exit Sub
        ElseIf txtCC.Text.Trim = "" Then
            pnlPhysicalExamMessage.Visible = True
            lblPhysicalExamMessage.Text = "علت مراجعه را ثبت نکرده اید."

            txtCC.Focus()
            Exit Sub
        ElseIf txtFBS.Text = "" Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار FBS را ثبت نکرده اید."

            txtFBS.Focus()
            Exit Sub
        ElseIf txtA1C.Text = "" Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار A1C را ثبت نکرده اید."

            txtA1C.Focus()
            Exit Sub
        ElseIf Not dpDateOf02.GetMiladiValue.HasValue Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "تاریخ انجام آزمایشات را ثبت نکرده اید."

            dpDateOf02.Focus()
            Exit Sub
        ElseIf (txtSystol.Text <> "" OrElse txtDyastol.Text <> "" OrElse txtHR.Text <> "" OrElse txtRR.Text <> "" OrElse txtO2.Text <> "") AndAlso Not dpDateOf03.GetMiladiValue.HasValue Then
            pnlLabResultsMessage.Visible = True
            lblLabResultsMessage.Text = "مقدار تاریخ ثبت علائم حیاتی را وارد نکرده اید."

            dpDateOf03.Focus()
            Exit Sub
        End If
        SaveHistory
        SavePhysicalExam
        SaveLabResults
        SavePrescription

        btnCancelReg_Click(Nothing, Nothing)
    End Sub
    Private Function isNotValidDateOf(oNumber As Integer, oNMin As Integer, oNMax As Integer, oDateOf As DateTime?, oDatePart As String) As Boolean
        If oDateOf IsNot Nothing Then
            Dim oNow = Getdate()
            Dim _Number As Long = 0
            If oDatePart.ToLower = "Y".ToLower Then
                _Number = DateDiff(DateInterval.Year, oDateOf.Value, oNow)
            ElseIf oDatePart.ToLower = "M".ToLower Then
                _Number = DateDiff(DateInterval.Month, oDateOf.Value, oNow)
            ElseIf oDatePart.ToLower = "D".ToLower Then
                _Number = DateDiff(DateInterval.Day, oDateOf.Value, oNow)
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

        FillDemographic("FileNo")
    End Sub
    Private Sub txtNationalCode_TextChanged(sender As Object, e As EventArgs) Handles txtNationalCode.TextChanged
        If txtNationalCode.Text.Trim = "" Then
            btnCancelDemographic_Click(Nothing, Nothing)
            Exit Sub
        End If

        FillDemographic("NationalID")
    End Sub
    Private Sub FillDemographic(oFieldName As String)
        Dim odb As New dbDataContext(ConnectionStringDemographic)
        Dim oDemographic As tblDemographic = Nothing
        If oFieldName.ToLower = "FileNo".ToLower Then
            oDemographic = odb.tblDemographics.Where(Function(f) f.FileNo = txtFileNo.Text.Trim).FirstOrDefault
        ElseIf oFieldName.ToLower = "NationalID".ToLower Then
            oDemographic = odb.tblDemographics.Where(Function(f) f.NationalID = txtNationalCode.Text.Trim).FirstOrDefault
        End If

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
        ElseIf oFieldName.ToLower = "FileNo".ToLower Then
            pnlDemographicMessage.Visible = True
            lblDemographicMessage.Text = "پرونده‌ای با شماره " & txtFileNo.Text.Trim & " یافت نشد."
        End If
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
    End Sub
    Private Sub FillHistory()

    End Sub
    Private Sub SaveHistory()

    End Sub
    Private Sub SavePhysicalExam()

    End Sub
    Private Sub SaveLabResults()

    End Sub
    Private Sub SavePrescription()

    End Sub
End Class