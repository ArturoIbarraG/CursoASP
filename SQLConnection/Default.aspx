<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQLConnection._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <asp:GridView ID="gdvComestibles" runat="server" AutoGenerateColumns="true"></asp:GridView>

        <asp:DropDownList ID="ddlComestibles" runat="server"></asp:DropDownList>

    </div>

</asp:Content>
