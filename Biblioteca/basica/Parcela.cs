using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Parcela
    {
        private int parcelaId;
        private DateTime dataVencimento;
        private decimal valor;
        private Emprestimo emprestimoId;

        public int ParcelaId
        {
            get { return parcelaId; }
            set { parcelaId = value; }
        }


        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }


        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public Emprestimo EmprestimoId
        {
            get { return emprestimoId; }
            set { emprestimoId = value; }
        }
    }
}
