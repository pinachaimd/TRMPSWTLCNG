<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WEB_APP.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <%--<meta name="viewport" content="width=device-width, initial-scale=1.0" />--%>
    <link rel="shortcut icon" href="Imagenes/Fondo/logo2.png" />

    <%-- Estilos --%>
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <%--<link href="CSS/Menus.css" rel="stylesheet" type="text/css" />--%>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link href="CSS/bootstrap.css" rel="stylesheet" />
    <link href="CSS/mdb.css" rel="stylesheet" />
    <link href="CSS/EstiloPrincipal.css" rel="stylesheet" />

    <%-- scripts --%>
    <script src="Script/jquery-3.3.1.min.js"></script>
<%--    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.13.0/umd/popper.min.js"></script>--%>
    <script src="Script/bootstrap.min.js"></script>
<%--    <script src="Script/mdb.min.js"></script>
    <script src="Script/dropzone.js"></script>
    <script src="http://momentjs.com/downloads/moment.min.js"></script>--%>

    <script src="JS/Login.js"></script>
    <title>Catastro</title>

</head>
<body>
    <div id="encabezado">

        <div class="text-right">
            <button id="generarequisicion" type="button" class="btn btn-brown btn-rounded btn-sm" data-toggle="modal" data-target="#modallogin">Login<i class="fas fa-sign-in-alt ml-2 color-fuente-strong" aria-hidden="true"></i></button>
            <%--<button id="cerrarsesion" type="button" class="btn btn-danger btn-rounded btn-sm">Cerrar Sesión<i class="fa fa-power-off ml-2" aria-hidden="true"></i></button>--%>
        </div>

        <div class="modal fade" id="modallogin" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <%--<div class="modal-dialog" role="document">--%>
                <div class="modal-dialog modal-notify modal-info" role="document">
                <div class="modal-content">
                    <div class="modal-header text-center">
                        <img src="Imagenes/Fondo/logo2.png" class="rounded text-center" alt="Responsive image" style="width: 20%; margin-right: 10px;" />
                        <h4 class="modal-title w-100 font-weight-bold color-fuente">Login</h4>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body mx-3">
                        <div class="form-group">
                            <i class="fas fa-user prefix fa-1x"></i>
                            <label for="InputUsuario">Usuario</label>
                            <input type="text" class="form-control" id="usuario" runat="server" aria-describedby="user" placeholder="Ingrese su nombre de usuario" />
                            <%--<small id="userHelp" class="form-text text-muted">Nunca comparta su nombre de usuario y contraseña</small>--%>
                        </div>
                        <div class="form-group">
                            <i class="fas fa-lock prefix fa-1x"></i>
                            <label for="InputPassword">Contraseña</label>
                            <input type="password" id="password" class="form-control" runat="server" aria-describedby="user" placeholder="Ingrese su contraseña" />
                        </div>
                        <div class="form-group">
                            <i class="fas fa-user-secret prefix fa-1x"></i>
                            <label for="InputRol">Rol</label>
                            <select class="form-control" id="cmbRol">
                                <option value="1">Seleccionar. . .</option>
                                <option value="2">Administrador</option>
                            </select>
                        </div>

                    </div>
                    <div class="modal-footer d-flex justify-content-center">
                        <button id="btnentrar" class="btn btn-green">Entrar</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div id="contenido">
        <div class="logo">
            <img src="Imagenes/Fondo/logo2.png" style="width: 100%; height: 100%;" />
        </div>
    </div>

    <!-------------------------------------------------------------------------------------------MODAL ERROR AL GUARDAR----------------------------------------------------------------------------------------->
    <div class="modal fade" id="ModalErrorGuardar" tabindex="-1" role="dialog" aria-labelledby="ModalErrorGuardar" aria-hidden="true">
        <div class="modal-dialog modal-notify modal-danger" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <p class="heading lead">¡Error!</p>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true" class="white-text">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="text-center">
                        <i class="fa fa-times fa-4x mb-3 animated rotateIn"></i>
                        <div id="MensajeError">
                        </div>
                    </div>
                </div>
                <div class="modal-footer justify-content-center"> 
                    <a type="button" class="btn btn-danger" data-dismiss="modal">OK<i class="fa fa-thumbs-o-up ml-1"></i></a>
                </div>
            </div>
        </div>
    </div>
    <!-------------------------------------------------------------------------------------------TERMINA MODAL ERROR AL GUARDAR--------------------------------------------------------------------------------->

</body>
</html>
