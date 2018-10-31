<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina5.aspx.cs" Inherits="Pagina5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">

    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
         <h2>Para registrarte ingresa los siguientes datos</h2>
        <br />
        <br />
       <h2>Nombre del usuario</h2>
        <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
        <br />
       <h2>Contraseña</h2>
        <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="txRegistro" CssClass="inputBtn" runat="server" Text="¡Registrate!" OnClick="txRegistro_Click" />
    
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server" Text=" "></asp:Label>
    
        <asp:Label ID="lbCon" CssClass="texto" runat="server"></asp:Label>

         <br />

        <asp:Button ID="btRegresar" CssClass="inputBtn" runat="server" Text="Regresar" OnClick="btRegresar_Click" />
    
    </div>
    </form>
</body>
</html>
