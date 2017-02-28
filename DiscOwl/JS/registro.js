﻿$(document).ready(function () {

    var ready = null;

    ready = new elementos();

    ready.insertar();
});


elementos = function () {
    var conexion1;

    var content;

    var correcto;
}

elementos.prototype.insertar = function () {
    $("#insertar").click(function () {
        elementos.prototype.validation();
        if (correcto == 4) {
            elementos.prototype.conexion();
        }
    });
}


elementos.prototype.conexion = function () {
    var usuario = $("#user").val();
    var pass1 = $("#pass").val();
    var fecha = $("#fecha").val();
    var email = $("#email").val();

    todojson = {
        "usuario": usuario,
        "password": pass1,
        "fechanacimiento": fecha,
        "email": email
    };

    var object = JSON.stringify(todojson);

    $.ajax({
        "url": "",
        "type": "POST",
        "contentType": 'application/json',
        "data": object,
        "dataType": "json",
        "success": function (data, textStatus, jqXHR) {
            content = data;
        }

    });
}




elementos.prototype.validation = function () {
    var regemail = /^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$/;
    var regletras = /^[a-zA-Z]+(\s*[a-zA-Z]*)*[a-zA-Z]+$/;
    var regfecha = /(\d+)(-|\/)(\d+)(?:-|\/)(?:(\d+)\s+(\d+):(\d+)(?::(\d+))?(?:\.(\d+))?)?/;

    correcto = 0;

    var usuario = $("#user").val();
    var pass1 = $("#pass").val();
    var pass2 = $("#repass").val();
    var fecha = $("#fecha").val();
    var email = $("#email").val();

    //Validacion usuario
    if (regletras.test(usuario)) {
        correcto++;
    }
    else {
        toastr.info('Usuario mal introducido, solo se aceptan letras.');
    }

    //Validacion password
    if ((pass1 != "") && (pass2 != "")) {
        if (pass1 == pass2) {
            correcto++;
        }
        else {
            toastr.info('La constraseña debe ser igual en ambos campos');
        }
    }
    else {
        toastr.info('Contraseña mal introducida');
    }

    //Validacion fecha
    if (regfecha.test(fecha)) {
        correcto++
    }
    else {
        toastr.info("Formato de fecha invalido, solo se acepta el formato 'dd/mm/yyyy'");
    }


    //Validacion email
    if (regemail.test(email)) {
        correcto++;
    }
    else {
        toastr.info('Email mal introducido');
    }

    //Validacion fecha menor que actual  Pendiente
    /*
    var f = new Date();
	var fecha2 = (f.getFullYear() + "-" + (f.getMonth() +1) + "-" + f.getDate());
	if(fecha < fecha2)
	{
		correcto++;
	}
	else
	{
		toastr.info("La fecha debe ser menor a la actual");
	}*/
}