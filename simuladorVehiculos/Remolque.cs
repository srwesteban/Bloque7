using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorVehiculos
{
    public class Remolque
    {
        public int Peso { get; set; }

        public Remolque()
        {
        }
        public Remolque(int peso)
        {
            this.Peso = peso;
        }
        public override string ToString()
        {
            return $"Si, Peso del remolque {Peso}";
        }
    }
}
