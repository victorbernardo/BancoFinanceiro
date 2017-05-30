using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.Interface;
using Biblioteca.basica;
using Biblioteca.dados;
using System.Data.SqlClient;
using System.Data;
namespace Biblioteca.dados
{
    public class DAOAgencia : Conexao, IDAOAgencia
    {
        public void Inserir(Agencia agencia)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into agencia(nome, NumeroAgencia, endereco_id)";
                sql += "value(@nome, @NumeroAgencia, @endereco_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = agencia.Nome;

                cmd.Parameters.Add("@NumeroAgencia", SqlDbType.Int);
                cmd.Parameters["@NumeroAgencia"].Value = agencia.NumeroAgencia;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = agencia.Endereco.Endereco_id;


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
                string sql = "delete from agencia where NumeroAgencia = @NumeroAgencia";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@NumeroAgencia", SqlDbType.Int);
                cmd.Parameters["@NumeroAgencia"].Value = agencia.NumeroAgencia;
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
                string sql = "update agencia set nome = @nome where NumeroAgencia = @NumeroAgencia";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = agencia.Nome;

                cmd.Parameters.Add("@NumeroAgencia", SqlDbType.Int);
                cmd.Parameters["@NumeroAgencia"].Value = agencia.NumeroAgencia;

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

        public List<Agencia> Pesquisar(Agencia agencia)
        {
            List<Agencia> retorno = new List<Agencia>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT nome, NumeroAgencia, endereco_id FROM agencia  where NumeroAgencia = @NumeroAgencia";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@NumeroAgencia", SqlDbType.Int);
                cmd.Parameters["@NumeroAgencia"].Value = agencia.NumeroAgencia;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Agencia a = new Agencia();
                    //acessando os valores das colunas do resultado
                    a.Nome = DbReader.GetDataTypeName(DbReader.GetOrdinal("nome"));
                    a.NumeroAgencia = DbReader.GetInt32(DbReader.GetOrdinal("NumeroAgencia"));
                    a.Endereco.Endereco_id = DbReader.GetInt32(DbReader.GetOrdinal("endereco_id"));

                    retorno.Add(a);
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
            return retorno;
        }
    }
}
