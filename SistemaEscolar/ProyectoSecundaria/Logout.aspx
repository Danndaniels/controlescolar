<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Default3" %>

<%
            Session.Abandon();
            Response.Redirect("Default.aspx");
          %>
