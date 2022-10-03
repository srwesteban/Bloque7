using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultades
{
    public class Estudiantes:IPersona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Id { get; set; }
        public string EstadoCivil { get; set; }

        public string Curso { get; set; }   
        public Estudiantes()
        {

        }
        public Estudiantes(string nombre,string apellido,string id,string estado,string curso )
        {
            this.Nombre = nombre; 
            this.Apellidos = apellido;
            this.Id = id;
            this.EstadoCivil = estado;
            this.Curso = curso;
        }
        public void cambioEstado(string cambio)
        {
            this.EstadoCivil = cambio;
        }
        public void cambiarCurso(string a)
        {
            this.Curso =a;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellidos}, ID: {Id}, Estado civil: {EstadoCivil}, curso: {Curso}";
        }
    }
}
