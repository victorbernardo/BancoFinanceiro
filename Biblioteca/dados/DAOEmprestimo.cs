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
    public class DAOEmprestimo : Conexao, IDAOEmprestimo
    {
        private DAOConta daoConta;
        public DAOEmprestimo()
        {
            daoConta = new DAOConta();
        }
        
        public void Inserir(Emprestimo emprestimo)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into emprestimo(taxa_juros_mensal, data_criacao, valor, numero_conta, quantidade_parcela)";
                sql += "values(@taxa_juros_mensal, @data_criacao, @valor, @numero_conta, @quantidade_parcela)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@taxa_juros_mensal", SqlDbType.Decimal);
                cmd.Parameters["@taxa_juros_mensal"].Value = emprestimo.TaxaJurosMensal;

                cmd.Parameters.Add("@data_criacao", SqlDbType.DateTime);
                cmd.Parameters["@data_criacao"].Value = emprestimo.DataCriacao;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = emprestimo.Valor;

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = emprestimo.NumeroConta.NumeroConta;

                cmd.Parameters.Add("@quantidade_parcela", SqlDbType.Int);
                cmd.Parameters["@quantidade_parcela"].Value = emprestimo.QuantidadeParcela;

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
        public void Excluir(Emprestimo emprestimo)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from emprestimo where idEmprestimo = @idEmprestimo";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@idEmprestimo", SqlDbType.Int);
                cmd.Parameters["@idEmprestimo"].Value = emprestimo.IdEmprestimo;
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
        public void Alterar(Emprestimo emprestimo)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update emprestimo set taxa_juros_mensal = @taxa_juros_mensal, quantidade_parcela = @quantidade_parcela where emprestimo_id = @emprestimo_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@taxa_juros_mensal", SqlDbType.Decimal);
                cmd.Parameters["@taxa_juros_mensal"].Value = emprestimo.Valor;

                cmd.Parameters.Add("@quantidade_parcela", SqlDbType.Decimal);
                cmd.Parameters["@quantidade_parcela"].Value = emprestimo.QuantidadeParcela;

                cmd.Parameters.Add("@emprestimo_id", SqlDbType.Decimal);
                cmd.Parameters["@emprestimo_id"].Value = emprestimo.IdEmprestimo;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar " + ex.Message);
            }
        }
        public List<Emprestimo> Pesquisar()
        {
            List<Emprestimo> retorno = new List<Emprestimo>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select Emprestimo.Emprestimo_id, Conta.Numero_conta, Emprestimo.Valor, Emprestimo.Quantidade_parcela,Emprestimo.Taxa_juros_mensal, Cliente.Nome, Cliente.Cpf from Emprestimo inner join Conta on Emprestimo.Numero_conta = Conta.Numero_conta inner join Cliente on Conta.Cliente_id = Cliente.Cliente_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Emprestimo emprestimo1 = new Emprestimo();
                    //acessando os valores das colunas do resultado
                    emprestimo1.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("emprestimo_id"));
                    emprestimo1.TaxaJurosMensal = DbReader.GetDecimal(DbReader.GetOrdinal("taxa_juros_mensal"));
                    emprestimo1.QuantidadeParcela = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_parcela"));
                    //emprestimo1.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));
                    emprestimo1.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    emprestimo1.NumeroConta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_Conta"));
                    emprestimo1.NumeroConta.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    emprestimo1.NumeroConta.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));

                    retorno.Add(emprestimo1);
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
        public Emprestimo PesquisaPorId(int numeroConta)
        {
            Emprestimo emprestimo = new Emprestimo();
            
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select Emprestimo.Emprestimo_id, Conta.Numero_conta, Emprestimo.Valor, Emprestimo.Quantidade_parcela, Emprestimo.Taxa_juros_mensal, Cliente.Nome, Cliente.Cpf from Emprestimo inner join Conta on Emprestimo.Numero_conta = Conta.Numero_conta inner join Cliente on Conta.Cliente_id = Cliente.Cliente_id where Emprestimo.Numero_conta = @numero_conta";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = numeroConta;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    
                    //acessando os valores das colunas do resultado
                    emprestimo.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("emprestimo_id"));
                    emprestimo.TaxaJurosMensal = DbReader.GetDecimal(DbReader.GetOrdinal("taxa_juros_mensal"));
                    emprestimo.QuantidadeParcela = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_parcela"));
                    //emprestimo1.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));
                    emprestimo.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    emprestimo.NumeroConta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_Conta"));
                    emprestimo.NumeroConta.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    emprestimo.NumeroConta.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    
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
            return emprestimo;
        }
    }
}
