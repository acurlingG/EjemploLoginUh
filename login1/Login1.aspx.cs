using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login1
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     
    

      
        protected void Ingresar_Click(object sender, EventArgs e)
        {
            if (CapaLogica.Usuario.validausuario(txtusuario.Text, txtclave.Text) == 1)
            {
                Response.Redirect("CapaVistas/inicio.aspx");
            }
            else

                Response.Write("<script>alert('Usuario o contraseña incorrectos');</script>");
        }
    }
}