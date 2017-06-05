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
            this.Salvar(conta);
        }

        public bool Sacar(Conta conta, decimal valor)
        {
            if (conta.Saldo > valor)
            {
                conta.Saldo -= valor;

            }

            return false;

        }
        public List<Conta> ListarTodasContas()
        {
            return this.Listar();
        }

       /* public Conta ProcurarConta(int numeroConta)
        {

            if (numeroConta != null)
            {
                if (numeroConta != 0)
                {
                    return contaDao.ProcurarConta(numeroConta);
                }
                else
                {
                    throw new BancoException("Conta inexistente");
                }
            }
            return null;
        }*/

        /*public void RemoverConta(int numeroConta)
        {
            Conta conta = ProcurarConta(numeroConta);
        if (conta != null)
        {
            contaDao.RemoverConta(numeroConta);
		}else{
			throw new BancoException("Cliente Não Existe");
		}
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
    
    }
}

