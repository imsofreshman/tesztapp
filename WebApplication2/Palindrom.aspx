<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Palindrom.aspx.cs" Inherits="WebApplication2.Palindrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Palindrom kereső</h1>
    <p>
        Kérem adjon meg egy mondatot:  <br />
        <asp:TextBox ID="txtSentence" runat="server" Width="362px"></asp:TextBox>
        <asp:Button ID="btnResult" runat="server" Text="Kiértékel" OnClick="btnResult_Click" />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
</asp:Content>
