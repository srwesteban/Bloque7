namespace EjercicioEmpleado
{
    class Program
    {
        public static void Main(String[] args)
        {
            Empleado empleado = new Empleado("hola", "asdas", "12121", "calleasd", 123213, 9888787);

            Console.WriteLine(empleado);

            Secretario secretario = new Secretario();
            Console.WriteLine(secretario);            

            Vendedor vendedor = new Vendedor();
            vendedor.ListaClientes.Add("Miguel Arias telefono: 123213123");
            vendedor.ListaClientes.Add("Santiago Moreno telefono: 234243234");
            vendedor.ListaClientes.Add("Deiby Salazar telefono: 2345435");
            vendedor.ListaClientes.Add("Deiby Salazar telefono: 456456456");
            Console.WriteLine(vendedor);



        }

    }
  
}
