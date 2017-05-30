﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca.basica
{

    public class Cliente
    {
        private String nome;

        private String telefone;
        private String cpf;
        private int idCliente;
        private String email;
        private Endereco endereco;


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }


        public String Email
        {
            get { return email; }
            set { email = value; }
        }


        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}