<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorProducto.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.ErrorProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2 style="color: #FF0000">Ha ocurrido un error!!!!</h2>

    <div class="alert-success">
        <p style="color: #FFCC00">Algo ha salido mal... :(</p>
        <img src="https://martinbrainon.com/inicio/wp-content/uploads/2018/01/lead-nuclear-power-human-error-homer-simpson-1.jpg" alt="Los Simpsons" style="width: 30%; height: auto" />
        <p style="color: #000000">Click al botón regresar para volver a la lista de Productos</p>
    </div>
    <div>
        <a href="ListaProducto.aspx" class="btn btn-secondary">Regresar</a>
    </div>


</asp:Content>
