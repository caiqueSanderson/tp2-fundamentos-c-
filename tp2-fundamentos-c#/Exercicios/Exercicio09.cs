using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_fundamentos_c_.Exercicios
{
    internal class Exercicio09
    {
        public void Start()
        {
            Console.WriteLine("--- Calculadora de Salário Líquido ---");

            Console.WriteLine("Insira seu salário: ");
            decimal grossSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de dependentes: ");
            int dependents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor de outros descontos: ");
            decimal otherDiscounts = Convert.ToDecimal(Console.ReadLine());

            if (grossSalary <= 0 || dependents < 0 || otherDiscounts < 0)
            {
                Console.WriteLine("Entrada inválida! Insira números positivos.");
                return;
            }

            decimal inss = CalculateInss(grossSalary);
            decimal irrf = CalculateIrrf(grossSalary, inss, dependents);
            decimal netSalary = grossSalary - inss - irrf - otherDiscounts;

            Console.WriteLine("Resumo do Cálculo:");
            Console.WriteLine($"Salário Bruto: R$ {grossSalary:F2}");
            Console.WriteLine($"INSS: R$ {inss:F2}");
            Console.WriteLine($"IRRF: R$ {irrf:F2}");
            Console.WriteLine($"Outros Descontos: R$ {otherDiscounts:F2}");
            Console.WriteLine($"Salário Líquido: R$ {netSalary:F2}");
            Console.WriteLine("Cálculo baseado nas alíquotas do INSS e IRRF.");
        }
        private decimal CalculateInss(decimal grossSalary)
        {
            if (grossSalary <= 1412) return grossSalary * 0.075m;
            else if (grossSalary <= 2666.68m) return grossSalary * 0.09m;
            else if (grossSalary <= 4000) return grossSalary * 0.12m;
            else return grossSalary * 0.14m;
        }

        private decimal CalculateIrrf(decimal grossSalary, decimal inss, int dependents)
        {
            decimal baseCalculation = grossSalary - inss - (dependents * 189.59m);

            if (baseCalculation <= 2112) return 0;
            else if (baseCalculation <= 2826.65m) return baseCalculation * 0.075m - 158.40m;
            else if (baseCalculation <= 3751.05m) return baseCalculation * 0.15m - 370.40m;
            else if (baseCalculation <= 4664.68m) return baseCalculation * 0.225m - 651.73m;
            else return baseCalculation * 0.275m - 884.96m;
        }
    }
}
