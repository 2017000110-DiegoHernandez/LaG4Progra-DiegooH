//ejer4

internal class Program
{
    private static void Main(string[] args)
    {
        double i;

        Console.WriteLine("Ingrese un numero");
        i = Convert.ToDouble(Console.ReadLine());

        while (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 || i % 13 == 0)
        {
            Console.WriteLine("Su numero es primo");
            i = i + 1;
        }


    }
}