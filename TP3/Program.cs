using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Escolha o exercício ---");
            Console.WriteLine("Exercicio 1 - Conceitos de Classe, Objeto, Campos e Métodos (C#)");
            Console.WriteLine("Exercicio 4 - Testando a Classe \"Ingresso\"");
            Console.WriteLine("Exercicio 5 - Criando Métodos de Propriedade (Getters e Setters)");
            Console.WriteLine("Exercicio 6 - Adicionando Construtores à Classe \"Ingresso\"");
            Console.WriteLine("Exercicio 9 - Testando a Classe de Matrícula");
            Console.WriteLine("Exercicio 12 - Testando a Classe de Figuras");
            Console.Write("Sua escolha: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    var exercicio01 = new Exercicios.Exercicio01();
                    exercicio01.Start();  
                    break;
                case "4":
                    var exercicio04 = new Exercicios.Exercicio04.AppTicket();
                    exercicio04.Start();
                    break;
                case "5":
                    var exercicio05 = new Exercicios.Exercicio05.AppTicket();
                    exercicio05.Start();
                    break;
                case "6":
                    var exercicio06 = new Exercicios.Exercicio06.AppTicket();
                    exercicio06.Start();
                    break;
                case "9":
                    var exercicio09 = new Exercicios.Exercicio09.AppRegistration();
                    exercicio09.Start();
                    break;
                case "12":
                    var exercicio12 = new Exercicios.Exercicio12.AppFigures();
                    exercicio12.Start();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
