@ModelType MyLastVbMvc.Models.ProductVM

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @Html.ValidationSummary(True)
        @<fieldset>

            <h4>ProductVM</h4>





            <div class="form-group">

                <div class="editor-label">
                    @Html.LabelFor(Function(model) model.CatalogID)
                </div>
                <div class="editor-field">
                    @Html.EditorFor(Function(model) model.CatalogID)
                    @Html.TextBox("CatalogID", "dasf", New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.CatalogID)
                </div>
                <div class="editor-label">
                    @Html.LabelFor(Function(model) model.Name)
                </div>
                <div class="editor-field">
                    @Html.EditorFor(Function(model) model.Name)
                    @Html.ValidationMessageFor(Function(model) model.Name)
                </div>
                <div class="editor-label">
                    @Html.LabelFor(Function(model) model.Price)
                </div>
                <div class="editor-field">
                    @Html.EditorFor(Function(model) model.Price)
                    @Html.ValidationMessageFor(Function(model) model.Price)
                </div>
                <div class="editor-label">
                    @Html.LabelFor(Function(model) model.IsInStock)
                </div>
                <div class="editor-field">
                    @Html.EditorFor(Function(model) model.IsInStock)
                    @Html.ValidationMessageFor(Function(model) model.IsInStock)
                </div>
                <div class="editor-label">
                    @Html.LabelFor(Function(model) model.Image)
                </div>
                <div class="editor-field">
                    @Html.EditorFor(Function(model) model.Image)
                    @Html.ValidationMessageFor(Function(model) model.Image)
                </div>

            </div>



            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>

        </fieldset>
    End Using

    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
