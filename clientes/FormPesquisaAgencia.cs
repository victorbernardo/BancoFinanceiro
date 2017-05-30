using Biblioteca.basica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class FormPesquisaAgencia : Form
    {
        private List<Agencia> agencias;
        public FormPesquisaAgencia()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            agencias = new List<Agencia>();
              
            Agencia agencia1 = new Agencia() {Nome="Ipinga 01",NumeroAgencia=1111111,Endereco = new Endereco() { Cidade="cidade01",Cep="123456"
            } };

            Agencia agencia2 = new Agencia() { Nome = "Ipinga 02", NumeroAgencia = 22222, Endereco = new Endereco() { Cidade = "cidade02" } };

            agencias.Add(agencia1);
            agencias.Add(agencia2);

            dgvAgencias.DataSource = agencias;


            MessageBox.Show("");

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Agencia RetornaAgenciaSelecionado()
        {

            Agencia agencia = dgvAgencias.CurrentRow != null ? agencias.Find(c => c.NumeroAgencia.Equals(dgvAgencias.CurrentRow.Cells[1].Value)) : null;

            return agencia;
        }
    }
}
