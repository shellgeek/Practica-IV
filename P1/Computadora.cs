using System;

namespace P1
{
    public class Computadora
    {
        private string Serial;
        private string Tipo;
        private string Marca;
        private string Modelo;
        private string MemoriaRam;
        private string Procesador;
        private string CapacidadHD;

    public Computadora(string serial, string tipo, string marca, string modelo, string memoriaram, string procesador, string capacidadhd)
    {
        this.Serial=serial;
        this.Tipo=tipo;
        this.Marca=marca;
        this.Modelo=modelo;
        this.MemoriaRam=memoriaram;
        this.Procesador=procesador;
        this.CapacidadHD=capacidadhd;
    }

    public void getComputador()
    {
        Console.WriteLine("Serial: " +Serial);
        Console.WriteLine("Tipo: " +Tipo);
        Console.WriteLine("Marca: " +Marca);
        Console.WriteLine("Modelo: " +Modelo);
        Console.WriteLine("Memoria Ram:" +MemoriaRam);
        Console.WriteLine("Procesador:" +Procesador);
        Console.WriteLine("Capacidad Disco Duro:" +CapacidadHD);
    }
}
}