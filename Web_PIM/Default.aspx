<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_PIM.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/default.css" />
    <style type="text/css">
        body {
            background-image: url(Images/background.png);
            background-size: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principalContent">
        <p>PIM um site onde você pode confiar para investir em criptomoedas. Aqui você recebe relatórios, gráficos e notícias sobre o mercado, e ainda tem um sistema para que você possa comprar e vender criptoativos. Aqui você pode lucrar com segurança, e se tiver alguma dúvida, depois de logado você tem uma aba de <i>Ajuda/Tutoriais</i> para consultar, e ainda tem uma equipe de suporte caso ocorra algum problema. Está esperando o que? Clique em <b><i>Cadastrar-se</i></b> em nosso menu, e entre no mundo das criptomoedas através de nosso site.</p>
        <img id="default" src="Images/default.png" />
        <p>Alguma dúvida? Acesse a aba <a id="Sobre" href="Sobre.aspx">Sobre</a>.</p>
    </div>
</asp:Content>