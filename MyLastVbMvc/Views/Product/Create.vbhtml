@ModelType MyLastVbMvc.ProductVM

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head><body>
    @Using (Html.BeginForm()) 
        @Html.AntiForgeryToken()



        @<div class="form-horizontal">
            <h4>ProductVM</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With { .class = "text-danger" })

         <div class="editor-lable">
             @Html.DisplayNameFor(Function(model) model.CatalogID)
             @Html.TextBoxFor(Function(model) model.CatalogID)

         </div>


            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>


    End Using

                     <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
