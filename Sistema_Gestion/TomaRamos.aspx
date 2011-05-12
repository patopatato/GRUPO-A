<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TomaRamos.aspx.cs" Inherits="Sistema_Gestion.TomaRamos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        #form1
        {
            height: 355px;
            width: 939px;
        }
    </style>
</head>
<body bgcolor="White">
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#CC9900" Font-Bold="True" 
        Font-Italic="False" Font-Size="Large" ForeColor="Black" Height="311px">
        Seleccione los ramos que desee tomar.<br />
        Los ramos que se encuentren con el signo ( * ) el sistema los SELECCIONA 
AUTOMATICAMENTE.<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
        </asp:GridView>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BotonAceptar" runat="server" Text="Aceptar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BotonCancelar" runat="server" Text="Cancelar" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">Condiciones</asp:LinkButton>
    </asp:Panel>
    </form>
</body>
</html>

