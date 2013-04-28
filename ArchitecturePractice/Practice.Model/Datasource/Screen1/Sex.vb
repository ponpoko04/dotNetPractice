Option Explicit On
Option Strict On

''' <summary>
''' Sexプルダウン
''' </summary>
''' <remarks>
''' プルダウンデータソース用モデル
''' DBから取ってくる場合も、バインド前にこういったクラスを経由するようにする
''' </remarks>
Public Class Sex

    Public Const MaleId As String = "0"
    Public Const FemaleId As String = "1"

    ''' <summary>
    ''' Male
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Male As ListItem
        Get
            'TODO: このデータをXMLで定義する。もしくはEnum等で定義する。
            Return New ListItem With {.Text = "Male", .Value = MaleId}
        End Get
    End Property

    ''' <summary>
    ''' Female
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Female As ListItem
        Get
            'TODO: このデータをXMLで定義する。もしくはEnum等で定義する。
            Return New ListItem With {.Text = "Female", .Value = FemaleId}
        End Get
    End Property

End Class
