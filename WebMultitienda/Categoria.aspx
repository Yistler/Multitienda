<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="WebMultitienda.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 325px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="border: solid 2px rgba(103, 58, 183, 1)">
        <h3>Formulario de Registro de Categoria</h3>

        <asp:Panel ID="pnlMensaje" runat="server" Visible="true">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>
        </asp:Panel>

        <tr>
            <td>Id:</td>
            <td class="auto-style1"><asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RfvId" runat="server" ControlToValidate="txtId" ErrorMessage="ID no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td class="auto-style1"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre no debe estar vacio" ForeColor="Red" SetFocusOnError="True">(*)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
             <td colspan="2">
                <asp:Button ID="BtnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="BtnVolver_Click" />
                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click"/>
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                 <br />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvMultitiendas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="IdCategoria" DataSourceID="" OnSelectedIndexChanged="gvMultitiendas_SelectedIndexChanged" OnPageIndexChanging="gvMultitiendas_PageIndexChanging" Width="400px" AllowPaging="True" PageSize="5">
        <Columns>
            <asp:BoundField DataField="IdCategoria" HeaderText="IdCategoria" SortExpression="IdCategoria" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
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
    </asp:Content>
