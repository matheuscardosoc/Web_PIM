using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_PIM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            PIMDataContext db = new PIMDataContext();

            // Consulta e validação Email e Senha

            var consulta = from p in db.tabUser
                           where p.emailUser == txtEmail.Text && p.senhaUser == txtSenha.Text
                           select new { p.idUser };

            int id = -1;

            foreach (var linha in consulta)
            {
                id = linha.idUser;
            }

            if(id >= 0)
            {
                Session["idUser"] = id;
                Response.Redirect("_Home.aspx?");
            }
            else
            {
                lblErro.Text = "Erro! Email ou Senha digitados não registrados ou confirmados!";
            }

        }
    }
}
