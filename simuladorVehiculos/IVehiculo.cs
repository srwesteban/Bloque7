using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorVehiculos
{
    public interface IVehiculo
    {
        public string Matricula { get; set; }
        public int Velocidad { get; set; }
        
    }
}
