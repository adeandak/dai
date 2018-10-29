using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (rbAdministrar.Checked)
        {
            Response.Redirect("Pagina4.aspx");
        }
        else
        {
            if (rbInscribir.Checked)
                Response.Redirect("Pagina3.aspx");
        }
    }

    protected void rbAdministrar_CheckedChanged(object sender, EventArgs e)
    {

    }
}