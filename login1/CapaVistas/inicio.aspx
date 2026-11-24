<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="login1.CapaVistas.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido a la página de inicio</h1>
            <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="64px" ImageUrl="~/imagenes/homeicono.png" OnClick="ImageButton1_Click" Width="67px" />
        </div>
    </form>
</body>
</html>
