using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientes.ServiceReference1;
using Microsoft.VisualBasic;

namespace clientes
{
    public partial class FormPesquisaEmprestimo : Form
    {
        private List<Emprestimo> emprestimos;
        Service1Client sv;
        public FormPesquisaEmprestimo()
        {
            InitializeComponent();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            dgvEmprestimo.Rows.Clear();
            if (txtNumeroConta.Equals("") || !Information.IsNumeric(txtNumeroConta.Text))
                MessageBox.Show("Dados inválidos");
            else
                this.CarregaGridPorNumeroConta(Int32.Parse(txtNumeroConta.Text));
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btListarTodosEmprestimos_Click(object sender, EventArgs e)
        {
            this.listar();
        }









        private void listar()
        {
            emprestimos = new List<Emprestimo>();
            sv = new Service1Client();
            emprestimos = sv.PesquisaEmprestimo().ToList();
            dgvEmprestimo.AutoGenerateColumns = false;
            emprestimos.ForEach(e => dgvEmprestimo.Rows.Add(e.NumeroConta.NumeroConta, e.Valor, e.QuantidadeParcela, e.NumeroConta.Cliente.Nome, e.NumeroConta.Cliente.Cpf));
    
        }
        private void CarregaGridPorNumeroConta(int numeroConta)
        {
            emprestimos = new List<Emprestimo>();
            sv = new Service1Client();           
            emprestimos.Add(sv.PesquisaEmprestimoPorNumeroConta(numeroConta));
            dgvEmprestimo.AutoGenerateColumns = false;            
            emprestimos.ForEach(e => dgvEmprestimo.Rows.Add(e.NumeroConta.NumeroConta, e.Valor, e.QuantidadeParcela, e.NumeroConta.Cliente.Nome, e.NumeroConta.Cliente.Cpf));
        }
        public Emprestimo RetornaEmprestimoSelecionado()
        {
            Emprestimo emprestimo = dgvEmprestimo.CurrentRow != null ? emprestimos.Find(e=> e.NumeroConta.Equals(dgvEmprestimo.CurrentRow.Cells[0].Value)) : null;
            return emprestimo;
        }


    }
}
