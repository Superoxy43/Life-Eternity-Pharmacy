﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPersonal.aspx.cs" Inherits="Life_Eternity_Pharmacy.Pages.ListaPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="primary-container">
        <div>
            <h2 style="color: #3333FF; font-style: oblique;">Lista del Personal</h2>
        </div>

        <div>
            <a href="CrearPersonal.aspx" class="btn btn-secundary" style="border-style: groove; border-width: medium; color: #FFFFFF; background-color: #000000">Crear Personal</a>
        </div>

        <asp:GridView ID="GvListaPersonal" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" EditRowStyle-BackColor="#CC6600" BorderColor="Black" HeaderStyle-BackColor="White" EditRowStyle-BorderColor="#CC6600" EmptyDataRowStyle-BackColor="#003366" Font-Italic="True" FooterStyle-BackColor="Yellow" FooterStyle-BorderColor="#003300" ForeColor="Black" SelectedRowStyle-BackColor="#6600CC" BackColor="#CCCCCC" HeaderStyle-BorderColor="White">
            <Columns>
                <asp:BoundField DataField="id_personal" HeaderText="ID" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="rol" HeaderText="Rol" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="EditarPersonal.aspx?id=<%# Eval("id_personal") %> " style="color: #00CCFF; background-color: #000000; border-style: groove; border-width: medium; text-decoration: overline;">Modificar</a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

        <div style="right: 100px; text-align: right">
            <a href="Home.aspx" class="btn btn-group" style="border-style: groove; border-width: medium; color: #808080; background-color: #000000;">Regresar</a>
        </div>

    </div>

</asp:Content>