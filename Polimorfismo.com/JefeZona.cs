using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleado
{
    public class JefeZona :Empleado, IEmpleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public double Salario { get; set; }

        public string Puesto = "Jefe de zona";

        public List<Vendedor> ListaVendedores = new List<Vendedor>();   
        
        public Carro carro = new Carro();
        public Secretario secretario = new Secretario();

        public JefeZona(string nombre, string apellidos, string dNI, string direccion, int telefono, double salario,
            string puesto, Carro carro, Secretario secretario)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dNI;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
            Puesto = puesto;
            this.carro = carro;
            this.secretario = secretario;
        }

        public void incrementarSalario()
        {
            this.Salario += (Salario * 0.2);
        }
        public void cambiosecretario(Secretario s)
        {
            this.secretario = s;
        }
        public void cambiarcoche(Carro c)
        {
            this.carro = c;
        }
        public void dardealta(Vendedor v)
        {
            ListaVendedores.Add(v);
            foreach (var vende in ListaVendedores)
            {
                Console.WriteLine(vende);
            }
        }
        public void dardebaja(Vendedor v)
        {
            ListaVendedores.Remove(v);
            foreach (var vende in ListaVendedores)
            {
                Console.WriteLine(vende);
            }
        }
        public override string ToString()
        {
            return $"Empleado: {Nombre} {Apellidos} dni: {DNI} direccion: {Direccion} " +
                $"telefono: {Telefono}  salario: " +
                $"{Salario}\npuesto: {Puesto} carro: {carro} secretario:{secretario}";
        }
    }
    
}
