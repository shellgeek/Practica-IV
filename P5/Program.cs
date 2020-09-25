/*Cree una clase llamada Personaje con los métodos de instancia MoverArriba, MoverAbajo,
MoverDerecha y MoverIzquierda. Cree una clase llamada Mario y otra clase llamada Koopa que
herede las funcionalidades de la clase Personaje.
Autor: RainierL. De Jesus Lopez */

using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCIONES DE MARIO!");

            Mario PerMario = new Mario();
            PerMario.MoverAbajo();
            PerMario.MoverDerecha();
            PerMario.MoverIzquierda();
            PerMario.MoverArriba();

            Console.WriteLine("\nACCIONES DE KOOPA!");
            Koopa PerKoopa = new Koopa();
            PerKoopa.MoverArriba();
            PerKoopa.MoverAbajo();
            PerKoopa.MoverDerecha();
            PerKoopa.MoverIzquierda();
        }
    }
}
