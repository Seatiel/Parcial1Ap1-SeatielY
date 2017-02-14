using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_SeatielY
{
    public class Utilidades
    {
        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }
    }
}
