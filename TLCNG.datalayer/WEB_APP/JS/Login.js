var RutaLogica = 'http://localhost:4688/Principal.aspx';

//BOTON DE ENTRAR
$(document).ready(function () {
    $('#btnentrar').click(function () {
        var Usuario = $('#usuario').val();
        var Password = $('#password').val();
        var Rol = $('#cmbRol').val();

        if (Usuario == '' || Password == '' || Rol == 1) {
            $('#MensajeError').text("Favor de ingresar un nombre de usuario, contraseña y rol.");
            $('#ModalErrorGuardar').modal('show');
        } else {
            $.ajax({
                type: "POST",
                url: RutaLogica + "/ValidaCredenciales",
                data: '{usuario:"' + Usuario + '", contrasena:"' + Password + '", idrol:"' + Rol + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    if (data.d == 'OK') {
                        location.href = "../Menu.aspx";
                    }
                    else {
                        $("#MensajeError").text("El usuario y/o la contraseña son incorrectos.");
                        $('#ModalErrorGuardar').modal('show');
                    }
                },
                error: function (e) {
                    $("#MensajeError").text("Lo sentimos pero se ha producido un error en la aplicación proporcione esta información a su administrador: " + e.status + " " + e.statusText);
                    $('#ModalErrorGuardar').modal('show');
                },
            });
        }
    });
});
