using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.basica;
using Biblioteca.dados;

namespace Biblioteca.negocio
{
    public class EmprestimoController
    {
        private DAOEmprestimo daoEmprestimo;
        public EmprestimoController()
        {
            this.daoEmprestimo = new DAOEmprestimo();
        }
        public void Salvar(Emprestimo emprestimo)
        {
            this.ValidaEmprestimo(emprestimo);
            this.VerificaDuplicidade(emprestimo);
            this.AumentaSaldo(emprestimo);
            this.InserirNovo(emprestimo);
            
        }





/*
###########################################################
FUNÇÕES INTERNAS (fragmentação dos métodos)
###########################################################
*/
        private void ValidaEmprestimo(Emprestimo e)
        {
            if (e.QuantidadeParcela.Equals(0))
                throw new Exception("Emprestimo invalido");
        }
        private void VerificaDuplicidade(Emprestimo e)
        {
            //falta configurar a funçao de duplicidade
            if (daoEmprestimo.PesquisaPorId(e.IdEmprestimo) == null)
                throw new Exception("Emprestimo ja existe");            
        }
        private void InserirNovo(Emprestimo e)
        {
            try
            {
                daoEmprestimo.Inserir(e);
            }
            catch (Exception ex)
            {                
                throw new Exception("Erro no inserir emprestimo " + ex.Message);
            }
            
        }
        private void AumentaSaldo(Emprestimo e)
        {
            DAOConta daoConta = new DAOConta();
            int numeroConta = e.NumeroConta.NumeroConta;            
            Conta conta = daoConta.PesquisarPorId(numeroConta);
            conta.Saldo += e.Valor;                         
            daoConta.Alterar(conta);
            
        }
    }
}
