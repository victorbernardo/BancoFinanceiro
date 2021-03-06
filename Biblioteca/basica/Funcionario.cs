﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Funcionario
    {
        private int matricula;
        private string cpf;
        private string nome;
        private string cargo;
        private string senha;
        private Agencia numeroAgencia;
        private Endereco endereco;

        public Funcionario()
        {
            numeroAgencia = new Agencia();
            endereco = new Endereco();
    }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }


        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public Agencia NumeroAgencia
        {
            get { return numeroAgencia; }
            set { numeroAgencia = value; }
        }


        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
