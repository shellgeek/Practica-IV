using System;

namespace P1
{
    public class Mascota
    {
        private string Especie;
        private string Nombre;
        private string NombreDueno;
        private bool TienePedigri;
        private bool VacunasAplicadas;

    

    public Mascota(string especie, string nombre, string nombredueno, bool tienepedigri, bool vacunasaplicadas)
    {
        this.Especie=especie;
        this.Nombre=nombre;
        this.NombreDueno = nombredueno;
        this.TienePedigri = tienepedigri;
        this.VacunasAplicadas = vacunasaplicadas;
    }

    public void getMascota()
    {
        Console.WriteLine("Especie..:"+Especie);
        Console.WriteLine("Nombre..:"+Nombre);
        Console.WriteLine("Nombre del Propietario..:"+NombreDueno);
        Console.WriteLine("Tiene Pedigri..:"+TienePedigri);
        Console.WriteLine("Tiene Vacunas Aplicadas..:"+VacunasAplicadas);
    }
}

}