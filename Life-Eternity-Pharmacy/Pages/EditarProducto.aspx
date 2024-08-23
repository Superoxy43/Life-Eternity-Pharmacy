﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProducto.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.EditarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #3333FF; font-style: oblique;">Editar Producto</h2>

    <div>


        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">ID</span>
            <asp:TextBox ID="TxtidProducto" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Descripción</span>
            <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Precio</span>
            <asp:TextBox ID="TxtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Stock</span>
            <asp:TextBox ID="TxtStock" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Proveedor</span>
            <asp:DropDownList ID="DdlProveedor" runat="server" Enabled="true"></asp:DropDownList>
        </div>
        <br />
        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Categoría</span>
            <asp:DropDownList ID="DdlCategoria" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <br />
        <div cssclass="table table-striped-columns">
            <asp:Button ID="BtnEditar" runat="server"
                Text="Modificar"
                ForeColor="White" CssClass="btn btn-success"
                OnClick="BtnEditar_Click" BorderColor="#0066FF" />
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="BtnEliminar_Click" />
            <a href="ListaProducto.aspx" class="btn btn-secondary">Cancelar</a>

        </div>

    </div>

</asp:Content>
