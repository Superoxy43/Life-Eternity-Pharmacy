<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="text-align: center">Bienvenido Usuario</h2>
    <div style="text-align: center">
        <div cssclass="table table-striped-columns">
            <a href="ListaCategoria.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Categoria</a>
            <a href="ListaProducto.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Producto</a>
            <a href="ListaProveedor.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Proveedor</a>
            <a href="ListaPersonal.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Personal</a>
            <a href="ListaCliente.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Proveedor</a>
            <a href="ListaVenta.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Venta</a>
            <a href="CrearVenta.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Crear Venta</a>
            <a href="DetalleVenta.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Detalle Venta</a>
            <a href="ListaFactura.aspx" class="btn btn-primary" style="border-style: ridge; color: #ffffff;">Factura</a>
        </div>
    </div>
    <div style="center; text-align: center">
        <img src="https://st2.depositphotos.com/5205783/7953/v/450/depositphotos_79534384-stock-illustration-logo-pharmacy-mashed-drugs-organic.jpg" alt="Pharmacy" style="width: 30%; height: auto" />
    </div>

    <div style="right: 100px; text-align: right">
        <a href="ErrorVenta.aspx" class="btn btn-group" style="border-style: groove; border-width: medium; color: #808080; background-color: #000000;">Regresar</a>
    </div>



</asp:Content>
