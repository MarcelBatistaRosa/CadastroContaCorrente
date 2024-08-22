using CadastroContaCorrente;
using System;
using System.Runtime.CompilerServices;

namespace CadastroContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            

            ContaCorrente Cc = new ContaCorrente(nome, conta);
            

            Console.Write("Haverá depósito inicial (s/n): ");
            string Di = Console.ReadLine();
            if (Di == "s")
            {
                Console.Write("Entre com o valor do depósito incial: ");
                double vdi = double.Parse(Console.ReadLine());
                Cc.Deposito(vdi);
                Console.WriteLine();
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(Cc);
            } 
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(Cc);
            }

            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            double D = double.Parse(Console.ReadLine());
            Cc.Deposito(D);
            Console.WriteLine(Cc);

            Console.WriteLine();
            Console.Write("Entre com o valor para Saque: ");
            double S = double.Parse(Console.ReadLine());
            Cc.Saque(S);
            Console.WriteLine(Cc);

        }
    }
}