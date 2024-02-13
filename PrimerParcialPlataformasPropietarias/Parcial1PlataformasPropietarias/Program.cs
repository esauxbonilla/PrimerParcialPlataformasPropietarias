using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la empresa
            CEmpresa empresa = new CEmpresa();

            //Recorremos cada uno de los elementos 

            foreach (CEmpleado miEmpleado in empresa)
            {
                miEmpleado.CalculaISR(0.00);
                miEmpleado.MuestraInformacion();
            }
        }
    }
}