using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Movimentacao
    {
        private int movimentacaoId;
        private DateTime data;
        private string tipo;
        private decimal valor;
        private Conta numeroConta;

        public int MovimentacaoId
        {
            get { return movimentacaoId; }
            set { movimentacaoId = value; }
        }


        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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

    }
}
