using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    public String usuario, password,valorRecuperadoA,valorRecuperadoPA;
    public String PuestoRecuperado = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int verificar = 0;//SE utilizara para verificar si solo son numeros en la caja usuario
        usuario = txtUsuario.Text;
        password = txtContra.Text;
        try
        {
            verificar = Int32.Parse(txtUsuario.Text.Replace("2", ""));
            BuscarAlumno();
        }
        catch (Exception ex)
        {

            BuscarPersonal();
        }
    }

    private void BuscarAlumno()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "SELECT CONTRASENA FROM ALUMNO WHERE MATRICULA='" + txtUsuario.Text + "'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            valorRecuperadoA= "" + registro["CONTRASENA"];
            conexion.Close();
            VerificacionMatricula(valorRecuperadoA);
        }
        else
        {
            LabelMensaje.Text = "Verifique los datos ingresados Alumno";
        }
        conexion.Close();
    }

    private void BuscarPersonal()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "SELECT CONTRASENA FROM PERSONALADMINISTRATIVO WHERE USUARIO='" + txtUsuario.Text + "'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            valorRecuperadoPA = "" + registro["CONTRASENA"];
            conexion.Close();
            VerificarUsuario(valorRecuperadoPA);

        }
        else
        {
            LabelMensaje.Text = "Verifique los datos ingresados Profesor";
        }
        conexion.Close();
    }

    private void VerificarUsuario(string verificar)
    {
        VerificarPrimeraVezPA(verificar);
       
    }

    private void VerificarPrimeraVezPA(String verificar)
    {
        int contador = 0;//se guardara cuantos caracteres tiene la contraseña
        contador = password.Length;
        if (contador > 4)
        {
            AccederProfesor(verificar);
        }
        else
        {

            Response.Redirect("ModificarPassword.aspx?Usuario=" + usuario);
        }
    }

    private void AccederProfesor(string verificar)
    {
        String VariableResultado = "";//Contiene lo que se recupero de la consulta
        VariableResultado = valorRecuperadoPA;
        RecuperarPuesto();
        if (password.Equals(VariableResultado))
        {

            if (PuestoRecuperado.Equals("Personal administrativo"))
            {
                Session["user"] = "Padministrativo";
                Session["usuario"] = usuario;
                Response.Redirect("PrincipalPAdministrativo.aspx");
            }
            else if (PuestoRecuperado.Equals("Profesor"))
            {
                Session["user"] = "Profesor";
                Session["usuario"] = usuario;
                Response.Redirect("PrincipalPAdministrativo.aspx");
            }
            else
            {
                Session["user"] = "Orientador";
                Session["usuario"] = usuario;
                Response.Redirect("PrincipalPAdministrativo.aspx");
            }
        }
        else
        {
            LabelMensaje.Text = "Verifique los datos ingresados";
        }
    }

    private void RecuperarPuesto()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        String consulta = "SELECT PUESTO FROM PERSONALADMINISTRATIVO WHERE USUARIO='" + txtUsuario.Text + "'";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            PuestoRecuperado= "" + registro["PUESTO"];

        }
        else
        {
            LabelMensaje.Text = "Verifique los datos ingresados Profesor";
        }
        conexion.Close();
    }

  

    private void VerificacionMatricula(String contra)
    {
        VerificarPrimerVez(contra);
       
    }

    private void VerificarPrimerVez(String contra)
    {
        int contador = 0;//se guardara cuantos caracteres tiene la contraseña
        contador = password.Length;
        if(contador>4){
            AccederAlumno(contra);
        }
        else{
           
            Response.Redirect("ModificarPassword.aspx?Usuario=" + usuario);
        }
    }

    private void AccederAlumno(String contra)
    {
      String VariableResultado = "";//Contiene lo que se recupero de la consulta
        VariableResultado = valorRecuperadoA;
        if (password.Equals(contra))
        {
            
            Session["user"] = "Alumno";
            Session["usuario"] = txtUsuario.Text;
            Response.Redirect("PrincipalPAdministrativo.aspx");
        }
        else
        {
            LabelMensaje.Text = "Error";
        }
    }
}