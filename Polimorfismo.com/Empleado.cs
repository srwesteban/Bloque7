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

        public Empleado Supervisor;

        public Empleado()
        {
        }
        public Empleado(string a)
        {
            this.Supervisor.Nombre =a;
        }
     
        public Empleado(string nombre,string apellido,string dni,
            string direccion,int telefono,double salario,Empleado supervisor)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;
            this.Supervisor = supervisor;
            
        }
        public void cambiarSupervisor(Empleado supervisor)
        {
            this.Supervisor = supervisor;
        }
        public void incrementarSalario()
        {
            this.Salario += 50000;
        }   

        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion}" +
                $" telefono: {Telefono} salario: {Salario}";
         
        }

    }
}

