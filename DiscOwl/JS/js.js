$(document).ready(function () {
    var minHeightSection = ($(window).height() - 210);
    var colores = ["red", "Orange", "#00FFFF", "#FF00FF"];
    var contador = 0;
    $("section").css({ "min-height": minHeightSection });

    //La siguiente función hace que si por casualidad el section es muy
    //pequeño la página sigua ocupando el 100% de la pantalla con el footer en bot.
    //Ademas controlo algunos problemillas con los menús al pasar de responsive etc.
    $(window).resize(function () {
        minHeightSection = ($(window).height() - 210);
        $("section").css({ "min-height": minHeightSection });
        widthtWindow = $(window).width();
        if (widthtWindow > 700 && !$("#login").is(':visible')) {
            $("#login").show(500);
        }
        if (widthtWindow < 700 && $("#login").is(':visible')) {
            $("#login").hide(500);
        }
        if (widthtWindow > 700 && !$("#navMenu").is(':visible')) {
            $("#navMenu").show(500);
        }
    });
    //La siguiente función rellena las barras del header automáticamente
    rellenaBars();
    function rellenaBars() {
        for (var i = 0; i < 20; i++) {
            $("#bars").append("<div class='bar cambiaColor'>");
        }
    }

    //La siguiente función hace que todo lo que tenga las clases cambiaColor
    // y cambiaColorBorde se cambie de color;
    cambiaColor();
    setInterval(cambiaColor, 3000);
    function cambiaColor() {
        if (contador > colores.length) {
            contador = 0;
        }
        $(".cambiaColor, #modalMenu:before").css({ "background": colores[contador] });
        $(".cambiaColorBorde").css({ "border-color": colores[contador] });
        $("nav a , #modalMenu").css({ "border-color": colores[contador], "color": colores[contador] });
        $("footer p").css({ "color": colores[contador] });
        $(".hvr-back-pulse:hover").css({ "background": colores[contador] })
        contador++;
    }

    //La siguiente función hace que si hacemos scroll de la página el header
    //desaparezca pero el nav se quede estático en top.
    $(window).scroll(function () {
        if ($(window).scrollTop() > 100) {
            $("nav").addClass("fix");
        }
        else {
            $("nav").removeClass("fix");
        }
    });

    $("#modalLogin").on("click", openLogin);
    function openLogin() {
        $("#login").css({ "visibility": "visible" });
        $("#login").toggle(500);
    }

    $("#modalMenu").on("click", openMenu);
    function openMenu() {
        if ($("#navMenu").is(':visible'))
            $("#flecha").attr("class", "fa fa-angle-double-up");
        else
            $("#flecha").attr("class", "fa fa-angle-double-down");
        $("#navMenu").slideToggle(500);
    }
});