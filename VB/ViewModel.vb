Imports System
Imports System.Collections.Generic
Imports System.Windows.Data
Imports System.ComponentModel

Namespace CollectionViewSupport

    Public Class ViewModel

        Private dataField As ICollectionView

        Public ReadOnly Property Data As ICollectionView
            Get
                If dataField Is Nothing Then
                    Dim list As List(Of TestData) = New List(Of TestData)()
                    For i As Integer = 0 To 100 - 1
                        list.Add(New TestData() With {.Number1 = i, .Number2 = i * 10, .Text1 = "row " & i, .Text2 = "ROW " & i})
                    Next

                    dataField = New ListCollectionView(list)
                End If

                Return dataField
            End Get
        End Property

        Private filtersField As List(Of FilterItem)

        Public ReadOnly Property Filters As List(Of FilterItem)
            Get
                If filtersField Is Nothing Then
                    filtersField = New List(Of FilterItem)()
                    Dim f1 As FilterItem = New FilterItem()
                    f1.Caption = "All items"
                    filtersField.Add(f1)
                    Dim f2 As FilterItem = New FilterItem()
                    f2.Caption = "Even items"
                    f2.Filter = AddressOf EvenMethod
                    filtersField.Add(f2)
                    Dim f3 As FilterItem = New FilterItem()
                    f3.Caption = "Odd items"
                    f3.Filter = AddressOf OddMethod
                    filtersField.Add(f3)
                End If

                Return filtersField
            End Get
        End Property

        Private Function EvenMethod(ByVal item As Object) As Boolean
            Return CType(item, TestData)?.Number1 Mod 2 = 0
        End Function

        Private Function OddMethod(ByVal item As Object) As Boolean
            Return CType(item, TestData)?.Number1 Mod 2 = 1
        End Function
    End Class

    Public Class FilterItem

        Public Property Caption As String

        Public Property Filter As Predicate(Of Object)
    End Class

    Public Class TestData

        Public Property Number1 As Integer

        Public Property Number2 As Integer

        Public Property Text1 As String

        Public Property Text2 As String
    End Class
End Namespace
