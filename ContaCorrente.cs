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

        
        
        
        
        public ContaCorrente (string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
            
        }

        public ContaCorrente (string nome, int conta, double depositoInicial) : this (nome, conta)
        {
          Deposito(depositoInicial);
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Conta.ToString() + ", " + "Titular: " + Nome + ", " + "Saldo: $" + Saldo.ToString("F2");
        }
    }
}   
