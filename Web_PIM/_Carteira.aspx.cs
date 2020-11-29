using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_PIM
{
    public partial class _Carteira : System.Web.UI.Page
    {
        float saldo = 0;
        float cotBTC = 0;
        float cotLTC = 0;
        float cotETH = 0;
        float cotXRP = 0;

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
                             where p.nomTipo.Equals("BTC")
                             select new { p.cotMoeda };

            foreach (var linha in preencher2)
            {
                cotBTC = linha.cotMoeda;
            }


            var preencher3 = from p in db.tabMoedas
                             where p.nomTipo.Equals("ETH")
                             select new { p.cotMoeda };

            foreach (var linha in preencher3)
            {
                cotETH = linha.cotMoeda;
            }


            var preencher4 = from p in db.tabMoedas
                             where p.nomTipo.Equals("LTC")
                             select new { p.cotMoeda };

            foreach (var linha in preencher4)
            {
                cotLTC = linha.cotMoeda;
            }


            var preencher5 = from p in db.tabMoedas
                             where p.nomTipo.Equals("XRP")
                             select new { p.cotMoeda };

            foreach (var linha in preencher5)
            {
                cotXRP = linha.cotMoeda;
            }
        }

        protected void btnSaque_Click(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            if (txtSaque.Text == "" || txtSaque.Text == " ")
            {

            }
            else
            {
                float saque = float.Parse(txtSaque.Text);
                if (txtEscolha.Text == "BTC")
                {
                    if (saque * cotBTC > saldo)
                    {
                        txtSaque.Focus();
                        txtSaque.BorderColor = Color.Red;
                        txtSaque.BackColor = Color.LightPink;
                        txtSaque.Text = "Saldo Insuficiente!";
                    }
                    else
                    {
                        if (saque >= 0)
                        {
                            var preencher = from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select new { p.saldoCarteira };

                            foreach (var linha in preencher)
                            {
                                saldo = (float)linha.saldoCarteira;
                            }

                            saldo -= saque * cotBTC;
                            txtEscolha3.Text = "BTC";
                            txtSaldo.Text = "BTC " + saldo / cotBTC;

                            var carteira = (from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select p).Single();

                            carteira.saldoCarteira = saldo;

                            db.SubmitChanges();
                        }
                    }
                }
                else if (txtEscolha.Text == "ETH")
                {
                    if (saque * cotETH > saldo)
                    {
                        txtSaque.Focus();
                        txtSaque.BorderColor = Color.Red;
                        txtSaque.BackColor = Color.LightPink;
                        txtSaque.Text = "Saldo Insuficiente!";
                    }
                    else
                    {
                        if (saque >= 0)
                        {
                            var preencher = from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select new { p.saldoCarteira };

                            foreach (var linha in preencher)
                            {
                                saldo = (float)linha.saldoCarteira;
                            }

                            saldo -= saque * cotETH;
                            txtEscolha3.Text = "ETH";
                            txtSaldo.Text = "ETH " + saldo / cotETH;

                            var carteira = (from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select p).Single();

                            carteira.saldoCarteira = saldo;

                            db.SubmitChanges();
                        }
                    }
                }
                else if (txtEscolha.Text == "LTC")
                {
                    if (saque * cotLTC > saldo)
                    {
                        txtSaque.Focus();
                        txtSaque.BorderColor = Color.Red;
                        txtSaque.BackColor = Color.LightPink;
                        txtSaque.Text = "Saldo Insuficiente!";
                    }
                    else
                    {
                        if (saque >= 0)
                        {
                            var preencher = from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select new { p.saldoCarteira };

                            foreach (var linha in preencher)
                            {
                                saldo = (float)linha.saldoCarteira;
                            }

                            saldo -= saque * cotLTC;
                            txtEscolha3.Text = "LTC";
                            txtSaldo.Text = "LTC " + saldo / cotLTC;

                            var carteira = (from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select p).Single();

                            carteira.saldoCarteira = saldo;

                            db.SubmitChanges();
                        }
                    }
                }
                else if (txtEscolha.Text == "XRP")
                {
                    if (saque * cotXRP > saldo)
                    {
                        txtSaque.Focus();
                        txtSaque.BorderColor = Color.Red;
                        txtSaque.BackColor = Color.LightPink;
                        txtSaque.Text = "Saldo Insuficiente!";
                    }
                    else
                    {
                        if (saque >= 0)
                        {
                            var preencher = from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select new { p.saldoCarteira };

                            foreach (var linha in preencher)
                            {
                                saldo = (float)linha.saldoCarteira;
                            }

                            saldo -= saque * cotXRP;
                            txtEscolha3.Text = "XRP";
                            txtSaldo.Text = "XRP " + saldo / cotXRP;

                            var carteira = (from p in db.tabCarteira
                                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                            select p).Single();

                            carteira.saldoCarteira = saldo;

                            db.SubmitChanges();
                        }
                    }
                }
                else
                {
                    txtSaque.Focus();
                    txtSaque.BorderColor = Color.Red;
                    txtSaque.BackColor = Color.LightPink;
                    txtSaque.Text = "Erro! Tipos: *BTC* *ETH* *LTC* *XRP*";
                    
                }
            }
        }

        protected void btnDeposito_Click(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            if (txtDeposito.Text == "" || txtDeposito.Text == " ")
            {

            }
            else
            {
                float deposito = float.Parse(txtDeposito.Text);
                if (txtEscolha2.Text == "BTC")
                {
                    if (deposito >= 0)
                    {
                        var preencher = from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select new { p.saldoCarteira };

                        foreach (var linha in preencher)
                        {
                            saldo = (float)linha.saldoCarteira;
                        }

                        saldo += deposito * cotBTC;
                        txtEscolha3.Text = "BTC";
                        txtSaldo.Text = "BTC " + saldo / cotBTC;

                        var carteira = (from p in db.tabCarteira
                                    where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                    select p).Single();

                        carteira.saldoCarteira = saldo;

                        db.SubmitChanges();
                    }
                    else
                    {
                        txtDeposito.Focus();
                        txtDeposito.BorderColor = Color.Red;
                        txtDeposito.BackColor = Color.LightPink;
                        txtDeposito.Text = "Erro! Valor Inválido";
                    }
                }
                else if (txtEscolha2.Text == "ETH")
                {
                    if (deposito >= 0)
                    {
                        var preencher = from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select new { p.saldoCarteira };

                        foreach (var linha in preencher)
                        {
                            saldo = (float)linha.saldoCarteira;
                        }

                        saldo += deposito * cotETH;
                        txtEscolha3.Text = "ETH";
                        txtSaldo.Text = "ETH " + saldo / cotETH;

                        var carteira = (from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select p).Single();

                        carteira.saldoCarteira = saldo;

                        db.SubmitChanges();
                    }
                    else
                    {
                        txtDeposito.Focus();
                        txtDeposito.BorderColor = Color.Red;
                        txtDeposito.BackColor = Color.LightPink;
                        txtDeposito.Text = "Erro! Valor Inválido";
                    }
                }
                else if (txtEscolha2.Text == "LTC")
                {
                    if (deposito >= 0)
                    {
                        var preencher = from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select new { p.saldoCarteira };

                        foreach (var linha in preencher)
                        {
                            saldo = (float)linha.saldoCarteira;
                        }

                        saldo += deposito * cotLTC;
                        txtEscolha3.Text = "LTC";
                        txtSaldo.Text = "LTC " + saldo / cotLTC;

                        var carteira = (from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select p).Single();

                        carteira.saldoCarteira = saldo;

                        db.SubmitChanges();
                    }
                    else
                    {
                        txtDeposito.Focus();
                        txtDeposito.BorderColor = Color.Red;
                        txtDeposito.BackColor = Color.LightPink;
                        txtDeposito.Text = "Erro! Valor Inválido";
                    }
                }
                else if (txtEscolha2.Text == "XRP")
                {
                    if (deposito >= 0)
                    {
                        var preencher = from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select new { p.saldoCarteira };

                        foreach (var linha in preencher)
                        {
                            saldo = (float)linha.saldoCarteira;
                        }

                        saldo += deposito * cotBTC;
                        txtEscolha3.Text = "XRP";
                        txtSaldo.Text = "XRP " + saldo / cotBTC;

                        var carteira = (from p in db.tabCarteira
                                        where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                                        select p).Single();

                        carteira.saldoCarteira = saldo;

                        db.SubmitChanges();
                    }
                    else
                    {
                        txtDeposito.Focus();
                        txtDeposito.BorderColor = Color.Red;
                        txtDeposito.BackColor = Color.LightPink;
                        txtDeposito.Text = "Erro! Valor Inválido";
                    }
                }
                else
                {
                    txtDeposito.Focus();
                    txtDeposito.BorderColor = Color.Red;
                    txtDeposito.BackColor = Color.LightPink;
                    txtDeposito.Text = "Erro! Tipos: *BTC* *ETH* *LTC* *XRP*";
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            var preencher = from p in db.tabCarteira
                            where p.idCarteira.Equals(Convert.ToInt32(Session["idCarteira"]))
                            select new { p.saldoCarteira };

            foreach (var linha in preencher)
            {
                saldo = (float)linha.saldoCarteira;
            }

            txtSaldo.Text = Convert.ToString(saldo);

            if (txtEscolha3.Text == "BTC")
            {
                txtSaldo.Text = "BTC " + saldo / cotBTC;
            }
            else if (txtEscolha3.Text == "ETH")
            {
                txtSaldo.Text = "ETH " + saldo / cotETH;
            }
            else if (txtEscolha3.Text == "LTC")
            {
                txtSaldo.Text = "LTC " + saldo / cotLTC;
            }
            else if (txtEscolha3.Text == "XRP")
            {
                txtSaldo.Text = "XRP " + saldo / cotXRP;
            }
            else
            {
                txtSaldo.Text = "R$ " + saldo;
            }
        }
    }
}