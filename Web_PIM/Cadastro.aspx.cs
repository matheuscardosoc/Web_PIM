using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_PIM
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            // Instanciando o DataContext
            PIMDataContext db = new PIMDataContext();

            // Instanciando a classe tabUser
            tabUser User = new tabUser();
            User.nomUser = txtNome.Text;
            User.emailUser = txtEmail.Text;
            User.senhaUser = txtSenha.Text;
            User.cpfUser = txtCPF.Text;
            User.telUser = txtTelefone.Text;
            User.dataUser = Convert.ToDateTime(txtDataNascimento.Text);

            db.tabUser.InsertOnSubmit(User);
            db.SubmitChanges();


            Response.Redirect("Login.aspx");
        }
    }
}