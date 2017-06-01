using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOCliente
    {
        void Inserir(Cliente cliente);

        void Excluir(Cliente cliente);
        void Alterar(Cliente cliente);
        List<Cliente> Pesquisar(Cliente cliente);
        List<Cliente> Consultar();
    }
}
