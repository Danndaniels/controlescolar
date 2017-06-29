<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="RCiclo.aspx.cs" Inherits="RCiclo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <form id="form1" runat="server">
   
    <div>
        
         <center>
          
            <table border="0" style="height: 274px; width: 694px">
                <tr>
                    <td colspan="3" class="auto-style12"><center>Registrar Ciclo escolar</center></td>
                    <td width="46" class="auto-style12"></td>
                    <td width="73" class="auto-style12"></td>
                    <td colspan="2" class="auto-style12"><center>Modificar Ciclo EScolar Actual</center></td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre</td>
                    <td class="auto-style7">
                        20<asp:TextBox ID="Txt1" runat="server" Width="23px" Height="16px"></asp:TextBox>-20<asp:TextBox ID="Txt2" runat="server" Width="24px" Height="16px"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="Label1" runat="server" ForeColor="#0000CC" Text="Ciclo registrado" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td width="144" class="auto-style8">ModificarCicloActual</td>
                    <td width="119" class="auto-style8">
                        <asp:Label ID="CicloEscolarActual" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="height: 119px"></td>
                    <td class="auto-style4" style="height: 119px">
                        <asp:Button ID="Button1" runat="server" Text="Registrar" class="btn btn-info btn-effect" OnClick="Button1_Click"/>
                    </td>
                    <td class="auto-style15" style="height: 119px"></td>
                    <td class="auto-style13" style="height: 119px"></td>
                    <td class="auto-style13" style="height: 119px"></td>
                    <td class="auto-style13" style="height: 119px">
                        <asp:Button ID="BotonModificar" runat="server" Text="Modificar" OnClick="Button2_Click" class="btn btn-info btn-effect"/>
                        <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" Visible="False" class="btn-danger" Height="31px" Width="112px"/>
                    </td>
                    <td class="auto-style13" style="height: 119px">
                        <asp:DropDownList ID="Combo" runat="server" DataSourceID="Ciclo" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="Ciclo" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [CicloEscolar]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11">
                       
                    </td>
                </tr>
            </table>
        </center>

    </div>
    </form>
</asp:Content>

