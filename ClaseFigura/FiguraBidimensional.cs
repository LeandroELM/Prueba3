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
    }
}
