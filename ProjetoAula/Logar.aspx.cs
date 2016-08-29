using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btn_Logar_Click(object sender, EventArgs e)
    {
        
        String conString = WebConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
        MetodosBD acessoBD = new MetodosBD();
        acessoBD.Connection(conString);
        acessoBD.AbrirConexao();

        if ((txt_Login.Text == "") || (txt_Senha.Text == ""))
        {
            lb_mensagem.Visible = true;
            lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
            lb_mensagem.Text = "Preencher os campos LOGIN e SENHA";
            txt_Login.Text = "";
            txt_Senha.Text = "";
        }
        else
        {
            // criptografando senha para validar com a armazenada no BD
            txt_Senha.Text = CriptografarSenha(txt_Senha.Text);

            // consultando no BD para validar login/senha
            String sqlAcesso = "select * from acessos where id_Usr='" + txt_Login.Text + "' and Senha_Usr='" + txt_Senha.Text + "'";
            int AchouReg = acessoBD.ExecutarConsulta(sqlAcesso);
            if (AchouReg <= 0)   // <= significa que não encontrou dados na tabela acesso
            {
                lb_mensagem.Visible = true;
                lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
                lb_mensagem.Text = "ACESSO NEGADO! Verifique se LOGIN e SENHA estão corretos";
            }
            else
            {
                // criando variaveis de sessão
                Session["login"] = txt_Login.Text;
                Response.Redirect("Produtos.aspx");
            }
            acessoBD.FecharConexao();
        }
    }

    protected void Acesso_Authenticate(object sender, AuthenticateEventArgs e)
    {
        String conString = WebConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
        MetodosBD acessoBD = new MetodosBD();
        acessoBD.Connection(conString);
        acessoBD.AbrirConexao();
        
        // criptografando senha para validar com a armazenada no BD
        String senha = CriptografarSenha(Acesso.Password);

        String sqlAcesso = "select * from ACESSOS where id_Usr='" + Acesso.UserName + "' and Senha_Usr='" + senha + "'";
        int AchouReg = acessoBD.ExecutarConsulta(sqlAcesso);
        if (AchouReg > 0)
        {
            Response.Redirect("Produtos.aspx");
        }
        acessoBD.FecharConexao();
    }


    public static string CriptografarSenha(string psenha)

    {
        StringBuilder senha = new StringBuilder();

        MD5 md5 = MD5.Create();
        byte[] entrada = Encoding.ASCII.GetBytes(psenha);
        byte[] hash = md5.ComputeHash(entrada);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            senha.Append(hash[i].ToString("X2"));  // montando a senha criptografada - X2 faz com que o byte seja convertido no formato Hexadecimal.
        }
        return senha.ToString();
    }


    protected void btn_Inserir_Click(object sender, EventArgs e)
    {
        String conString = WebConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
        MetodosBD acessoBD = new MetodosBD();
        acessoBD.Connection(conString);
        acessoBD.AbrirConexao();
        if ((txt_Login.Text == "") || (txt_Senha.Text == ""))
        {
            lb_mensagem.Visible = true;
            lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
            lb_mensagem.Text = "Preencher os campos LOGIN e SENHA para efetivar Cadastro!";
        }
        else  // campos preenchido corretamente
        {
            // verificando se o usuário não está cadastrado!
            string sqlLogin = "select * from acessos where id_Usr='" + txt_Login.Text + "' and Senha_Usr='" + txt_Senha.Text + "'";
            int achouLogin = acessoBD.ExecutarConsulta(sqlLogin);
            lb_mensagem.Text = achouLogin.ToString();
            if (achouLogin >= 0)
            {
                lb_mensagem.Visible = false;
                lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
                lb_mensagem.Text = "ESSE USUÁRIO JÁ TEM CADASTRADO!";
            }
            else
            {
                // verificando se a senha é FORTE
                bool SenhaOK = true;

                // Definição de letras minusculas
                Regex regTamanhoMinusculo = new Regex("[a - z]");

                // Definição de letras minusculas
                Regex regTamanhoMaiusculo = new Regex("[A - Z]");

                // Definição de letras minusculas
                Regex regTamanhoNumeros = new Regex("[0 - 9]");

                // Definição de letras minusculas
                Regex regCaracteresEspeciais = new Regex("[^ a - zA - Z0 - 9]");

                // Verificando tamanho minimo
                if (txt_Senha.Text.Length < 8)
                { SenhaOK = false; }

                // Verificando caracteres minusculos
                if (regTamanhoMinusculo.Matches(txt_Senha.Text).Count < 1)
                { SenhaOK = false; }

                // Verificando caracteres maiusculos
                if (regTamanhoMaiusculo.Matches(txt_Senha.Text).Count < 1)
                    SenhaOK = false;

                // Verificando numeros
                if (regTamanhoNumeros.Matches(txt_Senha.Text).Count < 1)
                { SenhaOK = false; }

                // Verificando os diferentes
                if (regCaracteresEspeciais.Matches(txt_Senha.Text).Count < 1)
                { SenhaOK = false; }

                if (SenhaOK == false)
                {
                    lb_mensagem.Visible = true;
                    lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
                    lb_mensagem.Text = "Senha FRACA! Tem que ter letra maiúscula e minúscula, números e caracteres especiais!!";
                }
                else  // login e senha OK para cadastrar novo usuário
                {
                    txt_Senha.Text = CriptografarSenha(txt_Senha.Text);
                    
                    // inserindo usuário na tabela ACESSO
                    string sqlAcesso = "insert into ACESSOS values(" + txt_Login.Text + ",'" + txt_Senha.Text + "')";
                    int resultadoAcesso = acessoBD.ExecutarQuery(sqlAcesso);
                    // verificando se o insert na tabela acesso foi realizado com sucesso
                    if (resultadoAcesso < 0)
                    {
                        lb_mensagem.Visible = true;
                        lb_mensagem.Attributes["style"] = "color:orange; font-weight:bold; font-size: 18px;";
                        lb_mensagem.Text = "Erro na INCLUSÃO do cadastro na tabela ACESSO!!";
                    }
                    else
                    {
                        // criando variaveis de sessão
                        Session["login"] = txt_Login.Text;
                        Response.Redirect("Produtos.aspx");
                    }
                }
            }

        }
        acessoBD.FecharConexao();
    }

    protected void btn_Limpar_Click(object sender, EventArgs e)
    {
        txt_Login.Text = "";
        txt_Senha.Text = "";
    }
}