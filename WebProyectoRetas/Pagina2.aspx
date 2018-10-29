<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        ¡Bienvenido!
        <br />
        <br />
        ¿Que deseas hacer?<br />
        <asp:RadioButton ID="rbInscribir" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Inscribirme a una reta." />
        <br />
        <asp:RadioButton ID="rbAdministrar" runat="server" Text="Administrar mis retas." OnCheckedChanged="rbAdministrar_CheckedChanged" />
        <br />
        <br />
        <asp:Button ID="btListo" runat="server" Text="¡Listo!" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lbAux" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
