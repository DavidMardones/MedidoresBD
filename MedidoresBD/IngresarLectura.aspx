<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresBD.IngresarLectura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Ingresar Lectura</h2>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNumeroSerie">Número de Serie:</label>
                    <asp:TextBox ID="txtNumeroSerie" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtFecha">Fecha:</label>
                    <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtHora">Hora:</label>
                    <asp:TextBox ID="txtHora" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtValorConsumo">Valor de Consumo:</label>
                    <asp:TextBox ID="txtValorConsumo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        </div>
    </div>
</asp:Content>
