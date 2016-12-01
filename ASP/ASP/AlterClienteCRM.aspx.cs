using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP
{
    public partial class AcessoCRM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        internal static bool isset(Object m)
        {
            return (@m == null) ? false : true; // @ indica literalmente("\n" é considerado como "\n" e não quebra de linha)
        }

        internal static bool estaVazio(TextBox txt)
        {
            return (txt.Text == "");
        }

        protected void btnAlterarCli_Click(object sender, EventArgs e)
        {
            //if (estaVazio(txtCelCli) && estaVazio(txtCPFCli) && estaVazio(txtDataCli) && estaVazio(txtDescCli) && estaVazio(txtEmailCli) && estaVazio(txtEndCli) && estaVazio(txtIDCli) && estaVazio(txtRGCli) && estaVazio(txtSexoCli) && estaVazio(txtSiteCli) && estaVazio(txtTelCli) && estaVazio(txtVIPCli))
            //    return;
        }

        protected void txtIDCli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int oIDDoClienteASerProcuradoNoBancoDeDados = 0;
                if (Int32.TryParse(txtIDCli.Text, out oIDDoClienteASerProcuradoNoBancoDeDados))
                {
                    SqlConnection conn = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");
                    conn.Open();
                    SqlCommand sql = new SqlCommand("SELECT * FROM Cliente WHERE ID=@id", conn);
                    sql.Parameters.AddWithValue("@id", oIDDoClienteASerProcuradoNoBancoDeDados);
                    SqlDataReader dt = sql.ExecuteReader();
                    if (dt.Read())
                    {
                        txtCPFCli.Text = (string)dt[1];
                        txtDescCli.Text = (string)dt[2];
                        txtEndCli.Text = (string)dt[3];
                        txtEmailCli.Text = (string)dt[4];
                        txtTelCli.Text = (string)dt[5];
                        txtCelCli.Text = (string)dt[6];
                        txtDataCli.Text = (string)dt[7];
                        txtSiteCli.Text = (string)dt[8];
                        txtRGCli.Text = (string)dt[9];
                        txtSexoCli.Text = (string)dt[10];
                        txtVIPCli.Text = (string)dt[11];
                    }

                    // fecha a conexão
                    dt.Close();
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('"+er.ToString()+"');</script>");
            }
        }
    }
}