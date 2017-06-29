<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="RGrupo.aspx.cs" Inherits="RGrupo" %>

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
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnAltas" runat="server" Text="Registrar" OnClick="BtnAltas_Click" class="btn btn-info btn-effect"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="" ForeColor="#0000CC"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                   Grado
                </td>
                <td class="auto-style6">
               <asp:DropDownList ID="ListaGrado" runat="server">
                   <asp:ListItem>1</asp:ListItem>
                   <asp:ListItem>2</asp:ListItem>
                   <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                  
                </td>
            </tr>
            </table>
 
             <br />
 
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Grupo" DataSourceID="Consulta">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:TemplateField HeaderText="GRADO" SortExpression="GRADO">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Bind("GRADO") %>'>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("GRADO") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Consulta" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>" DeleteCommand="DELETE FROM [Grupo] WHERE [Id_Grupo] = @Id_Grupo" InsertCommand="INSERT INTO [Grupo] ([Nombre], [GRADO]) VALUES (@Nombre, @GRADO)" SelectCommand="SELECT [Nombre], [GRADO], [Id_Grupo] FROM [Grupo]" UpdateCommand="UPDATE [Grupo] SET [Nombre] = @Nombre, [GRADO] = @GRADO WHERE [Id_Grupo] = @Id_Grupo">
            <DeleteParameters>
                <asp:Parameter Name="Id_Grupo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="GRADO" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="GRADO" Type="String" />
                <asp:Parameter Name="Id_Grupo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
      
    </div>
          </center>
    </form>
</asp:Content>

