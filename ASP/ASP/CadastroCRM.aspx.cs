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
        SqlConnection conn = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");

        protected void btnCadSitAtend_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO SituacaoAtendimento VALUES(@desc)", conn);
            sql.Parameters.AddWithValue("@desc", txtDescAtend.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            txtDescAtend.Text = "";
        }

        protected void btnCadastrarTipoAtendimento_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO TipoAtendimento VALUES(@desc)", conn);
            sql.Parameters.AddWithValue("@desc", txtTipoAtend.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            txtTipoAtend.Text = "";
        }

        protected void btnCadSit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO SituacaoPedido VALUES(@desc)", conn);
            sql.Parameters.AddWithValue("@desc", txtSitPed.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            txtSitPed.Text = "";
        }

        protected void btnCadDescProd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO CategoriaProduto VALUES(@desc)", conn);
            sql.Parameters.AddWithValue("@desc", txtDescProd.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            txtDescProd.Text = "";
        }

        protected void btnCadDescServ_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO CategoriaServico VALUES(@desc)", conn);
            sql.Parameters.AddWithValue("@desc", txtDescServ.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            txtDescServ.Text = "";
        }
    }
}