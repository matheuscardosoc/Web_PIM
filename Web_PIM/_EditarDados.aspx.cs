using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_PIM
{
    public partial class EditarDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();
            var preencher = from p in db.tabUser
                           where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                           select new 
                           { 
                                p.nomUser,
                                p.emailUser,
                                p.senhaUser,
                                p.cpfUser,
                                p.telUser,
                                p.dataUser
                           };
            string DataNascimento = "";
            foreach (var linha in preencher)
            {
                lblNome.Text = "Nome atual: " + linha.nomUser;
                lblEmail.Text = "Email atual: " + linha.emailUser;
                lblCPF.Text = "CPF atual: " + linha.cpfUser;
                lblTelefone.Text = "Telefone atual: " + linha.telUser;
                DataNascimento =  Convert.ToString(linha.dataUser);
            }
            string resultado = DataNascimento.Substring(0, DataNascimento.IndexOf("00:00:00"));
            lblDataNascimento.Text = "Data atual: " + resultado;
        }

        protected void btnNome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.Focus();
                txtNome.BorderColor = Color.Red;
                txtNome.BackColor = Color.LightPink;
            }
            else
            {
                PIMDataContext db = new PIMDataContext();

                var nome = (from p in db.tabUser
                            where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                            select p).Single();

                nome.nomUser = txtNome.Text;
                lblNome.Text = "Nome atual:" + nome.nomUser;

                db.SubmitChanges();
            }
        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                txtEmail.BorderColor = Color.Red;
                txtEmail.BackColor = Color.LightPink;
            }
            else
            {
                PIMDataContext db = new PIMDataContext();

                var nome = (from p in db.tabUser
                            where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                            select p).Single();

                nome.emailUser = txtEmail.Text;
                lblEmail.Text = "Email atual: " + nome.emailUser;

                db.SubmitChanges();
            }
        }

        protected void btnSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Focus();
                txtSenha.BorderColor = Color.Red;
                txtSenha.BackColor = Color.LightPink;
            }
            else 
            { 
            PIMDataContext db = new PIMDataContext();

            var nome = (from p in db.tabUser
                        where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                        select p).Single();

            nome.senhaUser = txtSenha.Text;

            db.SubmitChanges();
            }
        }

        protected void btnCPF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                txtCPF.Focus();
                txtCPF.BorderColor = Color.Red;
                txtCPF.BackColor = Color.LightPink;
            }
            else
            {
                PIMDataContext db = new PIMDataContext();

                var nome = (from p in db.tabUser
                            where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                            select p).Single();

                nome.cpfUser = txtCPF.Text;
                lblCPF.Text = "CPF atual: " + nome.cpfUser;

                db.SubmitChanges();
            }
        }

        protected void btnTelefone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                txtTelefone.Focus();
                txtTelefone.BorderColor = Color.Red;
                txtTelefone.BackColor = Color.LightPink;
            }
            else
            {
                PIMDataContext db = new PIMDataContext();

                var nome = (from p in db.tabUser
                            where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                            select p).Single();

                nome.telUser = txtTelefone.Text;
                lblTelefone.Text = "Telefone atual: " + nome.telUser;

                db.SubmitChanges();
            }
        }

        protected void btnDataNascimento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDataNascimento.Text))
            {
                txtDataNascimento.Focus();
                txtDataNascimento.BorderColor = Color.Red;
                txtDataNascimento.BackColor = Color.LightPink;
            }
            else
            {
                PIMDataContext db = new PIMDataContext();

                var nome = (from p in db.tabUser
                            where p.idUser.Equals(Convert.ToInt32(Session["idUser"]))
                            select p).Single();

                nome.dataUser = Convert.ToDateTime(txtDataNascimento.Text);
                string DataNascimento = Convert.ToString(nome.dataUser);
                string resultado = DataNascimento.Substring(0, DataNascimento.IndexOf("00:00:00"));
                lblDataNascimento.Text = "Data atual: " + resultado;

                db.SubmitChanges();
            }
        }

        protected void btnCarteira_Click(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            var consulta = from p in db.tabCarteira
                           where p.endCarteira == txtCarteira.Text
                           select new { p.idCarteira };

            int id = -1;

            foreach (var linha in consulta)
            {
                id = linha.idCarteira;
            }

            if (id >= 0)
            {
                Session["idCarteira"] = id;
            }
            else
            {
                tabCarteira Carteira = new tabCarteira();
                Carteira.endCarteira = txtCarteira.Text;
                Carteira.idTipoRegis = 1;
                Carteira.idUser = Convert.ToInt32(Session["idUser"]);
                Carteira.saldoCarteira = 0;

                db.tabCarteira.InsertOnSubmit(Carteira);
                db.SubmitChanges();


                var consulta2 = from p in db.tabCarteira
                               where p.endCarteira == txtCarteira.Text
                               select new { p.idCarteira };

                foreach (var linha in consulta2)
                {
                    id = linha.idCarteira;
                }

                Session["idCarteira"] = id;
            }
            
        }
    }
}