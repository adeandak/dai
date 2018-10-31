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
        String stringConexion = "Driver={SQL Server Native Client 11.0};Server=112SALAS10;Uid=sa;Pwd=sqladmin;Database=Retas"; //solo cambia la maquina
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringConexion);
            conexion.Open();
            
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

        try
        {
            if (con != null)
            {
                OdbcCommand checa = new OdbcCommand("select idUsuario from jugador where idUsuario='"+txUsuario.Text+"' ", con);
                OdbcDataReader rd = checa.ExecuteReader();
                if (rd.HasRows)
                {
                    lbCon.Text = "el nombre de usuario ya existe";
                    rd.Close();
                }
                else
                {
                    OdbcCommand cmd = new OdbcCommand("insert into jugador values( '" + txUsuario.Text + "','" + txContraseña.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lbAux.Text = "ÉXITO";
                    lbCon.Text = "has sido agregado al sistema";
                }
                

            }
            else
            {
                lbCon.Text = "no se agregó";
            }
        }catch(Exception ex)
        {
            lbCon.Text = "no se agregó";
        }
        
        
       
    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina1.aspx");
    }
}