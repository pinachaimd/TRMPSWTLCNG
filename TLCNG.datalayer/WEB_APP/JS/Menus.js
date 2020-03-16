//BOTON DE CERRAR CESION
$(document).ready(function () {
    $('#cerrarsesion').click(function () {
        location.href = "../Principal.aspx";
    });
});

//predial
$(document).ready(function () {
    $('#btnpredial').click(function () {
        location.href = "../Predial/ModuloPredial.aspx";
    });
});

//usuarios
$(document).ready(function () {
    $('#btnusuarios').click(function () {
        alert('diste click en usuario');
    });
});

//perfiles
$(document).ready(function () {
    $('#btnperfiles').click(function () {
        alert('diste click en perfiles');
    });
});

//tramites
$(document).ready(function () {
    $('#btntramites').click(function () {
        alert('diste click en tramites');
    });
});

//cajas
$(document).ready(function () {
    $('#btncajas').click(function () {
        alert('diste click en cajas');
    });
});