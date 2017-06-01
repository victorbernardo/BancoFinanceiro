using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Endereco
    {
        private int idEndereco;     
        private string rua;
        private string cep;
        private string complemento;
        private string numero;
        private string cidade;
        private string bairro;
        private string uf;

        public int IdEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }
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


        public string Bairro
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
