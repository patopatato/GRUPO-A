using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Sistema_Gestion.DAO;
namespace Sistema_Gestion.BSN
{
    public class Usuario
    {
        public void Autentificacion(String usuario, String contraseña)
        { 
        
        
        
        }

        public void guardar_contraseña(String contraseña)
        {
            Datos dat = new Datos();

            dat.guardar_contraseña(contraseña); 

        
        }





    }
}
