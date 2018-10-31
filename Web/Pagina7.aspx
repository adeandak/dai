<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina7.aspx.cs" Inherits="Pagina7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="./style.css">

    <title>CrearReta</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
        <h2>  Crear una reta</h2>
    
        <br />
        <br />
          <h2>  Deporte:</h2>
        
        <asp:DropDownList ID="ddlDeporte" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <h2>  Hora:</h2>
        <asp:DropDownList ID="ddlHora" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <h2>Fecha:</h2>
  
        <asp:TextBox ID="txAño" runat="server" Width="55px"></asp:TextBox>
        -<asp:TextBox ID="txMes" runat="server" Width="35px"></asp:TextBox>
        -<asp:TextBox ID="txDia" runat="server" Width="31px"></asp:TextBox>
        <h3> (Sólo se leeran los primeros caracteres para cada casilla)</h3>  
&nbsp;&nbsp;&nbsp; <br />
        <br />
          <h2>  Lugar:</h2>
        <asp:TextBox ID="txLugar" runat="server" Width="310px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btCrear" CssClass="inputBtn" runat="server" OnClick="btCrear_Click" Text="Crear" />
        <br />
        <br />
        <asp:Label ID="lbAux" CssClass="texto" runat="server"></asp:Label>

        <br />

        <asp:Button ID="btRegresar" CssClass="inputBtn" runat="server" Text="Regresar" OnClick="btRegresar_Click" />
    
    </div>
    </form>
</body>
</html>
