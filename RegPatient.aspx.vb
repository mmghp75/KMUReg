Imports KMUReg.SharedMethodClass
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
            txtNationalCode.Focus()
            Session("Demographic") = Nothing
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
        If Not CheckpnlSore01() Then Exit Sub
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
        If Not CheckpnlLaser() Then Exit Sub
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
        If Not CheckpnlDebrid() Then Exit Sub
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
        If Not CheckpnlSurg() Then Exit Sub
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
        If Not CheckpnlGang() Then Exit Sub
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
        If Not CheckpnlAmp() Then Exit Sub
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
        If Not CheckpnlInPatient() Then Exit Sub
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
        If Not CheckpnlNewSore() Then Exit Sub
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
        If Not CheckpnlNewInfection() Then Exit Sub
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
        If Not CheckpnlNewSwell() Then Exit Sub
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

        'hfExpanedPanelIds.Value = "pnlHistory"
        hfActivePanelId.Value = "History"
        UpdateDemographicData()
    End Sub
    Private Function CheckDemographicPanelData() As Boolean
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
        SaveHistory()
        SavePhysicalExam()
        SaveLabResults()
        SavePrescription()

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

        Session("Demographic") = Nothing
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
                cbxSurgery01.Checked = .Surgery
                If cbxSurgery01.Checked Then
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
                cbxGangrene01.Checked = .Gangrene
                If cbxGangrene01.Checked Then
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
            .Gangrene = cbxGangrene01.Checked
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

            .RegisteryID = oRegistery.id
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
            .Surgery = cbxSurgery01.Checked
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
    End Sub
    Private Sub SavePhysicalExam()

    End Sub
    Private Sub SaveLabResults()

    End Sub
    Private Sub SavePrescription()

    End Sub
    Private Function CheckboxListisChecked(cbl As CheckBoxList) As Boolean
        For Each o As ListItem In cbl.Items
            If o.Selected Then Return True
        Next
        Return False
    End Function
    Private Function CheckpnlSore01() As Boolean
        If txtDuration01.Text = "" AndAlso Not dpLastSore01.GetMiladiValue.HasValue Then
            pnlSore01MSG.Visible = True
            lblSore01MSG.Text = "زمان ابتلا یا تاریخ آخرین زخم را تعیین نکرده اید."

            txtDuration01.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration01.Text.Trim), 0, 2000, dpLastSore01.GetMiladiValue, "M") Then
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
    Private Function CheckpnlLaser() As Boolean
        If txtDuration02.Text = "" AndAlso Not dpLastLaser01.GetMiladiValue.HasValue Then
            pnlLaser01MSG.Visible = True
            lblLaser01MSG.Text = "زمان درمان یا تاریخ درمان با لیزر را تعیین نکرده اید."

            txtAgeOf.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration02.Text.Trim), 0, 2000, dpLastLaser01.GetMiladiValue, "M") Then
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
    Private Function CheckpnlDebrid() As Boolean
        If txtDuration03.Text = "" AndAlso Not dpLastDebrid01.GetMiladiValue.HasValue Then
            pnlDebrid01MSG.Visible = True
            lblDebrid01MSG.Text = "زمان دبرید یا تاریخ آخرین دبریدمان را تعیین نکرده اید."

            txtDuration03.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration03.Text.Trim), 0, 2000, dpLastDebrid01.GetMiladiValue, "M") Then
            pnlDebrid01MSG.Visible = True
            lblDebrid01MSG.Text = "مقدار نامناسبی برای زمان درمان یا تاریخ آخرین درمان با لیزر را ثبت کرده اید."

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
    Private Function CheckpnlSurg() As Boolean
        If txtDuration04.Text = "" AndAlso Not dpLastSurg01.GetMiladiValue.HasValue Then
            pnlSurg01MSG.Visible = True
            lblSurg01MSG.Text = "زمان جراحی یا تاریخ آخرین جراحی را تعیین نکرده اید."

            txtDuration04.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration04.Text.Trim), 0, 2000, dpLastSurg01.GetMiladiValue, "M") Then
            pnlSurg01MSG.Visible = True
            lblSurg01MSG.Text = "مقدار نامناسبی برای زمان [جراحی یا تاریخ آخرین جراحی را ثبت کرده اید."

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
    Private Function CheckpnlGang() As Boolean
        If txtDuration05.Text = "" AndAlso Not dpLastGang01.GetMiladiValue.HasValue Then
            pnlGang01MSG.Visible = True
            lblGang01MSG.Text = "زمان گانگرن یا تاریخ آخرین گانگرن را تعیین نکرده اید."

            txtDuration05.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration05.Text.Trim), 0, 2000, dpLastGang01.GetMiladiValue, "M") Then
            pnlGang01MSG.Visible = True
            lblGang01MSG.Text = "مقدار نامناسبی برای زمان [جراحی یا تاریخ آخرین جراحی را ثبت کرده اید."

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
    Private Function CheckpnlAmp() As Boolean
        If txtDuration06.Text = "" AndAlso Not dpLastAmp01.GetMiladiValue.HasValue Then
            pnlAmp01MSG.Visible = True
            lblAmp01MSG.Text = "زمان آمپوتاسیون یا تاریخ آخرین آمپوتاسیون را تعیین نکرده اید."

            txtDuration06.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration06.Text.Trim), 0, 2000, dpLastAmp01.GetMiladiValue, "M") Then
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
    Private Function CheckpnlInPatient() As Boolean
        If txtDuration07.Text = "" AndAlso Not dpLastInPatient01.GetMiladiValue.HasValue Then
            pnlInPatient01MSG.Visible = True
            lblInPatient01MSG.Text = "زمان بستری یا تاریخ آخرین بستری را تعیین نکرده اید."

            txtDuration07.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration07.Text.Trim), 0, 2000, dpLastInPatient01.GetMiladiValue, "M") Then
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
        If txtDuration08.Text = "" AndAlso Not dpNewSore.GetMiladiValue.HasValue Then
            pnlSore02MSG.Visible = True
            lblSore02MSG.Text = "زمان زخم یا تاریخ ایجاد زخم را تعیین نکرده اید."

            txtDuration08.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration08.Text.Trim), 0, 2000, dpNewSore.GetMiladiValue, "M") Then
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
        If txtDuration09.Text = "" AndAlso Not dpNewInfect.GetMiladiValue.HasValue Then
            pnlInfect01MSG.Visible = True
            lblInfect01MSG.Text = "زمان عفونت یا تاریخ ایجاد عفونت را تعیین نکرده اید."

            txtDuration09.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration09.Text.Trim), 0, 2000, dpNewInfect.GetMiladiValue, "M") Then
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
        If txtDuration10.Text = "" AndAlso Not dpNewSwell.GetMiladiValue.HasValue Then
            pnlSwell01MSG.Visible = True
            lblSwell01MSG.Text = "زمان تورم، تاول و قرمزی یا تاریخ آن‌ها را تعیین نکرده اید."

            txtDuration10.Focus()
            Return False
        ElseIf isNotValidDateOf(Val(txtDuration10.Text.Trim), 0, 2000, dpNewSwell.GetMiladiValue, "M") Then
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
End Class