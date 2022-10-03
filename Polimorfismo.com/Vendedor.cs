using System;
using System.Collections.Generic;
namespace EjercicioEmpleado
{
    public class Vendedor:Empleado,IEmpleado
    {
        public Carro carro = new Carro();
        public string Puesto = "Vendedor";
        public string AreaVentas { get; set; }

        public List<string> ListaClientes = new List<string>();        
       
        public Vendedor()
        {

        }
        public Vendedor(string nombre, string apellido, string dni,
            string direccion, int telefono, double salario,string areaventas)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Salario = salario;    
            this.AreaVentas = areaventas;

        }
        public void incrementoSalario()
        {
            this.Salario += (Salario * 0.10);
        }
        public List<string> darDeAlta(int i)
        {
            i = i-1;
            return this.ListaClientes;
        }
        public List<string> darDeBaja()
        {
            return this.ListaClientes;
        }
        public void cambiarCoche()
        {
            
        }


        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion}" +
                $"telefono: {Telefono} area de ventas: {AreaVentas} salario: " +
                $"{Salario} puesto: {Puesto} lista de clientes{ListaClientes}";
        }
    }
}

