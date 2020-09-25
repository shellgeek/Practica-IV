using System;

namespace P1
{
    public class Habitaciones
    {
        private string Numero;
        private string Tipo;
        private bool Ocupada;
        private bool Limpia;

    public Habitaciones (string numero, string tipo, bool ocupada, bool limpia)
    {
        this.Numero = numero;
        this.Tipo = tipo;
        this.Ocupada = ocupada;
        this.Limpia = limpia;
    }

    public void getHabitacion()
    {
        Console.WriteLine("Numero de Habitacion..:"+Numero);
        Console.WriteLine("Tipo Habitacion..:"+Tipo);
        Console.WriteLine("La Habitacion esta Ocupada?..:"+Ocupada);
        Console.WriteLine("La Habitacion esta Limpia?..:"+Limpia);
    }
    }
}