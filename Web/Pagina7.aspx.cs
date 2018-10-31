using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina7 : System.Web.UI.Page
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
        for(int i = 100; i < 2401; i=i+100)
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
        OdbcConnection con = conectarBD();
        try
        {
            int folio;


            String query2 = "select max(idReta) from reta";
            OdbcCommand sql2 = new OdbcCommand(query2, con);
            try
            {
                folio = Int32.Parse(sql2.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                folio = 0;
            }
            folio = folio + 1;



            if (con != null)
            {
                int res;
                String a=txAño.Text.ToString().Substring(0,4), d=txDia.Text.ToString().Substring(0,2), m= txMes.Text.ToString().Substring(0, 2);
                String query = "insert into reta values('" + folio + "'," + 1 + "," + ddlHora.SelectedValue.ToString() + ",'" + a+"-"+m+"-"+d + "', '"+txLugar.Text+ "','" + Session["cu"].ToString() + "'," + (ddlDeporte.SelectedIndex+1) + ");";
                //insert into reta values(1,1,1200,'2018-10-10','Calle 1','daniel',1);
                
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();

                String query3 = "insert into juega values('"+Session["cu"]+"',"+folio+");";
                OdbcCommand cmd1= new OdbcCommand(query3, con);
                res=cmd1.ExecuteNonQuery();
                con.Close();
                
                    lbAux.Text = "Éxito";
                


            }

        }
        catch (Exception ex)
        {
            con = null;
            lbAux.Text= "no se creó la reta" +ex.StackTrace;

        }

    }

    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}