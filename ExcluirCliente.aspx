<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExcluirCliente.aspx.cs" Inherits="Web_TesteTec.ExcluirCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/excluirCliente.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="excluirCadastro">
        <h1>Excluir Cliente</h1>
        <p id="idCliente">ID do Cliente: </p>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />

        <p id="nome">Nome: </p><asp:TextBox ID="txtNome" runat="server" ReadOnly="True"></asp:TextBox>
        <p id="dataNasc">Data de Nascimento: </p><asp:TextBox ID="txtDataNasc" runat="server" ReadOnly="True"></asp:TextBox>
        <p id="status">Status: </p><asp:TextBox ID="txtStatus" runat="server" ReadOnly="False"></asp:TextBox>
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
    </div>
    <div id="aviso">
        <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
