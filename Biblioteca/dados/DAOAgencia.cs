using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Interface;
using System.Data.SqlClient;
using System.Data;
//importaçao de pacotes
using Biblioteca.basica;
using Biblioteca.dados;

namespace Biblioteca.dados
{
    public class DAOAgencia : Conexao, IDAOAgencia
    {
        private DAOEndereco daoEndereco = new DAOEndereco();
        public void Inserir(Agencia agencia)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into agencia(Nome, Numero_Agencia, Endereco_id)";
                sql += "values(@Nome, @Numero_Agencia, @Endereco_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = agencia.Nome;

                cmd.Parameters.Add("@Numero_Agencia", SqlDbType.Int);
                cmd.Parameters["@Numero_Agencia"].Value = agencia.NumeroAgencia;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = agencia.Endereco.IdEndereco;


                //Executando a instrução
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao... Falta criar a classe de conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Excluir(Agencia agencia)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from agencia where Numero_Agencia = @Numero_Agencia";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Numero_Agencia", SqlDbType.Int);
                cmd.Parameters["@Numero_Agencia"].Value = agencia.NumeroAgencia;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao... Falta fazer a classe de concexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public void Alterar(Agencia agencia)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update agencia set nome = @nome where Numero_Agencia = @Numero_Agencia";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = agencia.Nome;

                cmd.Parameters.Add("@Numero_Agencia", SqlDbType.Int);
                cmd.Parameters["@Numero_Agencia"].Value = agencia.NumeroAgencia;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao... Falta criar a classe de conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar " + ex.Message);
            }
        }

        public Agencia PesquisarPorId(int numeroConta)
        {
            Agencia agencia = new Agencia();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT nome, Numero_Agencia, endereco_id FROM agencia  where Numero_Agencia = @Numero_Agencia";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@Numero_Agencia", SqlDbType.Int);
                cmd.Parameters["@Numero_Agencia"].Value = numeroConta;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    //acessando os valores das colunas do resultado
                    agencia.Nome = DbReader.GetDataTypeName(DbReader.GetOrdinal("nome"));
                    agencia.NumeroAgencia = DbReader.GetInt32(DbReader.GetOrdinal("Numero_Agencia"));
                    agencia.Endereco = daoEndereco.PesquisarPorId( DbReader.GetInt32(DbReader.GetOrdinal("endereco_id")));

                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao... Falta criar a classe de conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e pesquisar " + ex.Message);
            }
            return agencia;
        }
        public List<Agencia> Consultar()
        {
            List<Agencia> retorno = new List<Agencia>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select Agencia.Numero_agencia, Agencia.Nome, Endereco.Endereco_id, Endereco.Rua From Agencia inner join Endereco on Agencia.Endereco_id = Endereco.Endereco_id;";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Agencia a = new Agencia();
                    Endereco e = new Endereco();
                    //acessando os valores das colunas do resultado
                    a.NumeroAgencia = DbReader.GetInt32(DbReader.GetOrdinal("Numero_agencia"));
                    a.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    e.IdEndereco = DbReader.GetInt32(DbReader.GetOrdinal("Endereco_id"));
                    e.Rua = DbReader.GetString(DbReader.GetOrdinal("Rua"));
                    a.Endereco = e;

                    retorno.Add(a);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e ConsultarAgencia " + ex.Message);
            }
            return retorno;
        }
    }
}
