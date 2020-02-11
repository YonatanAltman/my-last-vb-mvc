Imports System.Web.Mvc
Imports Entities
Imports UserManager

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult
            Dim manager = New ProductManager()

            Dim products = manager.GetAll()
            Dim prodctusVm = ConvertProductsToVms(products)

            Return View(prodctusVm)
        End Function




#Region "PRIVATE FUNCTIONS"


        Private Function ConvertProductsToVms(products As List(Of Product)) As List(Of ProductVM)
            Dim vms = New List(Of ProductVM)
            For Each p In products
                vms.Add(ConvertProductToVm(p))
            Next





            Return vms

        End Function

        Private Function ConvertProductToVm(product As Product) As ProductVM
            Dim vm = New ProductVM(
                product.CatalogID,
                product.Name,
                product.Price,
                product.IsInStock,
                product.Image)


            Return vm

        End Function

#End Region

    End Class
End Namespace