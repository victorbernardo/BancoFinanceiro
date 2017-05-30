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
    public class DAOParcela : Conexao, IDAOParcela
    {
        public void Inserir(Parcela parcela)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into parcela(data_vencimento, valor, emprestimo_id)";
                sql += "values(@data_vencimento, @valor, @emprestimo_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@data_vencimento", SqlDbType.Date);
                cmd.Parameters["@data_vencimento"].Value = parcela.DataVencimento;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = parcela.Valor;

                cmd.Parameters.Add("@emprestimo_id", SqlDbType.Int);
                cmd.Parameters["@emprestimo_id"].Value = parcela.EmprestimoId.IdEmprestimo;


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

        public void Excluir(Parcela parcela)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from parcela where parcela_id = @parcela_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@parcela_id", SqlDbType.Int);
                cmd.Parameters["@parcela_id"].Value = parcela.ParcelaId;
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

        public void Alterar(Parcela parcela)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update parcela set data_vencimento = @data_vencimento, valor = @valor where parcela_id = @parcela_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@data_vencimento", SqlDbType.Date);
                cmd.Parameters["@data_vencimento"].Value = parcela.DataVencimento;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = parcela.Valor;

                cmd.Parameters.Add("@parcela_id", SqlDbType.Int);
                cmd.Parameters["@parcela_id"].Value = parcela.ParcelaId;

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

        public List<Parcela> Pesquisar(Parcela parcela)
        {
            List<Parcela> retorno = new List<Parcela>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT data_vencimento, parcela_id, valor, emprestimo_id FROM parcela  where parcela_id = @parcela_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@parcela_id", SqlDbType.Int);
                cmd.Parameters["@parcela_id"].Value = parcela.ParcelaId;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Parcela p = new Parcela();
                    //acessando os valores das colunas do resultado
                    p.DataVencimento = DbReader.GetDateTime(DbReader.GetOrdinal("data_vencimento"));
                    p.ParcelaId = DbReader.GetInt32(DbReader.GetOrdinal("parcela_id"));
                    p.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    p.EmprestimoId.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("emprestimo_id"));


                    retorno.Add(p);
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
