
var columnDefs2 = [
    { headerName: "Id Horario", field: "IdHorario", width: 150 },
    { headerName: "Hora", field: "Hora", width: 150 },
    { headerName: "Id Consultorio", field: "IdConsultorio", width: 200 }
];

var gridOptions2 = {
    columnDefs: columnDefs2,
    rowSelection: 'single',
    onSelectionChanged: onSelectionChanged2
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

function onSelectionChanged2() {
    var selectedRows = gridOptions2.api.getSelectedRows();
    var selectedRowsString = '';
    selectedRows.forEach(function (selectedRow, index) {
        if (index !== 0) {
            selectedRowsString += ', ';
        }
        selectedRowsString += selectedRow.nombre;
    });
    document.querySelector('#selectedRows').innerHTML = selectedRowsString;
}


function cargarHorarios() {
    var gridDiv = document.querySelector('#myGridHorarios');
    $('#myGridHorarios').empty();
    new agGrid.Grid(gridDiv, gridOptions2);

    $.getJSON('api/Horario/' + obtenerIdProfesional())
        .done(function (data) {
            $.each(data, function () {
                gridOptions2.api.setRowData(data);
            });
        });


};



