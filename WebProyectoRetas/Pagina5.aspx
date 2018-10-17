<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina5.aspx.cs" Inherits="Pagina5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Favor de ingresar los siguientes datos:"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="txRegistro" runat="server" Text="¡Registrate!" />
    
        <br />
        <asp:Label ID="lbAux" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
