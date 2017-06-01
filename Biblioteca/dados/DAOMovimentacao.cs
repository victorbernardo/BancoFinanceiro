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
    public class DAOMovimentacao : Conexao, IDAOMovimentacao
    {
        public void Inserir(Movimentacao movimentacao)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into movimentacao(data, tipo, valor, numero_conta)";
                sql += "values(@data, @tipo, @valor, @numero_conta)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = movimentacao.Data;

                cmd.Parameters.Add("@tipo", SqlDbType.NVarChar);
                cmd.Parameters["@tipo"].Value = movimentacao.Tipo;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = movimentacao.Valor;

                cmd.Parameters.Add("@numero_conta", SqlDbType.Int);
                cmd.Parameters["@numero_conta"].Value = movimentacao.NumeroConta.NumeroConta;

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

        public void Excluir(Movimentacao movimentacao)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from movimentacao where Movimentacao_id = @Movimentacao_id ";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Movimentacao_id ", SqlDbType.Int);
                cmd.Parameters["@Movimentacao_id "].Value = movimentacao.IdMovimentacao;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public void Alterar(Movimentacao movimentacao)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update movimentacao set Data = @data, Valor = @valor where Movimentacao_id = @Movimentacao_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = movimentacao.Data;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = movimentacao.Valor;

                cmd.Parameters.Add("@Movimentacao_id", SqlDbType.Int);
                cmd.Parameters["@Movimentacao_id"].Value = movimentacao.IdMovimentacao;

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

        public List<Movimentacao> Pesquisar(Movimentacao movimentacao)
        {
            List<Movimentacao> retorno = new List<Movimentacao>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT data, tipo, valor, movimentacao_id, numero_conta FROM movimentacao  where movimentacao_id = @movimentacao_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@movimentacao_id", SqlDbType.Int);
                cmd.Parameters["@movimentacao_id"].Value = movimentacao.IdMovimentacao;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Movimentacao m = new Movimentacao();
                    //acessando os valores das colunas do resultado
                    m.Data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    m.Tipo = DbReader.GetDataTypeName(DbReader.GetOrdinal("tipo"));
                    m.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    m.IdMovimentacao = DbReader.GetInt32(DbReader.GetOrdinal("movimentacao_id"));
                    m.NumeroConta.NumeroConta = DbReader.GetInt32(DbReader.GetOrdinal("numero_conta"));

                    retorno.Add(m);
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
