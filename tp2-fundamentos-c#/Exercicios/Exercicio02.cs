using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio02
    {
        public void Start()
        {
            Console.WriteLine("--- Calculadora dias para o seu aniversário ---");
            Console.WriteLine("Insira sua data de nascimento: ");

            string dateUser = Console.ReadLine();

            DateTime birthdate;
            bool sucessConvert = DateTime.TryParse(dateUser, out birthdate);

            if (!sucessConvert)
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            DateTime today = DateTime.Today;

            DateTime nextBirthday = new DateTime(today.Year, today.Month, today.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int daysUntilBirthday = (nextBirthday - today).Days;

            Console.WriteLine($"Seu próximo aniversário será em {daysUntilBirthday} dias");
        }
    }
}
