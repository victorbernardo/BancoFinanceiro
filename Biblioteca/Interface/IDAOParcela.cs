using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;

namespace Biblioteca.Interface
{
    public interface IDAOParcela
    {
        void Inserir(Parcela parcela);

        void Excluir(Parcela parcela);
        void Alterar(Parcela parcela);
        Parcela Pesquisar(int idParcela);
        List<Parcela> Pesquisar();


    }
}
