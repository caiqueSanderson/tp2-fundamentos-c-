using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios
{
    internal class Exercicio08
    {
        class Registration
        {
            string studantName;
            string course;
            int registrationNumber;
            string status;
            string startDate;

            public void Lock() {
                status = "Trancada";
            }

            public void Unlock()
            {
                status = "Destrancada";
            }

            public void ViewInfo()
            {
                Console.WriteLine($"Nome do estudante: {studantName}");
                Console.WriteLine($"Curso: {course}");
                Console.WriteLine($"Número de matrícula: {registrationNumber}");
                Console.WriteLine($"Status: {status}");
                Console.WriteLine($"Data de início: {startDate}");
            }
        }
    }
}
