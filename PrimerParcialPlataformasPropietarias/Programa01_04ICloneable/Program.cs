using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto("March", 170000);

            //Aquí pensamos que hacemos clonado
            //Pero solo es otra variable referenciada a la misma instancia

            CAuto Auto2 = Auto1;

            Auto1.CalcularTenencia(0.10);
            Auto2.CalcularTenencia(0.10);

            //Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("-------1-------");

            //Hacemos un cambio, si fuera clon solo uno cambia
            Auto1.Costo = 60000;

            //Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("-------2-------");

            //Ahora si hacemos un clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("-------3-------");

            //Modificamos uno, el otro no debe alterarse
            Auto1.Costo = 250000;

            //Imprimimos para verificar
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("-------4-------");

        }
    }
}