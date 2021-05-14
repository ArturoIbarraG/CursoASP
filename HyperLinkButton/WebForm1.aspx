<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HyperLinkButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Link a página web: <br />
            <asp:HyperLink ID="hlkUno" runat="server" NavigateUrl="https://www.google.com.mx" Target="_blank">Ir a Google</asp:HyperLink>
            <br />
        </div>
        <div>
            Link a WebForm de la misma aplicación: <br />
            <asp:HyperLink ID="hlkDos" runat="server" NavigateUrl="WebForm2.aspx">Ir al WebForm2</asp:HyperLink>
            <br />
        </div>
        <div>
            Link a WebForm de la misma aplicación en pestaña nueva:<br />
            <asp:HyperLink ID="hlkTres" runat="server" NavigateUrl="WebForm2.aspx" Target="_blank">Ir al WebForm2 en Nueva Pestaña</asp:HyperLink>
            <br />
        </div>
        <div>
            Link con imagen:<br />
            <asp:HyperLink ID="hlkImagen1" runat="server" ImageHeight="100px" ImageUrl="~/images/icon1.png" NavigateUrl="~/WebForm2.aspx">HyperLink</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlkImagen2" runat="server" ImageHeight="100px" ImageUrl="~/images/icon1.png" NavigateUrl="~/WebForm2.aspx">HyperLink</asp:HyperLink>
            <br />
        </div>
        <div>
            LinkButton:<br />
            <asp:LinkButton ID="lkbUno" runat="server" PostBackUrl="~/WebForm2.aspx">Ir a WebForm2</asp:LinkButton>
            <br />
        </div>
        <div>
            LinkButton con evento del lado del cliente:
            <br />
            <asp:LinkButton ID="lkbScript" runat="server" OnClientClick="return Funcion();" PostBackUrl="~/WebForm2.aspx">Función Javascript</asp:LinkButton>
        </div>

        <script type="text/javascript">
            function Funcion() {
                alert("Alerta de Javascript.");
                return true;
            }
        </script>
    </form>
</body>
</html>
