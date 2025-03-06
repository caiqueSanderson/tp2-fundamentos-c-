using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2_fundamentos_c_.Exercicios;

namespace tp2_fundamentos_c_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Escola o exercicio ---");
            Console.WriteLine("1 - Cálculo de Idade Precisa");
            Console.WriteLine("2 - Dias até o Próximo Aniversário");
            Console.WriteLine("3 - Diferença Entre Duas Datas");
            Console.WriteLine("4 - Formulário de Cadastro Simples");
            Console.WriteLine("5 - Conversor de Temperatura");
            Console.WriteLine("6 - Cálculo de IMC");
            Console.WriteLine("7 - Verificador de Número Par ou Ímpar");
            Console.WriteLine("8 - Classificação de Nota Escolar");
            Console.WriteLine("9 - Calculadora de Salário Líquido");
            Console.WriteLine("10 - Contagem Regressiva");
            Console.WriteLine("11 - Tabuada Interativa");
            Console.WriteLine("12 - Jogo de Adivinhação");

            Console.Write("Sua escolha: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    var exercicio01 = new Exercicio01();
                    exercicio01.Start();
                    break;
                case "2":
                    var exercicio02 = new Exercicio02();
                    exercicio02.Start();
                    break;
                case "3":
                    var exercicio03 = new Exercicio03();
                    exercicio03.Start();
                    break;
                case "4":
                    var exercicio04 = new Exercicio04();
                    exercicio04.Start();
                    break;
                case "5":
                    var exercicio05 = new Exercicio05();
                    exercicio05.Start();
                    break;
                case "6":
                    var exercicio06 = new Exercicio06();
                    exercicio06.Start();
                    break;
                case "7":
                    var exercicio07 = new Exercicio07();
                    exercicio07.Start();
                    break;
                case "8":
                    var exercicio08 = new Exercicio08();
                    exercicio08.Start();
                    break;
                case "9":
                    var exercicio09 = new Exercicio09();
                    exercicio09.Start();
                    break;
                case "10":
                    var exercicio10 = new Exercicio10();
                    exercicio10.Start();
                    break;
                case "11":
                    var exercicio11 = new Exercicio11();
                    exercicio11.Start();
                    break;
                case "12":
                    var exercicio12 = new Exercicio12();
                    exercicio12.Start();
                    break;
            }
        }
    }
}
