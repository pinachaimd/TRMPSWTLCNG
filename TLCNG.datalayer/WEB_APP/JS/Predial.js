$(document).ready(function () {
    despliegamenu();
    muestralosdiferentesmenus();
    clickencadaunodelosmenusinformacion();
    clickcadaunodelosmenusmantenimiento();
    //predio
    muestralosdiferentestiposdebusqueda();
    muestratodalainfodelpredio();
    informaciondelosbotonespredio();
});

//muestra y oculta el menu lateral
function despliegamenu() {
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });
}

//muestra los difentes tipos de menus laterales
function muestralosdiferentesmenus() {
    //menu 1
    $('#btninformacion').click(function () {
        $('#menu1').show();
        $('#menu2').hide();
        $('#menu3').hide();
        limpiagrid();
    });

    //menu 2
    $('#btnmantenimiento').click(function () {
        $('#menu1').hide();
        $('#menu2').show();
        $('#menu3').hide();
        limpiagrid();
    });

    //menu 3
    $('#btnestadisticas').click(function () {
        $('#menu1').hide();
        $('#menu2').hide();
        $('#menu3').show();
        limpiagrid();
    });
}

function limpiagrid() {
    $('#MenuPredio').hide();
    $('#MenuHistorialesPredio').hide();
    $('#MenuContribuyentePredio').hide();
    $('#MenuDireccionPredio').hide();
    $('#MenuFoxProAdeudos').hide();
    $('#MenuHistorialMysql').hide();
    $('#MenuCalculoRecargos').hide();
    $('#MenuCondonacionesAdeudo').hide();
    $('#MenuCondonacionesAvaluo').hide();
    $('#MenuDocumentosProcesos').hide();
    $('#MenuCancelacionPago').hide();
    $('#ManuAplicaciondeMultas').hide();
    $('#ManuCambioAdeudo').hide();

    $('#cuentadapredial').hide();
    $('#busquedapredio').hide();
    $('#cuentacatastral').hide();
    $('#infopredios').hide();
    $('#cuentadapredialhistoricos').hide();
    $('#cuentacatastralhistoricos').hide();
    $('#busquedaprediohistoricos').hide();
    $('#pfisica').hide();
    $('#pmoral').hide();
    $('#btnbuscaconpre').hide();
    $('input[name=accioncontribuyente]').prop('checked', false);
    $('#adeudosbusca').hide();
    $('#basegravable').hide();
    $('#buscarbasefoxpro').hide();
    $('#claprefoxpro').hide();
    $('#ctacatastralfoxpro').hide();
    $('#nombrefoxpro').hide();
    $('#predialmysql').hide();
    $('#usuariomysql').hide();
    $('#buscamysql').hide();
    $('input[name=accionmysql]').prop('checked', false);
    $('#annocalculobimestrales').hide();
    $('#recargo').hide();
    $('#calcularecargo').hide();
    $('#cuentarecargos').hide();
    $('#claverecargos').hide();
    $('#nombrerecargos').hide();
    $('#buscarecargos').hide();
    $('#pfisicacondonaciones').hide();
    $('#pmoralcondonaciones').hide();
    $('#cuentacondonacionesavaluo').hide();
    $('#clavecondonacionesavaluo').hide();
    $('#buscarcondonacionesavaluos').hide();
    $('#claveaplicacionmulta').hide();
    $('#cuentaaplicaiconmulta').hide();
    $('#buscaraplicacionmulta').hide();
    $('#cuentacambioadeudo').hide();
    $('#clavecambioadeudo').hide();
    $('#buscarcambioadeudo').hide();

    ///////////////////////////////////////////////////////////////////////////////////////////////
    //MANTENIMIENTO
    $('#Manucontribuyentesmante').hide();
    $('#ManupPrediomante').hide();
    $('#Manupinfoparcelasmante').hide();
    $('#Manucambiocuentamante').hide();
    $('#Manucostodocumentos').hide();
    $('#Manupagominimomante').hide();
    $('#MenuPrediosNuevos').hide();
    $('#MenuNotasSistemas').hide();
    $('#MenuCancelacionPredio').hide();
    $('#MenuAutorizacionAvaluos').hide();
    $('#MenuAjustesvalorescatastrales').hide();

    $('#cuentacontribuyenteman').hide();
    $('#clavecuentacontri').hide();
    $('#buscarcontrimante').hide();
    $('#cuentapredioman').hide();
    $('#clavecuentapredio').hide();
    $('#buscarcprediomante').hide();    
    $('#cuentaparcelasoman').hide();
    $('#clavecuentaparcelas').hide();
    $('#buscarparcelasmante').hide();
    $('#cuentacambiocuentaman').hide();
    $('#clavecuentacambiocuenta').hide();
    $('#buscarcambiocuentamante').hide();
    $('#notaaltacuenta').hide();
    $('#notaaltacolonia').hide();
    $('#buscarnotasaltas').hide();
    $('#infonotaalta').hide();
    $('#cuentadapredialcancelacion').hide();
    $('#cuentacatastralcancelacion').hide();
    $('#busquedaprediocancelacion').hide();
    $('#infocancelacionpredio').hide();
    $('#cuentadapredialajuste').hide();
    $('#cuentacatastralajuste').hide();
    $('#busquedapredioajuste').hide(); 
}

