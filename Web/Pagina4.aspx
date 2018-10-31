<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina4.aspx.cs" Inherits="Pagina4" %>

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
         <h2>Estas inscrito a las siguientes retas:</h2>
        
        <br />
        <asp:GridView ID="GridDatos" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Label ID="lbCon" CssClass="texto" runat="server"></asp:Label>
        <br />
        <br />
         <h2>Escribe el id de la reta que desees eliminar:</h2>
&nbsp;<asp:TextBox ID="txIdElimina" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bteliminar" CssClass="inputBtn" runat="server" Text="Elimina Reta" OnClick="bteliminar_Click" />
        <br />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server"></asp:Label>
         <br />
        <br />
        <asp:Button ID="btRegresar" CssClass="inputBtn" runat="server" Text="Regresar" OnClick="btRegresar_Click" />
    </div>
    </form>
</body>
</html>
