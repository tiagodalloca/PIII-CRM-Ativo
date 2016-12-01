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

        protected void apagarTudo()
        {
            txtCPFCli.Text = "";
            txtDescCli.Text = "";
            txtEndCli.Text = "";
            txtEmailCli.Text = "";
            txtTelCli.Text = "";
            txtCelCli.Text = "";
            txtDataCli.Text = "";
            txtSiteCli.Text = "";
            txtRGCli.Text = "";
            txtSexoCli.Text = "";
            txtVIPCli.Text = "";
            txtIDCli.Text = "";
        }

        protected void setEnabledGeral(bool bo)
        {
                txtCPFCli.Enabled = bo;
                txtDescCli.Enabled = bo;
                txtEndCli.Enabled = bo;
                txtEmailCli.Enabled = bo;
                txtTelCli.Enabled = bo;
                txtCelCli.Enabled = bo;
                txtDataCli.Enabled = bo;
                txtSiteCli.Enabled = bo;
                txtRGCli.Enabled = bo;
                txtSexoCli.Enabled = bo;
                txtVIPCli.Enabled = bo;
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
                    SqlCommand sql = new SqlCommand("SELECT * FROM Cliente WHERE idCliente=@id", conn);
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
                        txtDataCli.Text = ((DateTime)dt[7]).ToString();
                        txtSiteCli.Text = (string)dt[8];
                        txtRGCli.Text = (string)dt[9];
                        txtSexoCli.Text = (string)dt[10];
                        txtVIPCli.Text = dt[11].ToString();
                        setEnabledGeral(true);
                    }

                    // fecha a conexão
                    btnAlterarCli.Visible = true;
                    dt.Close();
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('" + er.ToString() + "');</script>");
            }
        }

        protected void btnAlterarCli_Click1(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (Int32.TryParse(txtIDCli.Text, out id))
                {
                    SqlConnection conn = new SqlConnection("Data Source=regulus;Initial Catalog=ERP;Persist Security Info=True;User ID=ERP;Password=ERP2016");
                    conn.Open();
                    SqlCommand sql = new SqlCommand("update Cliente set CNPJCPF=@cnpj,descCliente =@desc,enderecoCompleto=@end,email=@email,telefone=@telefone,celular =@celular,dataNascimento=convert(datetime,@datetime),site=@site,RG=@rg,sexo=@sexo,idTipoCliente=@idTipoCliente  where idCliente = @id", conn);
                    sql.Parameters.AddWithValue("@cnpj", txtCPFCli.Text);
                    sql.Parameters.AddWithValue("@desc", txtDescCli.Text);
                    sql.Parameters.AddWithValue("@end", txtEndCli.Text);
                    sql.Parameters.AddWithValue("@email", txtEmailCli.Text);
                    sql.Parameters.AddWithValue("@telefone", txtTelCli.Text);
                    sql.Parameters.AddWithValue("@celular", txtCelCli.Text);
                    sql.Parameters.AddWithValue("@datetime", txtDataCli.Text);
                    sql.Parameters.AddWithValue("@site", txtSiteCli.Text);
                    sql.Parameters.AddWithValue("@rg", txtRGCli.Text);
                    sql.Parameters.AddWithValue("@sexo", txtSexoCli.Text);
                    sql.Parameters.AddWithValue("@idTipoCliente", txtVIPCli.Text);
                    sql.Parameters.AddWithValue("@id", txtIDCli.Text);

                    SqlDataReader dt = sql.ExecuteReader();

                    // fecha a conexão
                    dt.Close();
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('" + er.ToString() + "');</script>");
            }

            btnAlterarCli.Visible = true;
            apagarTudo();
            setEnabledGeral(false);
        }
    }
}