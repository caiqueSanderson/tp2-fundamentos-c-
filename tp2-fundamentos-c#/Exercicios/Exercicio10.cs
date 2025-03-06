using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio10
    {
        public void Start()
        {
            Console.WriteLine("--- Contagem Regressiva ---");
            Console.WriteLine("Insira um número positivo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number <= 0)
            {
                Console.WriteLine("Digite um número inteiro positivo!");
                return;
            }

            bool isFirst = true;
            Console.Write("Contagem: ");
            while (number > 0)
            {
                if (isFirst)
                {
                    Console.Write(number--);
                    isFirst = false;
                }
                else
                {
                    Console.Write($", {number--}");  
                }
            }
        }
    }
}
