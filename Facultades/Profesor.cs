using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultades
{
    public class Profesor:IPersona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Id { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaInicio { get; set; }
        public int oficina { get; set; }
        public string Asignatura { get; set; }

        public Profesor(string nombre,
                        string apellidos,
                        string id,
                        string estado,
                        DateTime fecha,
                        int oficina,
                        string asignatura)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Id = id;
            this.EstadoCivil = estado;
            this.FechaInicio = fecha;
            this.oficina = oficina;
            this.Asignatura = asignatura;

        }
        public void cambioEstado(string a)
        {
            this.EstadoCivil = a;
        }
        public void cambioOficina(int a)
        {
            this.oficina = a; 
        }
        public void cambioAsignatura(string a)
        {
            this.Asignatura = a;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellidos}, ID: {Id}, Estado civil: {EstadoCivil}, oficina: {oficina}, " +
                $"Fecha de inicio: {FechaInicio},\nasignatura: {Asignatura}";

        }
    }
}
