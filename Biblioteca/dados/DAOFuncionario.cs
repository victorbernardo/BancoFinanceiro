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
    public class DAOFuncionario : Conexao, IDAOFuncionario
    {
        public void Inserir(Funcionario funcionario)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into funcionario(cpf, nome, cargo, senha, numero, endereco_id)";
                sql += "values(@cpf, @nome, @cargo, @senha, @numero, @endereco_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.NVarChar);
                cmd.Parameters["@cpf"].Value = funcionario.Cpf;

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = funcionario.Nome;

                cmd.Parameters.Add("@cargo", SqlDbType.NVarChar);
                cmd.Parameters["@cargo"].Value = funcionario.Cargo;

                cmd.Parameters.Add("@senha", SqlDbType.NVarChar);
                cmd.Parameters["@senha"].Value = funcionario.Senha;

                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = funcionario.NumeroAgencia.NumeroAgencia;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = funcionario.EnderecoId.Endereco_id;


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

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from funcionario where matricula = @matricula";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@matricula", SqlDbType.Int);
                cmd.Parameters["@matricula"].Value = funcionario.Matricula;
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

        public void Alterar(Funcionario funcionario)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update funcionario set nome = @nome, cargo = @cargo, senha = @senha where matriucla = @matricula";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = funcionario.Nome;

                cmd.Parameters.Add("@cargo", SqlDbType.NVarChar);
                cmd.Parameters["@cargo"].Value = funcionario.Cargo;

                cmd.Parameters.Add("@senha", SqlDbType.NVarChar);
                cmd.Parameters["@senha"].Value = funcionario.Senha;

                cmd.Parameters.Add("@matricula", SqlDbType.Int);
                cmd.Parameters["@matricula"].Value = funcionario.Matricula;

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

        public List<Funcionario> Pesquisar(Funcionario funcionario)
        {
            List<Funcionario> retorno = new List<Funcionario>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT matricula, nome, cargo, senha, NumeroAgencia, endereco_id FROM funcionario  where matricula = @matricula";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@matricula", SqlDbType.Int);
                cmd.Parameters["@matricula"].Value = funcionario.Matricula;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Funcionario f = new Funcionario();
                    //acessando os valores das colunas do resultado
                    f.Matricula = DbReader.GetInt32(DbReader.GetOrdinal("matricula"));
                    f.Nome = DbReader.GetDataTypeName(DbReader.GetOrdinal("nome"));
                    f.Cargo = DbReader.GetDataTypeName(DbReader.GetOrdinal("cargo"));
                    f.Senha = DbReader.GetDataTypeName(DbReader.GetOrdinal("senha"));
                    f.NumeroAgencia.NumeroAgencia = DbReader.GetInt32(DbReader.GetOrdinal("NumeroAgencia"));
                    f.EnderecoId.Endereco_id = DbReader.GetInt32(DbReader.GetOrdinal("endereco_id"));

                    retorno.Add(f);
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
