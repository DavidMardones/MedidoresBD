<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLectura.aspx.cs" Inherits="MedidoresBD.MostrarLectura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Mostrar Lectura</h2>
        <asp:GridView ID="gridLecturas" runat="server" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="idLectura" HeaderText="ID Lectura" />
                <asp:BoundField DataField="numeroSerie" HeaderText="Número de Serie" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="hora" HeaderText="Hora" DataFormatString="{0:hh:mm tt}" />
                <asp:BoundField DataField="valorConsumo" HeaderText="Valor de Consumo" DataFormatString="{0:N2}" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
