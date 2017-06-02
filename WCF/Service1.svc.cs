using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.basica;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public Cliente retornaCliente()
        {
            Cliente cliente  = new Cliente();

            cliente.Email = "Email";
            cliente.IdCliente = 11111;

            return cliente;
        }


        public List<Cliente> retornaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente() {IdCliente=1234,Cpf="2222222"};
            Cliente cliente2 = new Cliente() { IdCliente = 2222, Cpf = "33333333" };

            clientes.Add(cliente1);
            clientes.Add(cliente2);

            return clientes;

        }


        public void salvaCliente(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Conta RetornaConta()
        {
            return new Conta();
        }

        public List<Cliente> PesquisaCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente() { Email = "teste01@01", Nome ="Teste01",IdCliente = 1234, Cpf = "2222222",Endereco = new Endereco {Cidade="teste01",Bairro="Teste01", Cep="11111111"} };
            Cliente cliente2 = new Cliente() { Email ="teste02@02",Nome="Teste02",IdCliente = 2222, Cpf = "33333333", Endereco = new Endereco { Cidade = "teste02", Bairro = "Teste02", Cep = "11111111" } };

            clientes.Add(cliente1);
            clientes.Add(cliente2);

            return clientes;
        }

        public List<Agencia> PesquisaAgencia()
        {
            throw new NotImplementedException();
        }

        public List<Conta> PesquisaConta()
        {
            throw new NotImplementedException();
        }

        public void SalvarConta(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
