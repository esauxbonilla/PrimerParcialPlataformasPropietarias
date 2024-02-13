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

            foreach (IEmpleados miEmpleado in empresa)
            {
                miEmpleado.CalculaISR(0.00);
                miEmpleado.MuestraInformacion();
            }

            //Creamos un nuevo empleado que clonaremos
            CEmpleado emp1 = new CEmpleado(100000, "Ventas");
            emp1.CalculaISR(0.00);
            emp1.MuestraInformacion();

            //Hacemos un clon
            CEmpleado emp3 = (CEmpleado)emp1.Clone();


            emp1.CalculaISR(0.00);
            emp1.MuestraInformacion();
            emp3.CalculaISR(0.00);
            emp3.MuestraInformacion();
            Console.WriteLine("--------------");

            //Modificamos uno, el otro no debe alterarse
            emp1.Salario = 125000;

            //Imprimimos para verificar
            emp1.CalculaISR(0.00);
            emp1.MuestraInformacion();
            emp3.CalculaISR(0.00);
            emp3.MuestraInformacion();
            Console.WriteLine("--------------");
        
        }
    }
}