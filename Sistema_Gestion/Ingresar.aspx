<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Sistema_Gestion.Ingresar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="upla" src="logo2.png" style="width: 155px; height: 41px" /></div>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderColor="#000099" 
        BorderStyle="Double" Height="177px" Width="325px">
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Nombre deUsuario:"></asp:Label>
        <asp:TextBox ID="user" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="inicio" runat="server" 
    Text="Inicio de Sesión" onclick="inicio_Click" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" BackColor="Yellow" BorderColor="#000099" 
        Height="39px" Width="243px">
        <br />
        <asp:Label ID="L" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    </asp:Panel>
    </form>
</body>
</html>
