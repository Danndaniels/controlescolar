<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="AgregarAsignatura.aspx.cs" Inherits="AgregarAsignatura" %>

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
    &nbsp;<asp:SqlDataSource ID="NombreGrupo" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [Grupo]"></asp:SqlDataSource>
        <br />
        <table border="0" style="height: 59px; width: 667px">
            <tr>
                <td class="auto-style24">Grupo:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="NombreGrup" runat="server" DataSourceID="NombreGrupo" DataTextField="Nombre" DataValueField="Nombre" AutoPostBack="True" OnSelectedIndexChanged="NombreGrup_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:Label ID="LabelIDGrupo" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style3">Turno</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ListaTurno" runat="server">
                        <asp:ListItem>Matutino</asp:ListItem>
                        <asp:ListItem>Vespertino</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style25">Numero de asignaturas</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ListaTotalAsignaturas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
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
                    </asp:DropDownList>
                </td>
                <td class="auto-style26">
                   
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="Button1_Click" Visible="False" />
                   
                &nbsp;&nbsp;
                    <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" Visible="False" />
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                   
                </td>
            </tr>
            
        </table>
        <asp:SqlDataSource ID="NombreAsignatura" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre], [grado] FROM [Asignatura]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="EscogerProfesor" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT NOMBRE FROM PersonalAdministrativo WHERE (Puesto = @Puesto)">
            <SelectParameters>
                <asp:Parameter DefaultValue="PROFESOR" Name="Puesto" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="LabelAsignaturasRepetidas" runat="server"></asp:Label>
        <br />
      
        <asp:Label ID="LabelSentenciaa" runat="server" ForeColor="Red" Text=""></asp:Label>
        <br />
        <table border="0" style="height: 376px; width: 940px">
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign1" runat="server" Text="Asignatura:"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura1" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf1" runat="server" Text="Profesor"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor1" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Height="16px" Width="92px">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign2" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura2" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf2" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor2" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign3" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura3" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf3" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor3" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion3" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign4" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura4" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf4" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor4" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion4" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign5" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura5" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf5" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor5" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion5" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign6" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura6" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf6" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor6" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion6" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign7" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura7" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf7" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor7" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion7" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign8" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura8" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf8" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor8" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion8" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="LabelAsign9" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:DropDownList ID="ListaAsignatura9" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="LabelProf9" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ListaProfesor9" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion9" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign10" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura10" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf10" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor10" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion10" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LabelAsign11" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="ListaAsignatura11" runat="server" DataSourceID="NombreAsignatura" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelProf11" runat="server" Text="Profesor" Visible="False"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="ListaProfesor11" runat="server" DataSourceID="EscogerProfesor" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="LabelConfirmacion11" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="LabelGrupo" runat="server" ForeColor="Red" Visible="False">.</asp:Label>
        <br />
        <asp:Label ID="LabelIDPersonal" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="LabelIDAsignatura" runat="server" Text="Label" Visible="False"></asp:Label>
        </center>
    </form>
</asp:Content>

