<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServiceApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCargar" runat="server" Text="Cargar" OnClick="btnCargar_Click" />
        
    </div>

</asp:Content>
