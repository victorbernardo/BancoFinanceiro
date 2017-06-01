using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
namespace Biblioteca.Interface
{
    public interface IDAOMovimentacao
    {
        void Inserir(Movimentacao movimentacao);

        void Excluir(Movimentacao movimentacao);
        void Alterar(Movimentacao movimentacao);
        List<Movimentacao> Pesquisar(Movimentacao movimentacao); 
    }
}
