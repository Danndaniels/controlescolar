using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void ComboPersonal_SelectedIndexChanged(object sender, EventArgs e)
    {
        String valorCombo = ComboPersonal.Text;

        if (valorCombo.Equals("Profesor"))
        {
            General.FilterExpression = "Puesto='Profesor'";
        }
        else if (valorCombo.Equals("Personal administrativo"))
        {
            General.FilterExpression = "Puesto='Personal administrativo'";
        }
        else if (valorCombo.Equals("Todos"))
        {
            Response.Redirect("CPersonal.aspx");
        }
        else if (valorCombo.Equals("Orientador"))
        {
            General.FilterExpression = "Puesto='Orientador'";
        }
    }
   
}