
var columnDefs = [

    { headerName: "Nombre", field: "nombre", width: 90 },
    { headerName: "Apellido", field: "apellido", width: 120 },
    { headerName: "Especialidad", field: "especialidad", width: 90 }
];

var gridOptions = {
    columnDefs: columnDefs,
    rowSelection: 'single',
    onSelectionChanged: onSelectionChanged
};

function onSelectionChanged() {
    var espacio = ' ';
    var selectedRows = gridOptions.api.getSelectedRows();
    var selectedRowsString = '';
    selectedRows.forEach(function (selectedRow, index) {
        if (index !== 0) {
            selectedRowsString += ', ';
        }
        selectedRowsString += selectedRow.nombre ;
    });
    document.querySelector('#selectedRows').innerHTML = selectedRowsString;
}

// setup the grid after the page has finished loading
/*document.addEventListener('DOMContentLoaded', function () {
    var gridDiv = document.querySelector('#myGrid');
    new agGrid.Grid(gridDiv, gridOptions);

    // do http request to get our sample data - not using any framework to keep the example self contained.
    // you will probably use a framework like JQuery, Angular or something else to do your HTTP calls.
    var httpRequest = new XMLHttpRequest();
    httpRequest.open('GET', 'https://raw.githubusercontent.com/ag-grid/ag-grid/master/packages/ag-grid-docs/src/olympicWinnersSmall.json');
    httpRequest.send();
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState === 4 && httpRequest.status === 200) {
            var httpResult = JSON.parse(httpRequest.responseText);
            gridOptions.api.setRowData(httpResult);
        }
    };
});*/






document.addEventListener('DOMContentLoaded', function () {
    var gridDiv = document.querySelector('#myGrid');
    new agGrid.Grid(gridDiv, gridOptions);

    $.getJSON('/api/Profesional')
        .done(function (data) {
            $.each(data, function () {
                    gridOptions.api.setRowData(data);
            });
        });

});

/*function traerProfesional() {
    $.getJSON('api/Profesional/' + cedulaProfesional.value)
        .done(function (data) {
            $('<li>', { text: formatear(data) }).appendTo($('#tirar'));
        });
}


function cargar
$(document).ready(function () {
    $.getJSON(url)
        .done(function (data) {
            $.each(data, function (key, item) {
                $('<li>', { text: formatear(item) }).appendTo($('#profesionales'));
            });
        });
});*/