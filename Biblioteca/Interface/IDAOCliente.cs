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
        Cliente PesquisarPorId(int idCliente);
        List<Cliente> Consultar();
    }
}
