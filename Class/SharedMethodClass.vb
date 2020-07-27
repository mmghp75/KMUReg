﻿Imports System.Globalization
Imports KMUReg.SharedConstantClasses
Imports Telerik.Web.UI

Public Class SharedMethodClass

    Public Shared Sub ShowMessage(ByRef lit As Literal, textMessage As String, messageType As eMessageType, Optional showCloseButton As Boolean = True)
        Dim alertClass As String = ""
        Select Case messageType
            Case eMessageType.danger
                alertClass = "danger"

            Case eMessageType.info
                alertClass = "info"

            Case eMessageType.success
                alertClass = "success"

            Case eMessageType.warning
                alertClass = "warning"

        End Select

        lit.Text = String.Concat("<div class=""alert alert-", alertClass, """ role=""alert"">")
        If showCloseButton Then
            lit.Text += "<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>"
        End If
        lit.Text += String.Concat("   <span id=""", lit.ID, """>", textMessage, "</span>")
        lit.Text += "</div>"

    End Sub

    Enum eFocusType
        click
        focus
    End Enum
    'Public Shared Sub ShowModalPopup(page As Page, modalPopupClientID As String, Optional FocusedControlClientId As String = Nothing, Optional focusType As eFocusType = eFocusType.focus)
    Public Shared Sub ShowModalPopup(page As Object,
                                     modalPopupClientID As String,
                                     Optional focusType As eFocusType = eFocusType.focus,
                                     Optional firstControlIdInPanel As String = Nothing,
                                     Optional lastControlIdInPanel As String = Nothing,
                                     Optional controlIdForFocus As String = Nothing)
        Dim sb As New StringBuilder

        sb.AppendLine("
<script> $(document).ready(function () {    
")

        If firstControlIdInPanel IsNot Nothing AndAlso lastControlIdInPanel IsNot Nothing Then
            sb.AppendLine("

var firstInput = $('#" & firstControlIdInPanel & "');
            var lastInput = $('#" & lastControlIdInPanel & "');
    var controlIdForFocus = $('#" & controlIdForFocus & "');

    /*set focus on first input*/
    controlIdForFocus.focus();

    /*redirect last tab to first input*/
    lastInput.on('keydown', function (e) {
       if ((e.which === 9 && !e.shiftKey)) {
           e.preventDefault();
           firstInput.focus();
       }
    });

    /*redirect first shift+tab to last input*/
    firstInput.on('keydown', function (e) {
        if ((e.which === 9 && e.shiftKey)) {
            e.preventDefault();
            lastInput.focus();
        }
    }); 

")
        End If


        If controlIdForFocus IsNot Nothing AndAlso focusType = eFocusType.click Then
            Select Case focusType
                Case eFocusType.focus
                    sb.AppendLine("$('#" & modalPopupClientID & "').on('shown.bs.modal', function () {$('#" & controlIdForFocus & "').focus();});")

                Case eFocusType.click
                    sb.AppendLine("$('#" & modalPopupClientID & "').on('shown.bs.modal', function () {$('#" & controlIdForFocus & "').click();});")

            End Select
        End If

        sb.AppendLine("$('#" & modalPopupClientID & "').modal('show');  ")
        sb.AppendLine("}); </script>")


        ScriptManager.RegisterClientScriptBlock(page, page.GetType, "none", sb.ToString, False)
    End Sub
    Public Shared Sub RegisterScriptSignalRListener(page As Page,
                                                    hubMethodName As String,
                                                    registerScript As String)
        Dim sb As New StringBuilder

        'Reference the autogenerated SignalR hub script. 
        sb.AppendLine("    <script type=""text/javascript"" src=""/signalr/hubs""></script>")
        'Add script to update the page and send messages.
        sb.AppendLine("    <script type=""text/javascript"">")
        sb.AppendLine("        $(function () {")
        'Declare a proxy to reference the hub.")
        sb.AppendLine("            var notify = $.connection.notifyHub;")
        'Create a function that the hub can call to Broadcast messages.")
        sb.AppendLine("            notify.client." & hubMethodName & " = function () {")

        sb.AppendLine(registerScript)

        sb.AppendLine("            };")
        sb.AppendLine()
        'Start the connection.")
        sb.AppendLine("            $.connection.hub.start();")
        sb.AppendLine("        });")
        sb.AppendLine()

        sb.AppendLine("        ")
        sb.AppendLine("    </script>")

        ScriptManager.RegisterClientScriptBlock(page, page.GetType, hubMethodName, sb.ToString, False)

    End Sub
    Public Shared Sub RegisterNotifySignalRListener(page As Page,
                                                    hubMethodName As String,
                                                    messageType As eMessageType) ',
        'Optional ProviderID As String = "")
        Dim sb As New StringBuilder

        'Reference the autogenerated SignalR hub script. 
        sb.AppendLine("    <script type=""text/javascript"" src=""/signalr/hubs""></script>")
        'Add script to update the page and send messages.
        sb.AppendLine("    <script type=""text/javascript"">")
        sb.AppendLine("        $(function () {")
        'Declare a proxy to reference the hub.")
        sb.AppendLine("            var notify = $.connection.notifyHub;")
        'Create a function that the hub can call to Broadcast messages.")
        sb.AppendLine("            notify.client." & hubMethodName & " = function (messageTitle, messageText) {")
        sb.AppendLine("                callNotify(messageTitle, messageText, """ & messageType.ToString & """, null);")
        sb.AppendLine("            };")
        sb.AppendLine()
        'Start the connection.")
        sb.AppendLine("            $.connection.hub.start();")
        sb.AppendLine("        });")
        sb.AppendLine()

        sb.AppendLine("        ")
        sb.AppendLine("    </script>")

        ScriptManager.RegisterClientScriptBlock(page, page.GetType, hubMethodName, sb.ToString, False)

        GetNotifyMethod(page)

    End Sub
    Public Shared Sub RegisterNotifySignalRListenerForSpecifiedUsers(page As Page,
                                                                     hubMethodName As String,
                                                                     messageType As eMessageType,
                                                                     userID As String)
        Dim sb As New StringBuilder

        'Reference the autogenerated SignalR hub script. 
        sb.AppendLine("    <script type=""text/javascript"" src=""/signalr/hubs""></script>")
        'Add script to update the page and send messages.
        sb.AppendLine("    <script type=""text/javascript"">")
        sb.AppendLine("        $(function () {")
        'Declare a proxy to reference the hub.")
        sb.AppendLine("            var notify = $.connection.notifyHub;")
        'Create a function that the hub can call to Broadcast messages.")
        sb.AppendLine("            notify.client." & hubMethodName & " = function (messageTitle, messageText, specifiedUserIDS) {")
        sb.AppendLine("                if ((specifiedUserIDS != undefined) && ($.inArray('" & userID & "', specifiedUserIDS.split(',')) != -1)){ ")
        sb.AppendLine("                     callNotify(messageTitle, messageText, """ & messageType.ToString & """, null);")
        sb.AppendLine("                 }")
        sb.AppendLine("            };")
        sb.AppendLine()
        'Start the connection.")
        sb.AppendLine("            $.connection.hub.start();")
        sb.AppendLine("        });")
        sb.AppendLine()

        sb.AppendLine("        ")
        sb.AppendLine("    </script>")

        ScriptManager.RegisterClientScriptBlock(page, page.GetType, hubMethodName, sb.ToString, False)

        GetNotifyMethod(page)

    End Sub
    Private Shared Sub GetNotifyMethod(page As Page, Optional onShowCallingMethod As String = Nothing)
        Dim sb As New StringBuilder

        'Reference the Notify library. 
        sb.AppendLine("    <script type=""text/javascript"" src=""Scripts/bootstrap-notify.min.js""></script>")
        sb.AppendLine("    <script type=""text/javascript"">")
        sb.AppendLine("        function callNotify(_title, _message, _messageType, _url) {")
        sb.AppendLine("            $.notify({")
        sb.AppendLine("                // options")
        sb.AppendLine("                icon: 'glyphicon glyphicon-warning-sign',")
        sb.AppendLine("                title: _title,")
        sb.AppendLine("                message: _message,")
        sb.AppendLine("                url: _url,")
        sb.AppendLine("                target: '_blank'")
        sb.AppendLine("            }, {")
        sb.AppendLine("                // settings")
        sb.AppendLine("                element: 'body',")
        sb.AppendLine("                position: null,")
        sb.AppendLine("                type: _messageType,")
        sb.AppendLine("                allow_dismiss: true,")
        sb.AppendLine("                newest_on_top: false,")
        sb.AppendLine("                showProgressbar: false,")
        sb.AppendLine("                placement: {")
        sb.AppendLine("                    from: ""bottom"",")
        sb.AppendLine("                    align: ""right""")
        sb.AppendLine("                },")
        sb.AppendLine("                offset: 20,")
        sb.AppendLine("                spacing: 10,")
        sb.AppendLine("                z_index: 2031,")
        sb.AppendLine("                delay: 5000,")
        sb.AppendLine("                timer: 1000000,")
        sb.AppendLine("                url_target: '_blank',")
        sb.AppendLine("                mouse_over: null,")
        sb.AppendLine("                animate: {")
        sb.AppendLine("                    enter: 'animated fadeInDown',")
        sb.AppendLine("                    exit: 'animated fadeOutUp'")
        sb.AppendLine("                },")
        sb.AppendLine("                onShow: null,")
        sb.AppendLine("                onShown: null,")
        sb.AppendLine("                onClose: null,")
        sb.AppendLine("                onClosed: null,")
        sb.AppendLine("                icon_type: 'class'")
        sb.AppendLine("            });")
        sb.AppendLine("        }")
        sb.AppendLine("    </script>")

        ScriptManager.RegisterClientScriptBlock(page, page.GetType, "notify", sb.ToString, False)

    End Sub
    Public Shared Function GetWeekDay(DayOfWeek As Integer) As String
        Select Case DayOfWeek
            Case 1
                Return "دوشنبه"
            Case 2
                Return "سه‌شنبه"
            Case 3
                Return "چهارشنبه"
            Case 4
                Return "پنج‌شنبه"
            Case 5
                Return "جمعه"
            Case 6
                Return "شنبه"
            Case Else
                Return "یکشنبه"
        End Select
    End Function
    Public Shared Function AddSeperator(oInput As Integer) As String
        If Math.Abs(oInput) < 1000 Then
            If oInput < 0 Then Return Math.Abs(oInput) & "-"
            Return oInput
        End If
        Dim oResult As String = ""

        If oInput < 0 Then
            Dim oIn As String = -oInput
            For i = oIn.Length - 1 To 0 Step -1
                oResult &= oIn(i)
                If ((oIn.Length - i) Mod 3) = 0 AndAlso i <> 0 Then oResult &= "/"
            Next
            oResult = "-" & oResult
        Else
            Dim oIn As String = oInput
            For i = oIn.Length - 1 To 0 Step -1
                oResult &= oIn(i)
                If ((oIn.Length - i) Mod 3) = 0 AndAlso i <> 0 Then oResult &= "/"
            Next
        End If

        Return StrReverse(oResult)
    End Function
    Public Shared Function Getdate() As DateTime
        Dim oCmd As New SqlClient.SqlCommand("Select getdate()", (New dbDataContext(ConnectionString)).Connection)
        oCmd.Connection.Open()
        Dim oDate = oCmd.ExecuteScalar()
        oCmd.Connection.Close()
        Dim oResult = CType(oDate, DateTime)

        Return oResult
    End Function
    Public Shared Function Shamsi2Miladi(Shamsi As String) As Date
        Dim oPC As New PersianCalendar
        Dim oDatePartS = Shamsi.Split("/")

        Return oPC.ToDateTime(oDatePartS(0), oDatePartS(1), oDatePartS(2), 0, 0, 0, 0)
    End Function
    Public Shared Function Miladi2Shamsi(Miladi As Date) As String
        Dim oPC As New PersianCalendar

        Return oPC.GetYear(Miladi) & "/" & oPC.GetMonth(Miladi) & "/" & oPC.GetDayOfMonth(Miladi)
    End Function
    Public Shared Function GetNextFileNo() As String
        Dim odb As New dbDataContext(ConnectionStringDemographic)
        Dim oLastFileNo = odb.tblLastFileNos.Where(Function(f) f.RegisteryNameOf.ToLower = "DiabeticFoot".ToLower).FirstOrDefault
        If oLastFileNo Is Nothing Then
            oLastFileNo = New tblLastFileNo With {.LastFileNo = "00-00-01", .RegisteryNameOf = "DiabeticFoot"}
            odb.tblLastFileNos.InsertOnSubmit(oLastFileNo)
        End If
        While odb.tblDemographics.Where(Function(f) f.FileNo = oLastFileNo.LastFileNo).Count > 0
            odb.SubmitChanges()
            Dim oValue = Val(oLastFileNo.LastFileNo.Replace("-", "")) + 1
            Dim oStr As String = oValue
            While oStr.Length < 6
                oStr = "0" + oStr
            End While
            oLastFileNo.LastFileNo = oStr(0) + oStr(1) + "-" + oStr(2) + oStr(3) + "-" + oStr(4) + oStr(5)
        End While

        Return oLastFileNo.LastFileNo
    End Function

    Public Shared Sub ExpandPanel(sender As Object, groupedPanelList As CollapsePanelGroup(), expandingPanelIds As String())
        'باز نگه داشتن پنل های مورد نظر و بسته کردن باقی آن ها
        If sender Is Nothing OrElse Not groupedPanelList.Any Then
            Return
        End If

        'Collapse all groupedPanelList
        For Each item In groupedPanelList
            If item.TitleControl.Attributes("aria-expanded") IsNot Nothing Then
                item.TitleControl.Attributes.Remove("aria-expanded")
            End If

            If item.CollapsableControl.Attributes("Class") IsNot Nothing AndAlso item.CollapsableControl.Attributes("Class").Contains("collapse in") Then
                item.CollapsableControl.Attributes("Class") = item.CollapsableControl.Attributes("Class").Replace("collapse in", "collapse")
            End If
        Next

        If expandingPanelIds.Any Then
            For Each item In expandingPanelIds
                Dim foundGroupedPanel = groupedPanelList.FirstOrDefault(Function(x) x.PanelBlock.ID = item)
                If foundGroupedPanel IsNot Nothing Then
                    foundGroupedPanel.TitleControl.Attributes.Add("aria-expanded", "true")
                    foundGroupedPanel.CollapsableControl.Attributes("Class") = foundGroupedPanel.CollapsableControl.Attributes("Class").Replace(" collapse", " collapse in")
                End If
            Next
        End If
    End Sub
End Class