using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_APP
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Usuario Logueado--------------------------------------------------------------------------------------------------------------------------------
        [System.Web.Services.WebMethod]
        public static string ValidaCredenciales(string usuario, string contrasena, int idrol)
        {
            string resultado = "";
            if(usuario == "Usuario" && contrasena == "prueba" && idrol == 2)
            {
                resultado ="OK";
            }
            else
            {
                resultado = "NO";
            }
            return resultado;
        }
    }
}