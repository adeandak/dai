using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        OdbcConnection res;
        String stringConexion = "Driver={SQL Server Native Client 11.0};Server=DESKTOP-DO4J10F;Uid=sa;Pwd=sqladmin;Database=WebRetas"; //solo cambia la maquina
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringConexion);
            conexion.Open();
            lbAux.Text = "conexion exitosa";
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
        if (!IsPostBack)
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                OdbcCommand cmd = new OdbcCommand("select distinct deporte.nombre from deporte", miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                ddlDeportes.Items.Clear();
                while (rd.Read())
                {
                    ddlDeportes.Items.Add(rd.GetString(0));
                }
                rd.Close();
                miConexion.Close();
            }
        }

    }

    protected void ddlDeportes_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btNueva_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina6.aspx");
    }
}