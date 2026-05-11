//ejer6

internal class Program
{
    private static void Main(string[] args)
    {
        double sello;

        Console.WriteLine("Bienvenido a la barber");

        for (sello = 1; sello < 9; sello++) 
        {
            Console.WriteLine("Visita "+ sello+ " sello guardado");
            Console.ReadKey();

        }

        Console.WriteLine("Proximo corte gratis");


    }
}