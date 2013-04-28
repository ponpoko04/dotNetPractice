Option Explicit On
Option Strict On

Imports Practice.BusinessLayer
Imports Practice.Model

''' <summary>
''' アーキテクチャ練習
''' </summary>
''' <remarks></remarks>
Public Class About
    Inherits System.Web.UI.Page

#Region "Enum"
    ''' <summary>
    ''' GrvGridViewの内部コントロールID
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum GridInControls As Integer
        LblIdInGrid = 0
        TxtNameInGrid
    End Enum

    ''' <summary>
    ''' GrvGridInUpdatePanelの内部コントロールID
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum GridInUpdatePanel
        LblIdInGrid = 0
        TxtNameInGrid
    End Enum
#End Region

#Region "Page Events"

    Private Sub About_Init(sender As Object, e As System.EventArgs) Handles Me.Init

    End Sub
    ''' <summary>
    ''' ページロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>初回の描画について規定</remarks>
    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            '画面表示用データを取得
            'TODO: 実際はDB等から取得
            Dim grid As New List(Of Gridview) From {
                            New Gridview("1", "NAME1"),
                            New Gridview("2", "NAME2")
                        }
            Dim gridInUdp As New List(Of GridviewInUpdatePanel) From {
                            New GridviewInUpdatePanel("1", "NAME1 udp"),
                            New GridviewInUpdatePanel("2", "NAME2 udp")
                        }

            'Dim aaa As New ListItemService
            'Dim bbb = aaa.GetListItem(String.Empty,
            '                          New Dictionary(Of String, String) From {
            '                              {"sexSelectedIndex", Sex.MaleId.ToString()}
            '                          })
            '画面描画オブジェクトをモデルに詰める
            Dim model As New AboutModel
            model.UpdateObj(String.Empty, String.Empty, 0, grid, gridInUdp)

            '描画
            Me.DisplayScreen(model)
        End If

    End Sub
#End Region

#Region "Button Events"
    ''' <summary>
    ''' BtnSend_Click: Sendボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnSend_Click(sender As Object, e As System.EventArgs) Handles BtnSend.Click
        Dim model = Me.CommonUpdateModel(New AboutModel)
        Me.DisplayScreen(model)
    End Sub

    ''' <summary>
    ''' BtnAsync_Click: Asyncボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnAsync_Click(sender As Object, e As System.EventArgs) Handles BtnAsync.Click
        Dim model = Me.CommonUpdateModel(New AboutModel)
        Me.DisplayScreen(model)
    End Sub

    ''' <summary>
    ''' BtnAddRow_Click: AddRowボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnAddRow_Click(sender As Object, e As System.EventArgs) Handles BtnAddRow.Click
        'Dim model = Me.CommonUpdateModel(New AboutModel)
        Dim gridList = Me.GenerateGridToList()
        Dim incrementId = Integer.Parse(gridList(gridList.Count - 1).Id) + 1
        gridList.Add(New Gridview(incrementId.ToString(), String.Empty))
        Me.GrvGridView.DataSource = gridList
        Me.GrvGridView.DataBind()
        'Me.DisplayScreen(model)
    End Sub

    ''' <summary>
    ''' BtnAddRow2_Click: AddRowボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnAddRow2_Click(sender As Object, e As System.EventArgs) Handles BtnAddRow2.Click
        Dim gridList = Me.GenerateGridInUpdToList()
        Dim incrementId = Integer.Parse(gridList(gridList.Count - 1).Id) + 1
        gridList.Add(New GridviewInUpdatePanel(incrementId.ToString(), String.Empty))

        Me.GrvGridInUpdatePanel.DataSource = gridList
        Me.GrvGridInUpdatePanel.DataBind()
    End Sub

    ''' <summary>
    ''' BtnNextPage_Click: 次ページボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnNextPage_Click(sender As Object, e As System.EventArgs) Handles BtnNextPage.Click
        Response.Redirect("~/After.aspx")
    End Sub
#End Region

