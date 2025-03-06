using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio11
    {
        public void Start()
        {
            Console.WriteLine("--- Tabuada interativa ---");
            Console.WriteLine("Insira um número entre 1 e 10");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-- Multiplicação --");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