//muestra los formularios dependiendo el link que precione
function clickencadaunodelosmenusinformacion() {
    //Menu Predio
    $('#linkpredio').click(function () {
        $('#MenuPredio').show();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#cuentadapredial').hide();
        $('#busquedapredio').hide();
        $('#cuentacatastral').hide();
        $('#infopredios').hide();
    });

    $('#linkhistorialpredio').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').show();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#cuentadapredialhistoricos').hide();
        $('#cuentacatastralhistoricos').hide();
        $('#busquedaprediohistoricos').hide();
    });

    $('#linkcontribuyentepredio').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').show();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#pfisica').hide();
        $('#pmoral').hide();
        $('#btnbuscaconpre').hide();
        $('input[name=accioncontribuyente]').prop('checked', false);
    });

    $('#linkdireccionpredio').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').show();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();
    });

    $('#linkfoxpropredio').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').show();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#adeudosbusca').hide();
        $('#basegravable').hide();
        $('#buscarbasefoxpro').hide();
        $('#claprefoxpro').hide();
        $('#ctacatastralfoxpro').hide();
        $('#nombrefoxpro').hide();
    });

    $('#linkhistorialmysql').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').show();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#predialmysql').hide();
        $('#usuariomysql').hide();
        $('#buscamysql').hide();
        $('input[name=accionmysql]').prop('checked', false);
    });

    //Menu Proceso
    $('#linkcalculorecargos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').show();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#annocalculobimestrales').hide();
        $('#recargo').hide();
        $('#calcularecargo').hide();
    });


    //condonaciones procesos
    $('#linkcondonacionprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').show();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#cuentarecargos').hide();
        $('#claverecargos').hide();
        $('#nombrerecargos').hide();
        $('#buscarecargos').hide();
        $('#pfisicacondonaciones').hide();
        $('#pmoralcondonaciones').hide();
    });

    //condonaciones de avaluo
    $('#linkcondonacionavaluosprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').show();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();

        $('#cuentacondonacionesavaluo').hide();
        $('#clavecondonacionesavaluo').hide();
        $('#buscarcondonacionesavaluos').hide();
    });

    //documentos procesos
    $('#linkdocumentacionprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').show();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();
    });


    //cancelacion de pagos
    $('#linkcancelacionopagosprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').show();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').hide();
    });

    //aplicacion de multas
    $('#linkaplicacionmultasprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').show();
        $('#ManuCambioAdeudo').hide();

        $('#claveaplicacionmulta').hide();
        $('#cuentaaplicaiconmulta').hide();
        $('#buscaraplicacionmulta').hide();
    });

    //aplicacion de multas
    $('#linkcambioadeudoprocesos').click(function () {
        $('#MenuPredio').hide();
        $('#MenuHistorialesPredio').hide();
        $('#MenuContribuyentePredio').hide();
        $('#MenuDireccionPredio').hide();
        $('#MenuFoxProAdeudos').hide();
        $('#MenuHistorialMysql').hide();
        $('#MenuCalculoRecargos').hide();
        $('#MenuCondonacionesAdeudo').hide();
        $('#MenuCondonacionesAvaluo').hide();
        $('#MenuDocumentosProcesos').hide();
        $('#MenuCancelacionPago').hide();
        $('#ManuAplicaciondeMultas').hide();
        $('#ManuCambioAdeudo').show();

        $('#cuentacambioadeudo').hide();
        $('#clavecambioadeudo').hide();
        $('#buscarcambioadeudo').hide();
    });
}

