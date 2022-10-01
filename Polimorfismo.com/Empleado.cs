using System;
namespace EjercicioEmpleado
{
    public class Empleado : IEmpleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set;}
        public int Telefono { get; set; }
        public double Salario { get; set; }

        public Empleado supervisor;

        public Empleado()
        {

        }
     
        public Empleado(string nombre,string apellido,string dni,
            string direccion,int telefono,double salario)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;
            
        }
        public void cambiarSupervisor(Empleado supervisor)
        {
            this.supervisor = supervisor;
        }
        public void incrementarSalario()
        {
        }   

        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion}" +
                $"telefono: {Telefono} salario: {Salario} supervisado por: {supervisor}";
        }

    }
}

