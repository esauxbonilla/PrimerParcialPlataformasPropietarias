using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1PlataformasPropietarias
{
    internal interface IEmpleados
    {
        //Calcular ISR
        void CalculaISR(double isr);

        //Mostrar información
        void MuestraInformacion();
    }
}