function clickcadaunodelosmenusmantenimiento() {
    $('#linkcontribuyentesmantenimiento').click(function () {
        $('#Manucontribuyentesmante').show();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();

        $('#cuentacontribuyenteman').hide();
        $('#clavecuentacontri').hide();
        $('#buscarcontrimante').hide();
    });

    $('#linkprediomantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').show();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();
        
        $('#cuentapredioman').hide();
        $('#clavecuentapredio').hide();
        $('#buscarcprediomante').hide();        
    });

    $('#linkinfoparcelarmantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').show();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();

        $('#cuentaparcelasoman').hide();
        $('#clavecuentaparcelas').hide();
        $('#buscarparcelasmante').hide();
    });   

    $('#linkcambiocuentamantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').show();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();

        $('#cuentacambiocuentaman').hide();
        $('#clavecuentacambiocuenta').hide();
        $('#buscarcambiocuentamante').hide();
    });   

    $('#linkcostodocumentosmantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').show();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();
    }); 

    $('#linkpagominimomantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').show();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();
    }); 

    $('#linknuevoprediomantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').show();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();
    });

    $('#linknotasmantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').show();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();

        $('#notaaltacuenta').hide();
        $('#notaaltacolonia').hide();
        $('#buscarnotasaltas').hide();
        $('#infonotaalta').hide();        
    });

    $('#linkcancelacionprediomantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').show();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').hide();

        $('#cuentadapredialcancelacion').hide();
        $('#cuentacatastralcancelacion').hide();
        $('#busquedaprediocancelacion').hide();
        $('#infocancelacionpredio').hide();
    });    

    $('#linkAutorizacionavaluosmantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').show();
        $('#MenuAjustesvalorescatastrales').hide();
    });    

    $('#linkajustesvalorescatastralesmantenimiento').click(function () {
        $('#Manucontribuyentesmante').hide();
        $('#ManupPrediomante').hide();
        $('#Manupinfoparcelasmante').hide();
        $('#Manucambiocuentamante').hide();
        $('#Manucostodocumentos').hide();
        $('#Manupagominimomante').hide();
        $('#MenuPrediosNuevos').hide();
        $('#MenuNotasSistemas').hide();
        $('#MenuCancelacionPredio').hide();
        $('#MenuAutorizacionAvaluos').hide();
        $('#MenuAjustesvalorescatastrales').show();

        $('#cuentadapredialajuste').hide();
        $('#cuentacatastralajuste').hide();
        $('#busquedapredioajuste').hide();        
    }); 
    
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//muestra los diferentes tipos de busqueda
function muestralosdiferentestiposdebusqueda() {
    //busqueda cuenta predial
    $('#btnbuscacuentapredial').click(function () {
        $('#cuentadapredial').show();
        $('#busquedapredio').show();
        $('#cuentacatastral').hide();
    });

    //busqueda cuenta catastral
    $('#btnbuscacuentacatastral').click(function () {
        $('#cuentacatastral').show();
        $('#busquedapredio').show();
        $('#cuentadapredial').hide();
    });
}

function muestratodalainfodelpredio() {
    $('#btnbuscarpredio').click(function () {
        $('#infopredios').show();
    });
}

function informaciondelosbotones() {

}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//HISTORIAL PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    //historial predio
    muestralosdiferentestiposdebusquedahistorial();
    muestrahistorialdelpredio();
});

function muestralosdiferentestiposdebusquedahistorial() {
    //busqueda cuenta predial
    $('#btnbuscacuentahistorialpredial').click(function () {
        $('#cuentadapredialhistoricos').show();
        $('#busquedaprediohistoricos').show();
        $('#cuentacatastralhistoricos').hide();
    });

    //busqueda cuenta catastral
    $('#btnbuscacuentahistorialcatastral').click(function () {
        $('#cuentacatastralhistoricos').show();
        $('#busquedaprediohistoricos').show();
        $('#cuentadapredialhistoricos').hide();
    });
}

