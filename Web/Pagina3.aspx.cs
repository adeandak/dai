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
        String stringConexion = "Driver={SQL Server Native Client 11.0};Server=112SALAS10;Uid=sa;Pwd=sqladmin;Database=Retas"; //solo cambia la maquina
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
        OdbcConnection con = conectarBD();
        if(con != null)
        {


   


           try
            {

                OdbcCommand cmd = new OdbcCommand("insert into juega values('" + Session["cu"].ToString() + "','" + Int16.Parse(txtId.Text) + "')  ", con);
                cmd.ExecuteNonQuery();

                OdbcCommand cmd2 = new OdbcCommand("update reta set numParticipantes =numParticipantes+1 where idReta='"+txtId.Text+"'    ",con);
                cmd2.ExecuteNonQuery();


                lbaviso.Text = "has sido agregado a la reta";
                con.Close();
            }
            catch(Exception ex)
            {
                lbaviso.Text = "no se pudo agregar";
            }
        }
    }

    protected void btBuscar_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        if (con != null)
        {
            String var1 = ddlDeportes.SelectedValue;
            
            OdbcCommand cmd = new OdbcCommand("select idDeporte from deporte where deporte.nombre='" + var1 + "' ", con);
            OdbcDataReader rd = cmd.ExecuteReader();
            rd.Read();
            int claveDeporte = rd.GetInt16(0);
            OdbcCommand cmd2 = new OdbcCommand("select reta.idReta, numParticipantes, hora, fecha, lugar  from reta where idDeporte='" + claveDeporte + "'  " , con);
            OdbcDataReader rd2 = cmd2.ExecuteReader();
            gridDeporte.DataSource = rd2;
            gridDeporte.DataBind();
            rd.Close();
            rd2.Close();

        }
        else
            lbAux.Text = "error de conexion";
            
    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}