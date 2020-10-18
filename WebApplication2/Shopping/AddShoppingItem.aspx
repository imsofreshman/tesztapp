<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingItem.aspx.cs" Inherits="WebApplication2.Shopping.AddShoppingItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
            <asp:DropDownList ID="ddlShoppingPlaces" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddlShoppingOccasions" runat="server"></asp:DropDownList>
    </p>
    <p>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtUnitOfMeasure" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Hozzáad" OnClick="btnSubmit_Click" />
    <asp:Literal ID="lResult" runat="server"></asp:Literal>
    </p>
    



</asp:Content>
