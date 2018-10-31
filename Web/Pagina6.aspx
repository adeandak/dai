<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina6.aspx.cs" Inherits="Pagina6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">

    <title>Administrar</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
        <h2>Estas son las retas que has creado:</h2>
        <br />
        <br />
        <asp:GridView ID="GridDatos" CssClass="texto" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Label ID="lbCon" CssClass="texto" runat="server"></asp:Label>
        <br />
        <br />
        <h2>  Escribe el id de la reta que desees eliminar:</h2>
       <asp:TextBox ID="txIdElimina" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bteliminar" CssClass="inputBtn" runat="server" Text="Elimina Reta" OnClick="bteliminar_Click" />
        <br />
        <br />
        <h2>  Escribe el id de la reta que desees modificar:</h2>
         <asp:TextBox ID="txIdMod" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btMod" CssClass="inputBtn" runat="server" OnClick="btMod_Click" Text="Modificar Reta" />
        <br />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btRegresar" CssClass="inputBtn" runat="server" Text="Regresar" OnClick="btRegresar_Click" />
    </div>
    </form>
</body>
</html>
