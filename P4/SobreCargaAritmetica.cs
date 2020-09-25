using System;

namespace P4
{
    public class SobreCargaAritmetica
    {
        private double cantUno;
        private double CantDos;

    public ClaseAritmetica(double cantuno, double cantdos)
    {
        this.cantUno = cantuno;
        this.CantDos =cantdos;
    }

    public double Suma(double cantuno, double cantdos)
    {
        return cantuno+cantdos;
    }

    public double Suma(double cantuno, double cantdos, double canttres, double cantcuatro)
    {
        return cantuno+cantdos+canttres+cantcuatro;
    }
    public double Resta(double cantuno, double cantdos)
    {
        return cantuno-cantdos;
    }
      public double Resta(double cantuno, double cantdos, double canttres, double cantcuatro)
    {
        return cantuno-cantdos-canttres-cantcuatro;
    }

    public double Multiplicar (double cantuno, double cantdos)
    {
        return cantuno*cantdos;
    }

    public double dividir(double cantuno, double cantdos)
    {
        return cantuno/cantdos;
    }
}
}