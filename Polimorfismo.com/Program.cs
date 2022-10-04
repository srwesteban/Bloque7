namespace EjercicioEmpleado
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Empleado:\n");
            Empleado supervisor2 = new Empleado("Alberto", "Mesias", "10832423", "av condor", 314234234, 1500000, null);
            Empleado supervisor = new Empleado("Mario","Palacios","1937836","av condor",314234234,1500000,null);
            Empleado empleado = new Empleado("Julio", "Florez", "121231221", "calle 22A",7127127, 1000000,supervisor);
            Console.WriteLine(empleado);
            Console.WriteLine("supervisado por: "+ empleado.Supervisor);
            empleado.cambiarSupervisor(supervisor2);//cambio
            Console.WriteLine("\ncambio de supervisor\n");
            Console.WriteLine(empleado);
            Console.WriteLine("supervisado por: " + empleado.Supervisor);
            Console.WriteLine("\nincremento salario\n");
            empleado.incrementarSalario();
            Console.WriteLine(empleado);

            Console.WriteLine("\nSecretario:\n");
            Secretario secretario = new Secretario("Juan","Vicente","81212823","Manzana 8 casa 2",31542314,2000000);
            Secretario secretario2 = new Secretario("Maria", "Paz", "12321312", "street 14", 300332123, 2000000);
            Console.WriteLine(secretario);
            Console.WriteLine("\nincremento salario 5%\n");
            secretario.incrementoSalario();
            Console.WriteLine(secretario);

            Console.WriteLine("\nVendedor:\n");
            Carro car = new Carro("AWS","Renault");
            Carro car2 = new Carro("ACV","Audi");
            Vendedor vendedor = new Vendedor("Carlos","Lopez","12312332","Calle 2C n 2",316828726,3000000,"Norte",car);
            Vendedor vendedor2 = new Vendedor("Pablo", "Rosero", "2342344", "vereda torobajo", 311333223, 2000000,"Sur",car);
            Console.WriteLine(vendedor);
            vendedor.ListaClientes.Enqueue("Miguel Arias telefono: 123213123");
            vendedor.ListaClientes.Enqueue("Santiago Moreno telefono: 234243234");
            vendedor.ListaClientes.Enqueue("Deiby Salazar telefono: 2345435");
            vendedor.ListaClientes.Enqueue("Sebastian Rosero telefono: 456456456");
            Console.WriteLine("\nLista de clientes:");
            foreach(var cliente in vendedor.ListaClientes)
            {
                Console.WriteLine(cliente);
            }
            Console.WriteLine("\nDar de alta o registrar cliente\n");
            vendedor.darDeAlta("William Esteban telefono: 123123123");
            Console.WriteLine("\nDar de baja o eliminar cliente\n");
            vendedor.darDeBaja();
            Console.WriteLine("\ncambio de carro\n");
            vendedor.cambiarCoche(car2);
            Console.WriteLine(vendedor);

            

            Console.WriteLine("\nJefe de zona\n");
            JefeZona jefeZona = new JefeZona("Manuel","Correa","3049543","Altos de mirasol",321123123,5000000,"Jefe de zona",car2,secretario);
            Console.WriteLine(jefeZona);
           
            Console.WriteLine("\nincremento salario, Cambio de secretario, cambio de coche\n");
            jefeZona.incrementarSalario();
            jefeZona.cambiosecretario(secretario2);
            jefeZona.cambiarcoche(car);
            Console.WriteLine(jefeZona);

            Console.WriteLine("\nLista de vendedores:\n");
            jefeZona.ListaVendedores.Add(vendedor);
            jefeZona.ListaVendedores.Add(vendedor2);
            foreach (var vende in jefeZona.ListaVendedores)
            {
                Console.WriteLine(vende);
            }
            Console.WriteLine("\nDar de alta vendedor\n");
            Vendedor vendedor3 = new Vendedor("Luis","Potosi","12312312","Calle callejera",321423423,2000000,"Oeste",null);
            jefeZona.dardealta(vendedor3);
            Console.WriteLine("\nDar de baja vendedor\n");
            jefeZona.dardebaja(vendedor2);
        }

    }
  
}
