using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio06
    {
        public void Start()
        {
            Console.WriteLine("--- Calculador de IMC ---");

            Console.WriteLine("Insira seu peso em kg: ");
            string inputWeight = Console.ReadLine();
            if (!double.TryParse(inputWeight, NumberStyles.Float, CultureInfo.InvariantCulture, out double weight))
            {
                Console.WriteLine("Valor inválido!");
            }

            Console.WriteLine("Insira sua altura em m: ");
            string inputHeight = Console.ReadLine();
            if (!double.TryParse(inputHeight, NumberStyles.Float, CultureInfo.InvariantCulture, out double height))
            {
                Console.WriteLine("Valor inválido!");
            }

            double imc = weight / (height * height);
            string classification = "normal";

            if (imc < 18.5)
            {
                classification = "magreza";
            }
            else if (imc < 24.9)
            {
                classification = "normal";
            }
            else if (imc < 29.9)
            {
                classification = "sobrepeso";
            }
            else if (imc < 34.9)
            {
                classification = "obesidade grau I";
            }
            else if (imc < 39.9)
            {
                classification = "obesidade grau II";
            }
            else
            {
                classification = "obesidade grau III";
            }

            Console.WriteLine($"Seu IMC deu: {imc}");
            Console.WriteLine($"Sua classificação é: {classification}");
        }
    }
}
