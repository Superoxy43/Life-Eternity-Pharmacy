<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProducto.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.ListaProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="primary-container">
        <div>
            <h2 style="color: #3333FF; font-style: oblique;">Lista de Productos</h2>
        </div>

        <div>
            <a href="CrearProducto.aspx" class="btn btn-secundary" style="border-style: groove; border-width: medium; color: #FFFFFF; background-color: #000000">Crear Producto</a>
        </div>

        <asp:GridView ID="GvListaProducto" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" EditRowStyle-BackColor="#CC6600" BorderColor="Black" HeaderStyle-BackColor="White" EditRowStyle-BorderColor="#CC6600" EmptyDataRowStyle-BackColor="#003366" Font-Italic="True" FooterStyle-BackColor="Yellow" FooterStyle-BorderColor="#003300" ForeColor="Black" SelectedRowStyle-BackColor="#6600CC" BackColor="#CCCCCC" HeaderStyle-BorderColor="White">
            <Columns>
                <asp:BoundField DataField="id_producto" HeaderText="ID" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="precio" HeaderText="Precio" />
                <asp:BoundField DataField="stock" HeaderText="Stock" />
                <asp:BoundField DataField="nombreProvee" HeaderText="Proveedor" />
                <asp:BoundField DataField="descripCatego" HeaderText="Categoría" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="EditarProducto.aspx?id=<%# Eval("id_producto") %> " style="color: #00CCFF; background-color: #000000; border-style: groove; border-width: medium; text-decoration: overline;">Modificar</a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

        <div style="right: 100px; text-align: right">
            <a href="Home.aspx" class="btn btn-group" style="border-style: groove; border-width: medium; color: #808080; background-color: #000000;">Regresar</a>
        </div>

    </div>






</asp:Content>
