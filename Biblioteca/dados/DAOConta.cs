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
    public class DAOConta : Conexao, IDAOConta
    {
        public void Inserir(Conta conta)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into conta(saldo, data_criacao, numero_conta, NumeroAgencia, IdCliente)";
                sql += "values(@saldo, @data_criacao, @numero_conta, @NumeroAgencia, @IdCliente)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@saldo", SqlDbType.Decimal);
                cmd.Parameters["@saldo"].Value = conta.Saldo;

                cmd.Parameters.Add("@data_criacao", SqlDbType.DateTime);
                cmd.Parameters["@data_criacao"].Value = conta.DataCriacao;

                cmd.Parameters.Add("@NumeroAgencia", SqlDbType.Int);
                cmd.Parameters["@NumeroAgencia"].Value = conta.Numero_agencia.NumeroAgencia;

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = conta.NumeroConta;

                cmd.Parameters.Add("@IdCliente", SqlDbType.Int);
                cmd.Parameters["@IdCliente"].Value = conta.Cliente.IdCliente;

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

        public void Excluir(Conta conta)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from conta where numero_conta = @numero_conta";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = conta.NumeroConta;
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

        public void Alterar(Conta conta)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update conta set saldo = @saldo where numero_conta = @numero_conta";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@saldo", SqlDbType.Decimal);
                cmd.Parameters["@saldo"].Value = conta.Saldo;

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

        public List<Conta> Pesquisar(Conta conta)
        {
            List<Conta> retorno = new List<Conta>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT numero_conta, NumeroAgencia, IdCliente, saldo, data_criacao FROM conta  where numero_conta = @numero_conta";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = conta.NumeroConta;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Conta conta1 = new Conta();
                    //acessando os valores das colunas do resultado
                    conta1.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_conta"));
                    conta1.Numero_agencia.NumeroAgencia = DbReader.GetInt32(DbReader.GetOrdinal("NumeroAgencia"));
                    conta1.Cliente.IdCliente = DbReader.GetInt32(DbReader.GetOrdinal("IdCliente"));
                    conta1.Saldo = DbReader.GetDecimal(DbReader.GetOrdinal("saldo"));
                    conta1.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));

                    retorno.Add(conta1);
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

        public List<Conta> ListarConta()
        {
            List<Conta> retorno = new List<Conta>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select Numero_conta, Saldo, Data_criacao from Conta";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
               
               
                    //lendo o resultado da consulta
                    while (DbReader.Read())
                    {
                        Conta conta1 = new Conta();
                        //acessando os valores das colunas do resultado
                        conta1.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_conta"));
                        conta1.Saldo = DbReader.GetDecimal(DbReader.GetOrdinal("saldo"));
                        conta1.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));

                        retorno.Add(conta1);
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
                throw new Exception("Erro ao conectar e pesquisar " + ex.Message);
            }
            return retorno;
        }
    }
}
