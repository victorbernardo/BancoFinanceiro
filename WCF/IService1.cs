using Biblioteca.basica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Cliente retornaCliente();
        [OperationContract]
        List<Cliente> retornaClientes();
        [OperationContract]
        void salvaCliente(Cliente cliente);

        [OperationContract]
        void salvaCliente(Conta conta);

        [OperationContract]
        Conta RetornaConta();

    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
      
           
    }
}
