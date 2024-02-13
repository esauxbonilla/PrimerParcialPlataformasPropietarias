using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05IComparable
{
    internal class CRectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalcularArea();
        }

        private void CalcularArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}] = {2}", ancho, alto, area);
        }

        public void MuestraRectangulo()
        {
            Console.WriteLine("[{0},{1}] = {2}", ancho, alto, area);
        }
        //Implemetación de IComparable

        int IComparable.CompareTo(object obj)
        {
            //Hacemos type cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            //Si somos más grandes que el objeto regresamos 1
            if (area > temp.area)
                return 1;

            //Si somos más pequeños que el objeto regresamos -1
            if (area < temp.area)
                return -1;

            //Si somos iguales al objeto regresamos 0
            return 0;

        }
    }
}