<%@ Page Title="Editar Dados" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarDados.aspx.cs" Inherits="Web_TesteTec.Pages.EditarDados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles\EditarDados.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div id="consultar">
        <h1>Editar Dados</h1>
        <p>Digite o ID:</p>
        <asp:TextBox ID="txtConsultar" runat="server"></asp:TextBox>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        </div>

        <div id="dados">
            <h1>Dados do Cliente</h1>
            <asp:Label ID="lblID" runat="server" Text="Dados do ID: "></asp:Label>

            <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
            <p id="nome">Alterar para: </p>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <asp:Button ID="btnNome" runat="server" Text="Alterar" OnClick="btnNome_Click" /><br />

            <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento:"></asp:Label>
            <p id="dataNasc">Alterar para: </p>
            <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date" ></asp:TextBox>
            <asp:Button ID="btnDataNasc" runat="server" Text="Alterar" OnClick="btnDataNasc_Click" /><br />

            <asp:Label ID="lblStatus" runat="server" Text="Status atual: "></asp:Label>
            <p id="status">Alterar para:</p>
            <asp:RadioButtonList ID="rbStatus" runat="server">
                <asp:ListItem Value="true">Ativo</asp:ListItem>
                <asp:ListItem Value="false">Inativo</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnStatus" runat="server" Text="Alterar" OnClick="btnStatus_Click" />

        </div>

    </div>
</asp:Content>
