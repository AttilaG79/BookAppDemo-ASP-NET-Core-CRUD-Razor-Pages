

var dataTable;


$(document).ready(function () {
    loadDataTable()
});


function loadDataTable() {
    $('#tblBook').DataTable({
        "ajax": {
            "url": "api/Book",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name" },
            { "data": "author" },
            {"data":"category"},
            { "data": "isbn" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                            <a onclick=Delete('api/book?id='+${data}) class="btn btn-outline-danger">Delete</a>                            
                            </div>`;
                }
            }

        ]

    });
}

