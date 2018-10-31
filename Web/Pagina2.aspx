<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">

    <title>Menu</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
         <h2>¡Bienvenido!</h2>

        <br />
        <br />
       <h2>¿Que deseas hacer?</h2>
        <br />
        <asp:Button ID="btInscribe" CssClass="inputBtn" runat="server" OnClick="btInscribe_Click" Text="Inscribirme a una reta" />
        <br />
        <br />
        <asp:Button ID="btCrea" CssClass="inputBtn" runat="server" OnClick="btCrea_Click" Text="Crear una Reta" />
        <br />
        <br />
        <asp:Button ID="BtAdmin" CssClass="inputBtn" runat="server" OnClick="BtAdmin_Click" Text="Administrar las retas que creé" />
        <br />
        <br />
        <asp:Button ID="btRetaInscirto" CssClass="inputBtn" runat="server" OnClick="Button1_Click1" Text="Administrar las retas a las que estoy inscrito" />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
