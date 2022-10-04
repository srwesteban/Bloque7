using System;
using System.Collections.Generic;
namespace EjercicioEmpleado
{
    public class Vendedor:Empleado,IEmpleado
    {
        public Carro carro;
        public string Puesto = "Vendedor";
        public string AreaVentas { get; set; }

        public Queue<string> ListaClientes = new Queue<string>();


        public Vendedor()
        {

        }
        public Vendedor(string nombre, string apellido, string dni,
            string direccion, int telefono, double salario,string areaventas,Carro car)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;    
            this.AreaVentas = areaventas;
            this.carro = car;

        }
        public void incrementoSalario()
        {
            this.Salario += (Salario * 0.10);
        }
        public void darDeAlta(string a)
        {
            ListaClientes.Enqueue(a);

            foreach (var cliente in ListaClientes)
            {
                Console.WriteLine(cliente);
            }

        }
        public void darDeBaja()
        {
            ListaClientes.Dequeue();
            foreach (var cliente in ListaClientes)
            {
                Console.WriteLine(cliente);
            }
        }
        public void cambiarCoche(Carro a)
        {
            this.carro = a;
        }


        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion}" +
                $"telefono: {Telefono} area de ventas: {AreaVentas} salario: " +
                $"{Salario} puesto: {Puesto} carro: {carro}";
        }
    }
}

