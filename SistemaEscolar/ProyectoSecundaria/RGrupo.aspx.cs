using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class RGrupo : System.Web.UI.Page
{
    public String NombreGrupo;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        NombreGrupo = txtNombre.Text;
    }
  
    protected void BtnAltas_Click(object sender, EventArgs e)
    {

        String SentenciaRegistro = "insert into grupo(nombre,grado) values('" + NombreGrupo + "','"+ListaGrado.Text+"')";
        try
        {

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            Label1.Text = "Realizado";
        }
        catch (Exception ex)
        {
            Label1.Text = "ERROR " + ex;
        }
    }
}