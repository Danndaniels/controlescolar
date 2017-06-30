<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="PrincipalPAdministrativo.aspx.cs" Inherits="PrincipalPAdministrativo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <form>
       
          
            
        <center>    
            <asp:Label ID="Label1" runat="server" Text="BIENVENIDO "></asp:Label>
           
            </center>

        </form>

     <%
         
    if(Session["user"]=="Profesor"){
   
     %>
    profesor
    <%}
    else if (Session["user"] == "Padministrativo")
    { %>
    equis
    <%}
    else if (Session["user"] == "Orientador")
    { %>
    orientador
    <%} %>
</asp:Content>