function muestrahistorialdelpredio() {
    $('#btnbuscarprediohistorico').click(function () {
        $('#ModalHistorialPredio').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CONTRIBUYENTES PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    //contriyuente predio
    muestrainfocontribuyente();
    buscadependiendoelcontribuyente();
});

function muestrainfocontribuyente() {
    $('input[name=accioncontribuyente]').prop('checked', false);

    $("input[name=accioncontribuyente]").change(function () {
        var contribuyente = $('input:radio[name=accioncontribuyente]:checked').val();

        if (contribuyente == 'F') {
            $('#pfisica').show();
            $('#pmoral').hide();
            $('#btnbuscaconpre').show();
        }
        else if (contribuyente == 'M') {
            $('#pfisica').hide();
            $('#pmoral').show();
            $('#btnbuscaconpre').show();
        }
    });
}

function buscadependiendoelcontribuyente() {
    $('#btnbuscainfocontribuyentepredio').click(function () {
        $('#ModalContribuyentePredio').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//DIRECCION PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    $('#btncuscardireccionpredio').click(function () {
        $('#ModalDireccionpredio').modal('show');
    });
});



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//FOXPRO PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    //contriyuente predio
    muestrafoxproadeudos();
    buscafoxpropredio();
});

function muestrafoxproadeudos() {
    $('#btnadeudosfoxpropredial').click(function () {
        $('#adeudosbusca').show();
        $('#basegravable').hide();
        $('#buscarbasefoxpro').show();
    });

    $('#btnbasegravablefoxpropredial').click(function () {
        $('#adeudosbusca').hide();
        $('#basegravable').show();
        $('input[name=accionfoxpro]').prop('checked', false);
        seleccionaunaopcionfoxpro();
    });
}

function seleccionaunaopcionfoxpro() {
    $("input[name=accionfoxpro]").change(function () {
        var foxpro = $('input:radio[name=accionfoxpro]:checked').val();

        if (foxpro == 'P') {
            $('#claprefoxpro').show();
            $('#ctacatastralfoxpro').hide();
            $('#nombrefoxpro').hide();
            $('#buscarbasegravablefoxpro').show();
        }
        else if (foxpro == 'C') {
            $('#claprefoxpro').hide();
            $('#ctacatastralfoxpro').show();
            $('#nombrefoxpro').hide();
            $('#buscarbasegravablefoxpro').show();
        }
        else if (foxpro == 'N') {
            $('#claprefoxpro').hide();
            $('#ctacatastralfoxpro').hide();
            $('#nombrefoxpro').show();
            $('#buscarbasegravablefoxpro').show();
        }
    });
}

function buscafoxpropredio() {
    $('#btnbuscarfoxpro').click(function () {
        $('#ModalAdeudoFoxpro').modal('show');
    });

    $('#btnbuscarbasegravablefoxpro').click(function () {
        $('#Modalbasegravablefoxpro').modal('show');
    });
}




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Mysql PREDIAL
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaunaccionmysql();
    buscadatosmysql();
});

function seleccionaunaccionmysql() {
    $("input[name=accionmysql]").change(function () {
        var mysql = $('input:radio[name=accionmysql]:checked').val();

        if (mysql == 'P') {
            $('#predialmysql').show();
            $('#usuariomysql').hide();
            $('#buscamysql').show();
        }
        else if (mysql == 'U') {
            $('#predialmysql').hide();
            $('#usuariomysql').show();
            $('#buscamysql').show();
        }
    });
}

function buscadatosmysql() {
    $('#btnbuscamysql').click(function () {
        $('#ModalMysqlPredio').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CALCULOS DE RECARGOS PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionacalculoderecargos();
    buscacalculorecargos();
});

function seleccionacalculoderecargos() {
    $('#btnparametrosbimestrales').click(function () {
        $('#annocalculobimestrales').show();
        $('#recargo').show();
        $('#calcularecargo').show();
    });

    //$('#btnparametrosbimestrales').click(function () {
    //    $('#annocalculobimestrales').show();
    //    $('#recargo').show();
    //    $('#calcularecargo').show();
    //});
}

function buscacalculorecargos() {
    $('#btncalcularecargo').click(function () {
        $('#ModalCalculoRecargos').modal('show');
    });
}




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CONDONACIONES DE ADEUDOS PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionatipodebusquedaparacondonaciondeadeudo();
    clickparabusquedadecondonaciones();
});

