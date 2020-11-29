using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_PIM
{
    public partial class _Investir : System.Web.UI.Page
    {
        float saldo = 0;
        float cotBTC = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            var preencher = from p in db.tabCarteira
                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                            select new { p.saldoCarteira };

            foreach (var linha in preencher)
            {
                saldo = (float)linha.saldoCarteira;
            }

            txtSaldo.Text = "R$ " + Convert.ToString(saldo);


            var preencher2 = from p in db.tabMoedas
                             where p.nomTipo == "BTC"
                            select new { p.cotMoeda };

            foreach (var linha in preencher2)
            {
                cotBTC = (float)linha.cotMoeda;
            }

        }

        protected void btnSolicitarCompra_Click(object sender, EventArgs e)
        {
            lblConfirmacao2.Text = " ";

            if (txtPreco2.Text == "" || txtPreco2.Text == " ")
            {

            }
            else
            {
                float preco = float.Parse(txtPreco2.Text);

                if (preco > saldo)
                {
                    lblConfirmacao2.Text = "Saldo Insuficiente!";
                    lblConfirmacao1.Text = "";
                }
                else if (preco == 0)
                {
                    lblConfirmacao2.Text = "Valor Inválido";
                    lblConfirmacao1.Text = "";
                }
                else if (preco <= saldo)
                {
                    lblConfirmacao2.Text = "Contrato solicitado com sucesso!";
                    lblConfirmacao1.Text = "";
                }
                else
                {
                    lblConfirmacao2.Text = "Valor Inválido";
                    lblConfirmacao1.Text = "";
                }
            }
        }

        protected void btnSolicitarVenda_Click(object sender, EventArgs e)
        {
            if (txtMoeda.Text == "")
            {

            }
            else
            {
                float moeda = float.Parse(txtMoeda.Text);

                if (saldo / cotBTC < moeda)
                {
                    lblConfirmacao1.Text = "Você não possui esta quantia de moedas!";
                    lblConfirmacao2.Text = "";
                }
                else if (moeda >= 0)
                {
                    lblConfirmacao1.Text = "Contrato solicitado com sucesso!";
                    lblConfirmacao2.Text = "";
                }
                else
                {
                    lblConfirmacao1.Text = "Valor Inválido!";
                    lblConfirmacao2.Text = "";
                }
            }
        }
    }
}