<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuloPredial.aspx.cs" Inherits="WEB_APP.Predial.ModuloPredial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link rel="shortcut icon" href="Imagenes/Fondo/logo2.png" />

    <title>Predial</title>
    <link href="../CSS/Menus.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/mdb.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../CSS/EstiloPredial.css" />

    <!-- Font Awesome JS -->
    <script src="../Script/mdb.min.js"></script>
    <script src="../Script/dropzone.js"></script>
    <script src="../Script/moment.min.js"></script>
    <script src="../Script/solid.js"></script>
    <script src="../Script/fontawesome.js"></script>
    <script src="../Script/jquery-3.3.1.min.js"></script>
    <script src="../Script/bootstrap.min.js"></script>
    <script src="../JS/Predial.js"></script>
    <script src="../Script/popper.min.js"></script>

</head>
<body>
    <div class="wrapper">
        <nav id="sidebar">
            <div class="sidebar-header">
                <h3>MENU</h3>
            </div>

            <div id="menu1">
                <ul class="list-unstyled components">
                    <li>
                        <a href="#GeneralSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                            <img src="../Imagenes/Menu/Predial/igeneral.png" width="20" height="20" /><span class="textespaciImagen">General</span></a>
                        <ul class="collapse list-unstyled" id="GeneralSubmenu">
                            <li id="linkpredio">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/predio.png" width="20" height="20" /><span class="textespaciImagen">Predio</span></a>
                            </li>
                            <li id="linkhistorialpredio">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/historial_de_predio.png" width="20" height="20" /><span class="textespaciImagen">Historiales del Predio</span></a>
                            </li>
                            <li id="linkcontribuyentepredio">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/contribuyente.png" width="20" height="20" /><span class="textespaciImagen">Contribuyente</span></a>
                            </li>
                            <li id="linkdireccionpredio">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/direccion.png" width="20" height="20" /><span class="textespaciImagen">Dirección</span></a>
                            </li>
                            <li id="linkfoxpropredio">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/adeudos_Foxpro.png" width="20" height="20" /><span class="textespaciImagen">Adeudos FoxPro</span></a>
                            </li>
                            <li id="linkhistorialmysql">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/General/historial_MySQL.png" width="20" height="20" /><span class="textespaciImagen">Historial MySQL</span></a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href="#ProcesosSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                            <img class="" src="../Imagenes/Menu/Predial/procesos.png" width="20" height="20" /><span class="textespaciImagen">Procesos</span></a>
                        <ul class="collapse list-unstyled" id="ProcesosSubmenu">
                            <li id="linkcalculorecargos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/calculo_de_recargos.png" width="20" height="20" /><span class="textespaciImagen">Calculo de Recargos</span></a>
                            </li>
                            <li id="linkcondonacionprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/condonaciones.png" width="20" height="20" /><span class="textespaciImagen">Condonaciones al Adeudo</span></a>
                            </li>
                            <li id="linkcondonacionavaluosprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/condonacion de avaluos.png" width="20" height="20" /><span class="textespaciImagen">Condonación al Avaluo</span></a>
                            </li>
                            <li id="linkdocumentacionprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/descuentos.png" width="20" height="20" /><span class="textespaciImagen">Descuentos</span></a>
                            </li>
                            <li id="linkcancelacionopagosprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/cancelacion_de_pagos.png" width="20" height="20" /><span class="textespaciImagen">Cancelación de Pagos</span></a>
                            </li>
                            <li id="linkaplicacionmultasprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/aplicacion_de_multas.png" width="20" height="20" /><span class="textespaciImagen">Aplicación de Multas</span></a>
                            </li>
                            <li id="linkcambioadeudoprocesos">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Procesos/cambio de adeudo.png" width="20" height="20" /><span class="textespaciImagen">Cambio de Adeudo</span></a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>

            <div id="menu2">
                <ul class="list-unstyled components">
                    <li>
                        <a href="#MantenimientoSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                            <img src="../Imagenes/Menu/Predial/mantenimiento.png" width="20" height="20" /><span class="textespaciImagen">Mantenimiento</span></a>
                        <ul class="collapse list-unstyled" id="MantenimientoSubmenu">
                            <li id="linkcontribuyentesmantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/contribuyente.png" width="20" height="20" /><span class="textespaciImagen">Contribuyente</span></a>
                            </li>
                            <li id="linkprediomantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/predio.png" width="20" height="20" /><span class="textespaciImagen">Predio</span></a>
                            </li>
                            <li id="linkinfoparcelarmantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/informacion_de_parcelas.png" width="20" height="20" /><span class="textespaciImagen">Información de Planos</span></a>
                            </li>
                            <li id="linkcambiocuentamantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/cambio de cuenta.png" width="20" height="20" /><span class="textespaciImagen">Cambio de Cuenta</span></a>
                            </li>
                            <li id="linkcostodocumentosmantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/cosntancia.png" width="20" height="20" /><span class="textespaciImagen">Costo de Documentos</span></a>
                            </li>
                            <li id="linkpagominimomantenimiento">
                                <a>
                                    <img src="../Imagenes/Menu/Predial/Mantenimiento/pago_minimo.png" width="20" height="20" /><span class="textespaciImagen">Pago Mínimo</span></a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href="#SistemaSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                            <img class="" src="../Imagenes/Menu/Predial/sistema.png" width="20" height="20" /><span class="textespaciImagen">Sistema</span></a>
                        <ul class="collapse list-unstyled" id="SistemaSubmenu">
                            <li id="linknuevoprediomantenimiento">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Sistema/predios_nuevos.png" width="20" height="20" /><span class="textespaciImagen">Predios Nuevos</span></a>
                            </li>
                            <li id="linknotasmantenimiento">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Sistema/notas.png" width="20" height="20" /><span class="textespaciImagen">Notas</span></a>
                            </li>
                            <li id="linkcancelacionprediomantenimiento">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Sistema/cancelacion de predio.png" width="20" height="20" /><span class="textespaciImagen">Cancelación de Predios</span></a>
                            </li>
                            <li id="linkAutorizacionavaluosmantenimiento">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Sistema/autorizacion de avaluos.png" width="20" height="20" /><span class="textespaciImagen">Autorización de Avaluos</span></a>
                            </li>
                            <li id="linkajustesvalorescatastralesmantenimiento">
                                <a>
                                    <img class="" src="../Imagenes/Menu/Predial/Sistema/ajuste de valores.png" width="20" height="20" /><span class="textespaciImagen">Ajuste de Valores Catastrales</span></a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>

            <div id="menu3">
                <ul class="list-unstyled components">
                    <li>
                        <a href="#EstadisticaSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                            <img src="../Imagenes/Menu/Predial/estadisticas.png" width="20" height="20" /><span class="textespaciImagen">Estadisticas</span></a>
                        <ul class="collapse list-unstyled" id="EstadisticaSubmenu">
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/Historicos.png" width="20" height="20" /><span class="textespaciImagen">Históricos</span></a>
                            </li>
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/reportes_y_graficas.png" width="20" height="20" /><span class="textespaciImagen">Reporte y Gráficos</span></a>
                            </li>
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/movimientos_en_pagos.png" width="20" height="20" /><span class="textespaciImagen">Movimientos en Pagos</span></a>
                            </li>
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/detalles_en_condonacion.png" width="20" height="20" /><span class="textespaciImagen">Detalles en Condonación</span></a>
                            </li>
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/pagos_cancelados.png" width="20" height="20" /><span class="textespaciImagen">Pagos Cancelados</span></a>
                            </li>
                            <li>
                                <a href="#">
                                    <img src="../Imagenes/Menu/Predial/Estadisticas/predio_por_usuario1.png" width="20" height="20" /><span class="textespaciImagen">Predios por Propietario</span></a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>

            <div class="text-center">
                <button id="btninformacion" class="btn btn-brown btn-sm" data-toggle="modal">Informacion<i class="ml-1"></i></button>
                <button id="btnmantenimiento" class="btn btn-brown btn-sm" data-toggle="modal">Mantenimiento<i class="ml-1"></i></button>
                <button id="btnestadisticas" class="btn btn-brown btn-sm" data-toggle="modal">Estadisticas<i class="ml-1"></i></button>
            </div>
        </nav>

        <!-- Page Content  -->
        <div id="content">

            <div id="cabezera">
                <button type="button" id="sidebarCollapse" class="btn btn-info btn-sm">
                    <i class="fas fa-align-left"></i>
                    <span></span>
                </button>
            </div>

            <%-- cuando le den click a cualquier menu aqui se va a desplegar el formulario --%>
            <div id="cuerpo">
                <%-- MENU DE INFORMACION --%>
                <div>
                    <%-- PREDIOS --%>
                    <div>
                        <div id="MenuPredio" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnbuscacuentapredial" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnbuscacuentacatastral" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentadapredial">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredial" />
                                </div>
                                <div class="col" id="cuentacatastral">
                                    <label>Cuenta Catastral</label>
                                    <input class="form-control" type="text" id="txtcuentacatastral" />
                                </div>
                                <div class="col" id="busquedapredio">
                                    <button id="btnbuscarpredio" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>

                            <div id="infopredios" class="text-center margenboton">
                                <button id="btninformacionpredial" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalInformacionPredio">Información del Predio<i class="ml-1"></i></button>
                                <button id="btnadeudospredio" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalAdeudoPredio">Adeudo de Predio<i class="ml-1"></i></button>
                                <button id="btnhistorialpagos" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalHistorialpagos">Historial de Pagos<i class="ml-1"></i></button>
                                <button id="btncondonacionespredio" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalCondonaciones">Condonaciones del Predio<i class="ml-1"></i></button>
                            </div>
                        </div>

                        <%-- Información predio --%>
                        <div class="modal fade" id="ModalInformacionPredio" tabindex="-1" role="dialog" aria-labelledby="ModalInformacionPredio" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información de Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <label>INFORMACIÓN DEL PREDIO</label>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Fecha de Alta</label>
                                                <input class="form-control" type="text" id="txtfechadealtapredio" />
                                                <%--<input type="date" id="FechaInicio" class="form-control" />--%>
                                            </div>
                                            <div class="col">
                                                <label>Dirección del Predio</label>
                                                <input class="form-control" type="text" id="txtdireccionpredio" />
                                            </div>
                                            <div class="col">
                                                <label>Colonia</label>
                                                <input class="form-control" type="text" id="txtcoloniapredio" />
                                            </div>
                                            <div class="col">
                                                <label>Ubicación</label>
                                                <input class="form-control" type="text" id="txtubicacionpredio" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Tipo de Vialidad</label>
                                                <input class="form-control" type="text" id="txtvialidadpredio" />
                                            </div>
                                            <div class="col">
                                                <label>Numeros Ext/Int</label>
                                                <input class="form-control" type="text" id="txtnumerospredios" />
                                            </div>
                                            <div class="col">
                                                <label>Codigo Postal</label>
                                                <input class="form-control" type="text" id="txtcodigopostalpredio" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <label>INFORMACIÓN DEL CONTRIBUYENTE</label>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Nombre</label>
                                                <input class="form-control" type="text" id="txtnombrepredio" />
                                            </div>
                                            <div class="col">
                                                <label>A. Paterno</label>
                                                <input class="form-control" type="text" id="txtapaternopredio" />
                                            </div>
                                            <div class="col">
                                                <label>A. Materno</label>
                                                <input class="form-control" type="text" id="txtamaternopredio" />
                                            </div>
                                            <div class="col">
                                                <label>Dirección de Notificación</label>
                                                <input class="form-control" type="text" id="txtdireccionnotificacionpredio" />
                                            </div>
                                            <div class="col">
                                                <label>Tipo de Propietario</label>
                                                <input class="form-control" type="text" id="txttipopropietariopredio" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="row" style="margin-left: 25px; margin-top: 25px;">
                                                <label class="contenedor">
                                                    Mapa
                                            <input type="radio" name="accionmapa" value="M" />
                                                    <span class="marcado"></span>
                                                </label>
                                                <label style="margin-left: 40px;"></label>
                                                <label class="contenedor">
                                                    Fachada
                                            <input type="radio" name="accionmapa" value="F" />
                                                    <span class="marcado"></span>
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino Información Predio --%>

                        <%-- Adeudo del predio --%>
                        <div class="modal fade" id="ModalAdeudoPredio" tabindex="-1" role="dialog" aria-labelledby="ModalAdeudoPredio" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Adeudo del Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Años con Adeudos</label>
                                                <select class="form-control" id="cmbanoadeudopredio"></select>
                                            </div>
                                            <div class="col">
                                                <button id="btnbuscaanoadeudadopredio" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div class="modal-body mx-12">
                                            <div class="text-center form-row mb-4">
                                                <label>DETALLE DEL AÑO</label>
                                            </div>
                                            <div class="form-row mb-4">
                                                <div class="col">
                                                    <label>Monto del Adeudo</label>
                                                    <input class="form-control" type="text" id="txtmontoadeudopredio" />
                                                </div>
                                                <div class="col">
                                                    <label>Recargo</label>
                                                    <input class="form-control" type="text" id="txtrecargopredio" />
                                                </div>
                                                <div class="col">
                                                    <label>Multa</label>
                                                    <input class="form-control" type="text" id="txtmultarecargopredio" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento del Recargo</label>
                                                    <input class="form-control" type="text" id="txtdescuentorecargopredio" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento de la Multa</label>
                                                    <input class="form-control" type="text" id="txtdescuentodelamultapredio" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento General</label>
                                                    <input class="form-control" type="text" id="txtdescuentogeneralpredio" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="form-row">
                                            <table id="listatotalpagoannopredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">TOTAL</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina Adeudo predio --%>

                        <%-- historial de pago--%>
                        <div class="modal fade" id="ModalHistorialpagos" tabindex="-1" role="dialog" aria-labelledby="ModalHistorialpagos" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Historial de Pagos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Años con Historial</label>
                                                <select class="form-control" id="cmbannohistorial"></select>
                                            </div>
                                            <div class="col">
                                                <button id="btnbusquedahistorialpago" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div class="modal-body mx-12">
                                            <div class="text-center form-row mb-4">
                                                <label>DETALLE DEL AÑO</label>
                                            </div>
                                        </div>

                                        <div class="form-row">
                                            <table id="listaavaluopredial" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">AVALUO</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE SOLICITANTE </th>
                                                        <th class="th-sm negritas">MONTO</th>
                                                        <th class="th-sm negritas">FECHA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>

                                        <div class="form-row">
                                            <table id="listapagopredial" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">PAGO PREDIAL</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE SOLICITANTE </th>
                                                        <th class="th-sm negritas">MONTO</th>
                                                        <th class="th-sm negritas">FECHA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina historial de pago --%>

                        <%-- historial de pago--%>
                        <div class="modal fade" id="ModalCondonaciones" tabindex="-1" role="dialog" aria-labelledby="ModalCondonaciones" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Condonaciones</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacondonacionespredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN DE RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                        <th class="th-sm negritas">CONDONACIÓN DE MULTA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina historial de pago --%>
                        <%-- TERMINA PREDIOS --%>




                        <%-- ************************************************************************************************************************************* --%>
                        <%--HISTORIALES DE PREDIOS --%>
                        <div id="MenuHistorialesPredio" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnbuscacuentahistorialpredial" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnbuscacuentahistorialcatastral" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentadapredialhistoricos">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialhistoricos" />
                                </div>
                                <div class="col" id="cuentacatastralhistoricos">
                                    <label>Cuenta Catastral</label>
                                    <input class="form-control" type="text" id="txtcuentacatastralhistoricos" />
                                </div>
                                <div class="col" id="busquedaprediohistoricos">
                                    <button id="btnbuscarprediohistorico" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- historial predio--%>
                        <div class="modal fade" id="ModalHistorialPredio" tabindex="-1" role="dialog" aria-labelledby="ModalHistorialPredio" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Historial Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listahistorialsobreelpredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="14">MOVIMIENTOS SOBRE EL PREDIO</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas tamanotextogrid">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas tamanotextogrid">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas tamanotextogrid">CALLE</th>
                                                        <th class="th-sm negritas tamanotextogrid"># EXT</th>
                                                        <th class="th-sm negritas tamanotextogrid"># INT</th>
                                                        <th class="th-sm negritas tamanotextogrid">CP</th>
                                                        <th class="th-sm negritas tamanotextogrid">COLONIA</th>
                                                        <th class="th-sm negritas tamanotextogrid">TIPO DE CONSTRUCCION</th>
                                                        <th class="th-sm negritas tamanotextogrid">REALIZO BAJA</th>
                                                        <th class="th-sm negritas tamanotextogrid">FECHA DE ALTA</th>
                                                        <th class="th-sm negritas tamanotextogrid">FECHA DE BAJA</th>
                                                        <th class="th-sm negritas tamanotextogrid">SUP DE TERRENO</th>
                                                        <th class="th-sm negritas tamanotextogrid">SUP DE CONSTRUCCIÓN</th>
                                                        <th class="th-sm negritas tamanotextogrid">SUP URBANA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listamovimientosgenerales" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="6">MOVIMIENTOS GENERALES</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">USUARIO</th>
                                                        <th class="th-sm negritas">NOMBRE DE USUARIO</th>
                                                        <th class="th-sm negritas">FECHA</th>
                                                        <th class="th-sm negritas">HORA</th>
                                                        <th class="th-sm negritas">MOVIMIENTOS</th>
                                                        <th class="th-sm negritas">SISTEMA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina historial de pago --%>
                        <%-- TERMINA HISTORIALES DE PREDIOS --%>




                        <%-- ************************************************************************************************************************************* --%>
                        <%--CONTRIBUYENTES DE PREDIOS --%>
                        <div id="MenuContribuyentePredio" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                    <label class="contenedor">
                                        Persona Física
                                            <input type="radio" name="accioncontribuyente" value="F" />
                                        <span class="marcado"></span>
                                    </label>
                                    <label style="margin-left: 40px;"></label>
                                    <label class="contenedor">
                                        Persona Moral
                                            <input type="radio" name="accioncontribuyente" value="M" />
                                        <span class="marcado"></span>
                                    </label>
                                </div>

                                <div id="pfisica" class="form-group col">
                                    <label>Nombre</label>
                                    <input class="form-control" type="text" id="txtnombrecontribuyentespredio" />
                                </div>

                                <div id="pmoral" class="form-group col">
                                    <label>Razon Social</label>
                                    <input class="form-control" type="text" id="txtrazonsocialpredio" />
                                </div>

                                <div id="btnbuscaconpre" class="form-group col">
                                    <button id="btnbuscainfocontribuyentepredio" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- Contribuyente predio --%>
                        <div class="modal fade" id="ModalContribuyentePredio" tabindex="-1" role="dialog" aria-labelledby="ModalContribuyentePredio" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información Contribuyente</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacontribuyentepredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="6" class="th-sm negritas">INFORMACIÓN CONTRIBUYENTE</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas">NOMBRE</th>
                                                        <th class="th-sm negritas">DIRECCIÓN DEL PREDIO</th>
                                                        <th class="th-sm negritas">DIRECCIÓN DE NOTIFICACIÓN</th>
                                                        <th class="th-sm negritas">VER</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino Contribuyente Predio --%>
                        <%-- TERMINA CONTRIBUYENTES DE PREDIOS --%>




                        <%-- ************************************************************************************************************************************* --%>
                        <%--DIRECCION DE PREDIOS --%>
                        <div id="MenuDireccionPredio" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">

                                <div class="form-group col">
                                    <label>Colonia del Predio</label>
                                    <select class="form-control" id="cmbcoloniapredio"></select>
                                </div>

                                <div class="form-group col">
                                    <label>Dirección del Predio</label>
                                    <input class="form-control" type="text" id="txtdireccionnpredio" />
                                </div>

                                <div class="form-group col">
                                    <button id="btncuscardireccionpredio" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- Direccion predio--%>
                        <div class="modal fade" id="ModalDireccionpredio" tabindex="-1" role="dialog" aria-labelledby="ModalDireccionpredio" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Infomación</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listadireccionpredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="6" class="th-sm negritas">INFORMACIÓN CONTRIBUYENTE</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas">NOMBRE</th>
                                                        <th class="th-sm negritas">DIRECCIÓN DEL PREDIO</th>
                                                        <th class="th-sm negritas">DIRECCIÓN DE NOTIFICACIÓN</th>
                                                        <th class="th-sm negritas">VER</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina direccion predio --%>
                        <%--TERMINA DIRECCION DE PREDIOS --%>




                        <%-- ************************************************************************************************************************************* --%>
                        <%--ADEUDOS FOXPRO DE PREDIOS --%>
                        <div id="MenuFoxProAdeudos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnadeudosfoxpropredial" class="btn btn-brown btn-sm" data-toggle="modal">Adeudos<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnbasegravablefoxpropredial" class="btn btn-brown btn-sm" data-toggle="modal">Base Gravable<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="adeudosbusca">
                                    <label>Clave</label>
                                    <input class="form-control" type="text" id="txtclaveadeudofroxpropredial" />
                                </div>
                                <div class="col" id="buscarbasefoxpro">
                                    <button id="btnbuscarfoxpro" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                            <div id="basegravable" class="text-center form-row mb-4 margenboton">
                                <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                    <label class="contenedor">
                                        Clave Predial
                                            <input type="radio" name="accionfoxpro" value="P" />
                                        <span class="marcado"></span>
                                    </label>
                                    <label style="margin-left: 40px;"></label>
                                    <label class="contenedor">
                                        Cuenta Catastral
                                            <input type="radio" name="accionfoxpro" value="C" />
                                        <span class="marcado"></span>
                                    </label>
                                    <label style="margin-left: 40px;"></label>
                                    <label class="contenedor">
                                        Nombre
                                            <input type="radio" name="accionfoxpro" value="N" />
                                        <span class="marcado"></span>
                                    </label>
                                </div>

                                <div id="claprefoxpro" class="form-group col">
                                    <label>Clave Predia</label>
                                    <input class="form-control" type="text" id="txtclavepredialfoxpro" />
                                </div>

                                <div id="ctacatastralfoxpro" class="form-group col">
                                    <label>Cuenta Catastral</label>
                                    <input class="form-control" type="text" id="txtcuentacatastralfoxpro" />
                                </div>

                                <div id="nombrefoxpro" class="form-group col">
                                    <label>Nombre</label>
                                    <input class="form-control" type="text" id="txtnombrefoxpro" />
                                </div>
                                <div class="col" id="buscarbasegravablefoxpro">
                                    <button id="btnbuscarbasegravablefoxpro" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- Adeuos foxpro--%>
                        <div class="modal fade" id="ModalAdeudoFoxpro" tabindex="-1" role="dialog" aria-labelledby="ModalAdeudoFoxpro" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Adeudos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listaAdeudosfoxpro" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">NUMERO DE CUENTA</th>
                                                        <th class="th-sm negritas">VALOR</th>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">BIMESTRE 1</th>
                                                        <th class="th-sm negritas">BIMESTRE 2</th>
                                                        <th class="th-sm negritas">BIMESTRE 3</th>
                                                        <th class="th-sm negritas">BIMESTRE 4</th>
                                                        <th class="th-sm negritas">BIMESTRE 5</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina adeudos foxpro --%>

                        <%-- Adeuos foxpro--%>
                        <div class="modal fade" id="Modalbasegravablefoxpro" tabindex="-1" role="dialog" aria-labelledby="Modalbasegravablefoxpro" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Base Gravable</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listabasegravablefoxpro" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas">CUENTA DE ORIGEN</th>
                                                        <th class="th-sm negritas">CLAVE CATASTRAL</th>
                                                        <th class="th-sm negritas">NOMBRE PROPIETARIO</th>
                                                        <th class="th-sm negritas">VALOR CATASTRAL</th>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">NOMBRE CALLE</th>
                                                        <th class="th-sm negritas"># EXTERIOR</th>
                                                        <th class="th-sm negritas"># INTERIOR</th>
                                                        <th class="th-sm negritas">NUMERO LATERAL</th>
                                                        <th class="th-sm negritas">COLONIA</th>
                                                        <th class="th-sm negritas">SUPERFICIE</th>
                                                        <th class="th-sm negritas">CONSTRUIDO</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina adeudos foxpro --%>
                        <%--TERMINA ADEUDOS FOXPRO PREDIOS --%>





                        <%-- ************************************************************************************************************************************* --%>
                        <%--HISTORIAL MYSQL DE PREDIOS --%>
                        <div id="MenuHistorialMysql" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                    <label class="contenedor">
                                        Clave Predial
                                            <input type="radio" name="accionmysql" value="P" />
                                        <span class="marcado"></span>
                                    </label>
                                    <label style="margin-left: 40px;"></label>
                                    <label class="contenedor">
                                        Usuario
                                            <input type="radio" name="accionmysql" value="U" />
                                        <span class="marcado"></span>
                                    </label>
                                </div>

                                <div id="predialmysql" class="form-group col">
                                    <label>Clave Predial</label>
                                    <input class="form-control" type="text" id="txtpredialmysql" />
                                </div>

                                <div id="usuariomysql" class="form-group col">
                                    <label>Usuario</label>
                                    <input class="form-control" type="text" id="txtusuariomysql" />
                                </div>

                                <div id="buscamysql" class="form-group col">
                                    <button id="btnbuscamysql" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- mysql predio --%>
                        <div class="modal fade" id="ModalMysqlPredio" tabindex="-1" role="dialog" aria-labelledby="ModalMysqlPredio" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información MySQL</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listamysql" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas">TIPO DE OPERACIÓN</th>
                                                        <th class="th-sm negritas">DESCRIPCIÓN</th>
                                                        <th class="th-sm negritas">USUARIO</th>
                                                        <th class="th-sm negritas">NOMBRE</th>
                                                        <th class="th-sm negritas">FECHA DE MOVIMIENTO</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino mysql Predio --%>
                        <%-- TERMINA HISTORIAL MYSQL DE PREDIOS --%>
                    </div>
                    <%-- TERMINA PREDIOS --%>



                    <%-- PROCESOS --%>
                    <div>
                        <%-- ************************************************************************************************************************************* --%>
                        <%--CALCULO DE RECARGOS --%>
                        <div id="MenuCalculoRecargos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnparametrosbimestrales" class="btn btn-brown btn-sm" data-toggle="modal">Parametros Bimestrales<i class="ml-1"></i></button>
                                </div>
                                <%--<div class="col">
                                    <button id="btngeneraAdeudoanual" class="btn btn-brown btn-sm" data-toggle="modal">Generar Adeudo Anual<i class="ml-1"></i></button>
                                </div>--%>
                                <div class="col" id="annocalculobimestrales">
                                    <label>Parametros bimestrales para el cálculo de recargos de </label>
                                    <select class="form-control" id="cmbannocalculorecargos"></select>
                                </div>
                                <div class="col" id="recargo">
                                    <label>Recargo %</label>
                                    <input class="form-control" type="text" id="txtrecargoprocesos" />
                                </div>
                                <div class="col" id="calcularecargo">
                                    <button id="btncalcularecargo" class="btn btn-success btn-sm" data-toggle="modal">Calcular<i class="fas fa-calculator ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- calculo de recargos procesos --%>
                        <div class="modal fade" id="ModalCalculoRecargos" tabindex="-1" role="dialog" aria-labelledby="ModalCalculoRecargos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Calculo de Recargas</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listarecargosprocesos" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">BIMESTRES</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino calculo recargo procesos --%>
                        <%-- TERMINA CALCULO DE RECARGOS --%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--cONDONACION DE ADEUDO--%>
                        <div id="MenuCondonacionesAdeudo" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncondonacioncuentapredial" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncondonacionclavecatastra" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncondonacionespropietario" class="btn btn-brown btn-sm" data-toggle="modal">Nombre<i class="ml-1"></i></button>
                                </div>
                            </div>
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col" id="cuentarecargos">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialrecargos" />
                                </div>
                                <div class="col" id="claverecargos">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecatastralrecargos" />
                                </div>
                                <div class="col" id="nombrerecargos">
                                    <div class="text-center form-row mb-4 margenboton">
                                        <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                            <label class="contenedor">
                                                Persona Física
                                            <input type="radio" name="accioncondonaciones" value="F" />
                                                <span class="marcado"></span>
                                            </label>
                                            <label style="margin-left: 40px;"></label>
                                            <label class="contenedor">
                                                Persona Moral
                                            <input type="radio" name="accioncondonaciones" value="M" />
                                                <span class="marcado"></span>
                                            </label>
                                        </div>

                                        <div id="pfisicacondonaciones" class="form-group col">
                                            <label>Nombre</label>
                                            <input class="form-control" type="text" id="txtnombrecondonacionesprocesos" />
                                        </div>

                                        <div id="pmoralcondonaciones" class="form-group col">
                                            <label>Razon Social</label>
                                            <input class="form-control" type="text" id="txtrazonsocialcondonacionesprocesos" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col" id="buscarecargos">
                                    <button id="btnbuscarecargosprocesos" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%--    condonacion de adeudo procesos --%>
                        <div class="modal fade" id="ModalCondonacionesrecargos" tabindex="-1" role="dialog" aria-labelledby="ModalCondonacionesrecargos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Condonaciones</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacondonacionesrecargo" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO ORIGINAL</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL ADEUDO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL RECARGO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN A LA MULTA</th>
                                                        <th class="th-sm negritas">B1</th>
                                                        <th class="th-sm negritas">B2</th>
                                                        <th class="th-sm negritas">B3</th>
                                                        <th class="th-sm negritas">B4</th>
                                                        <th class="th-sm negritas">B5</th>
                                                        <th class="th-sm negritas">B6</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btncalculoindividual" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Calculo Individual<i class="ml-1"></i></button>
                                        <button id="btncalculogeneral" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Calculo General<i class="ml-1"></i></button>
                                        <button id="btncalculoautomatico" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Calculo Automatico<i class="ml-1"></i></button>
                                        <button id="btnaplicar" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Aplicar<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino condonacion de adeudo procesos --%>
                        <%-- TERMINACion DE CONDONACION DE ADEUDO --%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--CONDONACIONES AVALUOS--%>
                        <div id="MenuCondonacionesAvaluo" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncondonacionavaluocuentapredial" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncondonacionAvaluoclavecatastra" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentacondonacionesavaluo">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialavaluosrecargos" />
                                </div>
                                <div class="col" id="clavecondonacionesavaluo">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecatastralavaluoprocesos" />
                                </div>
                                <div class="col" id="buscarcondonacionesavaluos">
                                    <button id="btnbuscarecargosavaluosprocesos" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- condonaciones de avaluos procesos --%>
                        <div class="modal fade" id="ModalCondonacionesAvaluosrecargos" tabindex="-1" role="dialog" aria-labelledby="ModalCondonacionesAvaluosrecargos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Condonaciones Avaluos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacondonacionesavaluos" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">COSTO</th>
                                                        <th class="th-sm negritas">CONDONACIONES DEL AVALUOS</th>
                                                        <th class="th-sm negritas">PROPIETARIO</th>
                                                        <th class="th-sm negritas">DIRECCIÓN</th>
                                                        <th class="th-sm negritas">COMUNIDAD</th>
                                                        <th class="th-sm negritas">VALOR CATASTRAL</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>


                                    <div class="text-center">
                                        <button id="btncondonacionesavaluosaplicar" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Aplicar Cambios<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino calculo condonaciones avaluos --%>
                        <%-- TERMINA CONDONACIONES AVALUOS --%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--DESCUENTOS PROCESOS--%>
                        <div id="MenuDocumentosProcesos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <label>Parametros para los descuentos de</label>
                                    <select class="form-control" id="cmbparametrosdoscuentosanno"></select>
                                </div>
                                <div class="col">
                                    <button id="btnbuscarparametrosdescuentos" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- descuentos procesos --%>
                        <div class="modal fade" id="ModalDescuentosProcesos" tabindex="-1" role="dialog" aria-labelledby="ModalDescuentosProcesos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Descuentos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="text-center form-row mb-4 margenboton">
                                        <div class="modal-body mx-12">
                                            <div class="form-row col">
                                                <table id="listadescuentotabla1" class="table table-bordered table-responsive-md table-striped text-center">
                                                    <thead>
                                                        <tr>
                                                            <th class="th-sm negritas">CONCEPTO DE DESCUENTO</th>
                                                            <th class="th-sm negritas">PORCENTAJE</th>
                                                            <th class="th-sm negritas">ACTIVO</th>
                                                        </tr>
                                                    </thead>
                                                </table>
                                            </div>

                                            <div class="text-center">
                                                <button id="btncalculosiguienteanoo" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Calculo Siguiente Año<i class="ml-1"></i></button>
                                                <button id="btnnuevo" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Nuevo<i class="ml-1"></i></button>
                                                <button id="btnguardar" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Guardar<i class="ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div class="modal-body mx-12">
                                            <div class="form-row col">
                                                <table id="listacatalogodescuento" class="table table-bordered table-responsive-md table-striped text-center">
                                                    <thead>
                                                        <tr>
                                                            <th class="th-sm negritas">MES</th>
                                                        </tr>
                                                    </thead>
                                                </table>
                                            </div>

                                            <div class="text-center">
                                                <button id="btnagregardocumento" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Agregar Documento<i class="ml-1"></i></button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino desceuntos procesos --%>
                        <%-- TERMINA DESCUENTOS PROCESOS --%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--CANCELACION DE PAGOS PROCESOS--%>
                        <div id="MenuCancelacionPago" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <label>Folio</label>
                                    <input class="form-control" type="text" id="txtfoliocancelacionpagoproceso" />
                                </div>
                                <div class="col">
                                    <button id="btnbuscarfoliocancelacionpago" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- Cancelacion de pagos --%>
                        <div class="modal fade" id="Modalcancelaciopagosprocesos" tabindex="-1" role="dialog" aria-labelledby="Modalcancelaciopagosprocesos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Cancelación de Pagos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Clave Predial</label>
                                                <input class="form-control" type="text" id="txtclavepredialcancelacionpago" readonly="true" />
                                            </div>
                                            <div class="col">
                                                <label>Solicitante</label>
                                                <input class="form-control" type="text" id="txtsolicitantecancelacionpago" readonly="true" />
                                            </div>
                                            <div class="col">
                                                <label>Usuario que cobro</label>
                                                <input class="form-control" type="text" id="txtusuariocobro" readonly="true" />
                                            </div>
                                            <div class="col">
                                                <label>Folio de la operacion</label>
                                                <input class="form-control" type="text" id="txtfoliodelaoperacion" readonly="true" />
                                            </div>
                                            <div class="col">
                                                <label>Fecha de Pago</label>
                                                <input class="form-control" type="text" id="txtfechadepagoproceso" readonly="true" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Motivo de Cancelacion</label>
                                                <input class="form-control" type="text" id="txtcancelacionpago" />
                                            </div>
                                        </div>

                                        <div class="form-row">
                                            <table id="listacancelacionpago" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">BIMESTRE PAGADOS</th>
                                                        <th class="th-sm negritas">BIMESTRE 1</th>
                                                        <th class="th-sm negritas">BIMESTRE 2</th>
                                                        <th class="th-sm negritas">BIMESTRE 3</th>
                                                        <th class="th-sm negritas">BIMESTRE 4</th>
                                                        <th class="th-sm negritas">BIMESTRE 5</th>
                                                        <th class="th-sm negritas">BIMESTRE 6</th>
                                                        <th class="th-sm negritas">CANCELACIÓN</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina Cancelacion de pagos --%>
                        <%--TERMINA CANCELACION DE PAGOS PROCESOS--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--APLICACION DE MULTAS PROCESOS--%>
                        <div id="ManuAplicaciondeMultas" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnaplicacionmultascuentapredial" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnaplicacionmultasclavepredia" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentaaplicaiconmulta">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialaplicacionmulta" />
                                </div>
                                <div class="col" id="claveaplicacionmulta">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecatastralaplicacionmulta" />
                                </div>
                                <div class="col" id="buscaraplicacionmulta">
                                    <button id="btnbuscaaplicacionmultaprocesos" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>


                        <%-- Aplicacion de multas --%>
                        <div class="modal fade" id="ModalAplicacionmultas" tabindex="-1" role="dialog" aria-labelledby="ModalAplicacionmultas" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Aplicación de Multas</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listaaplicacionmultas" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL ADEUDO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL RECARGO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN A LA MULTA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnaplicarcambiosmultas" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Aplicar Cambios<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina aplicacion de multa--%>
                        <%--TERMINA APLICACION DE MULTAS PROCESOS--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--CAMBIO DE ADEUDOS PROCESOS--%>
                        <div id="ManuCambioAdeudo" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncambioadeudocuentapredial" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncambioadeudoclavepredia" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentacambioadeudo">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialcambioadeudo" />
                                </div>
                                <div class="col" id="clavecambioadeudo">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecatastralcambioadeudo" />
                                </div>
                                <div class="col" id="buscarcambioadeudo">
                                    <button id="btnbuscacambioadeudoprocesos" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>


                        <%-- cambio de adeudos --%>
                        <div class="modal fade" id="Modalcambiodeadeudos" tabindex="-1" role="dialog" aria-labelledby="Modalcambiodeadeudos" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Cambio de Adeudos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacambiodeadeudos" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL ADEUDO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN AL RECARGO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN A LA MULTA</th>
                                                        <th class="th-sm negritas">B1</th>
                                                        <th class="th-sm negritas">B2</th>
                                                        <th class="th-sm negritas">B3</th>
                                                        <th class="th-sm negritas">B4</th>
                                                        <th class="th-sm negritas">B5</th>
                                                        <th class="th-sm negritas">B6</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnadeudonuevo" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Adeudo nuevo<i class="ml-1"></i></button>
                                        <button id="btnaplicarcambios" class="btn btn-purple btn-sm" data-toggle="modal" disabled="disabled">Aplicar Cambios<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina cambio de adeudos--%>
                        <%--TERMINA CAMBIO DE ADEUDOS PROCESOS--%>
                    </div>
                    <%-- TERMINA PROCESOS--%>
                </div>
                <%--TERMINA MENU DE INFORMACION --%>



                <%-- ----------------------------------------------------------------------------------------------------- --%>
                <%-- MENU DE MATENIMIENTO --%>
                <div>
                    <%--Informacion Mantenimiento --%>
                    <div>
                        <%-- ************************************************************************************************************************************* --%>
                        <%--CONTRIBUYENTE MANTENIMIENTO --%>
                        <div id="Manucontribuyentesmante" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncuentacontribuyentemante" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncatastralcontribuyenmante" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentacontribuyenteman">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentacontrimante" />
                                </div>
                                <div class="col" id="clavecuentacontri">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecontrimante" />
                                </div>
                                <div class="col" id="buscarcontrimante">
                                    <button id="btnbuscacontrimante" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- contribuyente --%>
                        <div class="modal fade" id="Modalcontribuyentemantenimiento" tabindex="-1" role="dialog" aria-labelledby="Modalcontribuyentemantenimiento" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Cambio de Adeudos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">

                                        <div class="form-row">
                                            <table id="listapropietario" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE PROPIETARIO</th>
                                                        <th class="th-sm negritas">AGREGAR PROPIETARIO</th>
                                                        <th class="th-sm negritas">EDITAR PROPIETARIO</th>
                                                        <th class="th-sm negritas">ELIMINAR PROPIETARIO</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btn" class="btn btn-purple btn-sm" data-toggle="modal">Solo para mostrar formulario de edicion <i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="ModalEdicionContribuyente" tabindex="-1" role="dialog" aria-labelledby="ModalEdicionContribuyente" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información del Contribuyente</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                                <label class="contenedor">
                                                    Persona Física
                                            <input type="radio" name="accioncontribuyentes" value="F" />
                                                    <span class="marcado"></span>
                                                </label>
                                                <label style="margin-left: 40px;"></label>
                                                <label class="contenedor">
                                                    Persona Moral
                                            <input type="radio" name="accioncontribuyentes" value="M" />
                                                    <span class="marcado"></span>
                                                </label>
                                            </div>
                                        </div>

                                        <div class="text-center form-row mb-4">
                                            <div id="pfisicacontribuyentes" class="form-group col">
                                                <label>Nombre</label>
                                                <input class="form-control" type="text" id="txtnombrecontribuyentesmanteni" />
                                            </div>
                                            <div id="sexocontribuyente" class="form-group col">
                                                <label>Sexo</label>
                                                <select class="form-control" id="cmbsexocontribuyente">
                                                    <option value="1">Seleccionar. . .</option>
                                                    <option value="2">Masculino</option>
                                                    <option value="3">Femenino</option>
                                                </select>
                                            </div>
                                            <div id="pmoralcontribuyentes" class="form-group col">
                                                <label>Razon Social</label>
                                                <input class="form-control" type="text" id="txtrazoncontribuyentesmante" />
                                            </div>
                                            <div class="form-group col">
                                                <label>RFC</label>
                                                <input class="form-control" type="text" id="txtrfccontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>CURP</label>
                                                <input class="form-control" type="text" id="txtcurpcontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Telefono Movil</label>
                                                <input class="form-control" type="text" id="txttelefonocontribuyente" />
                                            </div>
                                        </div>

                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Tipo de Propietario</label>
                                                <select class="form-control" id="cmbtipopropietaqriocontribuyente"></select>
                                            </div>
                                            <div class="form-group col">
                                                <label>Persona Vulnerable</label>
                                                <select class="form-control" id="cmbpersonavulnerablecontribuyente"></select>
                                            </div>
                                            <div class="form-group col">
                                                <label>Telefono fijo</label>
                                                <input class="form-control" type="text" id="txttelefonofijocontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Direccion de Notificación</label>
                                                <input class="form-control" type="text" id="txtdireccionnotificontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Colonia</label>
                                                <select class="form-control" id="cmbcoloniacontribuyente"></select>
                                            </div>
                                        </div>

                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Propiedad %</label>
                                                <input class="form-control" type="text" id="txtpropiedadporcentajecontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Usufructo %</label>
                                                <input class="form-control" type="text" id="txtusufructoporcentajecontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Nuda %</label>
                                                <input class="form-control" type="text" id="txtnudaporcentajecontribuyente" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Total</label>
                                                <input class="form-control" type="text" id="txttotalcontribuyente" readonly="true" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnguardarcontribuyente" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina contribuyente--%>
                        <%--TERMINA CONTRIBUYENTE MANTENIMIENTO--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--PREDIO MANTENIMIENTO --%>
                        <div id="ManupPrediomante" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncuentapredioemante" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncatastralprediomante" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentapredioman">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentaprediomante" />
                                </div>
                                <div class="col" id="clavecuentapredio">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclaveprediomante" />
                                </div>
                                <div class="col" id="buscarcprediomante">
                                    <button id="btnbuscaprediomante" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- predio --%>
                        <div class="modal fade" id="ModalPrediomantenimiento" tabindex="-1" role="dialog" aria-labelledby="ModalPrediomantenimiento" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información del Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>CLAVE PREDIAL</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Clave</label>
                                                <input class="form-control" type="text" id="txtclavepredioedmante" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número de Cuenta</label>
                                                <input class="form-control" type="text" id="txtnumerocuentaedpredio" />
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>CUENTA CATASTRAL</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Municipio</label>
                                                <input class="form-control" type="text" id="txtmunicipiopredio" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Zona</label>
                                                <input class="form-control" type="text" id="txtzonapredio" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Manzana</label>
                                                <input class="form-control" type="text" id="tztmanzanapredio" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Predio</label>
                                                <input class="form-control" type="text" id="txtprediopredio" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Edificio</label>
                                                <input class="form-control" type="text" id="txtedificiopredio" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Condominio</label>
                                                <input class="form-control" type="text" id="txtcondominiopredio" />
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>DIRECCIÓN</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Calle</label>
                                                <input class="form-control" type="text" id="txtcallepredioman" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número exterior</label>
                                                <input class="form-control" type="text" id="txtexteriorprediomante" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número interior</label>
                                                <input class="form-control" type="text" id="txtinteriorpredioman" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Rancho</label>
                                                <select class="form-control" id="cmbranchoprediomant"></select>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>CP</label>
                                                <input class="form-control" type="text" id="txtcppredioman" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Fecha de alta</label>
                                                <input class="form-control" type="text" id="txtfechaprediomant" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Ubicación</label>
                                                <input class="form-control" type="text" id="txtubicacionpredioman" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Tipo de Vialidad</label>
                                                <select class="form-control" id="cmbtipovialidadmante"></select>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnguardarprediomante" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina predio--%>
                        <%--TERMINA PREDIO MANTENIMIENTO--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--PARCELA MANTENIMIENTO --%>
                        <div id="Manupinfoparcelasmante" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncuentaparcelasmante" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncatastralparcelasmante" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentaparcelasoman">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentaparcelasmante" />
                                </div>
                                <div class="col" id="clavecuentaparcelas">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclaveparcelasmante" />
                                </div>
                                <div class="col" id="buscarparcelasmante">
                                    <button id="btnbuscaparcelasmante" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- parcela --%>
                        <div class="modal fade" id="Modalparcelamantenimiento" tabindex="-1" role="dialog" aria-labelledby="Modalparcelamantenimiento" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información de Parcelas</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>INFORMACIÓN DEL PREDIO</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Calle</label>
                                                <input class="form-control" type="text" id="txtcalleparcelaman" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número exterior</label>
                                                <input class="form-control" type="text" id="txtexteriorparcelamante" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número interior</label>
                                                <input class="form-control" type="text" id="txtinteriorparcelaman" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Colonia</label>
                                                <input class="form-control" type="text" id="txtcoloniaparcelaman" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>CP</label>
                                                <input class="form-control" type="text" id="txtcpparcelaman" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Fecha de alta</label>
                                                <input class="form-control" type="text" id="txtfechaparcelamant" readonly="true" />
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>INFORMACIÓN DE LA MANZANA</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Lote</label>
                                                <input class="form-control" type="text" id="txtloteparcela" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Manzana</label>
                                                <input class="form-control" type="text" id="tztmanzanaparcela" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Zona</label>
                                                <input class="form-control" type="text" id="txtzonaparcela" />
                                            </div>

                                            <div class="form-group col">
                                                <label>Parcela</label>
                                                <input class="form-control" type="text" id="txtparcelaparcela" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnguardarparcelamante" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina parcela--%>
                        <%--TERMINA PARCELA MANTENIMIENTO--%>




                        <%-- ************************************************************************************************************************************* --%>
                        <%--CAMBIO DE CUENTA MANTENIMIENTO --%>
                        <div id="Manucambiocuentamante" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btncuentacambiocuentamante" class="btn btn-brown btn-sm" data-toggle="modal">Cuenta Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btncatastralcambiocuentamante" class="btn btn-brown btn-sm" data-toggle="modal">Clave Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentacambiocuentaman">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentacambiocuentamante" />
                                </div>
                                <div class="col" id="clavecuentacambiocuenta">
                                    <label>Clave Catastral</label>
                                    <input class="form-control" type="text" id="txtclavecambiocuentamante" />
                                </div>
                                <div class="col" id="buscarcambiocuentamante">
                                    <button id="btnbuscacambiocuentamante" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- cambio de cuenta --%>
                        <div class="modal fade" id="Modalcambiocuentamante" tabindex="-1" role="dialog" aria-labelledby="Modalcambiocuentamante" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Cambio De Cuenta</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>INFORMACIÓN DEL PREDIO</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Fecha de alta</label>
                                                <input class="form-control" type="text" id="txtfechacambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Dirección del predio</label>
                                                <input class="form-control" type="text" id="txtcallecambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Número ext/int</label>
                                                <input class="form-control" type="text" id="txtexteintcambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Colonia</label>
                                                <input class="form-control" type="text" id="txtcoloniacambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>CP</label>
                                                <input class="form-control" type="text" id="txtcpcambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Ubicación</label>
                                                <input class="form-control" type="text" id="txtubicacioncambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Tipo de Vialidad</label>
                                                <input class="form-control" type="text" id="txttipodevialidadcambiocuenta" readonly="true" />
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>INFORMACIÓN CONTRIBUYENTE</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Nombre</label>
                                                <input class="form-control" type="text" id="txtnombrecambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>A. Paterno</label>
                                                <input class="form-control" type="text" id="txtpaternocambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>A. Materno</label>
                                                <input class="form-control" type="text" id="txtmaternocacmbiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Dirección de Notificación</label>
                                                <input class="form-control" type="text" id="txtdirecnpotificacambiocuenta" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Tipo de Propietario</label>
                                                <input class="form-control" type="text" id="txttipopropietariocambiocuenta" readonly="true" />
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>CLAVES DISPONIBLES</label>
                                            </div>
                                        </div>
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Rango</label>
                                                <div class="form-row">
                                                    <div class="col">
                                                        <input class="form-control" type="text" id="txtrango1cambio" />
                                                    </div>
                                                    <div class="col">
                                                        <input class="form-control" type="text" id="txtrango2cambio" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group col">
                                                <label>Clave</label>
                                                <select class="form-control" id="cmbclavecambiocuenta"></select>
                                            </div>
                                            <div class="form-group col">
                                                <label>Cuenta</label>
                                                <select class="form-control" id="cmbcuentacambiocuenta"></select>
                                            </div>
                                            <div class="form-group col">
                                                <label>Base Gravable</label>
                                                <input class="form-control" type="text" id="txtbasegravablecambiocuenta" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnhacercambiocambiocuenta" class="btn btn-purple btn-sm" data-toggle="modal">Hacer Cambio<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina cambio de cuenta--%>
                        <%--TERMINA CAMBIO DE CUENTA MANTENIMIENTO--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--COSTO DE DOCUMENTOS MANTENIMIENTO --%>
                        <div id="Manucostodocumentos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnconstanciasmantenimiento" class="btn btn-brown btn-sm" data-toggle="modal">Constancia<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnimprecionmapamantenimiento" class="btn btn-brown btn-sm" data-toggle="modal">Impreción de Mapa<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnpagosdiversos" class="btn btn-brown btn-sm" data-toggle="modal">Pagos Diversos<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnparametrosavaluos" class="btn btn-brown btn-sm" data-toggle="modal">Parametros de Avaluos<i class="ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- costo documento --%>
                        <%-- constancia --%>
                        <div class="modal fade" id="ModalContanciasMantenimiento" tabindex="-1" role="dialog" aria-labelledby="ModalContanciasMantenimiento" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Constancias</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listaconstancias" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE</th>
                                                        <th class="th-sm negritas">COSTO</th>
                                                        <th class="th-sm negritas">DESCRIPCIÓN</th>
                                                        <th class="th-sm negritas">FECHA ALTA</th>
                                                        <th class="th-sm negritas">FECHA MODIFICACIÓN</th>
                                                        <th class="th-sm negritas">MODIFICAR</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnnuevacontancia" class="btn btn-purple btn-sm" data-toggle="modal">Nuevo<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="ModalNuevaconstancia" tabindex="-1" role="dialog" aria-labelledby="ModalNuevaconstancia" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Constancia</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Nombre</label>
                                                <input class="form-control" type="text" id="txtnombreconstancia" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Descripción</label>
                                                <input class="form-control" type="text" id="txtdescripcionconstancia" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Costo</label>
                                                <input class="form-control" type="text" id="txtcostoconstancia" readonly="true" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnguardarmodificacionconstancia" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- termina constancia --%>


                        <%-- imprecion de mapa --%>
                        <div class="modal fade" id="Modalimpreciondemapa" tabindex="-1" role="dialog" aria-labelledby="Modalimpreciondemapa" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Impreción de Mapa</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- termina imprecion de mapa --%>



                        <%-- pagos diversos--%>
                        <div class="modal fade" id="ModaPagosdiversos" tabindex="-1" role="dialog" aria-labelledby="ModaPagosdiversos" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Pagos Diversos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- termina pagos diversos --%>



                        <%-- Parametros de avaluos--%>
                        <div class="modal fade" id="ModaParametrosavaluos" tabindex="-1" role="dialog" aria-labelledby="ModaParametrosavaluos" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Parametros de Avaluos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- termina imprecion de mapa --%>
                        <%-- Termina Costo documento--%>
                        <%--TERMINA CAMBIO DE CUENTA MANTENIMIENTO--%>





                        <%-- ************************************************************************************************************************************* --%>
                        <%--PAGO MINIMO MANTENIMIENTO --%>
                        <div id="Manupagominimomante" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnpagominimo" class="btn btn-brown btn-sm" data-toggle="modal">Pago Mínimo<i class="ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- pago minimo --%>
                        <div class="modal fade" id="ModalPagominimo" tabindex="-1" role="dialog" aria-labelledby="ModalPagominimo" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Pago Mínimo</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listapagominimo" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">VALOR</th>
                                                        <th class="th-sm negritas">DESCRIPCIÓN</th>
                                                        <th class="th-sm negritas">FECHA ALTA</th>
                                                        <th class="th-sm negritas">FECHA MODIFICACIÓN</th>
                                                        <th class="th-sm negritas">MODIFICAR</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnnuevopagominimo" class="btn btn-purple btn-sm" data-toggle="modal">Nuevo<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="ModalNuevopagominimo" tabindex="-1" role="dialog" aria-labelledby="ModalNuevopagominimo" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Pago Mínimo</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <label>Año</label>
                                                <input class="form-control" type="text" id="txtannopagominimo" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Descripción</label>
                                                <input class="form-control" type="text" id="txtdescripcionpagominimo" readonly="true" />
                                            </div>
                                            <div class="form-group col">
                                                <label>Valor</label>
                                                <input class="form-control" type="text" id="txtvalorpagominimo" readonly="true" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnguardarpagominimo" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <%-- Termina pago minimo--%>
                        <%--TERMINA PAGO MINIMO MANTENIMIENTO--%>

                        <%-- ******************************************************************** --%>
                    </div>
                    <%-- Termina Informacion Mantenimiento --%>



                    <%--Informacion Sistemas --%>
                    <div>
                        <%-- ************************************************************************************************************************************* --%>
                        <%--PREDIO NUEVO SISTEMA --%>
                        <div id="MenuPrediosNuevos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnprediossinclavepredial" class="btn btn-brown btn-sm" data-toggle="modal">Predios sin clave predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnprediosinpropietarios" class="btn btn-brown btn-sm" data-toggle="modal">Predios sin propietarios<i class="ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- predio nuevo --%>
                        <div class="modal fade" id="Modalprediossinclavepredial" tabindex="-1" role="dialog" aria-labelledby="Modalprediossinclavepredial" aria-hidden="true" style="overflow-x: scroll;">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Predios sin clave predial</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">

                                        <div class="form-row">
                                            <table id="listacuentacatastral" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas">DETALLE</th>
                                                        <th class="th-sm negritas">ELIMINAR DATOS</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnver" class="btn btn-purple btn-sm" data-toggle="modal">solo es para ver el formulario que se abrira al precionar detalle<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="Modalnuevoprediosinclavepredial" tabindex="-1" role="dialog" aria-labelledby="Modalnuevoprediosinclavepredial" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información del Contribuyente</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="text-center form-row mb-4">
                                        <div class="form-group col">
                                            <div class="modal-body mx-12">
                                                <div class="form-row">
                                                    <table id="listapropietarionuevoprediosinclavepredial" class="table table-bordered table-responsive-md table-striped text-center">
                                                        <thead>
                                                            <tr>
                                                                <th class="th-sm negritas">NOMBRE PROPIETARIO</th>
                                                                <th class="th-sm negritas">EDITAR PROPIETARIO</th>
                                                                <th class="th-sm negritas">ELIMINAR PROPIETARIO</th>
                                                            </tr>
                                                        </thead>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group col">
                                            <div class="modal-body mx-12">
                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Fecha de alta</label>
                                                        <input class="form-control" type="text" id="txtfechaaltasinclavepredial" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Dirección del predio</label>
                                                        <input class="form-control" type="text" id="txtdireccionprediosinclavepredial" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Número ext/int</label>
                                                        <input class="form-control" type="text" id="txtextintsinclavepredial" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Colonia</label>
                                                        <input class="form-control" type="text" id="txtcoloniasinclavepredial" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>CP</label>
                                                        <input class="form-control" type="text" id="txtcpsinclavepredial" readonly="true" />
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>CLAVE PREDIAL</label>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="col">
                                                        <div class="text-center form-row mb-4">
                                                            <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                                                <label class="contenedor">
                                                                    Asignada
                                                                    <input type="radio" name="accionclavepredial" value="A" />
                                                                    <span class="marcado"></span>
                                                                </label>
                                                                <label style="margin-left: 40px;"></label>
                                                                <label class="contenedor">
                                                                    Disponible
                                                                    <input type="radio" name="accionclavepredial" value="D" />
                                                                    <span class="marcado"></span>
                                                                </label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Clave</label>
                                                        <select class="form-control" id="cmbclabeprediosnuevos"></select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Cuenta</label>
                                                        <input class="form-control" type="text" id="txtcuentanuevospredios" />
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>GENERAR ADEUDO PARA</label>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>
                                                            <input type="checkbox" id="checkpredionuevo" />
                                                            Predio Nuevo
                                                        </label>
                                                        <label>(se genera año actual y 5 años atras)</label>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Año</label>
                                                        <select class="form-control" id="cmbañopredionuevo"></select>
                                                        <label>(se genera apartir de este año)</label>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>
                                                            <input type="checkbox" id="checkhipotecapredionuevo" />
                                                            Hipoteca
                                                        </label>
                                                        <input class="form-control" type="text" id="txthipotecapredionuevo" />
                                                        <label>(el primer año tendra valor de hipoteca)</label>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>INFORMACIÓN DEL PREDIO</label>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Nombre</label>
                                                        <input class="form-control" type="text" id="txtnombrepredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Sexo</label>
                                                        <select class="form-control" id="cmbsexopredionuevosinclavepredial">
                                                            <option value="1">Seleccionar. . .</option>
                                                            <option value="2">Masculino</option>
                                                            <option value="3">Femenino</option>
                                                        </select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>RFC</label>
                                                        <input class="form-control" type="text" id="txtrfcpredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>CURP</label>
                                                        <input class="form-control" type="text" id="txtcurppredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Telefono Movil</label>
                                                        <input class="form-control" type="text" id="txttelefonomovilpredionuevosinclavepredial" />
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Tipo de Propietario</label>
                                                        <select class="form-control" id="cmbtipopropietariopredionuevosinclavepredial"></select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Persona Vulnerable</label>
                                                        <select class="form-control" id="cmbpersonavulnerablepredionuevosinclavepredial"></select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Telefono fijo</label>
                                                        <input class="form-control" type="text" id="txttelefonofijopredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Direccion de Notificación</label>
                                                        <input class="form-control" type="text" id="txtdireccionnotificacionespredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Colonia</label>
                                                        <select class="form-control" id="cmbcoloniapredionuevosinclavepredial"></select>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Propiedad %</label>
                                                        <input class="form-control" type="text" id="txtpropiedadpredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Usufructo %</label>
                                                        <input class="form-control" type="text" id="txtusufructopredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Nuda %</label>
                                                        <input class="form-control" type="text" id="txtnudapredionuevosinclavepredial" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Total</label>
                                                        <input class="form-control" type="text" id="txttotalpredionuevosinclavepredial" readonly="true" />
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="text-center">
                                                <button id="btnguardarpropietariopredionuevosinclavepredial" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="Modalprediossinpropietarios" tabindex="-1" role="dialog" aria-labelledby="Modalprediossinpropietarios" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Predios sin propietarios</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">

                                        <div class="form-row">
                                            <table id="listaprediosinpropietario" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">CLAVE</th>
                                                        <th class="th-sm negritas">NÚMERO DE CUENA</th>
                                                        <th class="th-sm negritas">DETALLE</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btndetalle" class="btn btn-purple btn-sm" data-toggle="modal">solo es para ver el formulario que se abrira al precionar detalle<i class="ml-1"></i></button>
                                    </div>

                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="Modalnuevoprediocontribuyente" tabindex="-1" role="dialog" aria-labelledby="Modalnuevoprediocontribuyente" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información del Contribuyente</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="text-center form-row mb-4">
                                        <div class="form-group col">
                                            <div class="modal-body mx-12">
                                                <div class="form-row">
                                                    <table id="listapropietarionuevopredio" class="table table-bordered table-responsive-md table-striped text-center">
                                                        <thead>
                                                            <tr>
                                                                <th class="th-sm negritas">NOMBRE PROPIETARIO</th>
                                                                <th class="th-sm negritas">EDITAR PROPIETARIO</th>
                                                                <th class="th-sm negritas">ELIMINAR PROPIETARIO</th>
                                                            </tr>
                                                        </thead>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group col">
                                            <div class="modal-body mx-12">
                                                <div class="text-center form-row mb-4 margenboton">
                                                    <div class="form-group col">
                                                        <label>INFORMACIÓN DEL PREDIO</label>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Fecha de alta</label>
                                                        <input class="form-control" type="text" id="txtfechaaltasinpropietario" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Dirección del predio</label>
                                                        <input class="form-control" type="text" id="txtdireccionprediosinpropietario" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Número ext/int</label>
                                                        <input class="form-control" type="text" id="txtextintsinpropietario" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Colonia</label>
                                                        <input class="form-control" type="text" id="txtcoloniasinpropietario" readonly="true" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>CP</label>
                                                        <input class="form-control" type="text" id="txtcpsinpropietario" readonly="true" />
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Nombre</label>
                                                        <input class="form-control" type="text" id="txtnombrepredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Sexo</label>
                                                        <select class="form-control" id="cmbsexopredionuevo">
                                                            <option value="1">Seleccionar. . .</option>
                                                            <option value="2">Masculino</option>
                                                            <option value="3">Femenino</option>
                                                        </select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>RFC</label>
                                                        <input class="form-control" type="text" id="txtrfcpredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>CURP</label>
                                                        <input class="form-control" type="text" id="txtcurppredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Telefono Movil</label>
                                                        <input class="form-control" type="text" id="txttelefonomovilpredionuevo" />
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Tipo de Propietario</label>
                                                        <select class="form-control" id="cmbtipopropietariopredionuevo"></select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Persona Vulnerable</label>
                                                        <select class="form-control" id="cmbpersonavulnerablepredionuevo"></select>
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Telefono fijo</label>
                                                        <input class="form-control" type="text" id="txttelefonofijopredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Direccion de Notificación</label>
                                                        <input class="form-control" type="text" id="txtdireccionnotificacionespredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Colonia</label>
                                                        <select class="form-control" id="cmbcoloniapredionuevo"></select>
                                                    </div>
                                                </div>

                                                <div class="text-center form-row mb-4">
                                                    <div class="form-group col">
                                                        <label>Propiedad %</label>
                                                        <input class="form-control" type="text" id="txtpropiedadpredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Usufructo %</label>
                                                        <input class="form-control" type="text" id="txtusufructopredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Nuda %</label>
                                                        <input class="form-control" type="text" id="txtnudapredionuevo" />
                                                    </div>
                                                    <div class="form-group col">
                                                        <label>Total</label>
                                                        <input class="form-control" type="text" id="txttotalpredionuevo" readonly="true" />
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="text-center">
                                                <button id="btnguardarpropietariopredionuevo" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina predio nuevo--%>
                        <%--TERMINA PREDIO NUEVO SISTEMA--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--NOTAS SISTEMAS --%>
                        <div id="MenuNotasSistemas" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnaltanotasistema" class="btn btn-brown btn-sm" data-toggle="modal">Gestión de notas<i class="ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- notas --%>
                        <div class="modal fade" id="Modalnotaalta" tabindex="-1" role="dialog" aria-labelledby="Modalnotaalta" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Gestión de Nota</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <div class="col">
                                                <div class="text-center form-row mb-4">
                                                    <div class="row col" style="margin-left: 25px; margin-top: 25px;">
                                                        <label class="contenedor">
                                                            Por predio
                                                                    <input type="radio" name="accionbuscanotaalta" value="P" />
                                                            <span class="marcado"></span>
                                                        </label>
                                                        <label style="margin-left: 40px;"></label>
                                                        <label class="contenedor">
                                                            Por Colonia
                                                                    <input type="radio" name="accionbuscanotaalta" value="C" />
                                                            <span class="marcado"></span>
                                                        </label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group col" id="notaaltacuenta">
                                                <label>Cuenta Predial</label>
                                                <input class="form-control" type="text" id="txtcuentrapredialnotasalta" />
                                            </div>
                                            <div class="form-group col" id="notaaltacolonia">
                                                <label>Colonia</label>
                                                <select class="form-control" id="cmbcolonianotasaltas"></select>
                                            </div>
                                            <div class="col" id="buscarnotasaltas">
                                                <button id="btnbuscaaltasnotas" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div id="infonotaalta">
                                            <div class="text-center form-row mb-4">
                                                <div class="form-group col">
                                                    <label>Fecha de alta</label>
                                                    <input class="form-control" type="text" id="txtfechaaltanotaalta" readonly="true" />
                                                </div>
                                                <div class="form-group col">
                                                    <label>Dirección del predio</label>
                                                    <input class="form-control" type="text" id="txtdireccionpredionotaalta" readonly="true" />
                                                </div>
                                                <div class="form-group col">
                                                    <label>Número ext/int</label>
                                                    <input class="form-control" type="text" id="txtextintnotaalta" readonly="true" />
                                                </div>
                                                <div class="form-group col">
                                                    <label>Colonia</label>
                                                    <input class="form-control" type="text" id="txtcolonianotaalta" readonly="true" />
                                                </div>
                                                <div class="form-group col">
                                                    <label>CP</label>
                                                    <input class="form-control" type="text" id="txtcpnotaalta" readonly="true" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="text-center form-row mb-4">
                                            <div class="form-group col">
                                                <div class="modal-body mx-12">
                                                    <div class="form-row">
                                                        <table id="listanotasaltas" class="table table-bordered table-responsive-md table-striped text-center">
                                                            <thead>
                                                                <tr>
                                                                    <th class="th-sm negritas">FECHA</th>
                                                                    <th class="th-sm negritas">NOTA</th>
                                                                    <th class="th-sm negritas">ELIMINAR NOTA</th>
                                                                </tr>
                                                            </thead>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-group col">
                                                <div class="modal-body mx-12">
                                                    <div class="text-center form-row mb-4">
                                                        <div class="form-group col">
                                                            <label>AGREGAR NOTA</label>
                                                        </div>
                                                    </div>

                                                    <div class="text-center form-row mb-4">
                                                        <div class="form-group col">
                                                            <label>Nota</label>
                                                            <textarea id="txtnotaalta" cols="100" rows="10"></textarea>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="text-center">
                                                    <button id="btnguardarnotaalta" disabled="disabled" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>
                        <%-- Termina notas--%>
                        <%--TERMINA NOTAS SISTEMAS--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--CANCELACION DE PREDIOS SISTEMAS --%>
                        <div id="MenuCancelacionPredio" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnbuscacuentapredialcancelacion" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnbuscacuentacatastralcancelacion" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentadapredialcancelacion">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialcancelacion" />
                                </div>
                                <div class="col" id="cuentacatastralcancelacion">
                                    <label>Cuenta Catastral</label>
                                    <input class="form-control" type="text" id="txtcuentacatastralcancelacion" />
                                </div>
                                <div class="col" id="busquedaprediocancelacion">
                                    <button id="btnbuscarprediocancelacion" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>

                            <div id="infocancelacionpredio" class="text-center margenboton">
                                <button id="btninformacionpredialcancelcion" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalInformacionPrediocancelar">Información del Predio<i class="ml-1"></i></button>
                                <button id="btnadeudopredialcancelacion" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalAdeudoPrediocancelar">Adeudo de Predio<i class="ml-1"></i></button>
                                <button id="btnhistorialpagoscancelacion" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalHistorialpagoscancelar">Historial de Pagos<i class="ml-1"></i></button>
                                <button id="btncondonacionesprediocancelacion" type="button" class="btn btn-purple btn-rounded btn-sm" data-toggle="modal" data-target="#ModalCondonacionescancelar">Condonaciones del Predio<i class="ml-1"></i></button>
                            </div>
                        </div>

                        <%-- cancelacion predios --%>
                        <%-- Información predio --%>
                        <div class="modal fade" id="ModalInformacionPrediocancelar" tabindex="-1" role="dialog" aria-labelledby="ModalInformacionPrediocancelar" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Información de Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="text-center form-row mb-4">
                                            <label>INFORMACIÓN DEL PREDIO</label>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Fecha de Alta</label>
                                                <input class="form-control" type="text" id="txtfechadealtaprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Tipo de Vialidad</label>
                                                <input class="form-control" type="text" id="txtvialidadprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Nombre de la vialidad</label>
                                                <input class="form-control" type="text" id="txtnombrevialidadcancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Colonia</label>
                                                <input class="form-control" type="text" id="txtcoloniaprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Ubicación</label>
                                                <input class="form-control" type="text" id="txtubicacionprediocancelar" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Numeros Ext/Int</label>
                                                <input class="form-control" type="text" id="txtnumerospredioscancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Codigo Postal</label>
                                                <input class="form-control" type="text" id="txtcodigopostalprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Lote</label>
                                                <input class="form-control" type="text" id="txtlotecancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Manzana</label>
                                                <input class="form-control" type="text" id="txtmanzanacancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Zona</label>
                                                <input class="form-control" type="text" id="txtzonacancelar" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Parcela</label>
                                                <input class="form-control" type="text" id="txtparcelacancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Área de terreno</label>
                                                <input class="form-control" type="text" id="txtareaterrenocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Sup. construcción</label>
                                                <input class="form-control" type="text" id="txtsuperficieconstruccioncancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Valor Catastral</label>
                                                <input class="form-control" type="text" id="txtvalorcatastralcancelar" />
                                            </div>
                                        </div>
                                        <div class="form-row mb-4">
                                            <label>INFORMACIÓN DEL CONTRIBUYENTE</label>
                                        </div>
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Nombre</label>
                                                <input class="form-control" type="text" id="txtnombreprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>A. Paterno</label>
                                                <input class="form-control" type="text" id="txtapaternoprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>A. Materno</label>
                                                <input class="form-control" type="text" id="txtamaternoprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Dirección de Notificación</label>
                                                <input class="form-control" type="text" id="txtdireccionnotificacionprediocancelar" />
                                            </div>
                                            <div class="col">
                                                <label>Tipo de Propietario</label>
                                                <input class="form-control" type="text" id="txttipopropietarioprediocancelar" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="row" style="margin-left: 25px; margin-top: 25px;">
                                                <label class="contenedor">
                                                    Mapa
                                            <input type="radio" name="accionmapacancelar" value="M" />
                                                    <span class="marcado"></span>
                                                </label>
                                                <label style="margin-left: 40px;"></label>
                                                <label class="contenedor">
                                                    Fachada
                                            <input type="radio" name="accionmapacancelar" value="F" />
                                                    <span class="marcado"></span>
                                                </label>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btncancelarpredio" disabled="disabled" class="btn btn-purple btn-sm" data-toggle="modal">Cancelar Predio<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termino Información Predio --%>

                        <%-- Adeudo del predio --%>
                        <div class="modal fade" id="ModalAdeudoPrediocancelar" tabindex="-1" role="dialog" aria-labelledby="ModalAdeudoPrediocancelar" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Adeudo del Predio</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Años con Adeudos</label>
                                                <select class="form-control" id="cmbanoadeudoprediocancelar"></select>
                                            </div>
                                            <div class="col">
                                                <button id="btnbuscaanoadeudadoprediocancelar" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div class="modal-body mx-12">
                                            <div class="text-center form-row mb-4">
                                                <label>DETALLE DEL AÑO</label>
                                            </div>
                                            <div class="form-row mb-4">
                                                <div class="col">
                                                    <label>Monto del Adeudo</label>
                                                    <input class="form-control" type="text" id="txtmontoadeudoprediocancelar" />
                                                </div>
                                                <div class="col">
                                                    <label>Recargo</label>
                                                    <input class="form-control" type="text" id="txtrecargoprediocancelar" />
                                                </div>
                                                <div class="col">
                                                    <label>Multa</label>
                                                    <input class="form-control" type="text" id="txtmultarecargoprediocancelar" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento del Recargo</label>
                                                    <input class="form-control" type="text" id="txtdescuentorecargoprediocancelar" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento de la Multa</label>
                                                    <input class="form-control" type="text" id="txtdescuentodelamultaprediocancelar" />
                                                </div>
                                                <div class="col">
                                                    <label>Descuento General</label>
                                                    <input class="form-control" type="text" id="txtdescuentogeneralprediocancelar" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="form-row">
                                            <table id="listatotalpagoannoprediocancelar" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">TOTAL</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina Adeudo predio --%>

                        <%-- historial de pago--%>
                        <div class="modal fade" id="ModalHistorialpagoscancelar" tabindex="-1" role="dialog" aria-labelledby="ModalHistorialpagoscancelar" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Historial de Pagos</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Años con Historial</label>
                                                <select class="form-control" id="cmbannohistorialcancelar"></select>
                                            </div>
                                            <div class="col">
                                                <button id="btnbusquedahistorialpagocancelar" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                            </div>
                                        </div>

                                        <div class="modal-body mx-12">
                                            <div class="text-center form-row mb-4">
                                                <label>DETALLE DEL AÑO</label>
                                            </div>
                                        </div>

                                        <div class="form-row">
                                            <table id="listaavaluopredialcancelar" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">AVALUO</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE SOLICITANTE </th>
                                                        <th class="th-sm negritas">MONTO</th>
                                                        <th class="th-sm negritas">FECHA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>

                                        <div class="form-row">
                                            <table id="listapagopredialcancelar" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th colspan="4" class="th-sm negritas">PAGO PREDIAL</th>
                                                    </tr>
                                                    <tr>
                                                        <th class="th-sm negritas">NOMBRE SOLICITANTE </th>
                                                        <th class="th-sm negritas">MONTO</th>
                                                        <th class="th-sm negritas">FECHA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina historial de pago --%>

                        <%-- historial de pago--%>
                        <div class="modal fade" id="ModalCondonacionescancelar" tabindex="-1" role="dialog" aria-labelledby="ModalCondonacionescancelar" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Condonaciones</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listacondonacionesprediocancelar" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">AÑO</th>
                                                        <th class="th-sm negritas">ADEUDO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN ADEUDO</th>
                                                        <th class="th-sm negritas">RECARGO</th>
                                                        <th class="th-sm negritas">CONDONACIÓN DE RECARGO</th>
                                                        <th class="th-sm negritas">MULTA</th>
                                                        <th class="th-sm negritas">CONDONACIÓN DE MULTA</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina historial de pago --%>
                        <%-- Termina cancelacion predios--%>
                        <%--TERMINA CANCELACION DE PREDIOS SISTEMAS--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--AUTORIZACION AVALUOS SISTEMAS --%>
                        <div id="MenuAutorizacionAvaluos" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnactualizarlista" class="btn btn-brown btn-sm" data-toggle="modal">Actualizar Lista<i class="ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- autorizacion de avaluos --%>
                        <div class="modal fade" id="ModalAutorizacionLista" tabindex="-1" role="dialog" aria-labelledby="ModalAutorizacionLista" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Avaluos Pendientes Para Cobro</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row">
                                            <table id="listaactualizarlista" class="table table-bordered table-responsive-md table-striped text-center">
                                                <thead>
                                                    <tr>
                                                        <th class="th-sm negritas">FOLIO DEL TRAMITE</th>
                                                        <th class="th-sm negritas">CLAVE PREDIAL</th>
                                                        <th class="th-sm negritas">CUENTA CATASTRAL</th>
                                                        <th class="th-sm negritas">FECHA DE AVALUO</th>
                                                        <th class="th-sm negritas">PROPIETARIO</th>
                                                        <th class="th-sm negritas">VALOR CATASTRAL</th>
                                                        <th class="th-sm negritas">SUP. TERRENO</th>
                                                        <th class="th-sm negritas">SUP. CONSTRUCCIÓN</th>
                                                        <th class="th-sm negritas">VIGENCIA</th>
                                                        <th class="th-sm negritas">AUTORIZACIÓN</th>
                                                        <th class="th-sm negritas">CANCELAR</th>
                                                    </tr>
                                                </thead>
                                            </table>
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>
                        <%-- Termina autorizacion de avaluos--%>
                        <%--TERMINA AUTORIZACION DE AVALUOS--%>



                        <%-- ************************************************************************************************************************************* --%>
                        <%--AUTORIZACION AVALUOS SISTEMAS --%>
                        <div id="MenuAjustesvalorescatastrales" class="modal-body mx-12">
                            <div class="text-center form-row mb-4 margenboton">
                                <div class="col">
                                    <button id="btnbuscacuentapredialajuste" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Predial<i class="ml-1"></i></button>
                                </div>
                                <div class="col">
                                    <button id="btnbuscacuentacatastralajuste" class="btn btn-brown btn-sm" data-toggle="modal">Consulta por Cta. Catastral<i class="ml-1"></i></button>
                                </div>
                                <div class="col" id="cuentadapredialajuste">
                                    <label>Cuenta Predial</label>
                                    <input class="form-control" type="text" id="txtcuentapredialajuste" />
                                </div>
                                <div class="col" id="cuentacatastralajuste">
                                    <label>Cuenta Catastral</label>
                                    <input class="form-control" type="text" id="txtcuentacatastralajuste" />
                                </div>
                                <div class="col" id="busquedapredioajuste">
                                    <button id="btnbuscarpredioajuste" class="btn btn-default btn-sm" data-toggle="modal">Buscar<i class="fas fa-search ml-1"></i></button>
                                </div>
                            </div>
                        </div>

                        <%-- autorizacion de avaluos --%>
                        <div class="modal fade" id="ModalAjustevalores" tabindex="-1" role="dialog" aria-labelledby="ModalAjustevalores" aria-hidden="true">
                            <div class="modal-dialog modal-fluid" role="document">
                                <div class="modal-content">
                                    <div class="modal-header text-center">
                                        <img src="../Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 7.50%; margin-right: 10px;" />
                                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Ajuste de valores catastrales</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>

                                    <div class="modal-body mx-12">
                                        <div class="form-row mb-4">
                                            <div class="col">
                                                <label>Adeudo</label>
                                                <input class="form-control" type="text" id="txtaddeudoajustes" />
                                            </div>
                                            <div class="col">
                                                <label>Base Gravable</label>
                                                <input class="form-control" type="text" id="txtbasegravableajustes" />
                                            </div>
                                            <div class="col">
                                                <label>Sup. Terreno</label>
                                                <input class="form-control" type="text" id="txtsupterrenoajustes" />
                                            </div>
                                            <div class="col">
                                                <label>Sup. Construcción</label>
                                                <input class="form-control" type="text" id="txtxsuprconstruccionajustes" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="text-center">
                                        <button id="btnajustes" disabled="disabled" class="btn btn-purple btn-sm" data-toggle="modal">Guardar<i class="ml-1"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%-- Termina autorizacion de avaluos--%>
                        <%--TERMINA AUTORIZACION DE AVALUOS--%>
                    </div>
                    <%-- Termina Informacion Sistemas --%>
                </div>
                <%--TERMINA MENU DE MANTENIMIENTO --%>




                <%-- -------------------------------------------------------------------------------------------------------- --%>
                <%-- MENU DE ESTADISTICAS --%>
                <div>
                    <%--Informacion Estadisticas --%>
                    <div></div>
                    <%-- Termina Informacion Estadisticas --%>
                </div>
                <%--TERMINA MENU DE ESTADISTICAS --%>
            </div>
        </div>
    </div>
</body>
</html>
