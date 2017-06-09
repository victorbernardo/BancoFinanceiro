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
                //abre uma conexao
                this.abrirConexao();
                string sql = "insert into parcela(data_vencimento, valor,numero_parcela, emprestimo_id)";
                sql += "values(@data_vencimento, @valor,@numero_parcela, @emprestimo_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@data_vencimento", SqlDbType.Date);
                cmd.Parameters["@data_vencimento"].Value = parcela.DataVencimento;

                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters["@valor"].Value = parcela.Valor;

                cmd.Parameters.Add("@numero_parcela", SqlDbType.Int);
                cmd.Parameters["@numero_parcela"].Value = parcela.NumeroParcela;

                cmd.Parameters.Add("@emprestimo_id", SqlDbType.Int);
                cmd.Parameters["@emprestimo_id"].Value = parcela.Emprestimo.IdEmprestimo;


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

        public void Excluir(Parcela parcela)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from parcela where parcela_id = @Parcela_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Parcela_id", SqlDbType.Int);
                cmd.Parameters["@Parcela_id"].Value = parcela.IdParcela;
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

        public void Alterar(Parcela parcela)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update parcela set Data_vencimento = @Data_vencimento, Valor = @Valor where Parcela_id = @Parcela_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Data_vencimento", SqlDbType.Date);
                cmd.Parameters["@Data_vencimento"].Value = parcela.DataVencimento;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = parcela.Valor;

                cmd.Parameters.Add("@Parcela_id", SqlDbType.Int);
                cmd.Parameters["@Parcela_id"].Value = parcela.IdParcela;

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

        public List<Parcela> Pesquisar()
        {
            List<Parcela> retorno = new List<Parcela>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT Data_vencimento, Parcela_id, Valor, numero_parcela, Emprestimo_id FROM Parcela ";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                /*cmd.Parameters.Add("@parcela_id", SqlDbType.Int);
                cmd.Parameters["@parcela_id"].Value = parcela.IdParcela;
                */
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Parcela p = new Parcela();
                    //acessando os valores das colunas do resultado
                    p.DataVencimento = DbReader.GetDateTime(DbReader.GetOrdinal("Data_vencimento"));
                    p.IdParcela = DbReader.GetInt32(DbReader.GetOrdinal("Parcela_id"));
                    p.NumeroParcela = DbReader.GetInt32(DbReader.GetOrdinal("numero_parcela"));
                    p.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    p.Emprestimo.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("Emprestimo_id"));


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
        public Parcela Pesquisar(int numeroParcela)
        {
            Parcela parcela = new Parcela();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT Data_vencimento, Parcela_id, Valor, Emprestimo_id FROM Parcela  where Parcela_id = @parcela_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@parcela_id", SqlDbType.Int);
                cmd.Parameters["@parcela_id"].Value = numeroParcela;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                                       //acessando os valores das colunas do resultado
                    parcela.DataVencimento = DbReader.GetDateTime(DbReader.GetOrdinal("Data_vencimento"));
                    parcela.IdParcela = DbReader.GetInt32(DbReader.GetOrdinal("Parcela_id"));
                    parcela.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    parcela.Emprestimo.IdEmprestimo = DbReader.GetInt32(DbReader.GetOrdinal("Emprestimo_id"));

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
            return parcela;
        }
    }
}
