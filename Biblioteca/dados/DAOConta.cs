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
        private DAOCliente daoCliente;
        private DAOAgencia daoAgencia;
        public DAOConta()
        {
            daoCliente = new DAOCliente();
            daoAgencia = new DAOAgencia();
        }
        public void Inserir(Conta conta)
        {
            try
            {
                //abre uma conexao
                this.abrirConexao();
                string sql = "insert into conta(Numero_conta, Saldo, Data_criacao, Numero_agencia, cliente_id)";
                sql += "values(@Numero_conta, @Saldo, @Data_criacao, @Numero_agencia, @cliente_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Saldo", SqlDbType.Decimal);
                cmd.Parameters["@Saldo"].Value = conta.Saldo;

                cmd.Parameters.Add("@Data_criacao", SqlDbType.DateTime);
                cmd.Parameters["@Data_criacao"].Value = conta.DataCriacao;

                cmd.Parameters.Add("@Numero_agencia", SqlDbType.Int);
                cmd.Parameters["@Numero_agencia"].Value = conta.Agencia.NumeroAgencia;

                cmd.Parameters.Add("@Numero_conta", SqlDbType.Int);
                cmd.Parameters["@Numero_conta"].Value = conta.NumeroConta;

                cmd.Parameters.Add("@Cliente_id", SqlDbType.Int);
                cmd.Parameters["@Cliente_id"].Value = conta.Cliente.IdCliente;

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
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

        public Conta PesquisarPorId(int numeroConta)
        {
            Conta conta = new Conta();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT numero_conta, Numero_Agencia, cliente_id, saldo, data_criacao FROM conta  where numero_conta = @numero_conta";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = numeroConta;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                
                while (DbReader.Read())
                {
                    
                    //acessando os valores das colunas do resultado
                    conta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_conta"));
                    conta.Agencia = daoAgencia.PesquisarPorId(DbReader.GetInt32(DbReader.GetOrdinal("Numero_Agencia")));
                    conta.Cliente = daoCliente.PesquisarPorId(DbReader.GetInt32(DbReader.GetOrdinal("cliente_id")));                    
                    conta.Saldo = DbReader.GetDecimal(DbReader.GetOrdinal("saldo"));
                    conta.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));
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
            return conta;
        }

        public List<Conta> ListarConta()
        {
            List<Conta> retorno = new List<Conta>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select Numero_conta, Saldo, Data_criacao, Numero_Agencia, cliente_id from Conta";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
               
               
                    //lendo o resultado da consulta
                    while (DbReader.Read())
                    {
                        Conta conta = new Conta();
                    //acessando os valores das colunas do resultado
                        conta.Agencia = daoAgencia.PesquisarPorId(DbReader.GetInt32(DbReader.GetOrdinal("Numero_Agencia")));
                        conta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_conta"));
                        conta.Saldo = DbReader.GetDecimal(DbReader.GetOrdinal("saldo"));
                        conta.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));
                        conta.Cliente = daoCliente.PesquisarPorId(DbReader.GetInt32(DbReader.GetOrdinal("cliente_id")));
                        retorno.Add(conta);
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
