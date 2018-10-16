using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagna2 : System.Web.UI.Page {
  protected OdbcConnection conectarBD() {
    String stringConexion = "Driver={SQL Server Native Client 11.0};Server=CC101-24;Uid=sa;Pwd=sqladmin;Database=GameSpot";
    OdbcConnection res;
    try {
      OdbcConnection conexion = new OdbcConnection(stringConexion);
      conexion.Open();
      Label1.Text = "conexion exitosa";
      res= conexion;
    }
    catch (Exception ex) {
      Label1.Text = ex.StackTrace.ToString();
      res= null;
    }
    return res;
  }
  protected void Page_Load(object sender, EventArgs e) {
    OdbcConnection miConexion = conectarBD();
    if (miConexion != null) {
      String query = "select nombre, edad, sexo from usuario where claveU= " + Session["cu"].ToString();
      OdbcCommand cmd = new OdbcCommand(query, miConexion);
      OdbcDataReader rd = cmd.ExecuteReader();
      if (rd.HasRows) {
        rd.Read();
        txNombre.Text = rd.GetString(0);
        txEdad.Text = rd.GetString(1);
        txSexo.Text = rd.GetString(2);
      }
      rd.Close();
      miConexion.Close();
    }
  }

  protected void Button1_Click(object sender, EventArgs e) {
    Response.Redirect("Pagina3.aspx");
  }
}