using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//importaçao de pacotes
using Biblioteca.basica;
using Biblioteca.negocio;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static ContaController contaController;
        private static ClienteController clienteController;
        private static AgenciaController agenciaController;
        private static EmprestimoController emprestimoController;
        //
        // construtor
        //
        private Service1()
        {
            contaController = new ContaController();
            clienteController = new ClienteController();
            agenciaController = new AgenciaController();
            emprestimoController = new EmprestimoController();
        }
        //
        // cliente
        //
        public List<Cliente> PesquisaCliente()
        {
            return clienteController.ListarTodosClientes();
        }
        //
        // agencia
        //
        public List<Agencia> PesquisaAgencia()
        {
            return agenciaController.ListarTodasAgencia();
        }
        //
        // conta
        //
     
        public void SalvarConta(Conta conta)
        {
            contaController.CriarConta(conta);
        }
       
        public Conta PesquisaContaPorNumeroConta(int numeroConta)
        {
            return contaController.PesquisarPorId(numeroConta);
        }
        //
        // emprestimo
        //
        public void SalvarEmprestimo(Emprestimo emprestimo)
        {
            emprestimoController.Salvar(emprestimo);
        }




        public List<Conta> PesquisaConta()
        {
            return contaController.Listar();
        }
    }
}
