
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <h1> 
        @ViewBag.Title
    </h1>
    <h2>
        @ViewData("school")

    </h2>
    <h3>
        @TempData("TempData")

    </h3>
    <div>

       <ViewBag>ddddd</ViewBag> 

    </div><input type="" name="name" value="some input" />
</body>
</html>
