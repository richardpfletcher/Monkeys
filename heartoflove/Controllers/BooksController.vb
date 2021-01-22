Imports System.Web.Mvc

Namespace Controllers
    Public Class BooksController
        Inherits Controller

        ' GET: Books
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace