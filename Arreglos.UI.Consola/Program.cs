using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(10);

        oMiArreglo.llenar(5, 20);

        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ascendente");

        oMiArreglo.Ordenar();

        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo descendente");

        oMiArreglo.Ordenar(false);

        Console.WriteLine(oMiArreglo);

        Console.ReadKey();
    }
}