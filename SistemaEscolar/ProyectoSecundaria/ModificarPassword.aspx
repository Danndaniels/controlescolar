<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificarPassword.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, minimal-ui">
<title>Bienvenido</title>
<link href="favicon.png" type="image/x-icon" rel="shortcut icon">
<link href="assets/css/master.css" rel="stylesheet">

<script src="assets/plugins/jquery/jquery-1.11.3.min.js"></script>

</head>

<body>

<!-- Loader -->
<div id="page-preloader"><span class="spinner"></span></div>
<!-- Loader end -->

<div class="layout-theme animated-css"  data-header="sticky" data-header-top="200"> 
  

  <div id="wrapper"> 
    
    <!-- HEADER -->
    <header class="header">
            
      <div class="container">
        <div class="row">
          <div class="col-xs-12"> <a class="header-logo" href="javascript:void(0);"><img class="header-logo__img" src="assets/img/logo.png" height="50" width="195" alt="Logo"></a>
            <div class="header-inner">
              <div class="header-search">
                <div class="navbar-search">
                  <form id="search-global-form">
                    <div class="input-group">
                      <input type="text" placeholder="Type your search..." class="form-control" autocomplete="off" name="s" id="search" value="">
                      <span class="input-group-btn">
                      <button type="reset" class="btn search-close" id="search-close"><i class="fa fa-times"></i></button>
                      </span> </div>
                  </form>
                </div>
              </div>
              
              <nav class="navbar yamm">
                <div class="navbar-header hidden-md  hidden-lg  hidden-sm ">
                  <button type="button" data-toggle="collapse" data-target="#navbar-collapse-1" class="navbar-toggle"><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                </div>
              
            <!-- end header-inner --> 
          </div>
          <!-- end col  --> 
        </div>
        <!-- end row  --> 
      </div>
      <!-- end container--> 
    </header>
    <!-- end header -->
    
    <div class="wrap-title-page">
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <h1 class="ui-title-page">Bienvenido a la plataforma</h1>

              <h3 class="ui-title-b">Es necesario que realices un cambio de contraseña, una vez modificada deberas volver a iniciar sesión</h3>

          </div>
        </div>
      </div>
      <!-- end container--> 
    </div>
    <!-- end wrap-title-page -->
    
   
    <!-- end section-breadcrumb-->
    
    <main class="main-content">
     <center>   
      <div class="container">
							<div class="row">
								<div class="col-sm-12">
								
                                    	<h2 class="ui-title-block">La contraseña debe contener mínimo <strong>8</strong> caracteres</h2>
        
       
    <form id="form1" runat="server" class="form-contact ui-form">
   <div class="row">
											<div class="col-md-6">
                                                 
											<table border="0" style="height: 163px; width: 409px">
  <tr>
    <td><h2>Ingrese la contraseña</h2></td>
    <td>
        <asp:TextBox ID="txtPass" runat="server" type="password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td><h2>Confirme la contraseña</h2></td>
    <td>
        <asp:TextBox ID="txtConfirmacion" runat="server" type="password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>
        <asp:Button ID="BtnAceptar" class="btn btn-info btn-effect" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" />
        <br />
        <asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="."></asp:Label>
<asp:TextBox ID="txtusuario" runat="server" Visible="False"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
</table>
                                                </center>
  </div>
    </form>
											</div>
       </div>
    
       
       
    </form>
  
      </div>
                                </div>
          </div>
        
      <!-- end container --> 
      
    </main>
    <!-- end main-content -->
    
   <footer class="footer">
      <div class="container">
        <div class="footer-inner border-decor_top">
          <div class="row">
            <div class="col-lg-3 col-sm-3">
              <section class="footer-section">
                <h3 class="footer-title">Nosotros</h3>
                <a href="javascript:void(0);"><img class="footer-logo img-responsive" src="assets/img/logo_white.png" height="50" width="195" alt="Logo"></a>
                <div class="footer-info">Esto es solo un texto de relleno.</div>
                
              </section>
              <!-- end footer-section --> 
            </div>
            <!-- end col -->
            
            <div class="col-lg-2 col-sm-3">
              <section class="footer-section">
               
              </section>
              <!-- end footer-section --> 
            </div>
            <!-- end col -->
            
            <div class="col-lg-3 col-sm-3">
              <section class="footer-section">
                <h3 class="footer-title">Contacto</h3>
                <div class="footer-contacts footer-contacts_mod-a"> <i class="icon stroke icon-Pointer"></i>
                  <address class="footer-contacts__inner">
                  Tecamac, Estado de Mexico
                  </address>
                </div>
                <div class="footer-contacts"> <i class="icon stroke icon-Phone2"></i> <span class="footer-contacts__inner">55593216445</span> </div>
                <div class="footer-contacts"> <i class="icon stroke icon-Mail"></i> <a class="footer-contacts__inner" href="mailto:Info@academica.com">Info@academica.com</a> </div> 
                </section>
              <!-- end footer-section --> 
            </div>
            <!-- end col -->
            
          </div>
          <!-- end row --> 
        </div>
        <!-- end footer-inner -->
        
        <div class="row">
          <div class="col-xs-12">
            <div class="footer-bottom">
              <div class="copyright">Copyright © 2017 Escuela Secundaria... |  Created by <a href="#">Daniel's</a></div>
              <ul class="social-links list-unstyled">
                <li><a class="icon fa fa-facebook" href="javascript:void(0);"></a></li>
                <li><a class="icon fa fa-twitter" href="javascript:void(0);"></a></li>
                <li><a class="icon fa fa-google-plus" href="javascript:void(0);"></a></li>
                <li><a class="icon fa fa-instagram" href="javascript:void(0);"></a></li>
                <li><a class="icon fa fa-linkedin" href="javascript:void(0);"></a></li>
                <li><a class="icon fa fa-youtube-play" href="javascript:void(0);"></a></li>
              </ul>
            </div>
            <!-- end footer-bottom --> 
          </div>
          <!-- end col --> 
        </div>
        <!-- end row --> 
      </div>
      <!-- end container --> 
    </footer>
  </div>
  <!-- end wrapper --> 
</div>
<!-- end layout-theme --> 

<!-- SCRIPTS --> 
<script src="assets/js/jquery-migrate-1.2.1.js"></script>
<script src="assets/plugins/bootstrap/js/bootstrap.min.js"></script> 
<script src="assets/js/modernizr.custom.js"></script> 
<script src="assets/js/waypoints.min.js"></script> 
<script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script> 

<!--THEME--> 
<script  src="assets/plugins/sliderpro/js/jquery.sliderPro.min.js"></script> 
<script src="assets/plugins/owl-carousel/owl.carousel.min.js"></script> 
<script src="assets/plugins/isotope/jquery.isotope.min.js"></script> 
<script src="assets/plugins/prettyphoto/js/jquery.prettyPhoto.js"></script> 
<script src="assets/plugins/datetimepicker/jquery.datetimepicker.js"></script> 
<script src="assets/plugins/jelect/jquery.jelect.js"></script> 
<script src="assets/plugins/rendro-easy-pie-chart/dist/jquery.easypiechart.min.js"></script> 
<script src="assets/js/cssua.min.js"></script> 
<script src="assets/js/wow.min.js"></script> 
<script src="assets/js/custom.min.js"></script>


</body>
</html>
