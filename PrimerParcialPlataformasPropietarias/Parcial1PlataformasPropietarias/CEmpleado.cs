using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal class CEmpleado : IEmpleados
    {
        double salario;
        double ISR;
        string departamento;

        //Constructor
        public CEmpleado(double pSalario, string pDepartamento)
        {
            //Inicializamos los datos
            salario = pSalario;
            departamento = pDepartamento;
        }
        //Métodos interfaz

        public void CalculaISR(double pImpuesto)
        {
            //Calculamos impuesto
            ISR = salario * 0.16;
        }

        public void MuestraInformacion()
        {
            //Mostramos la información 
            Console.WriteLine("Trabajas en {0}", departamento);
            Console.WriteLine("Tu salario es de {0}, con ISR de {1}", salario, ISR);
            Console.WriteLine("Tu salario total es de {0}", salario - ISR);
            Console.WriteLine("---------");
        }
    }
}