using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleado
{
    public class Despacho
    {
        public int NumeroFax = 981276398;
        public override string ToString()
        {
            return $"Si, numero fax: {NumeroFax}";
        }
    }
}
