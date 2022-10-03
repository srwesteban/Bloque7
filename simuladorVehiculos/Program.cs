namespace simuladorVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro:");
            Carro carro = new Carro("ACV233",4);
            Console.WriteLine(carro+"\n");
            Console.WriteLine("Carro con aceleracion");
            carro.acelerar(200);
            Console.WriteLine(carro+"\n");
            Console.WriteLine("Camion:");
            Remolque remolque = new Remolque(50);
            Camion camion = new Camion("ABC345");
            Console.WriteLine(camion + "no" + "\n");
            camion.ponRemolque(remolque);
            Console.WriteLine("camion con remolque");
            Console.WriteLine(camion + "\n");
            Console.WriteLine("camion sin remolque");
            camion.quitaRemolque();            
            Console.WriteLine(camion + "no" + "\n");
            Console.WriteLine("camion sin remolque con velocidad");
            camion.acelerar(120);
            Console.WriteLine(camion + "no" + "\n");
            camion.ponRemolque(remolque);
            Console.WriteLine("camion con velocidad y con remolque\n");
            camion.acelerar(120);
            Console.WriteLine(camion + "\n");
            Console.WriteLine("camion con baja velocidad y con remolque\n");
            camion.acelerar(60);
            Console.WriteLine(camion);



        }
    }
}