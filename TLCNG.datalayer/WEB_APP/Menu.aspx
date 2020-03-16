<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WEB_APP.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="Imagenes/Fondo/logo2.png" />

    <%-- Estilos --%>
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <link href="CSS/Menus.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="CSS/bootstrap.css" rel="stylesheet" />
    <link href="CSS/mdb.css" rel="stylesheet" />
    <link href="CSS/EstiloMenu.css" rel="stylesheet" />

    <%-- scripts --%>
    <script src="Script/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.13.0/umd/popper.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
    <script src="Script/mdb.min.js"></script>
    <script src="Script/dropzone.js"></script>
    <script src="http://momentjs.com/downloads/moment.min.js"></script>

    <script src="JS/Menus.js"></script>
    <title>Catastro</title>

</head>
<body>

    <!----------------------------------------------------------------------------------------------------TITULOS--------------------------------------------------------------------------------------------------------->
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ml-auto nav-flex-icons">
                <li class="nav-item item-inactivo">
                    <i class="fa fa-user-circle-o fa-3x nav-link color-fuente-strong" style="text-align: center"></i>
                </li>
                <li class="nav-item item-inactivo">
                    <a id="RolUsuario" class="nav-link color-fuente-strong text" data-toggle="modal"><span class="sr-only"></span></a>
                </li>
                <li class="nav-item item-inactivo">
                    <a id="NombreUsuario" class="nav-link color-fuente-strong text" data-toggle="modal"><span class="sr-only"></span></a>
                </li>
                <li class="nav-item item-inactivo">
                    <button id="cerrarsesion" type="button" class="btn btn-danger btn-rounded btn-sm">Cerrar Sesión<i class="fa fa-power-off ml-2" aria-hidden="true"></i></button>
                </li>
            </ul>
        </div>
    </nav>
    <!---------------------------------------------------------------------------------------------------------------TERMINA TITULOS------------------------------------------------------------------------------->

    <!----------------------------------------------------------------------------------------------------------CONTENEDOR DE INFORMACION----------------------------------------------------------------------------->
    <div class="contenedor">
        <table>
            <tr>
                <td>
                    <div>
                        <img id="btnpredial" src="Imagenes/Menu/Predial.png" title="PREDIAL" width="140" height="140" />
                    </div>
                </td>
                <td class="ancho"></td>
                <td>
                    <div>
                        <img id="btnusuarios" src="Imagenes/Menu/Usuarios.png"  title="USUARIOS" width="140" height="140" />
                    </div>
                </td>
                <td class="ancho"></td>
                <td>
                    <div>
                        <img id="btnperfiles" src="Imagenes/Menu/Perfiles.png" title="PERFILES" width="140" height="140" />
                    </div>
                </td>
                <td class="ancho"></td>
                <td>
                    <div>
                        <img id="btntramites" src="Imagenes/Menu/Gestion.png" title="TRAMITES" width="140" height="140" />
                    </div>
                </td>
                <td class="ancho"></td>
                <td>
                    <div>
                        <img id="btncajas" src="Imagenes/Menu/Caja.png" title="CAJAS" width="140" height="140" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <!---------------------------------------------------------------------------------------------------------- TERMINA CONTENEDOR DE INFORMACION----------------------------------------------------------------------------->


</body>
</html>
