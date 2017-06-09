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
        private DAOMovimentacao daoMovimentacao;

        public ContaController()
        {
            this.daoConta = new DAOConta();
            this.daoMovimentacao = new DAOMovimentacao();
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

        public List<Conta> Listar()
        {
            try
            {
                List<Conta> returnListar = new List<Conta>();
                returnListar = daoConta.ListarConta();

                if (returnListar != null)                
                    return returnListar;                
                else
                    throw new Exception("Nao existe conta cadastrada");                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no listar conta " + ex.Message);
            }

            return null;
        }
            
        public void Salvar(Conta conta)
        {
            try
            {
                if (conta != null)
                    daoConta.Inserir(conta);
                else
                    throw new Exception("Informe os dados");
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void alterar(Conta conta)
        {
            try
            {
                if(conta != null)
                    daoConta.Alterar(conta);
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível alterar " + e.Message);
            }
        }

        public bool Sacar(Conta conta, Movimentacao movimentacao)
        {
            Conta contaVerificada = new Conta();
            contaVerificada = VerificaSaldo(conta);

            if (conta.Saldo > contaVerificada.Saldo)
                throw new Exception("Saldo insuficinete");
            else
            {
                //decimal valorSaque = conta.Saldo;
                contaVerificada.Saldo -= conta.Saldo;
                //conta.Saldo -= movimentacao.Valor;                                
                daoConta.Sacar(contaVerificada);                
                daoMovimentacao.Inserir(movimentacao);
            }
            return false;
        }

        public void excluir(Conta conta)
        {
            Conta conta1 = daoConta.PesquisarPorId(conta.NumeroConta);
            if (conta1 != null)
            {
                daoConta.Excluir(conta1);
		    }else{
			    throw new Exception("Cliente Não Existe");
		    }
	    }

        public Conta PesquisarPorId(int numeroConta)
        {           
            try
            {                
                if (daoConta.PesquisarPorId(numeroConta) != null)
                    return daoConta.PesquisarPorId(numeroConta);                    
                else
                    throw new Exception("Nao existe conta castrada");                    
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Depositar(Conta conta, Movimentacao movimentacao)
        {
            Conta contaVerificada = new Conta();
            contaVerificada = VerificaSaldo(conta);

            if (conta.NumeroConta != null && movimentacao.Valor != null)
            {
                if (conta.Saldo > 0)
                {
                    decimal valorDeposito = conta.Saldo;
                    contaVerificada.Saldo += conta.Saldo;
                    //conta.Saldo += movimentacao.Valor;
                    movimentacao.Tipo = "Depósito";
                    movimentacao.Data = DateTime.Now;
                    movimentacao.Valor = valorDeposito;
                    movimentacao.NumeroConta.NumeroConta = conta.NumeroConta;
                    daoConta.Depositar(contaVerificada);
                    daoMovimentacao.Inserir(movimentacao);
                }
                else
                    throw new Exception("Deposito minino R$ 1,00");                
            }
            else
            {
                throw new Exception("Não foi possível realizar o depósito!");
            }
        }

        private Conta VerificaSaldo(Conta conta)
        {
            Conta conta1 = daoConta.PesquisarPorId(conta.NumeroConta);
            return conta1;            
        }
     }
}

