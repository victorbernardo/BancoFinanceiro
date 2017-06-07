using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.basica;
using Biblioteca.dados;

namespace Biblioteca.negocio
{
    public class ClienteController
    {
        private DAOCliente daoCliente;

        public ClienteController()
        {
           daoCliente = new DAOCliente();
        }
/*
###########################################################
FUNCIONALIDADES 
###########################################################
*/
        public void SalvarNovoCliente(Cliente cliente)
        {
            this.ValidarPreenchimento(cliente);
        }
        public List<Cliente> ListarTodosClientes()
        {
            return this.Listar();
        }


/*
###########################################################
FUNÇÕES INTERNAS (fragmentação dos métodos)
###########################################################
*/
        private void ValidarPreenchimento(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("Cliente invalido");
            if (cliente.Cpf == null)
                throw new Exception("Cpf invalido");    
        }
        private List<Cliente> Listar()
        {
            try
            {
                return daoCliente.Consultar();             
            }
            catch (Exception ex )
            {
                throw new Exception("Erro no listar cliente " + ex.Message) ;
            }
        }
    }
}
