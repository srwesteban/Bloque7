using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultades
{
    public interface IPersona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Id { get; set; }
        public string EstadoCivil { get; set; }

        public void cambioEstado(string a);


    }
}
