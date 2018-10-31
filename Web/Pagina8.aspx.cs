using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina8 : System.Web.UI.Page
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
        for (int i = 100; i < 2401; i = i + 100)
        {
            ddlHora.Items.Add(i.ToString());
        }

        if (!IsPostBack)
        {


            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                OdbcCommand cmd = new OdbcCommand("select nombre from deporte order by idDeporte ", miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                ddlDeporte.Items.Clear();
                while (rd.Read())
                {
                    ddlDeporte.Items.Add(rd.GetString(0));
                }
                rd.Close();
                miConexion.Close();
            }
        }
    }

    protected void btCrear_Click(object sender, EventArgs e)
    {
        
    }

    protected void btMod_Click(object sender, EventArgs e)
    {
            OdbcConnection con = conectarBD();
            if (con != null)
            {
                int res;
                String a = txAño.Text.ToString().Substring(0, 4), d = txDia.Text.ToString().Substring(0, 2), m = txMes.Text.ToString().Substring(0, 2);
                lbAux.Text = Session["idReta"].ToString();
                String query = "update reta set hora=" + ddlHora.SelectedValue + ", fecha='" + a + "-" + m + "-" + d + "', lugar='" + txLugar.Text + "', idDeporte=" + (ddlDeporte.SelectedIndex + 1) + " where idReta=" + Session["idReta"].ToString() + ";";
                //insert into reta values(1,1,1200,'2018-10-10','Calle 1','daniel',1);

                OdbcCommand cmd = new OdbcCommand(query, con);
                res=cmd.ExecuteNonQuery();
                lbAux.Text = res.ToString();


                con.Close();
            }
            else
            {
                lbAux.Text = "nop";
            }
    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}