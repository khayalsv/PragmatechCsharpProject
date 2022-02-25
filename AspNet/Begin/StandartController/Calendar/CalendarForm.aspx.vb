Public Class CalendarForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs)
        Response.Write("Selected Date: " + Calendar1.SelectedDate.ToLongDateString())
    End Sub
End Class