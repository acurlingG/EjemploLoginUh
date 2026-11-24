<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="login1.CapaVistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUsuario">Usuario:</label>
            <asp:TextBox ID="txtUsuario" runat="server" required TextMode="Email"></asp:TextBox>
            <br />
            <label for="txtClave">Contraseña:</label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password" required></asp:TextBox>  
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />

        </div>
    </form>
</body>
</html>
