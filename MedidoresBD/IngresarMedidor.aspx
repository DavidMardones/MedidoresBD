<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="MedidoresBD.IngresarMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Ingresar Medidor</h2>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="txtNumeroSerie">Número de Serie:</label>
                    <asp:TextBox ID="txtNumeroSerie" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="ddlTipo">Tipo:</label>
                    <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Tipo 1" Value="Tipo1"></asp:ListItem>
                        <asp:ListItem Text="Tipo 2" Value="Tipo2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        </div>
    </div>
</asp:Content>
