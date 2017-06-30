using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class CAlumnos_ : System.Web.UI.Page
{
    int ValorTurno, ValorSexo, ValorGrupo;
    String ResultadoConsulta = "";//Variablepara guardar la consulta con filtro
    String NombreDelGrupo;//Guardara el nombre del grupo
    int IDDeGrupo;//Al realizar la consulta se obtendra el valor de ID del nombre que tenga el grupo
    int ValorBuscar = 1;//SE utilizara para filtrar los datos del grupo,dependiendo el 
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }

    }

    private void ComboGrupo()
    {
        BuscarGrado.DataSource = SqlDataSource1;
        BuscarGrado.DataTextField = "Nombre";
        BuscarGrado.DataBind();
        ListItem item = new ListItem { Text = "Selecciona", Value = "" };
        BuscarGrado.Items.Insert(0, item);

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarDatos();
    }

    private void FiltrarDatos()
    {

        String Turno = "";
        String Sexo = "";
        String SentenciaFiltrar = "";
        Turno = BusquedaTurno.Text;
        Sexo = BusquedaSexo.Text;
        if (Turno.Equals("Selecciona") && Sexo.Equals("Selecciona") && ValorBuscar == 2)
        {
            Label4.Text = SentenciaFiltrar;
            Response.Redirect("CAlumnos.aspx");
        }
        else
        {
            BuscarIDGrupo();

            if (ValorBuscar == 1 && Sexo.Equals("Selecciona") && Turno != "Selecciona")
            {
               
                SentenciaFiltrar = "Turno='" + Turno+ "'";
                Label4.Text = "" + SentenciaFiltrar;
            }
            else if (ValorBuscar == 1 && Sexo!="Selecciona" && Turno != "Selecciona")
            {

                SentenciaFiltrar = "Turno='" + Turno + "' and Sexo='"+Sexo+"'";
                Label4.Text = ""+SentenciaFiltrar;
            }

            Consulta.FilterExpression = SentenciaFiltrar;
        }




    }

    private void BuscarIDGrupo()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select ID_GRUPO from GRUPO WHERE NOMBRE='" + BuscarGrado.Text + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            LabelIDGrupo.Text = "" + registro["ID_GRUPO"];
          ResultadoConsulta = "" + registro["ID_GRUPO"];

        }
        conexion.Close();

    }
    protected void BusquedaSexo_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarDatos();
    }
    protected void BuscarGrado_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        FiltrarDatos();
    }



    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (BUSCAR.Checked == true)
        {
            BuscarGrado.Visible = true;

            ValorBuscar = 1;
            FiltrarDatos();
        }
        else
        {
            BuscarGrado.Visible = false;
            ValorBuscar = 2;
            FiltrarDatos();
        }

    }
}