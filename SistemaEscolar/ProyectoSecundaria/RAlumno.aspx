<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="RAlumno.aspx.cs" Inherits="RAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <center>
    <form id="form1" runat="server">
    <div>
     <table border="0" style="height: 473px; width: 558px">
  <tr>
    <td colspan="3"><center>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ciclo escolar:<asp:DropDownList ID="ComboCiclo" runat="server" DataSourceID="CicloEscolar" DataTextField="Nombre" DataValueField="Nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="CicloEscolar" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [CicloEscolar] ORDER BY [Id_Ciclo] DESC"></asp:SqlDataSource>
        </center></td>
  </tr>
  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td class="auto-style4">
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td class="auto-style4">
        <asp:Label ID="LabelContrasena" runat="server" Text="Label" Visible="False"></asp:Label>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
         <tr>
    <td class="auto-style1">Nombre</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Nombre" BorderColor="#0066cc"></asp:TextBox>
             </td>
    <td class="auto-style3">
        <asp:Label ID="LabelConfirmacion" runat="server"></asp:Label>
             </td>
  </tr>
  <tr>
    <td class="auto-style1">Apellido Paterno</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtApePat" runat="server" class="form-control" placeholder="Apellido Paterno" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Apellido Materno</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtApeMat" runat="server" class="form-control" placeholder="Apellido Materno" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Sexo</td>
    <td class="auto-style4">
        <asp:DropDownList ID="comboSexo" runat="server" class="select jelect" BorderColor="#0066cc">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Femenino</asp:ListItem>
        </asp:DropDownList>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Dirección</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtDireccion" runat="server" class="form-control" placeholder="Dirección" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Telefono</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtTelefono" runat="server" class="form-control" placeholder="Telefono" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Correo</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtCorreo" runat="server" class="form-control" placeholder="Correo" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">
        <asp:Button ID="BtnAltas" class="btn btn-info btn-effect" runat="server" Text="Registrar" OnClick="BtnAltas_Click" style="height: 26px" />
             </td>
  </tr>
  <tr>
    <td class="auto-style1">CURP</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtCurp" runat="server" class="form-control" placeholder="CURP" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
          <tr>
    <td class="auto-style1">RFC</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtRFC" runat="server" class="form-control" placeholder="RFC" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Tutor</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtTutor" runat="server" class="form-control" placeholder="Tutor" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Tipo de sangre</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtTipoSangre" runat="server" class="form-control" placeholder="Tipo de sangre" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Numero de seguro social</td>
    <td class="auto-style4">
        <asp:TextBox ID="txtNumeroSeguro" runat="server" class="form-control" placeholder="Numero de seguro" BorderColor="#0066cc"></asp:TextBox>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">Grupo</td>
    <td class="auto-style4">
        <asp:DropDownList ID="ComboGrupo" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [Grupo]"></asp:SqlDataSource>
        <asp:Label ID="LabelGrupo" runat="server"></asp:Label>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
         <tr>
    <td class="auto-style1">Fecha de Nacimiento&nbsp;</td>
    <td class="auto-style4">
        
        <asp:DropDownList ID="ComboFecha1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>26</asp:ListItem>
            <asp:ListItem>27</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>29</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>31</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ComboFecha2" runat="server">
            <asp:ListItem>Enero</asp:ListItem>
            <asp:ListItem>Febrero</asp:ListItem>
            <asp:ListItem>Marzo</asp:ListItem>
            <asp:ListItem>Abril</asp:ListItem>
            <asp:ListItem>Mayo</asp:ListItem>
            <asp:ListItem>Junio</asp:ListItem>
            <asp:ListItem>Julio</asp:ListItem>
            <asp:ListItem>Agosto</asp:ListItem>
            <asp:ListItem>Septiembre</asp:ListItem>
            <asp:ListItem>Octubre</asp:ListItem>
            <asp:ListItem Value="Noviembre"></asp:ListItem>
            <asp:ListItem>Diciembre</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtFecha3" runat="server" Width="58px" placeholder="AAAA"></asp:TextBox>
        
        <asp:Label ID="LabelErrorFecha" runat="server" ForeColor="Red"></asp:Label>
        
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
         <tr>
    <td class="auto-style1">Turno&nbsp;</td>
    <td class="auto-style4">
        <asp:DropDownList ID="Comboturno" runat="server" class="select jelect">
            <asp:ListItem>Matutino</asp:ListItem>
            <asp:ListItem>Vespertino</asp:ListItem>
        </asp:DropDownList>
      </td>
    <td class="auto-style3">&nbsp;</td>
  </tr>
</table>
        <br />
        <br />
        <br />

        <asp:Label ID="SentenciaBase" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </div>
    </form>
        </center>

</asp:Content>

