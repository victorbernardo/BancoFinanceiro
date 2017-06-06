using Biblioteca.dados;
//using Biblioteca.exception;
using Biblioteca.basica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    public class ContaController : Exception
    {
        private DAOConta contaDao;

        public ContaController()
        {
            this.contaDao = new DAOConta();
        }
        public void CriarConta(Conta conta)
        {
            this.ValidarPreenchimento(conta);
            this.Duplicidade(conta);
            this.Salvar(conta);
        }
        public List<Conta> ListarTodasContas()
        {
            return this.Listar();
        }      
        public void RemoverConta(Conta conta)
        {
            Conta conta1 = contaDao.PesquisarPorId(conta.NumeroConta);
            if (conta1 != null)
            {
                contaDao.Excluir(conta);
		    }
            else
            {
			    throw new Exception("Conta Não Existe");
		    }
	    }
        public Conta ProcurarContaPorId(int numeroConta)
        {    
            return Pesquisa(numeroConta);
        }
       
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
       
        private List<Conta> Listar()
        {
            try
            {
                return contaDao.ListarConta();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no listar conta " + ex.Message);
            }
        }
        private void Salvar(Conta conta)
        {
            try
            {
                contaDao.Inserir(conta);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir " + ex.Message);
            }  
        }
        private void ValidarPreenchimento(Conta conta)
        {          
            if(conta == null)
                throw new Exception("Conta invalida");
        }
        private void Duplicidade(Conta conta)
        {
            if (contaDao.PesquisarPorId(conta.NumeroConta) != null)
                throw new Exception("Conta ja existe");
        }
        public bool Sacar(Conta conta, decimal valor)
        {
            if (conta.Saldo > valor)
            {
                conta.Saldo -= valor;
            }
            return false;
        }
        public Conta Pesquisa(int numeroConta)
        {
            try
            {
                return contaDao.PesquisarPorId(numeroConta);
            }                            
            catch (Exception ex)
            {
                throw new Exception("Conta nao existe " + ex.Message);
            }                                                
        }
    
    }
}

