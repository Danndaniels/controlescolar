using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AgregarAsignatura : System.Web.UI.Page
{
    int IDGrupo = 0;
    int IDProfesor = 0;
    int IDAsignatura = 0;
    String sentencia = "";
    String Grado = "";//SE UTILIZARA PARA GUARDAR EL ID DEL GRUPO



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (BtnGuardar.Text == "Guardar")
        {

            BtnCancelar.Visible = true;
            int valorCombo = 0;//Guardara el valor que este dentro del combo de las materias
            valorCombo = Int32.Parse(ListaTotalAsignaturas.Text);

            switch (valorCombo)
            {
                case 1:

                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    break;
                case 2:

                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;

                    break;

                case 3:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;

                    break;

                case 4:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    break;

                case 5:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;

                    break;

                case 6:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;

                    break;

                case 7:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;
                    LabelConfirmacion7.Visible = true;
                    LabelConfirmacion7.Text = "Profesor " + ListaProfesor7.Text + " para asignatura " + ListaAsignatura7.Text;

                    break;
                case 8:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;
                    LabelConfirmacion7.Visible = true;
                    LabelConfirmacion7.Text = "Profesor " + ListaProfesor7.Text + " para asignatura " + ListaAsignatura7.Text;
                    LabelConfirmacion8.Visible = true;
                    LabelConfirmacion8.Text = "Profesor " + ListaProfesor8.Text + " para asignatura " + ListaAsignatura8.Text;

                    break;
                case 9:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;
                    LabelConfirmacion7.Visible = true;
                    LabelConfirmacion7.Text = "Profesor " + ListaProfesor7.Text + " para asignatura " + ListaAsignatura7.Text;
                    LabelConfirmacion8.Visible = true;
                    LabelConfirmacion8.Text = "Profesor " + ListaProfesor8.Text + " para asignatura " + ListaAsignatura8.Text;
                    LabelConfirmacion9.Visible = true;
                    LabelConfirmacion9.Text = "Profesor " + ListaProfesor9.Text + " para asignatura " + ListaAsignatura9.Text;

                    break;

                case 10:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;
                    LabelConfirmacion7.Visible = true;
                    LabelConfirmacion7.Text = "Profesor " + ListaProfesor7.Text + " para asignatura " + ListaAsignatura7.Text;
                    LabelConfirmacion8.Visible = true;
                    LabelConfirmacion8.Text = "Profesor " + ListaProfesor8.Text + " para asignatura " + ListaAsignatura8.Text;
                    LabelConfirmacion10.Visible = true;
                    LabelConfirmacion10.Text = "Profesor " + ListaProfesor10.Text + " para asignatura " + ListaAsignatura10.Text;
                    LabelConfirmacion9.Visible = true;
                    LabelConfirmacion9.Text = "Profesor " + ListaProfesor9.Text + " para asignatura " + ListaAsignatura9.Text;

                    break;

                case 11:
                    LabelConfirmacion1.Visible = true;
                    LabelConfirmacion1.Text = "Profesor " + ListaProfesor1.Text + " para asignatura " + ListaAsignatura1.Text;
                    LabelConfirmacion2.Visible = true;
                    LabelConfirmacion2.Text = "Profesor " + ListaProfesor2.Text + " para asignatura " + ListaAsignatura2.Text;
                    LabelConfirmacion3.Visible = true;
                    LabelConfirmacion3.Text = "Profesor " + ListaProfesor3.Text + " para asignatura " + ListaAsignatura3.Text;
                    LabelConfirmacion4.Visible = true;
                    LabelConfirmacion4.Text = "Profesor " + ListaProfesor4.Text + " para asignatura " + ListaAsignatura4.Text;
                    LabelConfirmacion5.Visible = true;
                    LabelConfirmacion5.Text = "Profesor " + ListaProfesor5.Text + " para asignatura " + ListaAsignatura5.Text;
                    LabelConfirmacion6.Visible = true;
                    LabelConfirmacion6.Text = "Profesor " + ListaProfesor6.Text + " para asignatura " + ListaAsignatura6.Text;
                    LabelConfirmacion7.Visible = true;
                    LabelConfirmacion7.Text = "Profesor " + ListaProfesor7.Text + " para asignatura " + ListaAsignatura7.Text;
                    LabelConfirmacion8.Visible = true;
                    LabelConfirmacion8.Text = "Profesor " + ListaProfesor8.Text + " para asignatura " + ListaAsignatura8.Text;
                    LabelConfirmacion10.Visible = true;
                    LabelConfirmacion10.Text = "Profesor " + ListaProfesor10.Text + " para asignatura " + ListaAsignatura10.Text;
                    LabelConfirmacion11.Visible = true;
                    LabelConfirmacion11.Text = "Profesor " + ListaProfesor11.Text + " para asignatura " + ListaAsignatura11.Text;
                    LabelConfirmacion9.Visible = true;
                    LabelConfirmacion9.Text = "Profesor " + ListaProfesor9.Text + " para asignatura " + ListaAsignatura9.Text;

                    break;
            }


        }
        else
        {
            RealizarRegistro();
            BtnCancelar.Visible = false;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Visible = false;

        }
        ValidarQueNoSeRepitan();

    }

    private void RealizarRegistro()
    {
        int valorCombo = 0;//Guardara el valor que este dentro del combo de las materias
        valorCombo = Int32.Parse(ListaTotalAsignaturas.Text);

        String[] ComboAsignatura = { ListaAsignatura1.SelectedValue, ListaAsignatura2.SelectedValue, ListaAsignatura3.SelectedValue, ListaAsignatura4.SelectedValue,
                                   ListaAsignatura5.SelectedValue,ListaAsignatura6.SelectedValue,ListaAsignatura7.SelectedValue,ListaAsignatura8.SelectedValue,ListaAsignatura9.SelectedValue,
                                   ListaAsignatura10.SelectedValue, ListaAsignatura11.SelectedValue};
        String[] NombreProfesor = { ListaProfesor1.SelectedValue, ListaProfesor2.SelectedValue, ListaProfesor3.SelectedValue, ListaProfesor4.SelectedValue, ListaProfesor5.SelectedValue
                                  ,ListaProfesor6.SelectedValue,ListaProfesor7.SelectedValue,ListaProfesor8.SelectedValue,ListaProfesor9.SelectedValue,ListaProfesor10.SelectedValue,ListaProfesor11.SelectedValue};

        String NombreAsignatura = "";
        try
        {
            for (int i = 0; i <= valorCombo; i++)
            {
                String NombreGrupo = NombreGrup.SelectedValue;
                String turno = ListaTurno.Text;
                NombreAsignatura = ComboAsignatura[i];
                SacarIdGrupo(NombreGrupo);
                IDGrupo = Int32.Parse(LabelGrupo.Text);
                ScarIDProfesor(NombreProfesor[i]);
                IDProfesor = Int32.Parse(LabelIDPersonal.Text);
                SacarIdAsigantura(NombreAsignatura);
                IDAsignatura = Int32.Parse(LabelIDAsignatura.Text);
                sentencia = "insert into AsignaturaImpartida(id_grupo,id_asignatura,id_profesor,turno) Values(" + IDGrupo + "," + IDAsignatura + "," + IDProfesor + ",'" + turno + "')";
                InsertarRegistro(sentencia);
                LabelAsignaturasRepetidas.Text = "Registrar";
            }
        }
        catch (Exception ex)
        {
            LabelAsignaturasRepetidas.Text = "ERROR PAPU   " + ex;
        }
    }

    private void ValidarQueNoSeRepitan()
    {
        int valorCombo = 0;//Guardara el valor que este dentro del combo de las materias
        valorCombo = Int32.Parse(ListaTotalAsignaturas.Text);
        int numero = 0;//Se utilizara para saber cuantas se repiten
        String[] ComboAsignatura = { ListaAsignatura1.SelectedValue, ListaAsignatura2.SelectedValue, ListaAsignatura3.SelectedValue, ListaAsignatura4.SelectedValue,
                                   ListaAsignatura5.SelectedValue,ListaAsignatura6.SelectedValue,ListaAsignatura7.SelectedValue,ListaAsignatura8.SelectedValue,ListaAsignatura9.SelectedValue,
                                   ListaAsignatura10.SelectedValue, ListaAsignatura11.SelectedValue};
        String[] NombreProfesor = { ListaProfesor1.SelectedValue, ListaProfesor2.SelectedValue, ListaProfesor3.SelectedValue, ListaProfesor4.SelectedValue, ListaProfesor5.SelectedValue
                                  ,ListaProfesor6.SelectedValue,ListaProfesor7.SelectedValue,ListaProfesor8.SelectedValue,ListaProfesor9.SelectedValue,ListaProfesor10.SelectedValue,ListaProfesor11.SelectedValue};
        for (int i = 0; i <= valorCombo; i++)
        {
            for (int j = 0; j <= valorCombo; j++)
            {
                if (ComboAsignatura[i].Equals(ComboAsignatura[j]))
                {

                    numero = numero + 1;

                }

            }
        }
        if (numero == (valorCombo + 1))
        {
            BtnGuardar.Text = "Aceptar";


        }
        else
        {
            LabelAsignaturasRepetidas.Text = "Hay materias repetidas, verifica por favor";
        }

    }

    private void InsertarRegistro(string sentencia)
    {
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        catch
        {

        }
    }

    private void SacarIdAsigantura(string NombreAsignatura)
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select id_asignatura from asignatura where nombre='" + NombreAsignatura + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            LabelIDAsignatura.Text = "" + registro["ID_ASIGNATURA"];


        }
        else { }
        conexion.Close();

    }

    private void SacarIdGrupo(String Nombre)
    {

        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select id_GRUPO from GRUPO where nombre='" + Nombre + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            LabelGrupo.Text = "" + registro["ID_GRUPO"];


        }
        else { }
        conexion.Close();


    }

    private void ScarIDProfesor(String Nombre)
    {

        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select id_personal from personalAdministrativo where nombre='" + Nombre + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            LabelIDPersonal.Text = "" + registro["ID_Personal"];


        }
        else { }
        conexion.Close();


    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        BtnGuardar.Visible = true;
        LabelGrupo.Text = NombreGrup.Text;
        FiltarAsignaturas(NombreGrup.Text);
        LabelAsign1.Visible = true;
        ListaAsignatura1.Visible = true;
        LabelProf1.Visible = true;
        ListaProfesor1.Visible = true;
        int ValorEncontrado = Int32.Parse(ListaTotalAsignaturas.SelectedValue);

        switch (ValorEncontrado)
        {
            case 1:
                LabelAsign1.Visible = true;
                ListaAsignatura1.Visible = true;
                LabelProf1.Visible = true;
                ListaProfesor1.Visible = true;
                OcultarCampos();

                break;
            case 2:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                break;
            case 3:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                break;
            case 4:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                break;
            case 5:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                break;

            case 6:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                break;
            case 7:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                LabelProf7.Visible = true;
                ListaProfesor7.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaProfesor7.Visible = true;
                LabelAsign7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaAsignatura7.Visible = true;

                break;
            case 8:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                LabelProf7.Visible = true;
                ListaProfesor7.Visible = true;
                LabelProf8.Visible = true;
                ListaProfesor8.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaProfesor7.Visible = true;
                LabelAsign7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaProfesor8.Visible = true;
                LabelAsign8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaAsignatura8.Visible = true;

                break;
            case 9:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                LabelProf7.Visible = true;
                ListaProfesor7.Visible = true;
                LabelProf8.Visible = true;
                ListaProfesor8.Visible = true;
                LabelProf9.Visible = true;
                ListaProfesor9.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaProfesor7.Visible = true;
                LabelAsign7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaProfesor8.Visible = true;
                LabelAsign8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaProfesor9.Visible = true;
                LabelAsign9.Visible = true;
                ListaAsignatura9.Visible = true;
                ListaAsignatura9.Visible = true;


                break;
            case 10:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                LabelProf7.Visible = true;
                ListaProfesor7.Visible = true;
                LabelProf8.Visible = true;
                ListaProfesor8.Visible = true;
                LabelProf9.Visible = true;
                ListaProfesor9.Visible = true;
                LabelProf10.Visible = true;
                ListaProfesor10.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaProfesor7.Visible = true;
                LabelAsign7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaProfesor8.Visible = true;
                LabelAsign8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaProfesor9.Visible = true;
                LabelAsign9.Visible = true;
                ListaAsignatura9.Visible = true;
                ListaAsignatura9.Visible = true;
                ListaProfesor10.Visible = true;
                LabelAsign10.Visible = true;
                ListaAsignatura10.Visible = true;
                ListaAsignatura10.Visible = true;


                break;
            case 11:
                OcultarCampos();
                LabelAsign2.Visible = true;
                ListaAsignatura2.Visible = true;
                LabelProf2.Visible = true;
                ListaProfesor2.Visible = true;
                LabelAsign3.Visible = true;
                ListaAsignatura3.Visible = true;
                LabelProf3.Visible = true;
                ListaProfesor3.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf4.Visible = true;
                ListaProfesor4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelProf6.Visible = true;
                ListaProfesor6.Visible = true;
                LabelProf7.Visible = true;
                ListaProfesor7.Visible = true;
                LabelProf8.Visible = true;
                ListaProfesor8.Visible = true;
                LabelProf9.Visible = true;
                ListaProfesor9.Visible = true;
                LabelProf10.Visible = true;
                ListaProfesor10.Visible = true;
                LabelProf11.Visible = true;
                ListaProfesor11.Visible = true;
                ListaProfesor4.Visible = true;
                LabelAsign4.Visible = true;
                ListaAsignatura4.Visible = true;
                ListaAsignatura4.Visible = true;
                LabelProf5.Visible = true;
                ListaProfesor5.Visible = true;
                LabelAsign5.Visible = true;
                ListaAsignatura5.Visible = true;
                ListaProfesor6.Visible = true;
                LabelAsign6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaAsignatura6.Visible = true;
                ListaProfesor7.Visible = true;
                LabelAsign7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaAsignatura7.Visible = true;
                ListaProfesor8.Visible = true;
                LabelAsign8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaAsignatura8.Visible = true;
                ListaProfesor9.Visible = true;
                LabelAsign9.Visible = true;
                ListaAsignatura9.Visible = true;
                ListaAsignatura9.Visible = true;
                ListaProfesor10.Visible = true;
                LabelAsign10.Visible = true;
                ListaAsignatura10.Visible = true;
                ListaAsignatura10.Visible = true;
                ListaProfesor11.Visible = true;
                LabelAsign11.Visible = true;
                ListaAsignatura11.Visible = true;
                ListaAsignatura11.Visible = true;


                break;


        }
    }

    private void OcultarCampos()
    {
        LabelAsign2.Visible = false;
        LabelAsign3.Visible = false;
        LabelAsign4.Visible = false;
        LabelAsign5.Visible = false;
        LabelAsign6.Visible = false;
        LabelAsign7.Visible = false;
        LabelAsign8.Visible = false;
        LabelAsign9.Visible = false;
        LabelAsign10.Visible = false;
        LabelAsign11.Visible = false;
        ListaAsignatura2.Visible = false;
        ListaAsignatura3.Visible = false;
        ListaAsignatura4.Visible = false;
        ListaAsignatura5.Visible = false;
        ListaAsignatura6.Visible = false;
        ListaAsignatura7.Visible = false;
        ListaAsignatura8.Visible = false;
        ListaAsignatura9.Visible = false;
        ListaAsignatura10.Visible = false;
        ListaAsignatura11.Visible = false;
        LabelProf2.Visible = false;
        LabelProf3.Visible = false;
        LabelProf4.Visible = false;
        LabelProf5.Visible = false;
        LabelProf6.Visible = false;
        LabelProf7.Visible = false;
        LabelProf8.Visible = false;
        LabelProf9.Visible = false;
        LabelProf10.Visible = false;
        LabelProf11.Visible = false;
        ListaProfesor2.Visible = false;
        ListaProfesor3.Visible = false;
        ListaProfesor4.Visible = false;
        ListaProfesor5.Visible = false;
        ListaProfesor6.Visible = false;
        ListaProfesor7.Visible = false;
        ListaProfesor8.Visible = false;
        ListaProfesor9.Visible = false;
        ListaProfesor10.Visible = false;
        ListaProfesor11.Visible = false;
        LabelConfirmacion1.Visible = false;
        LabelConfirmacion2.Visible = false;
        LabelConfirmacion3.Visible = false;
        LabelConfirmacion4.Visible = false;
        LabelConfirmacion5.Visible = false;
        LabelConfirmacion6.Visible = false;
        LabelConfirmacion7.Visible = false;
        LabelConfirmacion8.Visible = false;
        LabelConfirmacion9.Visible = false;
        LabelConfirmacion10.Visible = false;
        LabelConfirmacion11.Visible = false;

    }
    protected void NombreGrup_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelGrupo.Text = NombreGrup.Text;
        FiltarAsignaturas(NombreGrup.Text);
    }

    private void FiltarAsignaturas(string Numero)
    {
        SacarIDGrupo(Numero);

    }

    private void SacarIDGrupo(string Numero)
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select grado from grupo where nombre='" + Numero + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            LabelIDGrupo.Text = "" + registro["GRADO"];


        }

        else { }
        Grado = LabelIDGrupo.Text;
        NombreAsignatura.FilterExpression = "Grado='" + Grado + "'";
        conexion.Close();
    }


    protected void BtnCancelar_Click(object sender, EventArgs e)
    {
        OcultarCampos();
        BtnGuardar.Text = "Guardar";
        BtnCancelar.Visible = false;
        LabelAsignaturasRepetidas.Text = "";
        ListaTotalAsignaturas.Text = "1";
    }
}