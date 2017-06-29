using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Graficas : System.Web.UI.Page
{
    int[] barras = new int[3];
    String[] nombres = new String[3];
    protected void Page_Load(object sender, EventArgs e)
    {
        barras[0] = 9;
        barras[1] = 8;
        barras[2] = 8;

        nombres[0] = "Español";
        nombres[1] = "Matematicas";
        nombres[2] = "Ciencias";

        Grafica.Series["Serie"].Points.DataBindXY(nombres, barras);
    }
}