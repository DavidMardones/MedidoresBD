<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidor.aspx.cs" Inherits="MedidoresBD.MostrarMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Mostrar Medidor</h2>
        <asp:GridView ID="gridMedidores" runat="server" CssClass="table table-striped">
            <!-- Agrega aquí las columnas del GridView -->
        </asp:GridView>
    </div>
</asp:Content>
