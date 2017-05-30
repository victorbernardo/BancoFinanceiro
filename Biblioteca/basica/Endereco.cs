using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Endereco
    {
        private int enderecoId;
        private String rua;
        private String cep;
        private String complemento;
        private String numero;
        private String cidade;
        private String bairro;
        private String uf;


        public int Endereco_id
        {
            get { return enderecoId; }
            set { enderecoId = value; }
        }


        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }


        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }


        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }


        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
