using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Data.SqlClient;


public class MetodosBD
{
    private SqlConnection con;
    private String ConnectionString { get; set; }

    public void Connection() { }

    // Construtor: recebe a string de conexao
    public void Connection(String ConnectionString)
    {
        this.ConnectionString = ConnectionString;
    }


    // método que faz a abertura da conexão
    public void AbrirConexao()
    {
        if (string.IsNullOrEmpty(this.ConnectionString)) throw
            new Exception("Não foi possível abrir a conexão com o BD! - método AbrirConexao");

        // senão tiver conexão, será aberta uma
        if (con == null)
        {
            con = new SqlConnection();
            con.ConnectionString = this.ConnectionString;
        }
        con.Open();
    }


    // método que fecha a conexao aberta
    public void FecharConexao()
    {
        con.Close();
    }

    // método usado para retorno de uma dataset de dados de uma pesquisa no BD
    public IDataReader RetornaDados(String sql)
    {
        // verificando se a string sql não está vazia
        if (string.IsNullOrEmpty(sql)) throw new Exception("A query não foi informada corretamente! - RetornarDados()");

        // verificando se a conexão está fechada
        if ((con == null) || (con.State == ConnectionState.Closed))
            throw new Exception("A conexão com o BD está fechada!. Rode o AbrirConexao()");

        // criando o comando de execução da query
        SqlCommand comando = new SqlCommand(sql, this.con);
        SqlDataReader dr_Dados = comando.ExecuteReader();
        // abrindo o dataReader para leitura
        dr_Dados.Read();
        return dr_Dados;
    }

    // método que executa uma consulta ao BD
    public int ExecutarConsulta(String sql)
    {
        // verificando se a string sql não está vazia
        if (string.IsNullOrEmpty(sql)) throw new Exception("A query não foi informada corretamente! - ExecutaConsulta()");

        // verificando se a conexão está fechada
        if ((con == null) || (con.State == ConnectionState.Closed))
            throw new Exception("A conexão com o BD está fechada!. Rode o AbrirConexao()");

        SqlCommand comando = new SqlCommand();
        comando.Connection = this.con;
        // rodo a pesquisa através de texto
        comando.CommandText = sql;
        try
        {
            // usado para consultas a tabelas onde o número de rows retornadas.
            // Sempre irá retornar a primeira coluna selecionada
            int resultado = (int)comando.ExecuteScalar();
            return resultado;

        }
        catch (Exception)
        {
            // retornar -1 significa que não há rows retornadas
            return -1;
        }
    }

    // método usado para INSERT, UPDATE e DELETE
    // o inteiro a ser retornado indicará 1 = sucesso e 0 = problema
    public int ExecutarQuery(String sql)
    {
        // verificando se a string sql não está vazia
        if (string.IsNullOrEmpty(sql)) throw new Exception("A query não foi informada corretamente! - ExecutarQuery");

        // verificando se a conexão está fechada
        if ((con == null) || (con.State == ConnectionState.Closed))
            throw new Exception("A conexão com o BD está fechada!. Rode o AbrirConexao()");

        SqlCommand comando = new SqlCommand();
        comando.Connection = this.con;
        comando.CommandText = sql;
        try
        {
            int retorno = (int)comando.ExecuteNonQuery();
            return retorno;
        }
        catch (Exception)
        {
            return 0;  // problema na execução do INSERT, UPDATE ou DELETE
        }
    }

}
