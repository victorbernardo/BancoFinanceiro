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
        public void Inserir(Emprestimo emprestimo)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into emprestimo(taxa_juros_mensal, data_criacao, valor, numero)";
                sql += "values(@taxa_juros_mensal, @data_criacao, @valor, @numero)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@taxa_juros_mensal", SqlDbType.Decimal);
                cmd.Parameters["@taxa_juros_mensal"].Value = emprestimo.TaxaJurosMensal;

                cmd.Parameters.Add("@data_criacao", SqlDbType.DateTime);
                cmd.Parameters["@data_criacao"].Value = emprestimo.DataCriacao;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = emprestimo.Valor;

                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = emprestimo.NumeroConta.NumeroConta;

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
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update emprestimo set valor = @valor where idEmprestimo = @idEmprestimo";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = emprestimo.Valor;

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
        public List<Emprestimo> Pesquisar(Emprestimo emprestimo)
        {
            List<Emprestimo> retorno = new List<Emprestimo>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT emprestimo_id, taxa_juros_mensal, data_criacao, valor, numeroConta FROM emprestimo  where emprestimo_id = @emprestimo_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@emprestimo_id", SqlDbType.Int);
                cmd.Parameters["@emprestimo_id"].Value = emprestimo.IdEmprestimo;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Emprestimo emprestimo1 = new Emprestimo();
                    //acessando os valores das colunas do resultado
                    emprestimo1.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("emprestimo_id"));
                    emprestimo1.TaxaJurosMensal = DbReader.GetDecimal(DbReader.GetOrdinal("taxa_juros_mensal"));
                    emprestimo1.DataCriacao = DbReader.GetDateTime(DbReader.GetOrdinal("data_criacao"));
                    emprestimo1.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    emprestimo1.NumeroConta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numeroConta"));

                    retorno.Add(emprestimo1);
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
