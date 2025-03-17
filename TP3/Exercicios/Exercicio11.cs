using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios
{
    internal class Exercicio11
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
    }
}
