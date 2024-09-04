<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebMultitienda.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Bienvenido a Multitienda SPA
    </p>
    <div>
        <asp:Button ID="btnCategoria" runat="server" Text="Categoria" OnClick="btnCategoria_Click" /> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btnProducto" runat="server" Text="Producto" OnClick="btnProducto_Click" />
    </div>

</asp:Content>
