
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

var columnDefs3 = [
    { headerName: "Id Reserva", field: "IdReserva", width: 100 },
    { headerName: "Hora", field: "Hora", width: 70 },
    { headerName: "Fecha", field: "Fecha", width: 140 },
    { headerName: "Nombre Profesional", field: "NombreProfesional", width: 150 },
    { headerName: "Apellido Profesional", field: "ApellidoProfesional", width: 150 },
    { headerName: "Consultorio", field: "Consultorio", width: 240 },
    { headerName: "Estado", field: "Estado", width: 100 }
];

var gridOptions3 = {
    columnDefs: columnDefs3,
    rowSelection: 'single',
    onSelectionChanged: onSelectionChanged3
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

function onSelectionChanged3() {
    var selectedRows = gridOptions3.api.getSelectedRows();
    var selectedRowsString = '';
    selectedRows.forEach(function (selectedRow, index) {
        if (index !== 0) {
            selectedRowsString += ', ';
        }
        selectedRowsString += selectedRow.nombre;
    });
    document.querySelector('#selectedRows').innerHTML = selectedRowsString;
}




function cargarReservas() {
    var gridDiv = document.querySelector('#myGridReservasFuturas');
    $('#myGridReservasFuturas').empty();
    new agGrid.Grid(gridDiv, gridOptions3);

    $.getJSON('api/Reserva/' + $('#pacId').val())
        .done(function (data) {
            $.each(data, function () {
                gridOptions3.api.setRowData(data);
            });
        });


};
