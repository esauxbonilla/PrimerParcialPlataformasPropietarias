using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIComparable
{
    internal class CAlumno : IComparable
    {
        private double cali1;
        private double cali2;
        private double cali3;
        private double promedio;

        public CAlumno(double pcali1, double pcali2, double pcali3)
        {
            cali1 = pcali1;
            cali2 = pcali2;
            cali3 = pcali3;
            CalcularPromedio();
        }

        private void CalcularPromedio()
        {
            promedio = (cali1 + cali2 + cali3) / 3;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2} = {3}", cali1, cali2, cali3, promedio);
        }

        public void MuestraPromedio()
        {
            Console.WriteLine("[{0}, {1}, {2} = {3}", cali1, cali2, cali3, promedio);
        }

        //Implementación de IComparable
        int IComparable.CompareTo(object obj)
        {
            //Hacemos typecast con el objeto con el cual nos vamos a comparar. 
            CAlumno temp = (CAlumno)obj;

            //Si somos más grandes que el objeto regresamos 1. 
            if (promedio > temp.promedio)
                return 1;

            //Si somos más pequeños que el objeto regresamos -1. 
            if (promedio < temp.promedio)
                return -1;

            //Somos iguales al objeto regresamos 0
            return 0;
        }
    }
}