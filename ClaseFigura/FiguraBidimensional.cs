using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFigura
{
    public class FiguraBidimensional : Figura
    {
        public void CalcularAreaCirculo(double radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El radio del círculo debe ser mayor que cero.");
            }

            area = Math.PI * Math.Pow(radio, 2);
        }
        public void CalcularAreaCuadrado(double Base, double altura)
        {
            if (Base <= 0 && altura <= 0)
            {

            }

            area = Base * altura;
        }
        public void CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            if (baseTriangulo <= 0 || altura <= 0)
            {
                
            }

            area = 0.5 * baseTriangulo * altura;
        }
    }
}
