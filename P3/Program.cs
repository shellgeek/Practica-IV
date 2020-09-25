/*Hacer una clase llamada Aritmética, que contenga métodos para cada una de las operaciones
aritméticas básicas. Estos métodos solo podrán ser accedidos desde la propia clase.
Autor: Rainier L. De Jesus Lopez*/

using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            Double val1, val2, result;
            Console.Clear();
            Console.WriteLine("**** CALCULADORA BASICA ****\n");
            Console.WriteLine("1- SUMA");
            Console.WriteLine("2- RESTA");
            Console.WriteLine("3- MULTIPLICAR");
            Console.WriteLine("4- DIVIDIR");
            Console.WriteLine("\n SELECCIONE UNA OPERACION A REALIZAR...:");
            opt = int.Parse(Console.ReadLine());
            Console.Write("INGRESE UNA CANTIDAD...:");
            val1=double.Parse(Console.ReadLine());
            Console.Write("INGRESE OTRA CANTIDAD...:");
            val2=double.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ClaseAritmetica Sumar = new ClaseAritmetica(val1, val2);
                    result = Sumar.Suma(val1,val2);
                    Console.WriteLine("LA SUMA DE LOS NUMEROS INGRESADO ES {0}", result);
                    break;

                case 2:
                    ClaseAritmetica Restar = new ClaseAritmetica(val1, val2);
                    result = Restar.Resta(val1, val2);
                    Console.WriteLine("LA RESTA DE LOS NUMEROS INGRESADO ES {0}", result);
                    break;
       
                case 3:
                    ClaseAritmetica Mult = new ClaseAritmetica(val1, val2);
                    result = Mult.Multiplicar(val1,val2);
                    Console.WriteLine("LA MULTIPLICACION DE LOS NUMEROS INGRESADO ES {0}", result);
                    break;

                case 4:
                    ClaseAritmetica Div = new ClaseAritmetica(val1, val2);
                    result = Div.dividir(val1,val2);
                    Console.WriteLine("LA DIVIDIR DE LOS NUMEROS INGRESADO ES {0}", result);
                    break;

                default:
                    Console.WriteLine("INGRESE UNA OPERACION VALIDA!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

