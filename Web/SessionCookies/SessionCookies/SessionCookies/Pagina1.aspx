<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="SessionCookies.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Usuario&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            Contraseña&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btPagina2" runat="server" OnClick="Button1_Click" Text="Ir a la pagina 2" />
            <br />
            <br />
            <asp:Label ID="lbContador" runat="server" Text="[lbContador]"></asp:Label>
        </div>
    </form>
</body>
</html>
