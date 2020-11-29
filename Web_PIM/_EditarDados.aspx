<%@ Page Title="Editar Dados" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_EditarDados.aspx.cs" Inherits="Web_PIM.EditarDados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/editardados.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <div class="editarDados">
            <h1 id="titulo">Configuração dos dados</h1>

            <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
            <p id="Nome">Nome:</p>
            <asp:TextBox ID="txtNome" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnNome" runat="server" Text="Aplicar" OnClick="btnNome_Click" />

            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
            <p id="Email">Email:</p>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Text=""></asp:TextBox>
            <asp:Button ID="btnEmail" runat="server" Text="Solicitar" OnClick="btnEmail_Click" />

            <p id="Senha">Senha:</p>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnSenha" runat="server" Text="Solicitar" OnClick="btnSenha_Click" />


            <asp:Label ID="lblCPF" runat="server" Text="Label"></asp:Label>
            <p id="CPF">CPF:</p>
            <asp:TextBox ID="txtCPF" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnCPF" runat="server" Text="Solicitar" OnClick="btnCPF_Click" />

            <asp:Label ID="lblTelefone" runat="server" Text="Label"></asp:Label>
            <p id="Telefone">Telefone:</p>
            <asp:TextBox ID="txtTelefone" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnTelefone" runat="server" Text="Aplicar" OnClick="btnTelefone_Click" />

            <asp:Label ID="lblDataNascimento" runat="server" Text="Label"></asp:Label>
            <p id="DataNascimento">Data de Nascimento:</p>
            <asp:TextBox ID="txtDataNascimento" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnDataNascimento" runat="server" Text="Solicitar" OnClick="btnDataNascimento_Click" />


            <p id="Carteira">Carteira:</p>
            <asp:TextBox ID="txtCarteira" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnCarteira" runat="server" Text="Aplicar" OnClick="btnCarteira_Click" />
            <asp:LinkButton ID="lnkAjuda" runat="server" PostBackUrl="~/_Ajuda.aspx">Precisa de Ajuda?</asp:LinkButton>
        </div>
    </div>

</asp:Content>
