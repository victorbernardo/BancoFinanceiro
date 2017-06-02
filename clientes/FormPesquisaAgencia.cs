using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importaçao de pacotes
using clientes.localhost1;
//using Biblioteca.basica;

namespace clientes
{
    public partial class FormPesquisaAgencia : Form
    {
        private List<Agencia> agencias;
        //
        //CONSTRUTOR PADRAO
        //
        public FormPesquisaAgencia()
        {
            InitializeComponent();
        }
        //
        //FUNÇOES DOS BOTÕES
        //
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridAgencia();
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //FUNÇOES INTERNAS
        //
        private void carregaGridAgencia()
        {
            agencias = new List<Agencia>();
            Service1 sv = new Service1();         
            agencias = sv.PesquisaAgencia().ToList();
            dgvAgencias.AutoGenerateColumns = false;
            dgvAgencias.DataSource = agencias;
        }
        public Agencia RetornaAgenciaSelecionado()
        {
            Agencia agencia = dgvAgencias.CurrentRow != null ? agencias.Find(c => c.NumeroAgencia.Equals(dgvAgencias.CurrentRow.Cells[1].Value)) : null;
            return agencia;
        }
    }
}
