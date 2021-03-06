﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importaçao de pacotes
using clientes.ServiceReference1;

namespace clientes
{
    public partial class FormPesquisaCliente : Form
    {
        private List<Cliente> clientes;
        //
        //CONSTRUTOR PADRAO
        //
        public FormPesquisaCliente()
        {
            InitializeComponent();
        }
  
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carrehaGridClientes();
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        //
        //FUNÇOES INTERNAS
        //              
        private void carrehaGridClientes()
        {
            clientes = new List<Cliente>();
            Service1Client sv = new Service1Client();

            clientes = sv.PesquisaCliente().ToList();//sv.PesquisaCliente().ToList();           
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AutoSize = true;
            //dgvClientes.DataSource = clientes;
            dgvClientes.Rows.Clear();
            clientes.ForEach(c=> dgvClientes.Rows.Add(c.Nome,c.Cpf,c.Telefone,c.Email, c.Endereco.Rua+", "+c.Endereco.Bairro+", "+c.Endereco.Cidade));
            
            
        }
        public Cliente RetornaClienteSelecionado()
        {
            Cliente cliente = dgvClientes.CurrentRow != null ? clientes.Find(c => c.Cpf.Equals(dgvClientes.CurrentRow.Cells[1].Value)) : null;
            return cliente;
        }
    }
}
