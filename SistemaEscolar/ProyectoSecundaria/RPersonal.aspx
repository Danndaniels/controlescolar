<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="RPersonal.aspx.cs" Inherits="RPersonal" %>

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
        <table border="0" class="auto-style1">
            <tr>
                <td colspan="3"> <center>Ciclo escolar:<asp:DropDownList ID="ComboCiclo" runat="server" DataSourceID="CicloEscolar" DataTextField="Nombre" DataValueField="Nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="CicloEscolar" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [CicloEscolar] ORDER BY [Id_Ciclo] DESC"></asp:SqlDataSource>
                </center></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="LabelUsuario" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="LabelPassword" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Nombre</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="LabelConfirmacion" runat="server" ForeColor="Blue"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Apellido Paterno</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtApePat" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Apellido Materno</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtApeMat" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Dirección</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Telefono</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Correo</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="BtnAltas" class="btn btn-info btn-effect" runat="server" Text="Registrar" OnClick="BtnAltas_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Cedula profesiona</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Puesto</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ComboPuesto" runat="server">
                        <asp:ListItem>Profesor</asp:ListItem>
                        <asp:ListItem>Personal administrativo</asp:ListItem>
                        <asp:ListItem>Orientador</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Numero de seguro social</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNumeroSeguro" runat="server" Width="159px"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">CURP</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCurp" runat="server" OnTextChanged="TextBox10_TextChanged" Width="163px"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">RFC</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtRFC" runat="server" Width="158px" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
       
    </div>
    </form>
         </center>
</asp:Content>

