using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio12
    {
        public void Start()
        {
            Console.WriteLine("--- Jogo de Adivinhação ---");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;

            while (secretNumber != guess)
            {
                Console.WriteLine("Insira seu palpite: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < secretNumber)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("O número secreto é menor!");
                }
                else
                {
                    Console.WriteLine($"Parabéns, o número secreto realmente era: {guess}");
                }
            }
        }
    }
}
