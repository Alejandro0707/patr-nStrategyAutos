using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface ITipoConduccion
    {
        string ObtenerDescripcion();
        int ObtenerPotencia(float decilitrosCombustible);
        int ObtenerIncrementoVelocidad(float decilitrosCombustible);
    }
}
