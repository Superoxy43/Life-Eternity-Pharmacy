<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProveedor.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.EditarProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2 style="color: #3333FF; font-style: oblique;">Editar Proveedor</h2>

    <div>


        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">ID</span>
            <asp:TextBox ID="TxtidProveedor" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Dirección</span>
            <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Teléfono</span>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Correo</span>
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div cssclass="table table-striped-columns">
            <asp:Button ID="BtnEditar" runat="server"
                Text="Modificar"
                ForeColor="White" CssClass="btn btn-success"
                OnClick="BtnEditar_Click" BorderColor="#0066FF" />
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="BtnEliminar_Click" />
            <a href="ListaProveedor.aspx" class="btn btn-secondary">Cancelar</a>

        </div>

    </div>


</asp:Content>
