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


        public void salvaCliente(Cliente cliente)
        {
          
            
        }

        public void salvaCliente(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Conta RetornaConta()
        {
            return new Conta();
        }
    }
}
