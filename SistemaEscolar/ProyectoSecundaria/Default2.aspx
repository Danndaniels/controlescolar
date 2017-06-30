<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" style="height: 163px; width: 409px">
  <tr>
    <td>Ingresa la n</td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>Confirma</td>
    <td>
        <%
            Session.Abandon();
          %>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelError" runat="server" Text="Label"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
