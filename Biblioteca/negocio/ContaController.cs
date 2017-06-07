using Biblioteca.dados;
//using Biblioteca.exception;
using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.basica;

namespace Biblioteca.negocio
{
    public class ContaController : Exception
    {
        private DAOConta daoConta;

        public ContaController()
        {
            this.daoConta = new DAOConta();
        }

        public void CriarConta(Conta conta)
        {

            conta = daoConta.PesquisarPorId(conta.NumeroConta);
            if (conta != null)
            {
                throw new Exception("Conta já existe!");
            }
            else
            {

			    throw new Exception("Conta Não Existe");
		    }
	    }
        /*public Conta ProcurarContaPorId(int numeroConta)
        {    
            return Pesquisa(numeroConta);
        }
        */
       
        /*
        public void ProcurarConta(Conta conta)
        {
            try
            {
                if (conta.Agencia != null)
                {
                    throw new BancoException("Agência não encontrada!");
                }
                else if (conta.NumeroConta < 10000)
                {
                    throw new BancoException("Conta inexiste!");
                }
                else if (contaDao.Pesquisar(conta) != null)
                {
                    throw new BancoException("Conta inexiste!");
                }
            }
            catch (Exception e)
            {
                throw e;
            }            
        }*/
        /*
###########################################################
FUNÇÕES INTERNAS (fragmentação dos métodos)
###########################################################
*/
       
        public List<Conta> Listar()
        {
            try
            {
                return daoConta.ListarConta();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no listar conta " + ex.Message);
            }
        }

        /*
        private void Salvar(Conta conta)
        {
            try
            {

			    throw new Exception("Conta Não Existe");
		    }
	    }
        /*public Conta ProcurarContaPorId(int numeroConta)
        {    
            return Pesquisa(numeroConta);
        }*/
       
        /*
        public void ProcurarConta(Conta conta)
        {
            try
            {
                if (conta.Agencia != null)
                {
                    throw new BancoException("Agência não encontrada!");
                }
                else if (conta.NumeroConta < 10000)
                {
                    throw new BancoException("Conta inexiste!");
                }
                else if (contaDao.Pesquisar(conta) != null)
                {
                    throw new BancoException("Conta inexiste!");
                }
            }
            catch (Exception e)
            {
                throw e;
            }            
        }*/
        /*
###########################################################
FUNÇÕES INTERNAS (fragmentação dos métodos)
###########################################################
*/
       
        public void Salvar(Conta conta)
        {
            try
            {

                daoConta.Inserir(conta);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool Sacar(Conta conta, decimal valor)
        {
            if (conta.Saldo > valor)
            {
                conta.Saldo -= valor;

            }

            return false;

        }

        
        public void RemoverConta(int numeroConta)
        {
            Conta conta = daoConta.PesquisarPorId(numeroConta);
            if (conta != null)
            {
                daoConta.Excluir(conta);
		    }else{
			    throw new Exception("Cliente Não Existe");
		    }
	    }

        public Conta PesquisarPorId(int numeroConta)
        {
            
            try
            {

                return daoConta.PesquisarPorId(numeroConta);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*public bool depositar(Conta conta)
        {
            conta = daoConta.PesquisarPorId(numeroConta);
            if (conta != null)
            {

                throw new Exception("Conta nao existe " + ex.Message);
            }                                                
        }

                throw new Exception("Conta nao existe " + ex.Message);
            }                                                
        }
    

                contaDao.Depositar(conta.valorDepositado);
                return true;
            }
            
            return false;
        }   */ 

    }

}

