using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFigura
{
    public class FIguraTridimensional : Figura
    {
        public void CalcularAreaEsfera(double radio)
        {
            if (radio <= 0)
            {
                
            }

            area = 4 * Math.PI * Math.Pow(radio, 2);
        }

        public void CalcularAreaCubo(double lado)
        {
            if (lado <= 0)
            {
                
            }

            area = 6 * Math.Pow(lado, 2);
        }

        public void CalcularAreaTetraedro(double longitudLado)
        {
            if (longitudLado <= 0)
            {
                
            }

            area = Math.Sqrt(3) * Math.Pow(longitudLado, 2);
        }
    }
}
