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
        static readonly string[] tabelas = { "SituacaoAtendimento", "TipoAtendimento", "SituacaoPedido", "CategoriaProduto", "CategoriaServico" };
        static readonly int[] lengths = { 40, 40, 40, 50, 50 };

        protected void btnCadSitAtend_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length < lengths[cbxTabelas.SelectedIndex])
            {
                lblGrande.Visible = false;
                conn.Open();
                SqlCommand sql = new SqlCommand("INSERT INTO " + tabelas[cbxTabelas.SelectedIndex] + " VALUES(@desc)", conn);
                sql.Parameters.AddWithValue("@desc", txtTexto.Text);
                sql.ExecuteNonQuery();
                conn.Close();
                txtTexto.Text = "";
            }
            else
                lblGrande.Visible = true;
        }

        protected void btnLimpar1_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            lblGrande.Visible = false;
        }
    }
}