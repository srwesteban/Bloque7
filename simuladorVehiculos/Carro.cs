using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorVehiculos
{
    public class Carro : IVehiculo
    {
        public string Matricula { get; set; }
        public int Velocidad { get; set; }
        public int Puertas { get; set; }

        public Carro()
        {
            this.Velocidad = 0;
        }
        public Carro(string matricula,int puertas)
        {
            this.Matricula = matricula;
            this.Puertas = puertas;
            this.Velocidad = 0;
        }
        public void acelerar(int acelerar)
        {
            this.Velocidad = acelerar;

        }
        public int mostrarPuertas()
        {
            return Puertas;
        }
        public override string ToString()
        {
            return $"Matricula: {Matricula} Velocidad {Velocidad} Puertas: {mostrarPuertas()}" ;
        }


    }
}
