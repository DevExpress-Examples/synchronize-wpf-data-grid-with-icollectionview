Imports System
Imports System.Collections.Generic
Imports System.Windows.Data
Imports System.ComponentModel

Namespace CollectionViewSupport
    Public Class ViewModel

        Private data_Renamed As ICollectionView
        Public ReadOnly Property Data() As ICollectionView
            Get
                If data_Renamed Is Nothing Then
                    Dim list As New List(Of TestData)()
                    For i As Integer = 0 To 99
                        list.Add(New TestData() With {.Number1 = i, .Number2 = i * 10, .Text1 = "row " & i, .Text2 = "ROW " & i})
                    Next i
                    data_Renamed = New ListCollectionView(list)
                End If
                Return data_Renamed
            End Get
        End Property

        Private filters_Renamed As List(Of FilterItem)
        Public ReadOnly Property Filters() As List(Of FilterItem)
            Get
                If Filters Is Nothing Then
                    Filters = New List(Of FilterItem)()

                    Dim f1 As New FilterItem()
                    f1.Caption = "All items"

                    Filters.Add(f1)

                    Dim f2 As New FilterItem()
                    f2.Caption = "Even items"
                    f2.Filter = AddressOf EvenMethod
                    Filters.Add(f2)

                    Dim f3 As New FilterItem()
                    f3.Caption = "Odd items"
                    f3.Filter = AddressOf OddMethod
                    Filters.Add(f3)
                End If
                Return Filters
            End Get
        End Property

        Private Function EvenMethod(item As Object) As Boolean
            Return DirectCast(item, TestData).Number1 Mod 2 = 0
        End Function
        Private Function OddMethod(item As Object) As Boolean
            Return DirectCast(item, TestData).Number1 Mod 2 = 1
        End Function


    End Class
    Public Class FilterItem
        Public Property Caption() As String
        Public Property Filter() As Predicate(Of Object)
    End Class
    Public Class TestData
        Public Property Number1() As Integer
        Public Property Number2() As Integer
        Public Property Text1() As String
        Public Property Text2() As String
    End Class
End Namespace
