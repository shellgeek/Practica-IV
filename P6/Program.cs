/* Cree una clase Carro, con un campo llamado _cantidadCombustible y un método que se llame
Encender el cual en base a la gasolina disponible mostrara si el carro pudo o no avanzar. Cada
vez que el método se ejecute, deberá restarse 1 a la gasolina disponible. La cantidad de gasolina
debe establecerse al momento de instanciar un objeto de del tipo de la clase.*/

using System;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantComb;
            Console.Write("Ingrese la Cantidad de Combustible..:");
            CantComb=int.Parse(Console.ReadLine());
            Carro carro = new Carro(CantComb);
            do
            {
                carro.EncenderCarro();
                CantComb--;
            } while (CantComb > -1);
        }
    }
}
