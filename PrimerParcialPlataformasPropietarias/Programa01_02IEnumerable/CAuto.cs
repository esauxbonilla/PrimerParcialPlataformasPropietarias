using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    internal class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        //Constructor
        public CAuto(string pModelo, double pCosto)
        {
            // Inicializamos los datos. 
            costo = pCosto;
            modelo = pModelo;
        }

        //Metodo interfaz

        public void CalculaTenencia(double pImpuesto)
        {
            //Calculamos impuesto
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            //Mostramos la información necesaria
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("--------------");
        }
    }
}