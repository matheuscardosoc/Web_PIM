<%@ Page Title="Investir" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_Investir.aspx.cs" Inherits="Web_PIM._Investir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/investir.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <div class="Investir">
            <p id="Texto">Solicitar a compra e venda de moedas</p>
            <p id="Moeda">Moeda:</p> <asp:TextBox ID="txtMoeda" runat="server" placeholder="x.xxxxx" ></asp:TextBox>
            <br />
            <p id="Preco">Preço:</p> <asp:TextBox ID="txtPreco" runat="server" placeholder="xxx.xxx,xx"></asp:TextBox>
            <br />
            <p id="Tipo">Tipo:</p>
            <asp:DropDownList id="DropList" Runat="Server">
                <asp:ListItem Text="Bitcoin - BTC" Value="BTC" />
                <asp:ListItem Text="Ethereum - ETH" Value="ETH"/>
                <asp:ListItem Text="Litecoin - LTC" Value="LTC"/>
                <asp:ListItem Text="Ripple - XRP" Value="XRP"/>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblConfirmacao1" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnSolicitarVenda" runat="server" Text="Solicitar Contrato de Venda" OnClick="btnSolicitarVenda_Click" />

            <p id="Moeda2">Moeda:</p> <asp:TextBox ID="txtMoeda2" runat="server" placeholder="x.xxxxx" ></asp:TextBox>
            <br />
            <p id="Preco2">Preço:</p> <asp:TextBox ID="txtPreco2" runat="server" placeholder="xxx.xxx,xx"></asp:TextBox>
            <br />
            <p id="Tipo2">Tipo:</p>
            <asp:DropDownList id="DropList2" Runat="Server">
                <asp:ListItem Text="Bitcoin - BTC" Value="BTC" />
                <asp:ListItem Text="Ethereum - ETH" Value="ETH"/>
                <asp:ListItem Text="Litecoin - LTC" Value="LTC"/>
                <asp:ListItem Text="Ripple - XRP" Value="XRP"/>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblConfirmacao2" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnSolicitarCompra" runat="server" Text="Solicitar Contrato de Compra" OnClick="btnSolicitarCompra_Click" />
            <asp:LinkButton ID="lnkAjuda1" runat="server" PostBackUrl="~/_Ajuda.aspx">Precisa de Ajuda?</asp:LinkButton>
        </div>
        <div class="Saldo">
            <p id="Carteira">Carteira</p>
            <p id="Saldo">Saldo:</p> <asp:TextBox ID="txtSaldo" runat="server" Text="Saldo Zero" Enabled="False"></asp:TextBox>
            <asp:LinkButton ID="lnkAjuda" runat="server" PostBackUrl="~/_Ajuda.aspx">Precisa de Ajuda?</asp:LinkButton>
        </div>
    </div>
</asp:Content>
