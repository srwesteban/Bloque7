using System;
namespace EjercicioEmpleado
{
    public class Secretario:Empleado,IEmpleado
    {


        private string Puesto = "Secretario";
        Despacho Despacho = new Despacho();
        public Secretario()
        {

        }
      
        public Secretario(string nombre, string apellido, string dni,
            string direccion, int telefono, double salario)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;
        }
        public void incrementoSalario()
        {
            this.Salario += (Salario * 0.05);
        }

        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion} " +
                $"telefono: {Telefono}\nDespacho: {Despacho} salario: " +
                $"{Salario} puesto: {Puesto}";
        }

    }
}

