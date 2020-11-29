<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Web_PIM.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/cadastro.css" />
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <div class="LogCad">
            <h1 id="Cadastro">Cadastro</h1>
            <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" required=""></asp:TextBox>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" TextMode="Email" required=""></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" TextMode="Password" required=""></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCPF" runat="server" placeholder="CPF *xxx.xxx.xxx-xx*" required=""></asp:TextBox>
            <br />
            <asp:TextBox ID="txtTelefone" runat="server" placeholder="Telefone *Somente Números*" TextMode="Phone" required=""></asp:TextBox>
            <br />
            <p id="Nasc">Data de Nascimento:</p><asp:TextBox ID="txtDataNascimento" runat="server" placeholder="01/01/2001" TextMode="Date" required=""></asp:TextBox>
            <br />
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar-se" OnClick="btnCadastro_Click" />
            <br />
            <asp:LinkButton runat="server" PostBackUrl="~/Login.aspx" ID="Login">Já tenho uma conta!</asp:LinkButton>
        </div>
    </div>
</asp:Content>
