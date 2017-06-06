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
//importaçao de pacotes
namespace Biblioteca.dados
{
   public class DAOCliente : Conexao, IDAOCliente
    {
        DAOEndereco daoEndereco = new DAOEndereco();
        public void Inserir(Cliente cliente)
        {
            try
            {
                //abre uma conexao
                this.abrirConexao();
                string sql = "insert into cliente(Nome, Telefone, Cpf, Email, Endereco_id)";
                sql += "values(@Nome, @Telefone, @Cpf, @Email, @Endereco_id)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nome", SqlDbType.NVarChar);
                cmd.Parameters["@Nome"].Value = cliente.Nome;

                cmd.Parameters.Add("@Telefone", SqlDbType.NVarChar);
                cmd.Parameters["@Telefone"].Value = cliente.Telefone;

                cmd.Parameters.Add("@Cpf", SqlDbType.NVarChar);
                cmd.Parameters["@Cpf"].Value = cliente.Cpf;

                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters["@Email"].Value = cliente.Email;

                cmd.Parameters.Add("@Endereco_id", SqlDbType.Int);
                cmd.Parameters["@Endereco_id"].Value = cliente.Endereco.IdEndereco;
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
                string sql = "update cliente set Nome = @nome, Telefone = @telefone, Cpf = @cpf, Email = @email, Endereco_id = @endereco_id  where Cliente_Id = @Cliente_Id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nome", SqlDbType.NVarChar);
                cmd.Parameters["@nome"].Value = cliente.Nome;

                cmd.Parameters.Add("@Telefone", SqlDbType.NVarChar);
                cmd.Parameters["@telefone"].Value = cliente.Telefone;

                cmd.Parameters.Add("@Cpf", SqlDbType.NVarChar);
                cmd.Parameters["@cpf"].Value = cliente.Cpf;

                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = cliente.Email;

                cmd.Parameters.Add("@Cliente_Id", SqlDbType.Int);
                cmd.Parameters["@Cliente_Id"].Value = cliente.IdCliente;

                cmd.Parameters.Add("@Endereco_id", SqlDbType.Int);
                cmd.Parameters["@Endereco_id"].Value = cliente.Endereco.IdEndereco;

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

        public Cliente PesquisarPorId(int  idCliente)
        {
            Cliente c = new Cliente();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT nome, telefone, cpf, Cliente_id, email, endereco_id FROM cliente  where Cliente_id = @Cliente_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@Cliente_id", SqlDbType.Int);
                cmd.Parameters["@Cliente_id"].Value = idCliente;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
               

                while (DbReader.Read())
                {
                    
                    //acessando os valores das colunas do resultado
                    c.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    c.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    c.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    c.IdCliente = DbReader.GetInt32(DbReader.GetOrdinal("Cliente_id"));
                    c.Email = DbReader.GetString(DbReader.GetOrdinal("email"));
                    c.Endereco = daoEndereco.PesquisarPorId(DbReader.GetInt32(DbReader.GetOrdinal("endereco_id")));
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
            return c;
        }
        public List<Cliente> Consultar()
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                //abrir a conexão
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT Cliente.cliente_id, Cliente.nome, Cliente.telefone, cliente.cpf, Cliente.email, Endereco.endereco_id, Endereco.rua FROM Cliente inner join Endereco on Endereco.endereco_id = Cliente.endereco_id";
                //sql += "FROM Cliente inner join Endereco on Endereco.endereco_id = Cliente.endereco_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
               
                    //executando a instrucao e colocando o resultado em um leitor
                    SqlDataReader DbReader = cmd.ExecuteReader();
                    //lendo o resultado da consulta
                    while (DbReader.Read())
                    {
                        Cliente c = new Cliente();
                        Endereco e = new Endereco();
                        //acessando os valores das colunas do resultado
                        c.IdCliente = DbReader.GetInt32(DbReader.GetOrdinal("Cliente_id"));
                        c.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                        c.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                        c.Cpf = DbReader.GetString(DbReader.GetOrdinal("Cpf"));
                        c.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                        e.IdEndereco = DbReader.GetInt32(DbReader.GetOrdinal("Endereco_id"));
                        e.Rua = DbReader.GetString(DbReader.GetOrdinal("Rua"));
                        c.Endereco = e;                       
                        
                        retorno.Add(c);
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
                throw new Exception("Erro ao conectar e consultar " + ex.Message);
            }
            return retorno;
        }
    }
}
