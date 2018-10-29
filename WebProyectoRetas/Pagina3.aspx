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
        <asp:DropDownList ID="ddlDeportes" runat="server" OnSelectedIndexChanged="ddlDeportes_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btBuscar" runat="server" Text="Buscar" OnClick="btBuscar_Click" />
        <br />
        <asp:GridView ID="gridDeporte" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lbAux" runat="server"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=" "></asp:Label>
        <br />
        <br />
        Ingresa el id de la reta a la que quieras registrate<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btNueva" runat="server" Text="Resgistrate en la reta" OnClick="btNueva_Click" />
        <br />
        <asp:Label ID="lbaviso" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
