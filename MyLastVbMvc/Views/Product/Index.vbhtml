@ModelType IEnumerable(Of ProductVM)
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <style>
        img {
            height: 100px
        }
       tbody tr:hover{
            background-color:rgba(0, 255, 255,0.1);
            cursor:pointer;
        }
    </style>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <div>
        Product List
        <h2>@Model.Count</h2>
    </div>

    <table class="table">
        <thead>

        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.CatalogID)

            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Name)

            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Price)

            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.IsInStock)

            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Image)

            </th>
        </tr>

        </thead>
        <tbody>
            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.CatalogID)

                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Name)

                    </td>
                    <td>
                        $ @Html.DisplayFor(Function(modelItem) item.Price)

                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.IsInStock)

                    </td>
                    <td>
                        <img src="@Html.DisplayFor(Function(modelItem) item.Image)"
                             alt="@Html.DisplayFor(Function(modelItem) item.CatalogID)" />

                    </td>

                </tr>

            Next

        </tbody>
    </table>
</body>
</html>
