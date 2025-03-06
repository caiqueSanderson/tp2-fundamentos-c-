using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio08
    {
        public void Start()
        {
            Console.WriteLine("--- Classificação de Nota Escolar ---");
            Console.WriteLine("Insira sua nota de 0 a 10: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            string classification = "";

            if (grade < 7)
            {
                classification = "Insuficiente";
            }
            else if (grade < 8)
            {
                classification = "Regular";
            }
            else if (grade < 9)
            {
                classification = "Bom";
            }
            else if (grade < 10)
            {
                classification = "Excelente";
            }

            Console.WriteLine($"A nota inserida foi {grade}");
            Console.WriteLine($"Sua nota é {classification}");
        }
    }
}
