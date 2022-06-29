Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Myself() As ActionResult
        ViewData("Message") = "My Self page"
        Return View()


    End Function
    Function BSPage() As ActionResult
        ViewData("Message") = "Bootstrap Practice"
        Return View()



    End Function


End Class
