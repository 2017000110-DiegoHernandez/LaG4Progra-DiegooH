//ejer8

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("Ingrese un numero");
        b = Convert.ToDouble(Console.ReadLine());

        d = b / 2;

        for (a = 2; a < d; a++) 
        {
            c = a * 2;
            Console.WriteLine(c);
        }



    }
}