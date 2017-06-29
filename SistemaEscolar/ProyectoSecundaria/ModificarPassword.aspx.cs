using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    public String pass="";
    public String confirmacion="";
    public String usuario = "";
    public String comando = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["Usuario"] != null)//Se recibe el numero de orden de compra
        {
            txtusuario.Text = Request.Params["Usuario"];//Se llena la caja de texto numero de orden de compra con el valor que se recibio.

        }
    }
    protected void BtnAceptar_Click(object sender, EventArgs e)
    {
        usuario = txtusuario.Text;
        pass = txtPass.Text;
        confirmacion = txtConfirmacion.Text;

        if(pass.Length>=8){

            if (pass.Equals(confirmacion))
            {
                VerificarLaTabla();
                ModificarContrasena();
            }
            else
            {
                LabelError.Text = "Las contraseñas no coinciden, verificalas";
            }
        }
        else
        {
            LabelError.Text = "La contraseña debe contener mínimo 8 caracteres";
        }


       
    }

  
    private void VerificarLaTabla()
    {
        int matricula = 0;
        String pruebaMatricula = usuario.Replace("2","");
        try { 
        matricula = Int32.Parse(pruebaMatricula);
        comando= "Update alumno set contrasena ='"+txtPass.Text+"' where matricula="+usuario;
            }
        catch (Exception ex)
        {
            comando = "Update PersonalAdministrativo set contrasena ='" + txtPass.Text + "' where usuario='" + usuario+"'";
        }
    }
    private void ModificarContrasena()
    {
        try
        {

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando1 = new SqlCommand(comando, conexion);
            comando1.ExecuteNonQuery();
            conexion.Close();
           Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            LabelError.Text = "ERROR " + ex;
        }
    }
    

}