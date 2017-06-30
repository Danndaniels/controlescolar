using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Net.Security;
using System.Data.SqlClient;

public partial class RPassword : System.Web.UI.Page
{

    public String correo = "";
    public String confirmacion = "";
    public String usuario = "";
    public String comando = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void BtnAceptar_Click(object sender, EventArgs e)
    {
        usuario = txtUsuario.Text;
        correo = txtCorreo.Text;

       
                VerificarLaTabla();
             


    }


    private void VerificarLaTabla()
    {
        Random rnd = new Random();
        int id = rnd.Next(9999) + 1;
        int matricula = 0;
        String pruebaMatricula = usuario.Replace("2", "");
        try
        {
            matricula = Int32.Parse(pruebaMatricula);
            comando = "Update alumno set contrasena ='" + id + "' where matricula=" + usuario;
        }
        catch (Exception ex)
        {
            comando = "Update PersonalAdministrativo set contrasena ='" + id+ "' where usuario='" + usuario + "'";
        }
        ModificarContrasena(id);
       
    }

    private void EnviarCorreo(int id)
    {
          MailMessage msj = new MailMessage();
        SmtpClient cli = new SmtpClient();
        String email = txtCorreo.Text.ToString();
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
        mailBody.Append("<h1>Recuperacion de contraseña</h1>");
        mailBody.Append("<br />");
        mailBody.Append("<p> Deberas ingresar al sistema con la siguiente infromación</p>");
        mailBody.Append("<br/>");
        mailBody.Append("<div id='Datos' style=' line-height: 16pt '>");
        mailBody.Append("Usuario: " + txtUsuario.Text);
        mailBody.Append("<br/>");
        mailBody.Append("<br/>");
        mailBody.Append("Contrase&ntilde;a: " + id);
        mailBody.Append("<br/>");
        mailBody.Append("<br/>");
        mailBody.Append("</div>");
        mailBody.Append("</div>");
        mailBody.Append("<br/>");
        mailBody.Append("<div id='p1' style=' text-align: justify; font-family: Arial; font-style: none; font-size: 11px;  '>");
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
        msj.Subject = "Recuperacion de contraseña".ToUpper();
        msj.IsBodyHtml = true;
        msj.BodyEncoding = System.Text.Encoding.UTF8;
        msj.Body = "****************************************************";
        msj.Body = "<HTML><head><meta http-equiv='Content-Type' content='text/html; charset=ISO-8859-1'><link href='../Syles/mail.css' rel='stylesheet' type='text/css' /></head><body style=' background-image: url(Images/LogoSTIE1.png);'> " + mailBody.ToString() + "</body></HTML>";
        ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate,
            X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        cli.Send(msj);

    }
    private void ModificarContrasena(int id)
    {
        try
        {

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando1 = new SqlCommand(comando, conexion);
            comando1.ExecuteNonQuery();
            conexion.Close();
            EnviarCorreo(id);
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            LabelError.Text = "ERROR " + ex;
        }
    }


}