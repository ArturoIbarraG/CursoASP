<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioBtn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="rbtnPizza" Text="Pizza" runat="server" GroupName="alimentos" />
            <asp:RadioButton ID="rbtnFrutas" Text="Frutas" runat="server" GroupName="alimentos" />
            <asp:RadioButton ID="rbtnVerduras" Text="Verduras" runat="server" GroupName="alimentos" />
        </div>
        <asp:Button ID="btnProcesa" runat="server" Text="Procesa" OnClick="btnProcesa_Click" />
    </form>
</body>
</html>
