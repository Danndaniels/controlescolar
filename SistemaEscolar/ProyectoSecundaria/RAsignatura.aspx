<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="RAsignatura.aspx.cs" Inherits="RAsignatura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <form id="form1" runat="server">
    <center>

          <div>
        <br />

        <table border="0" class="auto-style1">
            <tr>
                <td colspan="3"></td>
            </tr>
            <tr>
                <td class="auto-style4">Nombre&nbsp;</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BtnAltas" runat="server" Text="Registrar" OnClick="BtnAltas_Click" class="btn btn-info btn-effect"/>
                    <asp:Label ID="Label1" runat="server" Text="" ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Grado</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ComboGrupo" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            </table>
        <br />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Asignatura" DataSourceID="Consulta">
            <Columns>
                <asp:CommandField AccessibleHeaderText="Funciones" ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:TemplateField HeaderText="grado" SortExpression="grado">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Bind("grado") %>'>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("grado") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Consulta" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" DeleteCommand="DELETE FROM [Asignatura] WHERE [Id_Asignatura] = @Id_Asignatura" InsertCommand="INSERT INTO [Asignatura] ([Nombre], [grado]) VALUES (@Nombre, @grado)" SelectCommand="SELECT * FROM [Asignatura]" UpdateCommand="UPDATE [Asignatura] SET [Nombre] = @Nombre, [grado] = @grado WHERE [Id_Asignatura] = @Id_Asignatura">
            <DeleteParameters>
                <asp:Parameter Name="Id_Asignatura" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="grado" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="grado" Type="String" />
                <asp:Parameter Name="Id_Asignatura" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        
    </div>
        </center>
    </form>
</asp:Content>

