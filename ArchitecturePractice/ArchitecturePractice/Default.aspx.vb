Public Class _Default
    Inherits System.Web.UI.Page

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub link_DataBinding(sender As Object, e As System.EventArgs) Handles link.DataBinding

    End Sub

    Private Sub link_Disposed(sender As Object, e As System.EventArgs) Handles link.Disposed

    End Sub

    Private Sub link_Unload(sender As Object, e As System.EventArgs) Handles link.Unload

    End Sub

    Private Sub Page_Unload(sender As Object, e As System.EventArgs) Handles Me.Unload

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class