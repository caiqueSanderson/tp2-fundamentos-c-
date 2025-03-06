using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio04
    {
        public void Start()
        {
            Console.WriteLine("--- Formulário de Cadrastro Simples ---");

            Console.Write("Insira seu nome: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Insira sua idade: ");
            int age = Console.Read();

            Console.Write("Insira seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Seus dados: ");
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"E-mail: {email}");
        }
    }
}
