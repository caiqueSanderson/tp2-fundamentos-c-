using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios
{
    internal class Exercicio12
    {
        class Circle
        {
            public double radius;

            public double CalculateArea()
            {
                return Math.PI * (radius * radius);
            }
        }
        class Sphere
        {
            public double radius;

            public double CalculateVolume()
            {
                return (4.0 / 3.0) * Math.PI * (radius * radius * radius);
            }
        }

        internal class AppFigures
        {
            public void Start()
            {
                Circle circle = new Circle();
                Sphere sphere = new Sphere();

                circle.radius = 3;
                sphere.radius = 5;

                Console.WriteLine($"Circle area: {circle.CalculateArea():F2}");
                Console.WriteLine($"Sphere volume: {sphere.CalculateVolume():F2}");
            }
        }
    }
}
