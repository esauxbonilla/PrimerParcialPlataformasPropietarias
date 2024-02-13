using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAlumno[] Calificacion = new CAlumno[5];

            Calificacion[0] = new CAlumno(9.8, 7.8, 8.7);
            Calificacion[1] = new CAlumno(7.8, 7.3, 5.7);
            Calificacion[2] = new CAlumno(9.2, 7.5, 8.3);
            Calificacion[3] = new CAlumno(8.5, 7.5, 6.7);
            Calificacion[4] = new CAlumno(3.8, 6.8, 8.8);

            //Imprimimos arreglo original
            foreach (CAlumno c in Calificacion)
                //c.MuestraPromedio
                Console.WriteLine(c);

            Console.WriteLine("----------");

            //Hacemos uso de sort, el cual necesita implementacion de IComparable
            Array.Sort(Calificacion);

            //Imprimimos arreglo ordenado. 
            foreach (CAlumno c in Calificacion)
                Console.WriteLine(c);
        }
    }
}