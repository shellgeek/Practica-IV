using System;

namespace P6
{
    public class Carro
    {
        private int CantCombustible;

        //Constructor

        public Carro (int cantcombu)
        {
            this.CantCombustible=cantcombu;
        }

        public void EncenderCarro()
        {
            if (CantCombustible > 0)
            {
                Console.WriteLine("El Carro se ha Encendido!");
                CantCombustible-=1;
                Console.WriteLine("Cantidad de Combustible Restante...:"+ CantCombustible);
            }
            else
            {
                Console.WriteLine("El Carro no tiene combustible, No puede Encender!");
            }
        }
    }
}