function seleccionatipodebusquedaparacondonaciondeadeudo() {
    $('#btncondonacioncuentapredial').click(function () {
        $('#cuentarecargos').show();
        $('#claverecargos').hide();
        $('#nombrerecargos').hide();
        $('#buscarecargos').show();
        $('#pfisicacondonaciones').hide();
        $('#pmoralcondonaciones').hide();
    });

    $('#btncondonacionclavecatastra').click(function () {
        $('#cuentarecargos').hide();
        $('#claverecargos').show();
        $('#nombrerecargos').hide();
        $('#buscarecargos').show();
        $('#pfisicacondonaciones').hide();
        $('#pmoralcondonaciones').hide();
    });

    $('#btncondonacionespropietario').click(function () {
        $('#cuentarecargos').hide();
        $('#claverecargos').hide();
        $('#nombrerecargos').show();
        $('#buscarecargos').hide();
        $('#pfisicacondonaciones').hide();
        $('#pmoralcondonaciones').hide();

        selecionaaccioncondonaciones();
    });
}

function selecionaaccioncondonaciones() {
    $('input[name=accioncondonaciones]').prop('checked', false);

    $("input[name=accioncondonaciones]").change(function () {
        var Condonaciones = $('input:radio[name=accioncondonaciones]:checked').val();

        if (Condonaciones == 'F') {
            $('#pfisicacondonaciones').show();
            $('#pmoralcondonaciones').hide();
            $('#buscarecargos').show();
        }
        else if (Condonaciones == 'M') {
            $('#pfisicacondonaciones').hide();
            $('#pmoralcondonaciones').show();
            $('#buscarecargos').show();
        }
    });
}

$(document).ready(function () {
    $('#btnbuscarecargosprocesos').click(function () {
        $('#ModalCondonacionesrecargos').modal('show');
    });
});



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CONDONACIONES DE AVALUOS PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedacondonacionesavaluos();
    clickparabusquedacondonacionavaluos();
});

function seleccionabusquedacondonacionesavaluos() {
    $('#btncondonacionavaluocuentapredial').click(function () {
        $('#cuentacondonacionesavaluo').show();
        $('#clavecondonacionesavaluo').hide();
        $('#buscarcondonacionesavaluos').show();
    });

    $('#btncondonacionAvaluoclavecatastra').click(function () {
        $('#cuentacondonacionesavaluo').hide();
        $('#clavecondonacionesavaluo').show();
        $('#buscarcondonacionesavaluos').show();
    });
}

function clickparabusquedacondonacionavaluos() {
    $('#btnbuscarecargosavaluosprocesos').click(function () {
        $('#ModalCondonacionesAvaluosrecargos').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//DOCUMENTACION DE PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedadocumentos();
});

function seleccionabusquedadocumentos() {
    $('#btnbuscarparametrosdescuentos').click(function () {
        $('#ModalDescuentosProcesos').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CANCELACION DE PAGOS DE PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    buscafolioparacancelaciondepago();
});

function buscafolioparacancelaciondepago() {
    $('#btnbuscarfoliocancelacionpago').click(function () {
        $('#Modalcancelaciopagosprocesos').modal('show');
    });
}




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//APLICACION DE MULTAS PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedaaplicaciondemultas();
    clickparabusquedaaplicacionmultas();
});

function seleccionabusquedaaplicaciondemultas() {
    $('#btnaplicacionmultascuentapredial').click(function () {
        $('#cuentaaplicaiconmulta').show();
        $('#claveaplicacionmulta').hide();
        $('#buscaraplicacionmulta').show();
    });

    $('#btnaplicacionmultasclavepredia').click(function () {
        $('#cuentaaplicaiconmulta').hide();
        $('#claveaplicacionmulta').show();
        $('#buscaraplicacionmulta').show();
    });
}

function clickparabusquedaaplicacionmultas() {
    $('#btnbuscaaplicacionmultaprocesos').click(function () {
        $('#ModalAplicacionmultas').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CAMBIO DE ADEUDO PROCESOS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedacambioadeudo();
    clickparabusquedacambioadeudo();
});

function seleccionabusquedacambioadeudo() {
    $('#btncambioadeudocuentapredial').click(function () {
        $('#cuentacambioadeudo').show();
        $('#clavecambioadeudo').hide();
        $('#buscarcambioadeudo').show();
    });

    $('#btncambioadeudoclavepredia').click(function () {
        $('#cuentacambioadeudo').hide();
        $('#clavecambioadeudo').show();
        $('#buscarcambioadeudo').show();
    });
}

function clickparabusquedacambioadeudo() {
    $('#btnbuscacambioadeudoprocesos').click(function () {
        $('#Modalcambiodeadeudos').modal('show');
    });
}



//**************************************************************************************************************************************************

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CONTRIBUYENTE MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedacontribuyente();
    clickparabusquedacontribumante();
});

