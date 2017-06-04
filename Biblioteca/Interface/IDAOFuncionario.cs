using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOFuncionario
    {
        void Inserir(Funcionario funcionario);

        void Excluir(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        Funcionario PesquisarPorId(int idFuncionario);
        List<Funcionario> ListarFuncionario();
    }
}
