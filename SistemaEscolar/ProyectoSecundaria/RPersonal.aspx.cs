using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Net.Security;

public partial class RPersonal : System.Web.UI.Page
{
    public String TipoPersonal;//Se guardara para las primeras letras del usuario
    public String Usuario, Password;// Variables para usuario y contraseña
    public String Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, Telefono, Correo, Cedula, Puesto, NumeroSeguro, Curp, Rfc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        Nombre = txtNombre.Text;
        ApellidoPaterno = txtApePat.Text;
        ApellidoMaterno = txtApeMat.Text;
        Direccion = txtDireccion.Text;
        Telefono = txtTelefono.Text;
        Correo = txtCorreo.Text;
        Cedula = txtCedula.Text;
        Puesto = ComboPuesto.SelectedValue;
        Curp = txtCurp.Text;
        Rfc = txtRFC.Text;
        NumeroSeguro = txtNumeroSeguro.Text;

    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }
    protected void BtnAltas_Click(object sender, EventArgs e)
    {
        GenerarUsuario();
        String SentenciaRegistro = "insert into PersonalAdministrativo (Usuario,Contrasena,Nombre,ApellidoPaterno,ApellidoMaterno,Direccion,Telefono,CorreoElectronico,Cedula_profesional,Puesto,NumeroSeguro,Curp,RFC) values('" + Usuario + "','" + Password + "','" + Nombre + "','" + ApellidoPaterno + "','" + ApellidoMaterno + "','" + Direccion + "','" + Telefono + "','" + Correo + "','" + Cedula + "','" + Puesto + "','" + NumeroSeguro + "','" + Curp + "','" + Rfc + "');";
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LabelPassword.Text = "Realizado";
            GenerarEmail();
            LimpiarYMensaje();
        }
        catch (Exception ex)
        {
            LabelPassword.Text = "ERROR " + SentenciaRegistro;
        }
    }

    private void GenerarEmail()
    {

        MailMessage msj = new MailMessage();
        SmtpClient cli = new SmtpClient();
        String email = txtCorreo.Text.ToString();
        String name = txtNombre.Text.ToString();
        String app_p = txtApePat.Text.ToString();
        String app_m = txtApeMat.Text.ToString();
        String completo = name + " " + app_p + " " + app_m;
        String pass = Password;
        StringBuilder mailBody = new StringBuilder();
        mailBody.Append("<div class='.PageContainer'>");
        mailBody.Append("<div id='ContentContainer'>");
        mailBody.Append("<div id='LeftPane' >");
        mailBody.Append("<img src='' />");
        mailBody.Append("<br />");
        mailBody.Append("<br />");
        mailBody.Append("</div>");
        mailBody.Append("<div id='RightPane' style=' font-family: Arial; font-style: none; font-size: 12px;'>");
        mailBody.Append("<div id=Contenido style=' font-family: Verdana; font-style: italic; font-size: 13px;'>");
        mailBody.Append("<h2>¡Hola! " + completo + "");
        mailBody.Append("<br />");
        mailBody.Append("<p> Te damos la bienvenida al sistema de control escolar, para ingresar a la platafroma deberas ingresar los datos que se te proporcionan: </p>");
        mailBody.Append("<br/>");
        mailBody.Append("<div id='Datos' style=' line-height: 16pt '>");
        mailBody.Append("Usuario: " + Usuario);
        mailBody.Append("<br/>");
        mailBody.Append("<br/>");
        mailBody.Append("Contrase&ntilde;a: " + pass);
        mailBody.Append("<br/>");
        mailBody.Append("<br/>");
        mailBody.Append("</div>");
        mailBody.Append("</div>");
        mailBody.Append("<br/>");
        mailBody.Append("<div id='p1' style=' text-align: justify; font-family: Arial; font-style: none; font-size: 12px;  '>");
        mailBody.Append("<p>. </p>");
        mailBody.Append("</div>");
        mailBody.Append("<div style='clear: both;'></div>");
        mailBody.Append("</div>");
        mailBody.Append("<div id='FooterContainer' style=' text-align: justify; font-family: Arial; font-style: none; font-size: 12px;'>");
        mailBody.Append("<div id='FooterPane'>");
        mailBody.Append("</div>");
        mailBody.Append("</div>");
        mailBody.Append("</div>");
        msj.From = new MailAddress("secundaria270prueba@hotmail.com");
        msj.To.Add(new MailAddress(email));
        msj.Subject = "Bienvenido".ToUpper();
        msj.IsBodyHtml = true;
        msj.BodyEncoding = System.Text.Encoding.UTF8;
        msj.Body = "****************************************************";
        msj.Body = "<HTML><head><meta http-equiv='Content-Type' content='text/html; charset=ISO-8859-1'><link href='../Syles/mail.css' rel='stylesheet' type='text/css' /></head><body style=' background-image: url(Images/LogoSTIE1.png);'> " + mailBody.ToString() + "</body></HTML>";
        ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate,
            X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        cli.Send(msj);  
    }

    private void LimpiarYMensaje()
    {
        txtNombre.Text="";
        txtApePat.Text = "";
        txtApeMat.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtCorreo.Text = "";
        txtCedula.Text = "";
        txtCurp.Text = "";
        txtRFC.Text = "";
        txtNumeroSeguro.Text = "";
        LabelConfirmacion.Text = "Registro exitoso";

    }

    private void GenerarUsuario()
    {
        String valorCombo = ComboPuesto.Text;
        if (valorCombo.Equals("Profesor"))
        {
            TipoPersonal = "Pro";
        }
        else if (valorCombo.Equals("Personal administrativo"))
        {
            TipoPersonal = "Per";
        }
        else if (valorCombo.Equals("Orientador"))
        {
            TipoPersonal = "Or";
        }
        String Ciclo = ComboCiclo.Text;
        Ciclo = Ciclo.Replace("20", "");
        Ciclo = Ciclo.Replace("-", "");
        Random rnd = new Random();
        int id = rnd.Next(9999) + 1;
        Usuario = TipoPersonal + Ciclo + id;
        GenerarPassword();
    }

    private void GenerarPassword()
    {
        Random rnd = new Random();
        int id = rnd.Next(9999) + 1;
        Password = "" + id;
    }


    
}