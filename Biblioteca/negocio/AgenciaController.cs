using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.dados;
using Biblioteca.basica;

namespace Biblioteca.negocio
{
    public class AgenciaController
    {
        private DAOAgencia daoAgencia;

        public AgenciaController()
        {
            daoAgencia = new DAOAgencia();
        }
/*
###########################################################
FUNCIONALIDADES 
###########################################################
*/
        public List<Agencia> ListarTodasAgencia()
        {
            return this.Listar();
        }

/*
###########################################################
FUNÇÕES INTERNAS (fragmentação dos métodos)
###########################################################
*/
        private List<Agencia> Listar()
        {
            try
            {
                return daoAgencia.Consultar();
            }
            catch (Exception ex) 
            {
                
                throw new Exception("Erro no listar Agencia " + ex.Message) ;
            }
        }
    }
}
