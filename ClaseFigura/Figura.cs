using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFigura
{
    public class Figura
    {
        //Atributos de la clase Figura
        protected double area;
        protected double perimetro;
        protected double volumen;

        // Método para obtener el área de la figura
        public double ObtenerArea()
        {
            return area;
        }
        // Método para obtener el volumen de la figura
        public double ObtenerVolumen() 
        {
            return volumen;
        }
        // Método para obtener el perimetro de la figura
        public double ObtenerPerimetro() 
        {
            return perimetro;   
        }
    }
}
