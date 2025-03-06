using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio01
    {
        public void Start()
        {
            Console.WriteLine("--- Calculadora de idade ---");

            Console.WriteLine("Insira sua data de nascimento(dd/mm/yyyy): ");
            string dataUser = Console.ReadLine();

            DateTime birthdate;
            bool sucessConvert = DateTime.TryParse(dataUser, out birthdate);

            if (!sucessConvert)
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            DateTime now = DateTime.Today;

            int years = now.Year - birthdate.Year;
            int months = now.Month - birthdate.Month;
            int days = now.Day - birthdate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(now.Year, now.Month == 1 ? 12 : now.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Você têm {years} anos, {months} meses e {days} dias ");

            Console.WriteLine("Precione qualquer tecla para sair...");
            Console.ReadLine();
        }

    }
}
