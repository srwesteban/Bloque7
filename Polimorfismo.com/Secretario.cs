using System;
namespace EjercicioEmpleado
{
    public class Secretario:Empleado,IEmpleado
    {
        private string Puesto = "Secretario";
        private int NumeroFax;
        public Secretario()
        {

        }
        public Secretario(string nombre, string apellido, string dni,
            string direccion, int telefono, double salario,
            int numeroFax)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;
            this.NumeroFax = numeroFax;

        }
        public void incrementoSalario()
        {
            this.Salario += (Salario * 0.5);
        }

        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion}" +
                $"telefono: {Telefono} numero de fax: {NumeroFax} salario: " +
                $"{Salario} puesto: {Puesto}";
        }

    }
}

