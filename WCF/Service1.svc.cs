using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//importaçao de pacotes
using Biblioteca.basica;
using Biblioteca.dados;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //
        // cliente
        //
        public List<Cliente> PesquisaCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            DAOCliente daoCliente = new DAOCliente();
            listaCliente = daoCliente.Consultar();
            return listaCliente;
        }
        //
        // agencia
        //
        public List<Agencia> PesquisaAgencia()
        {
            List<Agencia> listaAgencia = new List<Agencia>();
            DAOAgencia daoAgencia = new DAOAgencia();
            listaAgencia = daoAgencia.Consultar();
            return listaAgencia;
        }
        //
        // conta
        //
        public List<Conta> PesquisaConta()
        {
            List<Conta> listaConta = new List<Conta>();
            DAOConta daoConta = new DAOConta();
            listaConta = daoConta.ListarConta();            
            return listaConta;
        }

        public void SalvarConta(Conta conta)
        {
            DAOConta daoConta = new DAOConta();
            daoConta.Inserir(conta);
        }
    }
}
