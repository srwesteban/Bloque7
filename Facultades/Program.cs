namespace Facultades
{
    public class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha1 = new DateTime(2022, 01, 01);
            DateTime fecha2 = new DateTime(2022, 06, 03);

            Console.WriteLine("Estudiante");
            Estudiantes estudiantes = new Estudiantes("William","Esteban","1085301221","Soltero","Diseño");
            Console.WriteLine(estudiantes);

            Console.WriteLine("\nEstudiante con cambios");
            estudiantes.cambiarCurso("Arquitectura");
            estudiantes.cambioEstado("Casado");
            Console.WriteLine(estudiantes);

            Console.WriteLine("\nProfesor");        
            Profesor profesor = new Profesor("Pablo","Pantoja","123123","casado",fecha1,03,"Matematicas");
            Console.WriteLine(profesor);
            Console.WriteLine("\nProfesor con cambios");
            profesor.cambioEstado("viudo");
            profesor.cambioOficina(22);
            profesor.cambioAsignatura("fisica");
            Console.WriteLine(profesor);

            Console.WriteLine("\nPersonal de servicio");
            PersonalServicio personalServicio = new PersonalServicio("Cecilia","Martinez","10234234","Divorciada",fecha2,"Biblioteca");
            Console.WriteLine(personalServicio);
            Console.WriteLine("\nPersonal de servicio con cambios");
            personalServicio.cambioEstado("Casada");
            personalServicio.TransladoArea("Secretaría");
            Console.WriteLine(personalServicio);



        }
    }
}