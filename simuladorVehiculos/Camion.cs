using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorVehiculos
{
    public class Camion : IVehiculo
    {
        public string Matricula { get; set; }
        public int Velocidad { get; set; }

        Remolque remolque = null;


        public Camion()
        {

        }
        public Camion(string matricula)
        {
            this.Matricula = matricula;
            this.Velocidad = 0;
        }
        public void ponRemolque(Remolque r)
        {
            this.remolque = r;
        }
        public void quitaRemolque()
        {
           this.remolque = null;
          
        }   
        public void acelerar(int a)
        {

            this.Velocidad = a;

            if (this.Velocidad > 100 && this.remolque != null)
            {
                Console.WriteLine("Cuidado va demasiado rapido!!! ");
            }
        }
        public override string ToString()
        {
        
            return $"Matricula {Matricula} Velocidad {Velocidad} Remolque: {remolque}";
        }
    }
}
