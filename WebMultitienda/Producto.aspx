<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="WebMultitienda.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border: solid 2px rgba(103, 58, 183, 1)">
        <caption>
            <h3 style="width: 399px">Formulario de Registro de Producto</h3>
            <asp:Panel ID="pnlMensaje" runat="server" Visible="true">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>
            </asp:Panel>
        </caption>
        <tr>
            <td>Id:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RfvId" runat="server" ControlToValidate="txtId" ErrorMessage="ID no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Descripcion:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Descripcion no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>IdCategoria:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtIdCategoria" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtIdCategoria" ErrorMessage="Categoria a la que pertenece no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BtnVolver" runat="server" CausesValidation="False" OnClick="BtnVolver_Click" Text="Volver" />
                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <asp:GridView ID="gvProducto" runat="server" Width="400px" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ObjectDataSource1" Height="16px" PageSize="5">
        <Columns>
            <asp:BoundField DataField="idProducto" HeaderText="idProducto" SortExpression="idProducto" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
            <asp:BoundField DataField="idCategoria" HeaderText="idCategoria" SortExpression="idCategoria" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReadAll" TypeName="Multitienda.Negocio.ProductoCollection"></asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
    </asp:Content>
