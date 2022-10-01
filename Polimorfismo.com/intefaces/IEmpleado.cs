using System;
namespace EjercicioEmpleado
{
    public interface IEmpleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public double Salario { get; set; }


        public string ToString();
        public void incrementarSalario();
    }
    



}

