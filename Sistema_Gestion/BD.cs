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
using System.Data.SqlClient;

namespace Sistema_Gestion
{
    public class BD
    {

        String cadena = "Data Source=ALEX-FA92C6D960\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        
        public DataSet  Ejecutar_Bd(String sqlStr)
        {

            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();
            SqlDataAdapter sqp = new SqlDataAdapter(sqlStr,conn);
            DataSet datos = new DataSet();
            sqp.Fill(datos);
            conn.Close();
            return datos;

        


        }
        public void setEjecutar_Bd(String strSql)
        {
            SqlConnection MyConnection =new SqlConnection(cadena);
        SqlCommand MyCommand=  new SqlCommand();
        MyConnection.Open();
        MyCommand.Connection = MyConnection;
        MyCommand.CommandText = strSql;
        MyCommand.ExecuteNonQuery();
        MyConnection.Close();
          //  SqlConnection conn = new SqlConnection(cadena);
            //conn.Open();
            //SqlDataAdapter sqp = new SqlDataAdapter(sqlStr, conn);
        
           
            //conn.Close();
           




        }
    }
}
