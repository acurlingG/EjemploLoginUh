using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login1.CapaVistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (CapaLogica.Usuario.validausuario(txtUsuario.Text, txtClave.Text) == 1)
            {
                Response.Redirect("inicio.aspx");
            }
            else

                Response.Write("<script>alert('Usuario o contraseña incorrectos');</script>");
        }

          
    }
}