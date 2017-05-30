using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOAgencia
    {
        void Inserir(Agencia agencia);

        void Excluir(Agencia agencia);
        void Alterar(Agencia agencia);
        List<Agencia> Pesquisar(Agencia agencia);
    }
}
