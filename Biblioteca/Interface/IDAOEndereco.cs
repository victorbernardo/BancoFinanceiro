using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOEndereco
    {
        void Inserir(Endereco endereco);

        void Excluir(Endereco endereco);
        void Alterar(Endereco endereco);
        List<Endereco> Pesquisar(Endereco endereco); 
    }
}
