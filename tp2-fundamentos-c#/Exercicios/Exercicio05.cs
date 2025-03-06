using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio05
    {
        public void Start()
        {
            Console.WriteLine("--- Conversor de Temperatura ---");
            Console.WriteLine("Insira o valor em graus Celsius: ");
            string value = Console.ReadLine();

            if (!double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out double celsius))
            {
                Console.WriteLine("Valor inválido!");
            }

            double celsiusToFahrenheit = ((celsius * 9) / 5) + 32;
            double celsiusToKelvin = celsius + 273.15;

            Console.WriteLine("Temperaturas convertidas com sucesso!");
            Console.WriteLine($"Fahrenheint: {celsiusToFahrenheit}");
            Console.WriteLine($"Kelvin: {celsiusToKelvin}");
        }
    }
}
