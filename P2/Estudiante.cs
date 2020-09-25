using System;

namespace P2
{
    class Estudiante
    {
        private string Nombre;
        private int Nota1;
        private int Nota2;
        private int Nota3;
        private int Promedio;

        public Estudiante(string nombre, int nota1, int nota2, int nota3) 
        {
            this.Nombre = nombre;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            if (nota1 > 100 || nota2 > 100 || nota3 > 100)
            {
                Console.WriteLine("La nota no puede ser mayor a 100");
            }
        }

        public int CalcularPromedio() 
        {
            Promedio = (Nota1+ Nota2 + Nota3) / 3;
            Console.WriteLine("Su promedio es de :{0}",Promedio);
            return Promedio;
        }
    }
}
