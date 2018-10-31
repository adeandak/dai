<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina1.aspx.cs" Inherits="Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">
    <title>Inicio</title>
</head>
<body>
    <form id="form1" runat="server">
  <div class="box">
        <h1>¿Ya tienes una cuenta?</h1>
        <br />
        <h2>Incia sesión</h2>
        <br />
        <h2>Usuario:</h2>
        <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
        <br />
        <h2>Contraseña:</h2>
        <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
        <br />
      <br />
      
        <asp:Button ID="btSiguiente" CssClass="inputBtn" runat="server" Text="Siguiente" OnClick="btSiguiente_Click" Height="36px" />
        <br />
        <br />
        <br />
        <h2>¿Aún no tienes cuenta?</h2>
        <br />
        <asp:Button ID="btRegistrate" CssClass="inputBtn" runat="server" Text="Registrate Aquí" OnClick="btRegistrate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server" Text="Soy un label auxiliar :)"></asp:Label>
        <br />
    
    </div>

    </form>
</body>
</html>
