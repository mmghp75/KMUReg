Public Class CollapsePanelGroup
    Sub New(panelBlock As HtmlGenericControl, titleControl As HtmlGenericControl, collapsableControl As HtmlGenericControl)
        Me.PanelBlock = panelBlock
        Me.TitleControl = titleControl
        Me.CollapsableControl = collapsableControl
    End Sub
    Public Property PanelBlock As HtmlGenericControl
    Public Property TitleControl As HtmlGenericControl
    Public Property CollapsableControl As HtmlGenericControl
End Class