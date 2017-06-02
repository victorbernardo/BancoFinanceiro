using Biblioteca.dados;
using Biblioteca.exception;
using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    class ContaController : Exception
    {
        private DAOConta contaDao;

        public ContaController(DAOConta contaDao)
        {
            this.contaDao = contaDao;
        }

        public void CriarConta(Conta conta)
        {

            if (conta != null)
            {
                contaDao.Inserir(conta);
            }

            else
            {
                throw new BancoException("Não foi possível criar a conta!");
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

        public Conta ProcurarConta(int numeroConta)
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
        }

        public void RemoverConta(int numeroConta)
        {
            Conta conta = ProcurarConta(numeroConta);
        if (conta != null)
        {
            contaDao.RemoverConta(numeroConta);
		}else{
			throw new BancoException("Cliente Não Existe");
		}
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
    }


}

