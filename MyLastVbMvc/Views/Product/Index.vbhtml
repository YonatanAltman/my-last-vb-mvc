@ModelType IEnumerable(Of ProductVM)
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
    <div> 
        Product List
        <h2>@Model.Count</h2>
    </div>
</body>
</html>
