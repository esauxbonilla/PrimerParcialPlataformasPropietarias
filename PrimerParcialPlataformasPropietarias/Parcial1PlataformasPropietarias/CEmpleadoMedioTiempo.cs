using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal class CEmpleadoMedioTiempo:IEmpleados,IComparable
    {
        double salario;
        double ISR;
        string departamento;

        //Constructor
        public CEmpleadoMedioTiempo(double pSalario, string pDepartamento)
        {
            //Inicializamos los datos
            salario = pSalario;
            departamento = pDepartamento;
        }
        public double Salario { get { return salario; } set { salario = value; } }
        public double Isr { get { return ISR; } set { ISR = value; } }

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
            Console.WriteLine("Tu salario total de medio tiempo es de {0}", (salario - ISR) * 0.5);
            Console.WriteLine("---------");
        }

        //Implemetación de IComparable
        int IComparable.CompareTo(object obj)
        {
            CEmpleadoMedioTiempo other = (CEmpleadoMedioTiempo)obj;
            if (this.salario > other.salario)
                return 1;
            else if (this.salario < other.salario)
                return -1;
            else
                return 0;
        }
    }
}
