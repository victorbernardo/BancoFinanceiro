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

            conta = contaDao.ProcurarConta(conta.NumeroConta);
            if (conta != null)
            {
                throw new GeralException("Conta já existe!");
            }
            else
            {
                contaDao.Inserir(conta);
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

        public void Atualizar(Conta conta)
        {

        }

        public void RemoverConta(int numeroConta)
        {
            Conta conta = contaDao.ProcurarConta(numeroConta);
            if (conta != null)
            {
                contaDao.RemoverConta(conta.NumeroConta);
		    }else{
			    throw new GeralException("Cliente Não Existe");
		    }
	    }

        public bool depositar(Conta conta)
        {
            conta = contaDao.ProcurarConta(conta.NumeroConta);
            if (conta != null)
            {
                contaDao.Depositar(conta.valorDepositado);
                return true;
            }
            
            return false;
        }    
    }

}

