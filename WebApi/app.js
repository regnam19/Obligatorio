
var app = angular.module('myApp', ["ngRoute"]);


app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: "Initial.html"
            })
            .when('/profesionalhistorial', {
                templateUrl: "profesionalhistorial.html",
                controller: 'controlprofesionalhistorial',
                controllerAs: 'controlprofesionalhistorial'

            })
            .when('/profesional', {
                templateUrl: "profesional.html",
                controller: 'controlprofesional',
                controllerAs: 'controlprofesional'
            })
            .when('/profesionalmisp', {
                templateUrl: "profesionalmisp.html",
                controller: 'controlprofesionalmisp',
                controllerAs: 'controlprofesionalmisp'
            })
            .when('/profesionalhorarioslibres', {
                templateUrl: "profesionalhorarioslibres.html",
                controller: 'controlprofesionalhorarioslibres',
                controllerAs: 'controlprofesionalhorarioslibres'
            })
            .when('/consultorios', {
                templateUrl: "consultorios.html",
                controller: 'controlconsultorios',
                controllerAs: 'controlconsultorios'
            })
        
            .otherwise({
                redirecTo: 'index.html'
            })
    }]);

app.controller('controlprofesionalhistorial', function ($scope, $http) {
    $http.get("/api/PacienteXatender/GetPacienteAtendido/11111111").then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesional', function ($scope, $http) {
    $http.get("/api/ReservasXconfirmar/GetReservasXconfirmar/11111111").then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesionalmisp', function ($scope, $http) {
    $http.get("/api/PacienteXatender/GetPacienteXatender/11111111").then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesionalhorarioslibres', function ($scope, $http) {
    $http.get("/api/ReservasXconfirmar/GetHorariosLibres/11111111").then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlconsultorios', function ($scope, $http) {
    $http.get("/api/Consultorio/GetConsultorios/").then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlHoras', ['$scope', function ($scope) {
    $scope.myFunc = function () {
        var consultorios = document.getElementsByName("consultorio");
        var consultorio;
        for (var i = 0; i < consultorios.length; i++) {
            if (consultorios[i].checked)
                consultorio = consultorios[i].value;
        }
        var dias = document.getElementsByName("dia");
        var dia = dias[0].value;

        var Horario = {
            dia: dia,
            idConsultorio: consultorio
        };

        var info_reserva = JSON.stringify(Horario);
        $.ajax({
            url: 'api/Horario/PostHorariosDisponibles/',
            cache: false,
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: info_reserva,
            dataType: 'json',
            success: function (data) {
                $scope.Horarios = data;

            }
        });

    };
}]);
    
