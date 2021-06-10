function addDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}

function dataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.getElementById(table);
        element.parentNode.removeChild(element);
    })
}