using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio07
    {
        public void Start()
        {
            Console.WriteLine("--- Verificador de Número Par ou Ímpar ---");

            Console.Write("Insira um número inteiro: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro válido");
                return;
            }

            Console.WriteLine($"O número escolhido foi: {number}");
            Console.WriteLine($"Ele é {(number % 2 == 0 ? "par" : "ímpar")}");
        }
    }
}
