using login1.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login1.CapaVistas
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(cls_usuario.nombre))
                {
                    Response.Redirect("Login1.aspx");
                } else
                {
                    lblUsuario.Text = "Bienvenido, " + cls_usuario.nombre;
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            cls_usuario.clave = string.Empty;
            cls_usuario.correo = string.Empty;
            cls_usuario.nombre = string.Empty;
            Response.Redirect("Login1.aspx");
        }
    }
}