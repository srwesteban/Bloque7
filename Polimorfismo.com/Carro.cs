using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleado
{
    public class Carro
    {
        public string matriculaCarro { get; set; }
        public string marcaCarro { get; set; }

        public Carro()
        {
            this.marcaCarro = "chevrolet";
            this.matriculaCarro = "ABC123";
        }
        public Carro(string matriculaCarro, string marcaCarro)
        {
            this.matriculaCarro = matriculaCarro;
            this.marcaCarro = marcaCarro;
        }
        public override string ToString()
        {
            return $"matricula: {matriculaCarro} marca: {marcaCarro}";
        }
    }
}
