<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Inscribirse a otra Reta:<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Deporte:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlDeportes" runat="server" OnSelectedIndexChanged="ddlDeportes_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btBuscar" runat="server" Text="Buscar" />
        <br />
        <br />
        <asp:Table ID="tbBusca" runat="server">
        </asp:Table>
        <br />
        <asp:Label ID="lbAux" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btNueva" runat="server" Text="Nueva reta" OnClick="btNueva_Click" />
        <asp:Label ID="Label2" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
