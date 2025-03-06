using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio03
    {
        public void Start()
        {
            Console.WriteLine("--- Diferença entre duas datas ---");
            Console.WriteLine("Insira a primeira data: ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime before))
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            Console.WriteLine("Insira a segunda data: ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime after))
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            if (before > after)
            {
                (before, after) = (after, before);
            }

            TimeSpan difference = after - before;

            int years = after.Year - before.Year;
            int months = after.Month - before.Month;
            int days = after.Day - before.Day;

            if (months < 0)
            {
                years--;
                months += 12;
            }

            if (days < 0)
            {
                months--;
                DateTime previousMonth = after.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            Console.WriteLine($"Diferença entre as datas: {years} anos, {months} meses e {days} dias");
        }
    }
}
