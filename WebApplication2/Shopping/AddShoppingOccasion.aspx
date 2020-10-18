<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingOccasion.aspx.cs" Inherits="WebApplication2.Shopping.AddShoppingOccasion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p> 
        <asp:Calendar ID="cndDate" runat="server"></asp:Calendar>
        <asp:TextBox ID="txtDescription" runat="server" Width="445px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Hozzáad" OnClick="btnSubmit_Click" />
        <asp:Literal ID="lResult" runat="server"></asp:Literal>
    </p>
</asp:Content>
