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

public partial class RAlumno : System.Web.UI.Page
{
    public String Matricula, Contrasena, Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Direccion, Telefono, Correo, Curp, Tutor, TipoDeSangre, NumeroSeguroSocial, Grupo, Fecha1, Fecha2, RFC, turno;
    public int Fecha3, IdGrupo;//El id de grupo se recuperara para de lo que se escogio en el combo
    public String BuscarAlumno = "";//En esta variable se guardara la matricula del alu
    public String pruebaMatricul;
    int BusquedaAvanzada;//Se utilizara para la consulta avanzada
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        Nombre = txtNombre.Text;
        ApellidoPaterno = txtApePat.Text;
        ApellidoMaterno = txtApeMat.Text;
        Sexo = comboSexo.SelectedItem.Text;
        Direccion = txtDireccion.Text;
        Telefono = txtTelefono.Text;
        Correo = txtCorreo.Text;
        Curp = txtCurp.Text;
        RFC = txtRFC.Text;
        Tutor = txtTutor.Text;
        TipoDeSangre = txtTipoSangre.Text;
        NumeroSeguroSocial = txtNumeroSeguro.Text;
        Fecha1 = ComboFecha1.SelectedItem.Text;
        Fecha2 = ComboFecha2.SelectedItem.Text;
        turno = Comboturno.SelectedItem.Text;
        Grupo = ComboGrupo.SelectedValue;


    }
    protected void BtnAltas_Click(object sender, EventArgs e)
    {
        String ConvertirMes = "";//Convertir el mes a numero
        String FechaEnNumero = "";//La fecha en formato DD/MM/AAAA
        if (Fecha2.Equals("Enero")) { ConvertirMes = "01"; }
        else if (Fecha2.Equals("Febrero")) { ConvertirMes = "02"; }
        else if (Fecha2.Equals("Marzo")) { ConvertirMes = "03"; }
        else if (Fecha2.Equals("Abril")) { ConvertirMes = "04"; }
        else if (Fecha2.Equals("Mayo")) { ConvertirMes = "05"; }
        else if (Fecha2.Equals("Junio")) { ConvertirMes = "06"; }
        else if (Fecha2.Equals("Julio")) { ConvertirMes = "07"; }
        else if (Fecha2.Equals("Agosto")) { ConvertirMes = "08"; }
        else if (Fecha2.Equals("Septiembre")) { ConvertirMes = "09"; }
        else if (Fecha2.Equals("Octubre")) { ConvertirMes = "10"; }
        else if (Fecha2.Equals("Noviembre")) { ConvertirMes = "11"; }
        else if (Fecha2.Equals("Diciembre")) { ConvertirMes = "12"; }
        try { Fecha3 = Int32.Parse(txtFecha3.Text); }
        catch { LabelErrorFecha.Text = "ERROR"; }
        FechaEnNumero = Fecha1 + "/" + ConvertirMes + "/" + Fecha3;
        SacarIdGrupo();//Metodo para sacar ID de lo que contenga el combo grupo
        GenerarMatricula();//Metodo para generar Matricula
        GenerarContrasena();//Metodo para generar Contraseña
        String SentenciaRegistro = "Insert into Alumno Values('" + Matricula + "','" + Contrasena + "','" + Nombre + "','" + ApellidoPaterno +
            "','" + ApellidoMaterno + "','" + Sexo + "','" + Direccion + "','" + Telefono + "','" + Correo + "','" + Curp + "','" + RFC + "','" + Tutor + "','" + TipoDeSangre + "','" + NumeroSeguroSocial + "'," + IdGrupo + ",'" + FechaEnNumero + "','" + turno + "');";

        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(SentenciaRegistro, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            SentenciaBase.Text = SentenciaRegistro;
            Label1.Text = SentenciaRegistro;
            SentenciaBase.Text = "SI PRRO";
        }
        catch (Exception ex)
        {
            SentenciaBase.Text = "NO PRRO" + ex;
            Label1.Text = SentenciaRegistro;
        }
        LimpiarCampos();
    

    }

    private void LimpiarCampos()
    {
       Crearcorreo();
        txtNombre.Text = "";
        txtApePat.Text = "";
        txtApeMat.Text = "";
        Sexo = comboSexo.SelectedItem.Text;
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtCorreo.Text = "";
        txtCurp.Text = "";
        txtRFC.Text = "";
        txtTutor.Text = "";
        txtTipoSangre.Text = "";
        txtNumeroSeguro.Text = "";
        LabelConfirmacion.Text = "Registro exitoso";
       
    }

    private void Crearcorreo()
    {
       
        MailMessage msj = new MailMessage();
        SmtpClient cli = new SmtpClient();
        String email = txtCorreo.Text.ToString();
        String name = txtNombre.Text.ToString();
        String app_p = txtApePat.Text.ToString();
        String app_m = txtApeMat.Text.ToString();
        String completo = name + " " + app_p + " " + app_m;
        String pass = Contrasena;
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
        mailBody.Append("Usuario: " + Matricula);
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

    private void SacarIdGrupo()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select id_grupo from grupo where nombre='" + Grupo + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
            LabelGrupo.Text = "" + registro["id_grupo"];
        else
            conexion.Close();
        IdGrupo = Int32.Parse(LabelGrupo.Text);
    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }
    protected void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }





    private void GenerarContrasena()
    {
        Random rnd = new Random();
        int id = rnd.Next(9999) + 1;
        Contrasena = "" + id;
        LabelContrasena.Text = Contrasena;
    }

    private void GenerarMatricula()
    {
        pruebaMatricul = ComboCiclo.SelectedValue;
        pruebaMatricul = pruebaMatricul.Replace("20", "");
        pruebaMatricul = pruebaMatricul.Replace("-", "");
        Matricula = pruebaMatricul;
        SacarIdGrupo();
        if (turno.Equals("Matutino"))
        {
            Matricula = Matricula + IdGrupo + 11;
        }
        else
        {
            Matricula = Matricula + IdGrupo + 22;
        }
        Random rnd = new Random();
        int id = rnd.Next(9999) + 1;
        Matricula = Matricula + id;
        Label2.Text = Matricula;
    }
    

    protected void BtnBusquedaAvanzada_Click(object sender, EventArgs e)
    {


    }

    private void SacarIdGrupo1(string Grado)
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        string SENTENCIA = "select id_grupo from grupo where nombre='" + Grado + "'";
        SqlCommand comando = new SqlCommand(SENTENCIA, conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
            LabelGrupo.Text = "" + registro["id_grupo"];
        else
            conexion.Close();
        IdGrupo = Int32.Parse(LabelGrupo.Text);
    }




}