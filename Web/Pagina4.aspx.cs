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
            con = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=112SALAS10;Uid=sa;Pwd=sqladmin;Database=Retas");
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
        OdbcConnection con = conectarBD();
        try
        {

            if (con != null)
            {
                String var1 = txIdElimina.Text;
                String query = "delete from juega where idUsuario= '" + Session["cu"].ToString() + "' and idReta="+var1+";";


                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();

                String qu = "select numParticipantes from reta where idReta="+var1+"";
                OdbcCommand cmd2 = new OdbcCommand(qu,con);
                OdbcDataReader rd = cmd2.ExecuteReader();
                if (rd.Read())
                {
                    int numP = rd.GetInt16(0) - 1;
                    String query1 = "update reta set numParticipantes = " + numP + "  where idReta= " + var1 + ";";
                    OdbcCommand cmd1 = new OdbcCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                }
                con.Close();

            }

        }
        catch (Exception ex)
        {
            con = null;
            lbAux.Text = "error"+ex;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina6.aspx");
    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}