
var app = angular.module('myApp', ["ngRoute"]);


app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: "login.html"
            })
            .when('/profesionalhistorial', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.profesional) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "profesionalhistorial.html",
                controller: 'controlprofesionalhistorial',
                controllerAs: 'controlprofesionalhistorial'

            })
            .when('/profesional', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.profesional) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "profesional.html",
                controller: 'controlprofesional',
                controllerAs: 'controlprofesional'
            })
            .when('/profesionalmisp', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.profesional) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "profesionalmisp.html",
                controller: 'controlprofesionalmisp',
                controllerAs: 'controlprofesionalmisp'
            })
            .when('/profesionalhorarioslibres', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.profesional) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "profesionalhorarioslibres.html",
                controller: 'controlprofesionalhorarioslibres',
                controllerAs: 'controlprofesionalhorarioslibres'
            })
            .when('/consultorios', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.profesional) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "consultorios.html",
                controller: 'controlconsultorios',
                controllerAs: 'controlconsultorios'
            })
            .when('/paciente', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.paciente) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "pacienteangular.html",
                controller: 'controllerpaciente',
                controllerAs: 'controllerpaciente'
            })
            .when('/reservaspaciente', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.paciente) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "reservasPaciente.html",
                controller: 'controllerreservaspaciente',
                controllerAs: 'controllerreservaspaciente'
            })
            .when('/historialreservaspaciente', {
                resolve: {
                    "check": function ($location, $rootScope) {
                        if (!$rootScope.paciente) {
                            $location.path('/');
                        }
                    }
                },
                templateUrl: "historialReservasPaciente.html",
                controller: 'controllerhistorialreservaspaciente',
                controllerAs: 'controllerhistorialreservaspaciente'
            })
        
            .otherwise({
                redirecTo: 'index.html'
            })
    }]);

app.controller('controlLogin', function ($scope, $location, $rootScope, $window) {
    $scope.submit = function () {
        var user = $scope.ciUsuario;
        var pass = $scope.passUsuario;
        var profesional = true;

        var Login = {
            usuario: user,
            contrasena: pass
        };

        var info_reserva = JSON.stringify(Login);
        $.ajax({
            url: 'api/Login/PostLogin/',
            cache: false,
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: info_reserva,
            dataType: 'json',
            success: function (data) {
                sessionStorage.setItem('logeo', 'true');
               
                if (data.Correcto) {
                    if (data.Habilitado) {
                        $rootScope.idUsuario = user;
                        $rootScope.profesional = data.Profesional;
                        $rootScope.paciente = data.Paciente;
                        $rootScope.habilitado = data.Habilitado;
                        if (data.Profesional) {
                            $location.path('/profesional');
                        }
                        if (data.Paciente) {
                            $location.path('/paciente');
                        }
                    }
                    else {
                        alert("Atencion, su usuario no esta habilitado");
                    } 
                }
                else {
                    alert("Usuario incorrecto");
                }

            }
        });

    };

   



    
});

app.controller('controlprofesionalhistorial', function ($scope, $http,$rootScope) {
    $http.get("/api/PacienteXatender/GetPacienteAtendido/" + $rootScope.idUsuario).then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesional', function ($scope, $http, $rootScope) {
    $http.get("/api/ReservasXconfirmar/GetReservasXconfirmar/" + $rootScope.idUsuario).then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesionalmisp', function ($scope, $http, $rootScope) {
    $http.get("/api/PacienteXatender/GetPacienteXatender/" + $rootScope.idUsuario).then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlprofesionalhorarioslibres', function ($scope, $http, $rootScope) {
    $http.get("/api/ConsultorioReservado/GetConsultorioReservado/" + $rootScope.idUsuario).then(function (response) {
        $scope.myData = response.data;
    });
});

app.controller('controlconsultorios', function ($scope, $http, $location, $rootScope) {
    $http.get("/api/Consultorio/GetConsultorios/").then(function (response) {
        $scope.myData = response.data;
    });
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
});

app.controller('controllerpaciente', function ($scope, $http, $location, $rootScope) {
    var usuario = $rootScope.idUsuario;
    $http.get("/api/Profesional/GetProfesioales").then(function (response) {
        $scope.profesionales = response.data;
    });
    $scope.myFunc = function ($location) {
        var uri = 'api/Horario/PostReservarHorarioProfesional/';
        var horas = document.getElementsByName('hora');
        for (var i = 0; i < horas.length; i++) {
            if (horas[i].checked) {
                var Horario = {
                    cedula: usuario,
                    IdHorario: horas[i].value
                };
                var info_reserva = JSON.stringify(Horario);
                $.ajax({
                    url: 'api/Horario/PostReservarHorarioProfesional/',
                    cache: false,
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: info_reserva,
                    dataType: 'json',
                    success: function (data) {
                        alert('Se agrego el horario');
                    }
                });
            }
        }
        alert("Horario Reservado");
        window.location.replace("#!paciente");
    }
});

    app.controller('controllerreservaspaciente', function ($scope, $http, $location, $rootScope) {
        $http.get("api/Reserva/GetReserva/" + $rootScope.idUsuario).then(function (response) {
            $scope.reservas = response.data;
        });
    });

    app.controller('controllerhistorialreservaspaciente', function ($scope, $http, $location, $rootScope) {
        $http.get("api/Reserva/GetHistorialReserva/" + $rootScope.idUsuario).then(function (response) {
            $scope.historialreservas = response.data;
        });
    });

    app.controller('controllerBuscarHorasLibresProfesional', function ($scope, $http) {

        $scope.myFunc = function () {
            var profesionales = document.getElementsByName("cedulaProfesional");
            var profesional;
            for (var i = 0; i < profesionales.length; i++) {
                if (profesionales[i].checked)
                    profesional = profesionales[i].value;
            }
            $http.get("api/Horario/GetHorario/" + profesional).then(function (response) {
                $scope.horariosLibres = response.data;
            });
        };

    });

    // funciona rootscope
    app.controller('controlHoras', function ($scope, $rootScope, $location) {

        $scope.reservar = function () {

            //alert($rootScope.profesional);
            var uri = 'api/Horario/PostReservarHorario/';
            var usuario = $rootScope.idUsuario;
            var horas = document.getElementsByName('hora');

            var consultorios = document.getElementsByName("consultorio");
            var consultorio;
            for (var i = 0; i < consultorios.length; i++) {
                if (consultorios[i].checked)
                    consultorio = consultorios[i].value;
            }
            var dias = document.getElementsByName("dia");
            var dia = dias[0].value;

            for (var i = 0; i < horas.length; i++) {
                if (horas[i].checked) {

                    var Horario = {
                        dia: dia,
                        idConsultorio: consultorio,
                        cedula: usuario,
                        hora: horas[i].value
                    };
                    var info_reserva = JSON.stringify(Horario);
                    $.ajax({
                        url: 'api/Horario/PostReservarHorario/',
                        cache: false,
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: info_reserva,
                        dataType: 'json',
                        success: function (data) {
                            window.location.replace("#!profesionalhorarioslibres");
                        }
                    });

                }
            }
            window.location.replace("#!profesionalhorarioslibres");

        }



});

$('.message a').click(function () {
    $('form').animate({ height: "toggle", opacity: "toggle" }, "slow");
});