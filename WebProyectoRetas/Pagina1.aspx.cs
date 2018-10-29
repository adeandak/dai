using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        OdbcConnection res;
        String stringConexion = "Driver={SQL Server Native Client 11.0};Server=DESKTOP-DO4J10F;Uid=sa;Pwd=sqladmin;Database=Retas"; //solo cambia la maquina
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringConexion);
            conexion.Open();
            lbAux.Text = "conexion exitosa";
            res= conexion;
        }
        catch (Exception ex)
        {
            lbAux.Text = ex.StackTrace.ToString();
            res=null;
        }
        return res;
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
    }

    protected void btSiguiente_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD(); //para probar la conexion OJO CON QUE EL BOTON TENGA CLIC Pues la interface ya se habia hecho
        if (miConexion != null)
        {
            String query = "select idUsuario from jugador where idUsuario='" + txUsuario.Text + "' and contra='" + txContraseña.Text + "'";
            OdbcCommand cmd = new OdbcCommand(query, miConexion);
            OdbcDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Session["cu"] = rd.GetString(0).ToString();
                lbAux.Text = "Exito amigos";
                Response.Redirect("Pagina2.aspx"); //COMANDO PARA LLAMAR A LA SIGUIENTE PAGINA
            }
            else
                lbAux.Text = "el usuario o contraseña son incorrectos";
            miConexion.Close();
            rd.Close();

        }
    }


    protected void btRegistrate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina5.aspx");
    }
}