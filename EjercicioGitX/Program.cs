using System;

namespace EjercicioGitX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MIS DATOS PERSONALES ===");
            Console.WriteLine("Nombre: Xavier Andres Alcerro Alcerro");
            Console.WriteLine("Cuenta: 20221930056");
            Console.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"));

            Console.WriteLine("\n=== INFORMACIÓN ACADÉMICA ===");
            Console.WriteLine("Carrera: Ingeniería en Sistemas");
            Console.WriteLine("Trimestre: 1");
            Console.WriteLine("Asignatura: POO");

            Console.WriteLine("\n=== MENSAJE ===");
            Console.WriteLine("¡Aprendiendo Git y GitHub!");
            Console.WriteLine("Este es mi cuarto commit en develop");

            Console.WriteLine("\n=== PRESIONE UNA TECLA PARA SALIR ===");
            Console.ReadKey();
        }
    }
}