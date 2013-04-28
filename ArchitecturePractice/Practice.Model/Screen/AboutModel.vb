Option Explicit On
Option Strict On

''' <summary>
''' About画面モデル
''' </summary>
''' <remarks></remarks>
Public Class AboutModel

    Private _id As String
    Public Property Id As String
        Get
            Return _id
        End Get
        Private Set(value As String)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Private Set(value As String)
            _name = value
        End Set
    End Property

    Public ReadOnly Property Sex As List(Of ListItem)
        Get
            Dim sexModel As New Sex
            Return New List(Of ListItem) From {
                    sexModel.Male,
                    sexModel.Female
                }
            'Return New List(Of ListItem) From {
            '            New ListItem With {.Text = "Male", .Value = "0"},
            '            New ListItem With {.Text = "Female", .Value = "1"}
            '        }
        End Get
    End Property

    Public Property SexSelected As Integer

    Public Property Favarite As List(Of ListItem)

    Private _gridview As List(Of Gridview)
    Public Property Gridview As List(Of Gridview)
        Get
            Return _gridview
        End Get
        Private Set(value As List(Of Gridview))
            _gridview = value
        End Set
    End Property

    Private _gridviewInUpdatePanel As List(Of GridviewInUpdatePanel)
    Public Property GridviewInUpdatePanel As List(Of GridviewInUpdatePanel)
        Get
            Return _gridviewInUpdatePanel
        End Get
        Private Set(value As List(Of GridviewInUpdatePanel))
            _gridviewInUpdatePanel = value
        End Set
    End Property

    ''' <summary>
    ''' 画面オブジェクトの内容更新時にコールします
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="name"></param>
    ''' <param name="grid"></param>
    ''' <remarks></remarks>
    Public Sub UpdateObj(ByVal id As String,
                         ByVal name As String,
                         ByVal sexSelectedIdx As Integer,
                         ByVal grid As List(Of Gridview),
                         ByVal gridviewInUpdatePanel As List(Of GridviewInUpdatePanel))
        Me.Id = id
        Me.Name = name
        Me.SexSelected = sexSelectedIdx
        Me.Gridview = grid
        Me.GridviewInUpdatePanel = gridviewInUpdatePanel
    End Sub

End Class
