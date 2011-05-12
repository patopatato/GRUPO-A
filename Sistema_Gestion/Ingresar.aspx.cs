using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Sistema_Gestion.BSN;

namespace Sistema_Gestion
{
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void inicio_Click(object sender, EventArgs e)
        {
             Usuario us=new Usuario();

            String usuario="";
            String contraseña="";
            usuario = user.Text;
            contraseña = id.Text;
            us.Autentificacion(usuario,contraseña);

            L.Text = "electro";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BotonAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
