<%@ Page Title="Ajuda" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_Ajuda.aspx.cs" Inherits="Web_PIM._Ajuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/ajuda.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <h1 id="titulo">Tutorial</h1>
        <p>Alguma dúvida sobre o funcionamento do sistema? A sua dúvida será tirada aqui!</p>
        <br />
        <br />

        <h2 id="EditarDados">Editar Dados</h2>
        <p>A aba de editar dados é importantissima para todo primeiro acesso ao site, é nela que você confere se todos os seus dados estão corretos, e informa seu <b><i>Endereço de Carteira</i></b>, oque é crucial para nosso sistema funcionar dentro dos conformes...<br />Dentro de <b><i>Editar Dados</i></b> você pode alterar seu Nome, Email, Senha, CPF, Telefone, Data de Nascimento, e informar seu <b><i>Endereço de Carteira</i></b></p>
        <img id="tutorial1" src="Images/tutorial1.PNG"/>

        <h2 id="Relatorios">Relatórios</h2>
        <p>A aba de Relatórios possui algumas informações importantes para você investir em criptomoedas, a aba possui notícias, gráficos e relatórios. Sempre bom dar uma conferida nesta aba!</p>
        <img id="tutorial2" src="Images/tutorial2.PNG" />

        <h2 id="Investir">Investir</h2>
        <p>Essa é a aba mais importante para você que quer lucrar com o mercado de criptoativos, ao mesmo tempo que você pode ver o seu saldo em <i>Reais</i> no canto direito superior na <i>Carteira</i>, você pode solicitar um contrato de venda, ou um contrado de compra.</p>
        <img id="tutorial3" src="Images/tutorial3.PNG" />

        <h2 id="Carteira">Carteira</h2>
        <p>A aba da carteira é o seu ponto de partida, mas é importante que em <b><i>Editar Dados</i></b> você tenha informado o Endereço da sua carteira. Aqui você pode verificar seu saldo em reais e em criptoativos, você também pode fazer um depósito utilizando como base criptoativos.</p>
        <img id="tutorial4" src="Images/tutorial4.PNG" />
        <br />
        <br />
        <br />
        <br />

        <p>Ainda restou alguma dúvida? Entre em contato com a gente através do Email de suporte: <b>pimads2020@outlook.com</b> </p>
    </div>
</asp:Content>
