<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina4.aspx.cs" Inherits="Pagina4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Estás inscrito a las siguientes retas:<br />
        <asp:Table ID="tbBusca" runat="server">
        </asp:Table>
        <br />
        En caso de no poder participar en alguna reta, introduce el id de la reta aquí:<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btAceptar" runat="server" Text="Aceptar" />
        <br />
        <br />
        <asp:Label ID="lbAux" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
