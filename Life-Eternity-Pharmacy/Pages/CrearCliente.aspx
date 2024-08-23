<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.CrearCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #3333FF; font-style: oblique;">Crear Cliente</h2>

    <div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Nombre</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span style="color: #003366; text-decoration: blink; font-style: italic">Apellido</span>
            <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox>
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
            <asp:Button ID="BtnAgregar" runat="server"
                Text="Guardar"
                ForeColor="White" CssClass="btn btn-success"
                OnClick="BtnAgregar_Click" BorderColor="#0066FF" />

            <a href="ListaCliente.aspx" class="btn btn-secondary" style="border-style: ridge; color: #ffffff;">Cancelar</a>

        </div>

    </div>

</asp:Content>
