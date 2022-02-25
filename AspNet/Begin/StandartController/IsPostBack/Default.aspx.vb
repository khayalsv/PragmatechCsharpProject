Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            lblmessage.Text = "Post oldu"
        Else lblmessage.Text = "Post olmadi"
        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'lblmessage.Text = txtMessage.Text

    End Sub
End Class