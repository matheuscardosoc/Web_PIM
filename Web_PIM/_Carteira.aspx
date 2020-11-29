<%@ Page Title="Carteira" Language="C#" MasterPageFile="~/SiteLogado.Master" AutoEventWireup="true" CodeBehind="_Carteira.aspx.cs" Inherits="Web_PIM._Carteira" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="Styles/carteira.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <div class="SaqDep">
            <p id="Saq">Saque</p>
            <p id="Saque">Quantia a Sacar:</p>
            <p id="TipoMoeda">Tipo da Moeda:</p>
            <asp:TextBox ID="txtEscolha" runat="server" placeholder="*BTC* *ETH* *LTC* *XRP*"></asp:TextBox>
            <asp:TextBox ID="txtSaque" runat="server" placeholder="x,xxxxxx"></asp:TextBox>
            <asp:Button ID="btnSaque" runat="server" Text="Realizar Saque" OnClick="btnSaque_Click" />

            <p id="Dep">Depósito</p>
            <p id="Deposito">Quantia a Depositar:</p>
            <p id="TipoMoeda2">Tipo da Moeda:</p>
            <asp:TextBox ID="txtEscolha2" runat="server" placeholder="*BTC* *ETH* *LTC* *XRP*"></asp:TextBox>
            <asp:TextBox ID="txtDeposito" runat="server" placeholder="x,xxxxxx"></asp:TextBox>
            <asp:Button ID="btnDeposito" runat="server" Text="Realizar Depósito" OnClick="btnDeposito_Click" />
            
        </div>
        <div class="Saldo">
            <p id="Sal">Saldo</p>
            <p id="TipoMoeda3">Tipo da Moeda:</p>
            <asp:TextBox ID="txtEscolha3" runat="server" placeholder="*BTC* *ETH* *LTC* *XRP*"></asp:TextBox>
            <p id="Saldo">Seu saldo é:</p>
            <asp:TextBox ID="txtSaldo" runat="server" Enabled="False"></asp:TextBox>
            <asp:LinkButton ID="lnkAjuda2" runat="server" PostBackUrl="~/_Ajuda.aspx">Precisa de Ajuda?</asp:LinkButton>
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
        </div>
    </div>
</asp:Content>