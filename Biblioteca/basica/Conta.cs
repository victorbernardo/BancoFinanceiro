﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.basica
{
    public class Conta
    {
        private int numeroConta;
        private decimal saldo;
        private DateTime dataCriacao;
        private Agencia numeroAgencia;
        private Cliente cliente;

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        public Agencia Numero_agencia
        {
            get { return numeroAgencia; }
            set { numeroAgencia = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}
