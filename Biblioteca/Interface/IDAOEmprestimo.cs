using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOEmprestimo
    {
        void Inserir(Emprestimo emprestimo);
        void Excluir(Emprestimo emprestimo);
        void Alterar(Emprestimo emprestimo);
        List<Emprestimo> Pesquisar(Emprestimo emprestimo);
    }
}