function seleccionabusquedacontribuyente() {
    $('#btncuentacontribuyentemante').click(function () {
        $('#cuentacontribuyenteman').show();
        $('#clavecuentacontri').hide();
        $('#buscarcontrimante').show();
    });

    $('#btncatastralcontribuyenmante').click(function () {
        $('#cuentacontribuyenteman').hide();
        $('#clavecuentacontri').show();
        $('#buscarcontrimante').show();
    });
}

function clickparabusquedacontribumante() {
    $('#btnbuscacontrimante').click(function () {
        $('#Modalcontribuyentemantenimiento').modal('show');
    });

    $('#btn').click(function () {
        $('#ModalEdicionContribuyente').modal('show');
        $('input[name=accioncontribuyentes]').prop('checked', false);
        seleccionaradiobutoncontribuyente();
    });
}

function seleccionaradiobutoncontribuyente() {
    $("input[name=accioncontribuyentes]").change(function () {
        var contrimante = $('input:radio[name=accioncontribuyentes]:checked').val();

        if (contrimante == 'F') {
            $('#pfisicacontribuyentes').show();
            $('#sexocontribuyente').show();
            $('#pmoralcontribuyentes').hide();            
        }
        else if (contrimante == 'M') {
            $('#pfisicacontribuyentes').hide();
            $('#sexocontribuyente').hide();
            $('#pmoralcontribuyentes').show();
        }
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//PREDIO MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedapredio();
    clickparabusquedaprediomante();
});

function seleccionabusquedapredio() {
    $('#btncuentapredioemante').click(function () {
        $('#cuentapredioman').show();
        $('#clavecuentapredio').hide();
        $('#buscarcprediomante').show();    
    });

    $('#btncatastralprediomante').click(function () {
        $('#cuentapredioman').hide();
        $('#clavecuentapredio').show();
        $('#buscarcprediomante').show();    
    });
}

function clickparabusquedaprediomante() {
    $('#btnbuscaprediomante').click(function () {
        $('#ModalPrediomantenimiento').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//INFORMACION DE PARCELAS MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedaparcelasmante();
    clickparabusquedaparcelamante();
});

function seleccionabusquedaparcelasmante() {
    $('#btncuentaparcelasmante').click(function () {
        $('#cuentaparcelasoman').show();
        $('#clavecuentaparcelas').hide();
        $('#buscarparcelasmante').show();
    });

    $('#btncatastralparcelasmante').click(function () {
        $('#cuentaparcelasoman').hide();
        $('#clavecuentaparcelas').show();
        $('#buscarparcelasmante').show();
    });
}

function clickparabusquedaparcelamante() {
    $('#btnbuscaparcelasmante').click(function () {
        $('#Modalparcelamantenimiento').modal('show');
    });
}




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CAMBIO DE CUENTAS MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionabusquedacambiodecuentas();
    clickparabusquedapcambiodecuentamante();
});

function seleccionabusquedacambiodecuentas() {
    $('#btncuentacambiocuentamante').click(function () {
        $('#cuentacambiocuentaman').show();
        $('#clavecuentacambiocuenta').hide();
        $('#buscarcambiocuentamante').show();
    });

    $('#btncatastralcambiocuentamante').click(function () {
        $('#cuentacambiocuentaman').hide();
        $('#clavecuentacambiocuenta').show();
        $('#buscarcambiocuentamante').show();
    });
}

