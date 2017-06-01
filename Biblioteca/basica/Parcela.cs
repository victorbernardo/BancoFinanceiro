using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
   public class Parcela
    {
        private decimal valor;
        private int idParcela;
        private int numeroParcela;
        private DateTime dataVencimento;
        private string status;
        private Emprestimo emprestimo;

      

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int IdParcela
        {
            get { return idParcela; }
            set { idParcela = value; }
        }

        public int NumeroParcela
        {
            get { return numeroParcela; }
            set { numeroParcela = value; }
        }

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Emprestimo Emprestimo
        {
            get { return emprestimo; }
            set { emprestimo = value; }
        }
    }
}
