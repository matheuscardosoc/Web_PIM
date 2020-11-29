<%@ Page Title="Home" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_Home.aspx.cs" Inherits="Web_PIM.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/home.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <p>Olá seja bem-vindo. Aqui você pode controlar seu investimentos em criptoativos, acompanhando relatórios e gráficos de movimentação de criptoativos, e com um sistema funcional e seguro para a negociação de criptomoedas.</p>
        <p>Para começar entre em <b><i>Editar Dados</i></b> e informe o seu <i><b>Endereço de Carteira</b></i>. Veja o exemplo na imagem a seguir: </p>
        <img id="exemplo" src="Images/exemplo.PNG" />
    </div>
</asp:Content>
