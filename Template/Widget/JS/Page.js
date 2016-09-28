
// Render Grid Template
function renderPageGridRowTemplate(data) {
    // Cast the Template
    var gridRowTemplate = kendo.template($("#_pageGridRowTemplate").html());
    // Return the Template with the Data
    return gridRowTemplate(data);
}