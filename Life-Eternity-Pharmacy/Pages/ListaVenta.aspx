<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVenta.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.ListaVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="primary-container">
        <div>
            <h2 style="color: #3333FF; font-style: oblique;">Lista de Ventas</h2>
        </div>

        <asp:GridView ID="GvListaVenta" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" EditRowStyle-BackColor="#CC6600" BorderColor="Black" HeaderStyle-BackColor="White" EditRowStyle-BorderColor="#CC6600" EmptyDataRowStyle-BackColor="#003366" Font-Italic="True" FooterStyle-BackColor="Yellow" FooterStyle-BorderColor="#003300" ForeColor="Black" SelectedRowStyle-BackColor="#6600CC" BackColor="#CCCCCC" HeaderStyle-BorderColor="White">
            <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID Venta" />
            <asp:BoundField DataField="usuario" HeaderText="Usuario" />
            <asp:BoundField DataField="personal" HeaderText="Personal" />
            <asp:BoundField DataField="cliente" HeaderText="Cliente" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
            <asp:BoundField DataField="TipoComprobante" HeaderText="Tipo de Comprobante" />
            <asp:BoundField DataField="Total" HeaderText="Total" />

            </Columns>
        </asp:GridView>

        <div style="right: 100px; text-align: right">
            <a href="Home.aspx" class="btn btn-group" style="border-style: groove; border-width: medium; color: #808080; background-color: #000000;">Regresar</a>
        </div>

    </div>

</asp:Content>
