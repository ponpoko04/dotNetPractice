﻿Option Explicit On
Option Strict On

''' <summary>
''' GridviewInUpdatePanel
''' </summary>
''' <remarks></remarks>
Public Class GridviewInUpdatePanel

    ''' <summary>
    ''' 引数なしでnewさせない
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
    End Sub

    Public Sub New(ByVal id As String, ByVal name As String)
        Me.Id = id
        Me.Name = name
    End Sub

    Public Property Id As String
    Public Property Name As String

End Class
