Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            ' ViewBag
            ViewBag.Message = "Message from ViewBag!"

            ' ViewData
            ViewData("School") = "Academka"


            Return View()  'same like => Return View("Index")

        End Function
    End Class
End Namespace