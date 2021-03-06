﻿
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
    var id_consultorio;
    $scope.myFunc = function () {
        var checked = false;
        var entre = false;
        var consultorios = document.getElementsByName("consultorio");
        for (var i = 0; i < consultorios.length; i++) {
            if (consultorios[i].checked) {
                id_consultorio = consultorios[i].value;
                checked = true;
            }
        }
        var dias = document.getElementsByName("dia");
        var dia = dias[0].value;
        if (dia !== "") {
            entre = true;
            var Horario = {
                dia: dia,
                idConsultorio: id_consultorio
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
        }
        else {
            alert("ERROR: Ingrese una fecha");
        }
        if (!checked && entre) {
            alert("ERROR: Seleccione un consultorio");
        }
        

    };
    $scope.reservar = function () {
        var checked = false;
        var uri = 'api/Horario/PostReservarHorario/';
        var usuario = $rootScope.idUsuario;
        var horas = document.getElementsByName('hora');
        var dias = document.getElementsByName("dia");
        var dia = dias[0].value;

        for (var i = 0; i < horas.length; i++) {
            if (horas[i].checked) {
                checked = true;
                var Horario = {
                    dia: dia,
                    idConsultorio: id_consultorio,
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
        if (checked) {
            alert("Consultorio reservado");
            window.location.replace("#!profesionalhorarioslibres");
        }
        else {
            alert("ERROR: Seleccione un horario");
        }

    }
});

app.controller('controllerpaciente', function ($scope, $http, $location, $rootScope) {
    var usuario = $rootScope.idUsuario;
    $http.get("/api/Profesional/GetProfesioales").then(function (response) {
        $scope.profesionales = response.data;
    });
    var profesional;
    $scope.buscarFunc = function () {
        var profesionales = document.getElementsByName("cedulaProfesional");
        for (var i = 0; i < profesionales.length; i++) {
            if (profesionales[i].checked)
                profesional = profesionales[i].value;
        }
        $http.get("api/Horario/GetHorario/" + profesional).then(function (response) {
            $scope.horariosLibres = response.data;
        });
    };
    $scope.myFunc = function ($location) {
        var checked = false;
        var dentro = false;
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
                    success: function () {
                        alert('Se agrego el horario');
                    }
                });
                if (!dentro) {
                    dentro = true;
                    alert("Horario Reservado");
                }
                
                checked = true;
            }
        }

        if (!checked) {
            alert("ERROR: Seleccione al menos un horario");
        }
        else {
            window.location.replace("#!paciente");
        }
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

    // funciona rootscope
