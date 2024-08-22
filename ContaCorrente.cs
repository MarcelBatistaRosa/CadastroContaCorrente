using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroContaCorrente
{
    internal class ContaCorrente
    {
        private double Saldo;
        public int  Conta { get; private set; }
        public string Nome { get; set; }

        public ContaCorrente (string nome, int conta, double saldo)
        {
            Nome = nome;
            Conta = conta;
            Saldo = saldo;
        }

        public ContaCorrente (string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
            Saldo = 0;
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Conta: " + Conta.ToString() + ", " + "Titular: " + Nome + ", " + "Saldo: $" + Saldo.ToString("F2");
        }
    }
}   
