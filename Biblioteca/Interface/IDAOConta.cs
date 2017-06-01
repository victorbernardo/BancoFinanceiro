using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOConta
    {
        void Inserir(Conta conta);

        void Excluir(Conta conta);
        void Alterar(Conta conta);
        List<Conta> Pesquisar(Conta conta);

        List<Conta> ListarConta();
    }
}
