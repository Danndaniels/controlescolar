<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
            <div class="col-xs-12">
              <div class="find-course find-course_mod-b">
                <form class="find-course__form" action="#" runat="server">
                  <div class="form-group" > <i class="icon stroke icon-User"></i>
                      <asp:TextBox ID="txtUsuario" class="form-control" runat="server" placeholder="Usuario"></asp:TextBox><asp:TextBox ID="txtContra" class="form-control" runat="server" placeholder="Contraseña" type="password"></asp:TextBox>
                      
                      <asp:Label ID="LabelMensaje" runat="server" Text=""></asp:Label>
                  </div>
                  <!-- end form-group -->
                  <a class="find-course__wrap-btn">
                      
                            <asp:Button ID="Button1" class="btn btn-info btn-effect" runat="server" Text="ACCEDER" OnClick="Button1_Click" />
                      
                  </div>
                </form>
                    <a href="RPassword.aspx"><asp:Label ID="Label1" runat="server" Text="¿Has olvidado tu contraseña?"  ForeColor="White"></asp:Label></a>
                   
              </div>
              <!-- end find-course -->
              
            </div>
            <!-- end col --> 
          </div>
</asp:Content>

