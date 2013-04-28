Option Explicit On
Option Strict On

''' <summary>
''' Favoriteプルダウン
''' </summary>
Public Class Favorite

    Private _sexSelectedIndex As Integer

    Public Sub New(ByVal sexSelectedIndex As Integer)
        Me._sexSelectedIndex = sexSelectedIndex
    End Sub

    ''' <summary>
    ''' DBからFavoriteプルダウンのアイテムを取得します
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFavoriteDropdownItems() As List(Of ListItem)
        Return New List(Of ListItem) From {
            New ListItem With {.Text = "sexSelectedIndex", .Value = Sex.MaleId.ToString()}
        }
    End Function

End Class
