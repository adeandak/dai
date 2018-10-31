<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">

    <title>Inscripcion</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
         <h2>Inscribirse a otra Reta</h2>
        <br />
         <h2>Deporte</h2>
        <br />
        <asp:DropDownList ID="ddlDeportes" runat="server" OnSelectedIndexChanged="ddlDeportes_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btBuscar" CssClass="inputBtn" runat="server" Text="Buscar" OnClick="btBuscar_Click" />
        <br />
        <asp:GridView ID="gridDeporte" CssClass="texto"  runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server"></asp:Label>
        <asp:Label ID="Label2" CssClass="texto" runat="server" Text=" "></asp:Label>
        <br />
        <br />
          <h2> Ingresa el id de la reta a la que quieras registrate </h2>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
         <br />
        <br />
        <asp:Button ID="btNueva" CssClass="inputBtn" runat="server" Text="Resgistrate en la reta" OnClick="btNueva_Click" />
        <br />
         <br />
        <asp:Label ID="lbaviso" CssClass="texto" runat="server"></asp:Label>
         <br />

         <br />
         <asp:Button ID="btRegresar" CssClass="inputBtn" runat="server" Text="Regresar" OnClick="btRegresar_Click" />

    </div>
    </form>
</body>
</html>
