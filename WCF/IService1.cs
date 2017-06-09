using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//importaçao de pacotes
using Biblioteca.basica;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //
        // cliente
        //
        [OperationContract]
        List<Cliente> PesquisaCliente();
        //
        // agencia
        //
        [OperationContract]
        List<Agencia> PesquisaAgencia();
        //
        // conta
        //
        [OperationContract]
        List<Conta> PesquisaConta();   
   
        [OperationContract]
        void SalvarConta(Conta conta);

        [OperationContract]
        Conta PesquisaContaPorNumeroConta(int numeroConta);

        [OperationContract]
        void AlterarConta(Conta conta);

        [OperationContract]
        void RemoverConta(Conta conta);
        //
        // emprestimo
        //
        [OperationContract]
        void SalvarEmprestimo(Emprestimo emprestimo);
        [OperationContract]
        List<Emprestimo> PesquisaEmprestimo();
        [OperationContract]
        Emprestimo PesquisaEmprestimoPorNumeroConta(int numeroConta);
        [OperationContract]
        void AlterarEmprestimo(Emprestimo emprestimo);
       
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {              
    }
}
