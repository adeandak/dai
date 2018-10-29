using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina5 : System.Web.UI.Page
{

    protected OdbcConnection conectarBD()
    {
        OdbcConnection res;
        String stringConexion = "Driver={SQL Server Native Client 11.0};Server=DESKTOP-DO4J10F;Uid=sa;Pwd=sqladmin;Database=Retas"; //solo cambia la maquina
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringConexion);
            conexion.Open();
            lbAux.Text = "ÉXITO";
            res = conexion;
        }
        catch (Exception ex)
        {
            lbAux.Text = ex.StackTrace.ToString();
            res = null;
        }
        return res;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txRegistro_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        if (con != null)
        {
            OdbcCommand cmd = new OdbcCommand("insert into jugador values( '" + txUsuario.Text + "','" + txContraseña.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            lbCon.Text = "has sido agregado al sistema";

        }
        else
        {
            lbCon.Text = "no se agregó";
        }
        
       
    }
}