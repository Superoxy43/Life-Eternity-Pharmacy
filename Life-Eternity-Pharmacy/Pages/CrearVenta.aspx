<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearVenta.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.CrearVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #3333FF; font-style: oblique;">Crear Venta</h2>

    <div>
        <%-- Venta --%>
        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Usuario</span>
            <asp:DropDownList ID="DdlUsuario" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Cliente</span>
            <asp:DropDownList ID="DdlCliente" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Personal</span>
            <asp:DropDownList ID="DdlPersonal" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Fecha</span>
            <asp:TextBox ID="TxtFecha" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Tipo Comprobante</span>
            <asp:TextBox ID="TxtTipoComprobante" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <br />
        <div>
            <asp:Button ID="BtnAgregar" runat="server"
                Text="Guardar"
                ForeColor="White" CssClass="btn btn-success"
                OnClick="BtnAgregar_Click" BorderColor="#0066FF" />
        </div>
        <div class="message-container">
            <asp:Label ID="LbAgregarResultado" runat="server" Text="Resultado"></asp:Label>
        </div>
        <br />
        <asp:GridView ID="GvListaVenta" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" EditRowStyle-BackColor="#CC6600" BorderColor="Black" HeaderStyle-BackColor="White" EditRowStyle-BorderColor="#CC6600" EmptyDataRowStyle-BackColor="#003366" Font-Italic="True" FooterStyle-BackColor="Yellow" FooterStyle-BorderColor="#003300" ForeColor="Black" SelectedRowStyle-BackColor="#6600CC" BackColor="#CCCCCC" HeaderStyle-BorderColor="White">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID Venta" />
                <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                <asp:BoundField DataField="personal" HeaderText="Personal" />
                <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="TipoComprobante" HeaderText="Tipo de Comprobante" />
                <asp:BoundField DataField="Total" HeaderText="Total" />
            </Columns>
        </asp:GridView>
        <br />

        <%-- DetalleVenta --%>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Venta</span>
            <asp:DropDownList ID="DdlVenta" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Producto</span>
            <asp:DropDownList ID="DdlProducto" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Cantidad</span>
            <asp:TextBox ID="TxtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Precio</span>
            <asp:TextBox ID="TxtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Impuesto</span>
            <asp:TextBox ID="TxtImpuesto" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnInsertar" runat="server"
                Text="Guardar"
                ForeColor="White" CssClass="btn btn-success"
                OnClick="BtnInsertar_Click" BorderColor="#0066FF" />
        </div>
        <div class="message-container">
            <asp:Label ID="LbInsertarResultado" runat="server" Text="Resultado"></asp:Label>
        </div>

        <br />

        <asp:GridView ID="GvListaDetalleVenta" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" EditRowStyle-BackColor="#CC6600" BorderColor="Black" HeaderStyle-BackColor="White" EditRowStyle-BorderColor="#CC6600" EmptyDataRowStyle-BackColor="#003366" Font-Italic="True" FooterStyle-BackColor="Yellow" FooterStyle-BorderColor="#003300" ForeColor="Black" SelectedRowStyle-BackColor="#6600CC" BackColor="#CCCCCC" HeaderStyle-BorderColor="White">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID DetalleVenta" />
                <asp:BoundField DataField="venta" HeaderText="Venta" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre Producto" />
                <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="precio" HeaderText="Precio" />
                <asp:BoundField DataField="impuesto" HeaderText="I.V.A" />
                <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />
            </Columns>
        </asp:GridView>

        <br />
        <div style="right: 100px; text-align: right">
            <a href="Home.aspx" class="btn btn-group" style="border-style: groove; border-width: medium; color: #808080; background-color: #000000;">Regresar</a>
        </div>

    </div>

</asp:Content>
