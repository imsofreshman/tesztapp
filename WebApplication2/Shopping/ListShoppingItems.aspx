<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListShoppingItems.aspx.cs" Inherits="WebApplication2.Shopping.ListShoppingItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        SQL Data Source, generated <br />
        <asp:DropDownList ID="ddlSelectedDate1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Date" DataValueField="ShoppingOccasionID"></asp:DropDownList> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingDBConnectionString %>" SelectCommand="SELECT [Date], [ShoppingOccasionID] FROM [ShoppingOccasion]"></asp:SqlDataSource>
        <br />
        SQL Data Source, custom query <br />
        <asp:DropDownList ID="ddlSelectedDate2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Date" DataValueField="ShoppingOccasionID"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingDBConnectionString %>" SelectCommand="SELECT ShoppingOccasionID, Date FROM ShoppingOccasion WHERE (Date &gt; GETDATE()) ORDER BY Date"></asp:SqlDataSource>
        <br />
        Code Behind, existing data source <br />
        <asp:DropDownList ID="ddlSelectedDate3" runat="server"></asp:DropDownList>
        <br />
        Object <br /> 
        <asp:DropDownList ID="ddlSelectedDate4" runat="server"></asp:DropDownList>
        <br />
    </p>
    <p>

    </p>


</asp:Content>
