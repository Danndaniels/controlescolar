<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormlariodePruebas.aspx.cs" Inherits="FormlariodePruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 62px;
            height: 52px;
        }
        .auto-style4 {
            width: 109px;
            height: 52px;
        }
        .auto-style6 {
            width: 62px;
            height: 77px;
        }
        .auto-style7 {
            width: 109px;
            height: 77px;
        }
        .auto-style8 {
            height: 77px;
        }
        .auto-style9 {
            width: 62px;
            height: 47px;
        }
        .auto-style10 {
            width: 109px;
            height: 47px;
        }
        .auto-style11 {
            height: 47px;
        }
        .auto-style12 {
            height: 54px;
        }
        .auto-style13 {
            height: 52px;
        }
        .auto-style14 {
            height: 77px;
            width: 145px;
        }
        .auto-style15 {
            height: 52px;
            width: 145px;
        }
        .auto-style16 {
            height: 47px;
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
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
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" Text="Registrar" class="btn btn-info btn-effect" OnClick="Button1_Click"/>
                    </td>
                    <td class="auto-style15"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style13">
                        <asp:Button ID="BotonModificar" runat="server" Text="Modificar" OnClick="Button2_Click" class="btn btn-info btn-effect"/>
                        <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" Visible="False" />
                    </td>
                    <td class="auto-style13">
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
                        <asp:Label ID="Label2" runat="server" ForeColor="#0000CC" Text="Ciclo actual modificado"></asp:Label>
                    </td>
                </tr>
            </table>
        </center>
    </form>
</body>
</html>
