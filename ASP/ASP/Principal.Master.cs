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
            if (txtNome.Text == "")
            {
                tirarMensagens();
                MNSI.Visible = true;
                return;
            }
            if (txtSenha.Text == "")
            {
                tirarMensagens();
                MSI.Visible = true;
                return;
            }

            SqlConnection conne = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");
            conne.Open();
            SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM AcessoFuncionario WHERE loginFuncionario=@name and senhaFuncionario=@senha", conne);
            sql.Parameters.AddWithValue("@name", txtNome.Text);
            sql.Parameters.AddWithValue("@senha", txtSenha.Text);
            SqlDataReader dt = sql.ExecuteReader();
            if (dt.Read())
            {
                if (dt.GetInt32(0) == 0)
                {
                    tirarMensagens();
                    MUNSI.Visible = true;
                    return;
                }
                Response.Redirect("CadastroCRM.aspx");
                // existe no BD
            }
            else
            {
                tirarMensagens();
                MEC.Visible = true;
            }
            dt.Close();
            conne.Close();
        }
    }
}