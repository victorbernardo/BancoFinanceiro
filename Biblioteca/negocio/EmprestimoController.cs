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
        private DAOParcela daoParcela;
        public EmprestimoController()
        {
            this.daoEmprestimo = new DAOEmprestimo();
            this.daoParcela = new DAOParcela();
        }

        public void Salvar(Emprestimo emprestimo)
        {
            this.ValidaEmprestimo(emprestimo);
            this.VerificaDuplicidade(emprestimo);
            this.AumentaSaldo(emprestimo);
            this.InserirNovo(emprestimo);            
        }
        public List<Emprestimo> Listar()
        {
            return ListaTudo();
        }
        public Emprestimo PesquisaNumeroConta(int numeroConta)
        {
            return Pesquisar(numeroConta);
        }
        public void AlterarEmprestimo(Emprestimo emprestimo)
        {
            Alterar(emprestimo);
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
           if (daoEmprestimo.PesquisaPorId(e.IdEmprestimo) == null)
                throw new Exception("Emprestimo ja existe");           
        }
        private void InserirNovo(Emprestimo e)
        {
            try
            {
                daoEmprestimo.Inserir(e);
                for (int i = 1;i <= e.QuantidadeParcela;i++ )
                {
                    Parcela parcela = new Parcela();


                }



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
        private List<Emprestimo> ListaTudo()
        {
            return daoEmprestimo.Pesquisar();
        }
        private Emprestimo Pesquisar(int numeroConta)
        {
            if (!daoEmprestimo.PesquisaPorId(numeroConta).Equals(""))
                return daoEmprestimo.PesquisaPorId(numeroConta);
            else
                throw new Exception("Emprestimo nao existe");
        }
        private void Alterar(Emprestimo emprestimo)
        {
            daoEmprestimo.Alterar(emprestimo);
        }
    }
}
