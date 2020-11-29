<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_PIM.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/login.css" />
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
            <h1 id="Login">Login</h1>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="E-mail"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" placeholder="Senha"></asp:TextBox>
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Login" OnClick="btnEntrar_Click" />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar-se" PostBackUrl="~/Cadastro.aspx" />
            <a id="Sobre" href="Sobre.aspx">Sobre nós</a>
            <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        </div>
     </div>
</asp:Content>
