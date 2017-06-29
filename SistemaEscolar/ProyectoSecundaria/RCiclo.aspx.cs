using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class RCiclo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        String valorBoton = BotonModificar.Text;
        if (valorBoton.Equals("Modificar"))
        {
            Combo.Visible = true;
            BotonModificar.Text = "Aceptar";
            BtnCancelar.Visible = true;
        }
        if (valorBoton.Equals("Aceptar"))
        {
            String cicloAModificar = "";
            cicloAModificar = Combo.Text.ToString();
            TodosLosCamposNo();
            ModificarCiclo(cicloAModificar);
            Combo.Visible = false;
            BotonModificar.Text = "Modificar";
            BtnCancelar.Visible = false;

        }


    }

    private void ModificarCiclo(string cicloAModificar)
    {
        String SentenciaRegistro = "update cicloescolar set Actual='SI' where Nombre='" + cicloAModificar + "'";
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            ActualizarVariableCiclo();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error en la base de datos " + ex;
        }
    }

    private void ActualizarVariableCiclo()
    {
        String nombreCiclo = "";
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

    private void TodosLosCamposNo()
    {
        String SentenciaRegistro = "update cicloescolar set Actual='NO'";
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error en la base de datos " + ex;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int ciclo1 = Int32.Parse(Txt1.Text);
            int ciclo2 = Int32.Parse(Txt2.Text);

            int contarPrimerCampo = 0;
            int contarSegundoCampo = 0;

            contarPrimerCampo = Txt1.Text.Length;
            contarSegundoCampo = Txt2.Text.Length;

            if (contarPrimerCampo == 2 && contarSegundoCampo == 2)
            {
                if (ciclo2 - ciclo1 == 1)
                {
                    Label1.Visible = true;
                    String nombreCiclo = "20" + Txt1.Text + "-" + "20" + Txt2.Text;
                    RegistrarCicloEscolar(nombreCiclo);
                    Label1.Text = "Registro exitoso";
                    Response.Redirect("RCiclo.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Los ciclos escolares duran unicamente un año";
                }

            }
            else
            {
                Label1.Text = "Ingresa unicamente 2 numeros por campo";
            }

        }
        catch (Exception ex)
        {
            Label1.Visible = true;
            Label1.Text = "Ingresa unicamente dos numeros";

        }


    }

    private void RegistrarCicloEscolar(string nombreCiclo)
    {
        String SentenciaRegistro = "insert into cicloEscolar(nombre,Actual) values('" + nombreCiclo + "','No')";
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error en la base de datos " + ex;
        }
    }
    protected void BtnCancelar_Click(object sender, EventArgs e)
    {
        BtnCancelar.Visible = false;
        Combo.Visible = false;
        BotonModificar.Text = "Modificar";
    }
}