<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoEditarProducto.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.ResultadoEditarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2 style="font-style: italic; color: #006699; text-decoration: blink">Se ha completado el proceso</h2>

    <div class="alert-success">
        <p>Se ha modificado la información del <a style="text-decoration: underline">Producto</a> en la base de datos.</p>
    </div>
    <br />
    <div>
        <a href="ListaProducto.aspx" class="btn btn-secondary">Regresar</a>
    </div>



</asp:Content>
