using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tirarMensagens()
        {
            MSI.Visible = false;
            MNSI.Visible = false;
            MUNSI.Visible = false;
            MEC.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") // nome não foi digitado
            {
                tirarMensagens();
                MNSI.Visible = true;
                return;
            }
            if (txtSenha.Text == "") // senha não foi digitada
            {
                tirarMensagens();
                MSI.Visible = true;
                return;
            }

            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            // abrindo a conexão com o banco de dados
            SqlConnection conne = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");
            conne.Open();

            // operando com o select, impedindo "SQL Injection"
            SqlCommand sql = new SqlCommand("SELECT COUNT(*) as c, IdFunc as i FROM AcessoFuncionario WHERE loginFuncionario=@name and senhaFuncionario=@senha GROUP BY idFunc", conne);
            sql.Parameters.AddWithValue("@name", nome);
            sql.Parameters.AddWithValue("@senha", senha);

            // Executando o select
            SqlDataReader dt = sql.ExecuteReader();
            if (dt.Read())
            {
                if ((int)dt[0] == 0) // não tem no banco
                {
                    tirarMensagens();
                    MUNSI.Visible = true;
                    return;
                }

                // existe no BD
                // armazena na Session(que nem PHP)
                Session["IDFunc"] = (int)dt[1];
                Session["NomeFunc"] = nome;
                Session["SenhaFunc"] = senha;

                // Muda de página
                Response.Redirect("CadastroCRM.aspx");
            }
            else // não tem dados (provavelmente erro de conexão)
            {
                tirarMensagens();
                MEC.Visible = true;
            }
            dt.Close(); // fechando as conexões
            conne.Close();
        }
    }
}