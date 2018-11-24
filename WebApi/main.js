
var columnDefs = [
    { headerName: "Nombre", field: "nombre", width: 150 },
    { headerName: "Apellido", field: "apellido", width: 150 },
    { headerName: "Especialidad", field: "especialidad", width: 200 }
];

var gridOptions = {
    columnDefs: columnDefs,
    rowSelection: 'single',
    onSelectionChanged: onSelectionChanged
};

function obtenerIdProfesional() {
    var selectedRows = gridOptions.api.getSelectedRows();
    var selectedRowsString = '';
    selectedRows.forEach(function (selectedRow, index) {
        if (index !== 0) {
            selectedRowsString += ', ';
        }
        selectedRowsString += selectedRow.cedula;
    });
    return selectedRowsString;
    };

function onSelectionChanged() {
    var selectedRows = gridOptions.api.getSelectedRows();
    var selectedRowsString = '';
    selectedRows.forEach(function (selectedRow, index) {
        if (index !== 0) {
            selectedRowsString += ', ';
        }
        selectedRowsString += selectedRow.nombre ;
    });
    window.onload = function () { document.querySelector('#selectedRows').innerHTML = selectedRowsString };
}

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

