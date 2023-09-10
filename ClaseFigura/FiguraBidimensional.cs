using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFigura
{
    public class FiguraBidimensional : Figura
    {
        //Métodos para calcular el área de las figuras bidimensionales.
        public void CalcularAreaCirculo(double radio)
        {
           area = Math.PI * Math.Pow(radio, 2);
        }
        public void CalcularAreaCuadrado(double Base, double altura)
        {
            area = Base * altura;
        }
        public void CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            area = 0.5 * baseTriangulo * altura;
        }

        //Métodos para calcular el perímetro de las figuras bidimensionales.

        public void CalcularPerimetroCirculo(double radio)
        {
            perimetro = 2 * Math.PI * radio;
        }

        public void CalcularPerimetroCuadrado(double lado)
        {
            perimetro = 4 * lado;
        }

        public void CalcularPerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                //validar
            }

            if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
            {
                //validar
            }

            perimetro = lado1 + lado2 + lado3;
        }
    }
}
