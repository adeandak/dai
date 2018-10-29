using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina4 : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        OdbcConnection con;
        try
        {
            con = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=DESKTOP-DO4J10F;Uid=sa;Pwd=sqladmin;Database=Retas");
            con.Open();
            lbCon.Text = "conexion exitosa";
            
        

        }catch(Exception ex)
        {
            lbCon.Text="no se pudo conectar";
            con = null;
        }
        return con;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            OdbcConnection con = conectarBD();
            if (con != null)
            {

                try
                {
                    Response.Write(Session["cu"].ToString());
                    OdbcCommand cmd = new OdbcCommand("select reta.idReta, deporte.nombre, hora, fecha, lugar, numParticipantes from reta,deporte,juega where deporte.idDeporte=reta.idDeporte and reta.idReta=juega.idReta and idUsuario= '" + Session["cu"].ToString() + "'  ", con);
                    OdbcDataReader rd = cmd.ExecuteReader();
                   // rd.Read();
                    GridDatos.DataSource = rd;
                    GridDatos.DataBind();
                    rd.Close();
                }
                catch (Exception ex)
                {
                    lbCon.Text = "ocurrio un error" + ex;
                }



            }
        }
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void bteliminar_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina6.aspx");
    }
}