#Region "Dropdownlist Events"
    ''' <summary>
    ''' DdlSex_SelectedIndexChanged: 性別プルダウン変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DdlSex_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DdlSex.SelectedIndexChanged
        Dim aaa As New ListItemService
        Dim bbb = aaa.GetListItem(String.Empty,
                                  New Dictionary(Of String, String) From {
                                      {"sexSelectedIndex", Me.DdlSex.SelectedIndex.ToString()}
                                  })
        Dim model As New AboutModel With {.Favarite = bbb}
        model = Me.CommonUpdateModel(model)
        Me.DisplayScreen(model)
    End Sub
#End Region

#Region "Common Events"
    ''' <summary>
    ''' 画面描画オブジェクトをモデルに詰めて再描画
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CommonUpdateModel(ByVal model As AboutModel) As AboutModel
        model.UpdateObj(Me.TxtId.Text, Me.TxtName.Text, Me.DdlSex.SelectedIndex,
                        Me.GenerateGridToList(), Me.GenerateGridInUpdToList())
        Return model
    End Function

    ''' <summary>
    ''' DisplayScreen: 画面モデルから描画データを画面にセットします
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayScreen(ByVal model As AboutModel)
        Me.TxtId.Text = model.Id
        Me.TxtName.Text = model.Name

        Me.DdlSex.DataSource = model.Sex
        Me.DdlSex.DataBind()
        Me.DdlSex.SelectedIndex = model.SexSelected

        'Me.DdlFavorite.DataSource = model.Favarite
        'Me.DdlFavorite.DataBind()

        Me.GrvGridView.DataSource = model.Gridview
        Me.GrvGridView.DataBind()

        Me.GrvGridInUpdatePanel.DataSource = model.GridviewInUpdatePanel
        Me.GrvGridInUpdatePanel.DataBind()
    End Sub

    ''' <summary>
    ''' GridからList(Of Model)を生成します
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenerateGridToList() As List(Of Gridview)
        Dim gridList As New List(Of Gridview)
        'Me.GrvGridView.
        For Each row As GridViewRow In Me.GrvGridView.Rows
            'row.DataItem()
            Dim label = TryCast(row.FindControl(GridInControls.LblIdInGrid.ToString()), Label)
            Dim text = TryCast(row.FindControl(GridInControls.TxtNameInGrid.ToString()), TextBox)

            gridList.Add(New Gridview(label.Text, text.Text))
        Next
        Return gridList
    End Function

    ''' <summary>
    ''' GridからList(Of Model)を生成します
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenerateGridInUpdToList() As List(Of GridviewInUpdatePanel)
        Dim gridList As New List(Of GridviewInUpdatePanel)
        For Each row As GridViewRow In Me.GrvGridInUpdatePanel.Rows
            Dim label = TryCast(row.FindControl(GridInUpdatePanel.LblIdInGrid.ToString()), Label)
            Dim text = TryCast(row.FindControl(GridInUpdatePanel.TxtNameInGrid.ToString()), TextBox)

            gridList.Add(New GridviewInUpdatePanel(label.Text, text.Text))
        Next
        Return gridList
    End Function
#End Region

    Private Sub GrvGridView_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvGridView.RowDataBound
        'If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex > 0 Then
        '    If DataBinder.GetPropertyValue(e.Row.DataItem, "Id").ToString() = "2" AndAlso
        '       DataBinder.GetIndexedPropertyValue(e.Row.DataItem, CStr(e.Row.RowIndex)).ToString() = DataBinder.GetIndexedPropertyValue(e.Row.DataItem, CStr(e.Row.RowIndex - 1)).ToString() Then
        '        e.Row.Cells(1).Visible = False
        '    End If
        'End If
    End Sub

    Private Sub OdsFavorite_Init(sender As Object, e As System.EventArgs) Handles OdsFavorite.Init

    End Sub

    Private Sub OdsFavorite_Load(sender As Object, e As System.EventArgs) Handles OdsFavorite.Load

    End Sub

    Private Sub OdsFavorite_Selecting(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsFavorite.Selecting
        e.InputParameters("sqlId") = String.Empty
        e.InputParameters("param") = New Dictionary(Of String, String) From {{"sexSelectedIndex", Sex.MaleId.ToString()}}
    End Sub

End Class