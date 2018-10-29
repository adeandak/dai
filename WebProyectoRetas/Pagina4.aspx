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
        <asp:GridView ID="GridDatos" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Label ID="lbCon" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;Escribe el id de la reta que desees eliminar<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="bteliminar" runat="server" Text="Elimina Reta" OnClick="bteliminar_Click" />
        <br />
        <br />
        <asp:Label ID="lbAux" runat="server" Text=" "></asp:Label>
        Modifica retas
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modifica Retas" />
    </div>
    </form>
</body>
</html>
