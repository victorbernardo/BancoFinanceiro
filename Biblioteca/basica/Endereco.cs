using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Endereco
    {
        private int endereco;
        private string rua;
        private string cep;
        private string complemento;
        private string numero;
        private string cidade;
        private string bairro;
        private string uf;


        public int endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }


        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }


        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }


        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
