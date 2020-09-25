using System;

namespace P3
{
    public class ClaseAritmetica
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

    public double Resta(double cantuno, double cantdos)
    {
        return cantuno-cantdos;
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