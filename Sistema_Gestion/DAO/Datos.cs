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
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;



namespace Sistema_Gestion.DAO
{
    
    public class Datos
    {
        BD bd = new BD();
        String sql = "";
        public DataSet ver_ramos_rut(String rut)
        {
           
            DataSet datos = new DataSet();

            sql="SELECT     dbo.ramo.nombre FROM         dbo.alum INNER JOIN  dbo.malla ON dbo.alum.rut = dbo.malla.rut INNER JOIN   dbo.ramo ON dbo.malla.ramos = dbo.ramo.codigo where dbo.alum.rut=" + rut;
            datos=bd.Ejecutar_Bd(sql);

     
            
            return datos;
        }

        public void Autenctificacion()
        {
            BD bd = new BD();
            String sql = "";

       
        }
        public void guardar_contraseña(String contraseña)
        {
            DataSet datos = new DataSet();
            BD bd = new BD();
            String sql = "";
          

            byte[] pass = Encoding.UTF8.GetBytes(contraseña);
            MD5 md5 = new MD5CryptoServiceProvider();
            string strPassword = Encoding.UTF8.GetString(md5.ComputeHash(pass));
            sql = " insert into  Usuario (id,usuario,constraseña) values (23,'alexis', 'strPassword')";

             bd.setEjecutar_Bd(sql);



            
            //        MD5 Me = MD5CryptoServiceProvider.Create();
  //         contraseña =  Me.txtPass.Text;
            
//Me.lblSHA1.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(contraseña, "sha1");
//Me.lblMD5.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(contraseña, "md5");
        
        }

    }
}
