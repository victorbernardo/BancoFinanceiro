using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca.basica;
using Biblioteca.dados;
using Biblioteca.exception;

namespace Biblioteca.negocio
{
    class EmprestimoController : Exception
    {
        
        private DAOEmprestimo emprestimoDao;
        private ProcurarContaController procurarContaController;

        public EmprestimoController(DAOEmprestimo emprestimoDao, ProcurarContaController procurarContaController)
        {
            this.emprestimoDao = emprestimoDao;
            this.procurarContaController = procurarContaController;
        }

        public void FazerEmprestimo(Emprestimo emprestimo)
        {
            if (emprestimo != null)
            {
                if (emprestimo.TaxaJurosMensal != null)
                {
                    if (emprestimo.Valor != null)
                    {
                       
                        emprestimoDao.Inserir(emprestimo);
                       
                    }
                    else
                    {
                        throw new GeralException("Informe o valor!");
                    }
                }
                else
                {
                    throw new GeralException("Informe a taxa de juros!");
                }

            }
            else
            {
                throw new GeralException("Não foi possível realizar o empréstimo!");
            }
        }

        public bool PagarParcela(Parcela parcela, Conta conta)
        {
            if (parcela.NumeroParcela <= 12)
            {
                if (conta.Saldo > parcela.Valor)
                {
                    conta.Saldo -= parcela.Valor;

                    return true;
                }
                
            }
           
            return false;
        }

        
    }
}
