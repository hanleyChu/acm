<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ProductCategories.aspx.cs" Inherits="ASPNET_MVC_Store.Presentation.ProductCategories" Title="Product Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<form id="CategoriesForm" runat="server">
    <h2>
        Browse Products</h2>
    <asp:DataList ID="CategoriesDataList" runat="server" OnItemCommand="CategoriesDataList_ItemCommand">
        <ItemTemplate>
            &nbsp;• <asp:LinkButton ID="CategoryLinkButton" runat="server" Text='<%# Eval("CategoryName") %>'></asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</form>
</asp:Content>
