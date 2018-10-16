using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page {
  protected OdbcConnection conectarBD() {
    String stringConexion = "Driver={SQL Server Native Client 11.0};Server=CC101-24;Uid=sa;Pwd=sqladmin;Database=GameSpot";
    OdbcConnection res;
    try {
      OdbcConnection conexion = new OdbcConnection(stringConexion);
      conexion.Open();
      Label1.Text = "conexion exitosa";
      res = conexion;
    }
    catch (Exception ex) {
      Label1.Text = ex.StackTrace.ToString();
      res = null;
    }
    return res;
  }

  protected void Page_Load(object sender, EventArgs e) {
    
  }

  protected void btPagina2_Click(object sender, EventArgs e) {
    OdbcConnection miConexion = conectarBD();
    if(miConexion != null) {
      String query = "select claveU from usuario where email='" + txUsuario.Text + "' and password='" + txContraseña.Text + "'";
      OdbcCommand cmd = new OdbcCommand(query, miConexion);
      OdbcDataReader rd = cmd.ExecuteReader();
      if (rd.HasRows) {
        rd.Read();
        Session["cu"] = rd.GetInt32(0).ToString();
        Response.Redirect("Pagina2.aspx");
      }
      else {
        lbContador.Text = "el usuario o password son incorrectos";
      }
      rd.Close();
      miConexion.Close();
    }
  }
}