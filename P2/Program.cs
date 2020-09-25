/*Crear una clase llamada Estudiante con un campo llamado promedio, el cual solo podrá ser
accedido mediante una propiedad. El valor del promedio no puede estar por encima de 100 que
es la nota máxima.
Autor: Rainier L. De Jesus Lopez */

using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Nota01, Nota02, Nota03;
            Console.WriteLine("Ingrese el nombre del Estudiante..:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la primera Nota..:");
            Nota01 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda Nota..:");
            Nota02= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera Nota..:");
            Nota03= int.Parse(Console.ReadLine());
            Estudiante est = new Estudiante(Nombre, Nota01, Nota02, Nota03);
            est.CalcularPromedio();
        }
    }
}
