Option Explicit On
Option Strict On

Imports Practice.Model

''' <summary>
''' ListItemクラスのデータを操作します
''' </summary>
''' <remarks></remarks>
Public Class ListItemService

    ''' <summary>
    ''' ListItemを取得します
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetListItem(ByVal sqlId As String, ByVal param As IDictionary(Of String, String)) As List(Of ListItem)
        'sqlId使ってDBから検索してくる

        Dim list As New List(Of ListItem)
        Dim aaa As String = String.Empty
        If Not param.TryGetValue("sexSelectedIndex", aaa) Then Return New List(Of ListItem)

        If aaa = Sex.FemaleId Then
            list.Add(New ListItem With {.Text = "Cloth", .Value = "Cloth"})
            list.Add(New ListItem With {.Text = "Desert", .Value = "Desert"})
        ElseIf aaa = Sex.MaleId Then
            list.Add(New ListItem With {.Text = "Car", .Value = "Car"})
            list.Add(New ListItem With {.Text = "Train", .Value = "Train"})
        Else
            Return New List(Of ListItem)
        End If

        Return list
    End Function

End Class