function clickparabusquedapcambiodecuentamante() {
    $('#btnbuscacambiocuentamante').click(function () {
        $('#Modalcambiocuentamante').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//COSTO DE DOCUMENTOS MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaaccionbotonescostodocumentos();
});

function seleccionaaccionbotonescostodocumentos() {
    $('#btnconstanciasmantenimiento').click(function () {
        $('#ModalContanciasMantenimiento').modal('show');      
        guardamodificacionconstancia();
    });

    $('#btnimprecionmapamantenimiento').click(function () {
        $('#Modalimpreciondemapa').modal('show');   
    });

    $('#btnpagosdiversos').click(function () {
        $('#ModaPagosdiversos').modal('show');
    });

    $('#btnparametrosavaluos').click(function () {
        $('#ModaParametrosavaluos').modal('show');
    });
}

function guardamodificacionconstancia() {
    $('#btnnuevacontancia').click(function () {   
        $('#ModalNuevaconstancia').modal('show');   
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//PAGO MINIMO MANTENIMIENTO
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaaccionbotonpagominimo();
});

function seleccionaaccionbotonpagominimo() {
    $('#btnpagominimo').click(function () {
        $('#ModalPagominimo').modal('show');
        guardamodificacionpagominimo();
    });
}

function guardamodificacionpagominimo() {
    $('#btnnuevopagominimo').click(function () {
        $('#ModalNuevopagominimo').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//NUEVO PREDIO SISTEMAS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaaccionbotonesnuevospredios();
});

function seleccionaaccionbotonesnuevospredios() {
    $('#btnprediossinclavepredial').click(function () {
        $('#Modalprediossinclavepredial').modal('show');
        verformularioprueba();
    });

    $('#btnprediosinpropietarios').click(function () {
        $('#Modalprediossinpropietarios').modal('show');
        verformularioprueba();
    });
}

function verformularioprueba() {
    $('#btnver').click(function () {
        $('#Modalnuevoprediosinclavepredial').modal('show');
    });

    $('#btndetalle').click(function () {
        $('#Modalnuevoprediocontribuyente').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//NOTAS SISTEMAS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaaccionbotonesnotas();
});

function seleccionaaccionbotonesnotas() {
    $('#btnaltanotasistema').click(function () {
        $('#Modalnotaalta').modal('show');
        seleccionaradiobuttonnotasaltas();
    });
}

function seleccionaradiobuttonnotasaltas() {
    $("input[name=accionbuscanotaalta]").change(function () {
        var altanota = $('input:radio[name=accionbuscanotaalta]:checked').val();

        if (altanota == 'P') {
            $('#notaaltacuenta').show();
            $('#notaaltacolonia').hide();
            $('#buscarnotasaltas').show();
            $('#infonotaalta').show();
        }
        else if (altanota == 'C') {
            $('#notaaltacuenta').hide();
            $('#notaaltacolonia').show();
            $('#buscarnotasaltas').show();
            $('#infonotaalta').hide();
        }
    });
}




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CANCELACION PREDIO SISTEMAS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaaccionbotonescacelacionpredios();
    clickbotondebuscarcancelacionpredios();
});

function seleccionaaccionbotonescacelacionpredios() {
    $('#btnbuscacuentapredialcancelacion').click(function () {
        $('#cuentadapredialcancelacion').show();
        $('#cuentacatastralcancelacion').hide();
        $('#busquedaprediocancelacion').show();
    });

    $('#btnbuscacuentacatastralcancelacion').click(function () {
        $('#cuentadapredialcancelacion').hide();
        $('#cuentacatastralcancelacion').show();
        $('#busquedaprediocancelacion').show();
    });
}

function clickbotondebuscarcancelacionpredios() {
    $('#btnbuscarprediocancelacion').click(function () {
        $('#infocancelacionpredio').show();
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//AUTORIZACION DE AVALUOS SISTEMAS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaActualizarlista();   
});

function seleccionaActualizarlista() {
    $('#btnactualizarlista').click(function () {
        $('#ModalAutorizacionLista').modal('show');
    });
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//AJUSTE DE VALORES CATASTRALES SISTEMAS
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    seleccionaAjustesvalores();
    seleccionabusquedaajustes();
});

function seleccionaAjustesvalores() {
    $('#btnbuscacuentapredialajuste').click(function () {
        $('#cuentadapredialajuste').show();
        $('#cuentacatastralajuste').hide();
        $('#busquedapredioajuste').show(); 
    });

    $('#btnbuscacuentacatastralajuste').click(function () {
        $('#cuentadapredialajuste').hide();
        $('#cuentacatastralajuste').show();
        $('#busquedapredioajuste').show(); 
    });
}

function seleccionabusquedaajustes() {
    $('#btnbuscarpredioajuste').click(function () {
        $('#ModalAjustevalores').modal('show');
    });
}
