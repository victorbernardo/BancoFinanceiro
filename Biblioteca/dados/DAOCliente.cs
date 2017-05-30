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
   public class DAOCliente : Conexao, IDAOCliente
    {
        public void Inserir(Cliente cliente)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into cliente(nome, telefone, cpf, email, endereco_id)";
                sql += "values(@nome, @telefone, @cpf, @email, @endereco_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = cliente.Nome;

                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar);
                cmd.Parameters["@telefone"].Value = cliente.Telefone;

                cmd.Parameters.Add("@cpf", SqlDbType.NVarChar);
                cmd.Parameters["@cpf"].Value = cliente.Cpf;

                cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = cliente.Email;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = cliente.Endereco.Endereco_id;
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

        public void Excluir(Cliente cliente)
        {
            try
            {
                //abrir a conexão... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "delete from cliente where IdCliente = @IdCliente";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int);
                cmd.Parameters["@IdCliente"].Value = cliente.IdCliente;
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

        public void Alterar(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update cliente set nome = @nome, telefone = @telefone, cpf = @cpf, email = @email, endereco_id = @endereco_id  where IdCliente = @IdCliente";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = cliente.Nome;

                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar);
                cmd.Parameters["@telefone"].Value = cliente.Telefone;

                cmd.Parameters.Add("@cpf", SqlDbType.NVarChar);
                cmd.Parameters["@cpf"].Value = cliente.Cpf;

                cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = cliente.Email;

                cmd.Parameters.Add("@IdCliente", SqlDbType.Int);
                cmd.Parameters["@IdCliente"].Value = cliente.IdCliente;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = cliente.Endereco.Endereco_id;

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

        public List<Cliente> Pesquisar(Cliente cliente)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT nome, telefone, cpf, IdCliente, email, endereco_id FROM cliente  where IdCliente = @IdCliente";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@IdCliente", SqlDbType.Int);
                cmd.Parameters["@IdCliente"].Value = cliente.IdCliente;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente c = new Cliente();
                    //acessando os valores das colunas do resultado
                    c.Nome = DbReader.GetDataTypeName(DbReader.GetOrdinal("nome"));
                    c.Telefone = DbReader.GetDataTypeName(DbReader.GetOrdinal("telefone"));
                    c.Cpf = DbReader.GetDataTypeName(DbReader.GetOrdinal("cpf"));
                    c.IdCliente = DbReader.GetInt32(DbReader.GetOrdinal("IdCliente"));
                    c.Email = DbReader.GetDataTypeName(DbReader.GetOrdinal("email"));
                    c.Endereco.Endereco_id = DbReader.GetInt32(DbReader.GetOrdinal("endereco_id"));

                    retorno.Add(c);
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
