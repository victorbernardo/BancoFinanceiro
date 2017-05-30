using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Agencia
    {
        private int numeroAgencia;
        private String nome;
        private Endereco endereco;


        public Agencia()
        {
            endereco = new Endereco();
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            set { numeroAgencia = value; }
        }


        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        
        
    }
}
