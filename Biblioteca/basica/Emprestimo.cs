using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
   public class Emprestimo
    {
        private int idEmprestimo;
        private decimal taxaJurosMensal;
        private DateTime dataCriacao;
        private decimal valor;
        private Conta numeroConta;
        private int quantidadeParcela;
        private List<Parcela> parcelas;
        public Emprestimo()
        {
            numeroConta = new Conta();
            parcelas = new List<Parcela>();
        }
        public int QuantidadeParcela
        {
            get { return quantidadeParcela; }
            set { quantidadeParcela = value; }
        }

        public int IdEmprestimo
        {
            get { return idEmprestimo; }
            set { idEmprestimo = value; }
        }


        public decimal TaxaJurosMensal
        {
            get { return taxaJurosMensal; }
            set { taxaJurosMensal = value; }
        }


        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }


        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public Conta NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }
        public List<Parcela> Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }
    }
}
