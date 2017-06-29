<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="CAlumnos.aspx.cs" Inherits="CAlumnos_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <form id="form1" runat="server">
    <div>
    
        <table border="0" style="height: 82px; width: 592px">
            <tr>
                <td width="43">Turno</td>
                <td class="auto-style3">
        <asp:DropDownList ID="BusquedaTurno" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>Selecciona</asp:ListItem>
            <asp:ListItem>Matutino</asp:ListItem>
            <asp:ListItem Value="Vespertino"></asp:ListItem>
        </asp:DropDownList>
                </td>
                <td class="auto-style2">Sexo</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="BusquedaSexo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BusquedaSexo_SelectedIndexChanged">
            <asp:ListItem>Selecciona</asp:ListItem>
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Femenino</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:CheckBox ID="BUSCAR" runat="server" Text="Buscar por grupo" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged"/>
                    <br />
                </td>
                <td class="auto-style1">
        <asp:DropDownList ID="BuscarGrado" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="BuscarGrado_SelectedIndexChanged" Width="91px" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre" Visible="False">
        </asp:DropDownList>
                    <br />
                    <asp:Label ID="LabelIDGrupo" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;<br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" SelectCommand="SELECT [Nombre] FROM [Grupo]"></asp:SqlDataSource>
        <br />
        Sentencia:<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
       
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Matricula" DataSourceID="Consulta" AllowSorting="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Matricula" HeaderText="Matricula" ReadOnly="True" SortExpression="Matricula" />
                <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="ApellidoPaterno" HeaderText="ApellidoPaterno" SortExpression="ApellidoPaterno" />
                <asp:BoundField DataField="ApellidoMaterno" HeaderText="ApellidoMaterno" SortExpression="ApellidoMaterno" />
                <asp:TemplateField HeaderText="Sexo" SortExpression="Sexo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue=<%# Bind("Sexo") %>>
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Sexo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="CorreoElectronico" SortExpression="CorreoElectronico" />
                <asp:BoundField DataField="CURP" HeaderText="CURP" SortExpression="CURP" />
                <asp:BoundField DataField="rfc" HeaderText="rfc" SortExpression="rfc" />
                <asp:BoundField DataField="Tutor" HeaderText="Tutor" SortExpression="Tutor" />
                <asp:BoundField DataField="TipoSangre" HeaderText="TipoSangre" SortExpression="TipoSangre" />
                <asp:BoundField DataField="NUmeroSeguro" HeaderText="NUmeroSeguro" SortExpression="NUmeroSeguro" />
                <asp:BoundField DataField="id_grupo" HeaderText="id_grupo" SortExpression="id_grupo" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:BoundField DataField="Turno" HeaderText="Turno" SortExpression="Turno" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="Consulta" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" DeleteCommand="DELETE FROM [Alumno] WHERE [Matricula] = @Matricula" InsertCommand="INSERT INTO [Alumno] ([Matricula], [Contrasena], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Sexo], [Direccion], [Telefono], [CorreoElectronico], [CURP], [rfc], [Tutor], [TipoSangre], [NUmeroSeguro], [id_grupo], [FechaNacimiento], [Turno]) VALUES (@Matricula, @Contrasena, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo, @Direccion, @Telefono, @CorreoElectronico, @CURP, @rfc, @Tutor, @TipoSangre, @NUmeroSeguro, @id_grupo, @FechaNacimiento, @Turno)" SelectCommand="SELECT * FROM [Alumno]" UpdateCommand="UPDATE [Alumno] SET [Contrasena] = @Contrasena, [Nombre] = @Nombre, [ApellidoPaterno] = @ApellidoPaterno, [ApellidoMaterno] = @ApellidoMaterno, [Sexo] = @Sexo, [Direccion] = @Direccion, [Telefono] = @Telefono, [CorreoElectronico] = @CorreoElectronico, [CURP] = @CURP, [rfc] = @rfc, [Tutor] = @Tutor, [TipoSangre] = @TipoSangre, [NUmeroSeguro] = @NUmeroSeguro, [id_grupo] = @id_grupo, [FechaNacimiento] = @FechaNacimiento, [Turno] = @Turno WHERE [Matricula] = @Matricula">
            <DeleteParameters>
                <asp:Parameter Name="Matricula" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Matricula" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="ApellidoPaterno" Type="String" />
                <asp:Parameter Name="ApellidoMaterno" Type="String" />
                <asp:Parameter Name="Sexo" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="CorreoElectronico" Type="String" />
                <asp:Parameter Name="CURP" Type="String" />
                <asp:Parameter Name="rfc" Type="String" />
                <asp:Parameter Name="Tutor" Type="String" />
                <asp:Parameter Name="TipoSangre" Type="String" />
                <asp:Parameter Name="NUmeroSeguro" Type="String" />
                <asp:Parameter Name="id_grupo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Turno" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="ApellidoPaterno" Type="String" />
                <asp:Parameter Name="ApellidoMaterno" Type="String" />
                <asp:Parameter Name="Sexo" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="CorreoElectronico" Type="String" />
                <asp:Parameter Name="CURP" Type="String" />
                <asp:Parameter Name="rfc" Type="String" />
                <asp:Parameter Name="Tutor" Type="String" />
                <asp:Parameter Name="TipoSangre" Type="String" />
                <asp:Parameter Name="NUmeroSeguro" Type="String" />
                <asp:Parameter Name="id_grupo" Type="Int32" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Turno" Type="String" />
                <asp:Parameter Name="Matricula" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</asp:Content>

