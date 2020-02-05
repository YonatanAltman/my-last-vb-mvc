Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            Dim title = "Index"
            ViewBag.Title = title.ToLower()


            Return View()
        End Function
        Function Bb() As ActionResult
            Dim title = "BeBe"
            ViewBag.Title = title.ToLower()
            ViewData("School") = "Academka"
            TempData("TempData") = "PM"

            Return View("Index")
        End Function
        Function Beni() As ActionResult
            Dim title = "Beni"
            ViewBag.Title = title.ToLower()
            ViewData("School") = "Epr AcadeMe"
            TempData("TempData") = "PM"
            ' if we have a Redirect the ViewBag & ViewData won't be available
            Return Redirect("./Index")
            'Return View("Index")
        End Function
    End Class
End Namespace