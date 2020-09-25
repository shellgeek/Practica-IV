/* Modele tres entidades del mundo real, colocar por lo menos 3 características distintivas.
Autor:Rainier L. De Jesus*/

using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora compu = new Computadora("1293F45G22","LAPTOP","LENOVO","Y700", "16 GB DDR4", "INTREL CORE I7", "1TB HDD");
            Mascota masco =new Mascota ("CANINO", "BEETHOVEN", "RAINIER DE JESUS", false, true);
            Habitaciones hab =new Habitaciones("209","DOBLE", false, false);
            compu.getComputador();
            masco.getMascota();
            hab.getHabitacion();
        }
    }
}
