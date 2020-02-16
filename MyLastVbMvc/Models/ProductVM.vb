Imports System.ComponentModel.DataAnnotations
Namespace Models


    Public Class ProductVM

        <Required(ErrorMessage:="Catalog is required")>
        <StringLength(10)>
        <Display(Name:="Crazy Catalog")>
        Public CatalogID As String
        Public Name As String
        Public Price As Double
        Public IsInStock As Boolean
        Public Image As String

        Sub New()

        End Sub
        Sub New(
            catalogID As String,
            name As String,
            price As Double,
            IsInStock As Boolean,
            Image As String
            )
            Me.CatalogID = catalogID
            Me.Name = name
            Me.Price = price
            Me.IsInStock = IsInStock
            Me.Image = Image


        End Sub




    End Class

End Namespace
