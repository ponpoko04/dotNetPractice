Public Class After
    Inherits System.Web.UI.Page

    Private Sub After_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'ccc
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ddd
        If Not IsPostBack Then
            Dim cookie = Response.Cookies("searched")
            If Not cookie Is Nothing Then Response.Cookies("searched").Value = ""
        End If
        Dim grid As New List(Of GridCache) From {
                        New GridCache With {.key = "1", .value = "NAME1"},
                        New GridCache With {.key = "2", .value = "NAME2"}
                    }
        Me.GrvCache.DataSource = grid
        Me.GrvCache.DataBind()
    End Sub

    Private Sub After_PreRender(sender As Object, e As System.EventArgs) Handles Me.PreRender

    End Sub

    Private Sub After_PreRenderComplete(sender As Object, e As System.EventArgs) Handles Me.PreRenderComplete

    End Sub

    Private Sub BtnShow_Click(sender As Object, e As System.EventArgs) Handles BtnShow.Click
        Me.GrvCache.Visible = True
    End Sub

    Private Class GridCache
        Public Property key As String
        Public Property value As String
    End Class

End Class