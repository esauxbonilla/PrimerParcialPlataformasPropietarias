using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal class CEmpresa:IEnumerable
    {
        private IEmpleados[] activos;

        public CEmpresa()
        {
            activos = new IEmpleados[8];

            activos[0] = new CEmpleado(80000.00, "Marketing");
            activos[1] = new CEmpleado(95000.00, "Tecnología");
            activos[2] = new CEmpleado(75000.00, "Recursos Humanos");
            activos[3] = new CEmpleado(82000.00, "Finanzas");
            activos[4] = new CEmpleadoMedioTiempo(82000.00, "Marketing");
            activos[5] = new CEmpleadoMedioTiempo(95000.00, "Tecnología");
            activos[6] = new CEmpleadoMedioTiempo(75000.00, "Recursos Humanos");
            activos[7] = new CEmpleadoMedioTiempo(82000.00, "Finanzas");
        }

        public IEnumerator GetEnumerator()
        {
            //Regresamos la estructura que queramos que recorra el foreach
            
            return activos.GetEnumerator();
        }
    }
}