Public Class Grid
    Inherits System.Web.UI.UserControl

    'Public Event ShowGrid As EventHandler

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim cookie = Response.Cookies("searched").Value
            If Not cookie Is Nothing AndAlso cookie <> String.Empty Then Response.Cookies.Remove("searched")
        End If
        Dim grid As New List(Of GridCache) From {
                        New GridCache With {.key = "1", .value = "NAME1"},
                        New GridCache With {.key = "2", .value = "NAME2"}
                    }
        Me.GrvCache.DataSource = grid
        Me.GrvCache.DataBind()
    End Sub

    Public Sub ShowGrid()
        Me.GrvCache.Visible = True
    End Sub

    Private Class GridCache
        Public Property key As String
        Public Property value As String
    End Class

    Private Sub BtnShow_Click(sender As Object, e As System.EventArgs) Handles BtnShow.Click
        Me.GrvCache.Visible = True
    End Sub
End Class