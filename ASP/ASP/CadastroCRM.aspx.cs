using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP
{
    public partial class CadastroCRM1 : System.Web.UI.Page
    {
        // A conexão
        SqlConnection conn = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");
        // vetores que relacionam-se com o BD
        static readonly string[] tabelas = { "SituacaoAtendimento", "TipoAtendimento", "SituacaoPedido", "CategoriaProduto", "CategoriaServico" };
        static readonly int[] lengths = { 40, 40, 40, 50, 50 };

        protected void btnCadSitAtend_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length < lengths[cbxTabelas.SelectedIndex]) // se tiver um tamanho adequado ao banco
            {
                lblGrande.Visible = false;

                // abre a conexão para certa tabela
                conn.Open();
                SqlCommand sql = new SqlCommand("INSERT INTO " + tabelas[cbxTabelas.SelectedIndex] + " VALUES(@desc)", conn);
                sql.Parameters.AddWithValue("@desc", txtTexto.Text);
                sql.ExecuteNonQuery();

                // fecha a conexão
                conn.Close();
                txtTexto.Text = "";
            }
            else
                lblGrande.Visible = true; // mostra mensagem de erro
        }

        protected void btnLimpar1_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            lblGrande.Visible = false;
        }

        internal static bool isset(Object m)
        {
            return (@m == null) ? false : true; // @ indica literalmente("\n" é considerado como "\n" e não quebra de linha)
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(isset(Session["NomeFunc"]) && isset(Session["SenhaFunc"]) && isset(Session["IDFunc"]))) // não tem nada na Session(não veio por Principal.Master)
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}