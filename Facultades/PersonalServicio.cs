using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultades
{
    public class PersonalServicio : IPersona
    {
        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Id { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaInicio { get; set; }
        public string AreaTrabajo { get; set; }
        public PersonalServicio(string nombre, string apellidos, string id, string estadoCivil, DateTime fechaInicio, string areaTrabajo)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Id = id;
            EstadoCivil = estadoCivil;
            FechaInicio = fechaInicio;
            AreaTrabajo = areaTrabajo;
        }
        public void cambioEstado(string cambio)
        {
            this.EstadoCivil = cambio;
        }
        public void TransladoArea(string a)
        {
            this.AreaTrabajo = a;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellidos}, ID: {Id}, Estado civil: {EstadoCivil}, Fecha de inicio: {FechaInicio}," +
                $"\nArea de Trabajo: {AreaTrabajo}";
        }

    }
}
