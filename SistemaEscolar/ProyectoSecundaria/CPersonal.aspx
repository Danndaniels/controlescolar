<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="CPersonal.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <form id="form1" runat="server">
        <p>
            <center> Buscar Personal:
            <asp:DropDownList ID="ComboPersonal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ComboPersonal_SelectedIndexChanged">
                <asp:ListItem>Todos</asp:ListItem>
                <asp:ListItem>Profesor</asp:ListItem>
                <asp:ListItem>Orientador</asp:ListItem>
                <asp:ListItem>Personal administrativo</asp:ListItem>
            </asp:DropDownList>
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         
            </center>
        </p>
        <p>
          
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Personal" DataSourceID="General" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="ApellidoPaterno" HeaderText="ApellidoPaterno" SortExpression="ApellidoPaterno" />
                <asp:BoundField DataField="ApellidoMaterno" HeaderText="ApellidoMaterno" SortExpression="ApellidoMaterno" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="CorreoElectronico" SortExpression="CorreoElectronico" />
                <asp:BoundField DataField="Cedula_Profesional" HeaderText="Cedula_Profesional" SortExpression="Cedula_Profesional" />
                <asp:TemplateField HeaderText="Puesto" SortExpression="Puesto">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("Puesto") %>'>
                            <asp:ListItem>Profesor</asp:ListItem>
                            <asp:ListItem>Orientador</asp:ListItem>
                            <asp:ListItem>Personal administrativo</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Puesto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="NumeroSeguro" HeaderText="NumeroSeguro" SortExpression="NumeroSeguro" />
                <asp:BoundField DataField="Curp" HeaderText="Curp" SortExpression="Curp" />
                <asp:BoundField DataField="Rfc" HeaderText="Rfc" SortExpression="Rfc" />
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
        <asp:SqlDataSource ID="General" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" DeleteCommand="DELETE FROM [PersonalAdministrativo] WHERE [Id_Personal] = @Id_Personal" InsertCommand="INSERT INTO [PersonalAdministrativo] ([Usuario], [Contrasena], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Direccion], [Telefono], [CorreoElectronico], [Cedula_Profesional], [Puesto], [NumeroSeguro], [Curp], [Rfc]) VALUES (@Usuario, @Contrasena, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Direccion, @Telefono, @CorreoElectronico, @Cedula_Profesional, @Puesto, @NumeroSeguro, @Curp, @Rfc)" SelectCommand="SELECT * FROM [PersonalAdministrativo]" UpdateCommand="UPDATE [PersonalAdministrativo] SET [Usuario] = @Usuario, [Contrasena] = @Contrasena, [Nombre] = @Nombre, [ApellidoPaterno] = @ApellidoPaterno, [ApellidoMaterno] = @ApellidoMaterno, [Direccion] = @Direccion, [Telefono] = @Telefono, [CorreoElectronico] = @CorreoElectronico, [Cedula_Profesional] = @Cedula_Profesional, [Puesto] = @Puesto, [NumeroSeguro] = @NumeroSeguro, [Curp] = @Curp, [Rfc] = @Rfc WHERE [Id_Personal] = @Id_Personal">
            <DeleteParameters>
                <asp:Parameter Name="Id_Personal" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Usuario" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="ApellidoPaterno" Type="String" />
                <asp:Parameter Name="ApellidoMaterno" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="CorreoElectronico" Type="String" />
                <asp:Parameter Name="Cedula_Profesional" Type="String" />
                <asp:Parameter Name="Puesto" Type="String" />
                <asp:Parameter Name="NumeroSeguro" Type="String" />
                <asp:Parameter Name="Curp" Type="String" />
                <asp:Parameter Name="Rfc" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Usuario" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="ApellidoPaterno" Type="String" />
                <asp:Parameter Name="ApellidoMaterno" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="CorreoElectronico" Type="String" />
                <asp:Parameter Name="Cedula_Profesional" Type="String" />
                <asp:Parameter Name="Puesto" Type="String" />
                <asp:Parameter Name="NumeroSeguro" Type="String" />
                <asp:Parameter Name="Curp" Type="String" />
                <asp:Parameter Name="Rfc" Type="String" />
                <asp:Parameter Name="Id_Personal" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</asp:Content>

