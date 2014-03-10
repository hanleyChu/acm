<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="EditProduct.aspx.cs" Inherits="ASPNET_MVC_Store.Presentation.EditProduct" Title="Edit Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<form id="EditProductForm" runat="server">
    <h2>
    Edit
        <asp:Label ID="ProductNameLabel" runat="server" Text="ProductNameLabel"></asp:Label></h2>
    <p>
        <table>
            <tr>
                <td>
                    Name:</td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Category:</td>
                <td>
                    <asp:DropDownList ID="CategoryDropDownList" runat="server" AppendDataBoundItems="True"
                        Width="203px" DataTextField="CategoryName">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    Supplier:</td>
                <td>
                    <asp:DropDownList ID="SupplierDropDownList" runat="server" AppendDataBoundItems="True"
                        Width="204px" DataTextField="CompanyName">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    Unit Price:</td>
                <td>
                    <asp:TextBox ID="UnitPriceTextBox" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </p>
    <asp:Button ID="CommitButton" runat="server" Text="Save" OnClick="CommitButton_Click" />
</form>    
</asp:Content>
