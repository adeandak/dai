using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina6 : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        OdbcConnection con;
        try
        {
            con = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=112SALAS10;Uid=sa;Pwd=sqladmin;Database=Retas");
            con.Open();




        }
        catch (Exception ex)
        {
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
                    //Response.Write(Session["cu"].ToString());
                    OdbcCommand cmd = new OdbcCommand("select distinct reta.idReta, deporte.nombre, hora, fecha, lugar, numParticipantes from reta,deporte,juega where deporte.idDeporte=reta.idDeporte and reta.creador='" + Session["cu"].ToString() + "' ", con);
                    OdbcDataReader rd = cmd.ExecuteReader();
                    // rd.Read();
                    GridDatos.DataSource = rd;
                    GridDatos.DataBind();
                    rd.Close();
                }
                catch (Exception ex)
                {
                    lbCon.Text = "ocurrio un error";
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
                String query3 = "delete from juega where idReta= " + var1 + "  ";
                OdbcCommand cmd1 = new OdbcCommand(query3, con);
                cmd1.ExecuteNonQuery();
                
                String query = "delete from reta where idReta= " + var1 + "  ";
                

                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

        }
        catch (Exception ex)
        {
            con = null;

        }

    }

    protected void btMod_Click(object sender, EventArgs e)
    {

        if (txIdMod.Text != null && !txIdMod.Text.Equals(""))
        {
            OdbcConnection con = conectarBD();
            try
            {

                if (con != null)
                {

                    String var1 = txIdElimina.Text;
                    String query3 = "select idReta from reta ";
                    OdbcCommand cmd1 = new OdbcCommand(query3, con);
                    OdbcDataReader rd = cmd1.ExecuteReader();
                    List<Int32> lista = new List<int>();
                    while (rd.Read())
                    {
                        lista.Add(rd.GetInt32(0));
                    }
                    if (lista.Contains(Int32.Parse(txIdMod.Text)))
                    {
                        Session["idReta"] = txIdMod.Text;
                        //lbAux.Text = Session["idReta"].ToString();
                        Response.Redirect("Pagina8.aspx");
                    }
                    else
                    {
                        lbAux.Text = "ID incorrecto";
                    }
                }
            }
            catch (Exception ex)
            {
                con = null;

            }

        }
    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}