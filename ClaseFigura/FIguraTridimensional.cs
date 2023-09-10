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
        //Métodos para calcular el área de las figuras tridimensionales.
        public void CalcularAreaEsfera(double radio)
        {
            area = 4 * Math.PI * Math.Pow(radio, 2);
        }

        public void CalcularAreaCubo(double lado)
        {
            area = 6 * Math.Pow(lado, 2);
        }

        public void CalcularAreaTetraedro(double longitudLado)
        {
            area = Math.Sqrt(3) * Math.Pow(longitudLado, 2);
        }

        //Métodos para calcular el volumen de las figuras tridimensionales.
        public void CalcularVolumenEsfera(double radio)
        {
            if (radio <= 0)
            {
                //validar
            }

            volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }
        public void CalcularVolumenCubo(double lado)
        {
            if (lado <= 0)
            {
                //validar
            }

            volumen = Math.Pow(lado, 3);
        }
        public void CalcularVolumenTetraedro(double lado)
        {
            if (lado <= 0)
            {
                //validar
            }

            volumen = (Math.Pow(lado, 3)) / (6 * Math.Sqrt(2));
        }
    }
}
