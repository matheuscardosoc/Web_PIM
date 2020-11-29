<%@ Page Title="Relatórios" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_Relatorios.aspx.cs" Inherits="Web_PIM.Relatorios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/relatorios.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <h1 id="titulo">Relatórios</h1>

        <h3 id="Report1">Report Bitcoin</h3>
        <p id="pReport1">Cotação de Bitcoin continua subindo desde de Outubro. A cotação da criptomoeda já chega no valor de R$ 91.196.<br /><br />Foto do dia 16/11 às 16:30h:</p>
        <img id="imgReport1" src="Images/bitcoin.png" alt="Variação da Cotação da Bitcoin" />
        <p id="pFonte1">Fonte:</p><a id="Fonte1" href="https://www.infomoney.com.br/cotacoes/bitcoin-btc/" target="_blank" >InfoMoney</a>
        
        <h3 id="Report2">Report Ethereum</h3>
        <p id="pReport2">Ethereum instável no mercado, a tendência é que o valor da criptomoeda volte a aumentar. Valor atual é de R$ 2.512.<br /><br />Gráfico do dia 15/11/2020:</p>
        <img id="imgReport2" src="Images/ethereum.png" alt="Variação da Cotação da Ethereum" />
        <p id="pFonte2">Fonte:</p><a id="Fonte2" href="www.google.com/search?q=ethereum+cotação&ie=UTF-8&oe=UTF-8" target="_blank">Google</a>

        <h3 id="Report3">Report Litecoin</h3>
        <p id="pReport3">Litecoin tem boa variação na última semana, mas a tendência é que isso não dure muito tempo. O valor atual é de R$ 388,09.<br /><br />Gráfico do dia 16/11/2020:</p>
        <img id="imgReport3" src="Images/litecoin.png" alt="Variação da Cotação da Litecoin" />
        <p id="pFonte3">Fonte:</p><a id="Fonte3" href="https://www.infomoney.com.br/cotacoes/litecoin-ltc/" target="_blank" >InfoMoney</a>

        <h3 id="Report4">Report Ripple</h3>
        <p id="pReport4">O Ripple está na cotação de R$ 1,73 no momento atual. Mas você sabe como usar o Ripple? <a href="https://foxbit.com.br/blog/tudo-sobre-o-ripple/#:~:text=A%20criptomoeda%20XRP%20funciona%20da,e%20reduzindo%20custos%20dessas%20instituições.&text=A%20proposta%20principal%20do%20Ripple,de%20forma%20rápida%20e%20barata." target="_blank">Clique aqui</a> para saber mais sobre a criptomoeda e como ela funciona.</p>
    </div>
</asp:Content>
