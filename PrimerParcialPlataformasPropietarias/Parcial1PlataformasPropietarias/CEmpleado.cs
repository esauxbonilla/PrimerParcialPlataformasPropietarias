using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal class CEmpleado : IEmpleados, ICloneable, IComparable
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
            
        public double Salario { get { return salario; } set { salario = value; } }
        public double Isr { get { return ISR; } set { ISR = value; } }

        //Métodos interfaz
        public void CalculaISR(double pImpuesto)
        {
            //Calculamos impuesto
            ISR = salario * 0.16;
        }

        public override string ToString()
        {
            return string.Format("Trabajas en {0}\nTu salario es de {1}, con ISR de {2}\nTu salario total es de {3}\n---------",
        departamento, salario, ISR, salario - ISR);
        }

        public void MuestraInformacion()
        {
            //Mostramos la información 
            Console.WriteLine("Trabajas en {0}", departamento);
            Console.WriteLine("Tu salario es de {0}, con ISR de {1}", salario, ISR);
            Console.WriteLine("Tu salario total es de {0}", salario - ISR);
            Console.WriteLine("---------");
        }

        //Método para implementar el método a ICloneable
        public object Clone()
        {
            CEmpleado temp = new CEmpleado(salario, departamento);
            temp.Isr = ISR;
            return temp;
        }

        //Implemetación de IComparable
        int IComparable.CompareTo(object obj)
        {
            CEmpleado other = (CEmpleado) obj;
            if (this.salario > other.salario)
                return 1;
            else if (this.salario < other.salario)
                return -1;
            else
                return 0;
        }
    }
}