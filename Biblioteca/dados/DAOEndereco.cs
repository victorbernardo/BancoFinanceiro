﻿using System;
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
    public class DAOEndereco : Conexao, IDAOEndereco
    {
        public void Inserir(Endereco endereco)
        {
            try
            {
                //abre uma conexao... Falta fazer a classe de concexao
                this.abrirConexao();
                string sql = "insert into endereco(rua, cep, complemento, numero, cidade, bairro, uf)";
                sql += "values(@rua, @cep, @complemento, @numero, @cidade, @bairro, @uf)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@rua", SqlDbType.NVarChar);
                cmd.Parameters["@rua"].Value = endereco.Rua;

                cmd.Parameters.Add("@cep", SqlDbType.NVarChar);
                cmd.Parameters["@cep"].Value = endereco.Cep;

                cmd.Parameters.Add("@complemento", SqlDbType.NVarChar);
                cmd.Parameters["@complemento"].Value = endereco.Complemento;

                cmd.Parameters.Add("@numero", SqlDbType.NVarChar);
                cmd.Parameters["@numero"].Value = endereco.Numero;

                cmd.Parameters.Add("@cidade", SqlDbType.NVarChar);
                cmd.Parameters["@cidade"].Value = endereco.Cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.NVarChar);
                cmd.Parameters["@bairro"].Value = endereco.Bairro;

                cmd.Parameters.Add("@uf", SqlDbType.NVarChar);
                cmd.Parameters["@uf"].Value = endereco.Uf;

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

        public void Excluir(Endereco endereco)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from endereco where Endereco_id = @Endereco_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Endereco_id", SqlDbType.Int);
                cmd.Parameters["@Endereco_id"].Value = endereco.IdEndereco;
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

        public void Alterar(Endereco endereco)
        {
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                string sql = "update endereco set Rua = @rua, Cep = @cep, Complemento = @complemento, Numero = @numero, Cidade = @cidade, Bairro = @bairro, Uf = @uf where Endereco_id = @Endereco_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@rua", SqlDbType.NVarChar);
                cmd.Parameters["@rua"].Value = endereco.Rua;

                cmd.Parameters.Add("@cep", SqlDbType.NVarChar);
                cmd.Parameters["@cep"].Value = endereco.Cep;

                cmd.Parameters.Add("@complemento", SqlDbType.NVarChar);
                cmd.Parameters["@complemento"].Value = endereco.Complemento;

                cmd.Parameters.Add("@numero", SqlDbType.NVarChar);
                cmd.Parameters["@numero"].Value = endereco.Numero;

                cmd.Parameters.Add("@cidade", SqlDbType.NVarChar);
                cmd.Parameters["@cidade"].Value = endereco.Cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.NVarChar);
                cmd.Parameters["@bairro"].Value = endereco.Bairro;

                cmd.Parameters.Add("@uf", SqlDbType.NVarChar);
                cmd.Parameters["@uf"].Value = endereco.Uf;

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = endereco.IdEndereco;



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

        public List<Endereco> Pesquisar(Endereco endereco)
        {
            List<Endereco> retorno = new List<Endereco>();
            try
            {
                //abrir a conexão... Falta criar a classe de conexao
                this.abrirConexao();
                //instrucao a ser executada... Falta configurar essa string sql
                string sql = "SELECT rua, cep, complemento, numero, cidade, bairro, uf, endereco_id FROM endereco  where endereco_id = @endereco_id";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@endereco_id", SqlDbType.Int);
                cmd.Parameters["@endereco_id"].Value = endereco.IdEndereco;

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Endereco e = new Endereco();
                    //acessando os valores das colunas do resultado
                    e.Rua = DbReader.GetDataTypeName(DbReader.GetOrdinal("rua"));
                    e.Cep = DbReader.GetDataTypeName(DbReader.GetOrdinal("cep"));
                    e.Complemento = DbReader.GetDataTypeName(DbReader.GetOrdinal("complemento"));
                    e.Numero = DbReader.GetDataTypeName(DbReader.GetOrdinal("numero"));
                    e.Cidade = DbReader.GetDataTypeName(DbReader.GetOrdinal("cidade"));
                    e.Bairro = DbReader.GetDataTypeName(DbReader.GetOrdinal("bairro"));
                    e.Uf = DbReader.GetDataTypeName(DbReader.GetOrdinal("uf"));
                    e.IdEndereco = DbReader.GetInt32(DbReader.GetOrdinal("endereco_id"));

                    retorno.Add(e);
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
