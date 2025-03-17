using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios
{
    internal class Exercicio09
    {
        class Registration
        {
            public string studantName;
            public string course;
            public int registrationNumber;
            public string status;
            public string startDate;

            public void Lock()
            {
                status = "Trancada";
            }

            public void Unlock()
            {
                status = "Ativa";
            }

            public void ViewInfo()
            {
                Console.WriteLine($"\nNome do estudante: {studantName}");
                Console.WriteLine($"Curso: {course}");
                Console.WriteLine($"Número de matrícula: {registrationNumber}");
                Console.WriteLine($"Status: {status}");
                Console.WriteLine($"Data de início: {startDate}");
            }
        }

        internal class AppRegistration
        {
            public void Start()
            {
                Registration registration = new Registration();
                registration.studantName = "Fulano";
                registration.course = "Engenharia de Software";
                registration.registrationNumber = 123456;
                registration.status = "Ativa";
                registration.startDate = "01/01/2021";

                registration.ViewInfo();

                registration.Lock();
                registration.ViewInfo();

                registration.Unlock();
                registration.ViewInfo();
            }
        }
    }
}
