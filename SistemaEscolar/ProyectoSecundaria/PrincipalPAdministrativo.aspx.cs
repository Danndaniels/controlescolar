using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class PrincipalPAdministrativo : System.Web.UI.Page
{
    public String nombre = "";
    public String nombreCiclo = "";

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        NombreUsuario();
        CicloEScolarActual();
    }

    private void CicloEScolarActual()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "select nombre from cicloEscolar where Actual='Si'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            nombreCiclo = "" + registro["NOMBRE"];
        }
        else
        {

        }
        conexion.Close();
        Session["nombreCiclo"] = nombreCiclo;
    }

    private void NombreUsuario()
    {
      
        try
        {
            String recuperarValor="";
            recuperarValor = (string)(Session["usuario"]);
                String quitar2="";
                quitar2 = recuperarValor.Replace("2","");
            int verificar = Int32.Parse(quitar2);
            BuscarAlumno();
        }
        catch (Exception ex)
        {

            BuscarPersonal();
        }
        
    }

    private void BuscarPersonal()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "SELECT NOMBRE FROM PERSONALADMINISTRATIVO WHERE USUARIO='" + Session["usuario"] + "'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            nombre = "" + registro["NOMBRE"];


        }
        else
        {

        }
        conexion.Close();
        Session["nombre"] = nombre;
    }

    private void BuscarAlumno()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "SELECT NOMBRE FROM ALUMNO WHERE MATRICULA='" + Session["usuario"] + "'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            nombre = "" + registro["NOMBRE"];


        }
        else
        {
            nombre = "Error";
        }
       
        conexion.Close();
        Session["nombre"] = nombre;
    }
    
    
}