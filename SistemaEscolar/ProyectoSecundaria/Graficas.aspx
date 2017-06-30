<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPAdmin.master" AutoEventWireup="true" CodeFile="Graficas.aspx.cs" Inherits="Graficas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <asp:Chart ID="Grafica" runat="server">
            <series>
                <asp:Series Name="Serie">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
</asp:Content>

