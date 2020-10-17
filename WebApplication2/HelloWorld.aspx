<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebApplication2.HelloWorld" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hellobello</h1>
    <asp:DropDownList ID="ddl1" runat="server"> </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Szöveg kiirása" OnClick="Button1_Click" />
    <asp:Literal Text="szalami" runat="server" />
    <p>
        Ez az oldal alja
    </p>
</asp:Content>
