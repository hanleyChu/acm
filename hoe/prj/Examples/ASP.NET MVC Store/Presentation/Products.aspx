<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="ASPNET_MVC_Store.Presentation.Products" Title="Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<form id="ProductsForm" runat="server">
    <h2>
        <asp:Label ID="CategoryNameLabel" runat="server" Text="CategoryNameLabel"></asp:Label>&nbsp;</h2>
    <p>
        <asp:DataList ID="ProductsDataList" runat="server" OnItemCommand="ProductsDataList_ItemCommand">
            <ItemTemplate>
                &nbsp;• <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                (<asp:LinkButton ID="EditProductButton" runat="server">Edit</asp:LinkButton>)
            </ItemTemplate>
        </asp:DataList>&nbsp;</p>
</form>
</asp:Content>
