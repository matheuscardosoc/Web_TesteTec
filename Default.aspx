<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_TesteTec.Pages.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/default.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <p>Desafio técnico, feito por <b>Matheus Cardoso Coelho</b>.</p><br />
        <p>Para alterar e consultar dados, acesse a aba <b>Editar Dados</b>.</p>
        <p>Para cadastrar um novo cliente, acesse a aba <b>Cadastrar Cliente</b>.</p>
        <p>Para excluir algum cliente, acesse a aba <b>Excluir Cliente</b>.</p>
    </div>
</asp:Content>
