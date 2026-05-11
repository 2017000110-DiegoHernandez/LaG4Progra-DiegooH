//ejer5

internal class Program
{
    private static void Main(string[] args)
    {
        double i, b, c;

        Console.WriteLine("Ingrese un numero");
        c = Convert.ToDouble(Console.ReadLine());
        i = c * 10;
        b = 0;

        while (b <= i)
        {
            Console.WriteLine(b);
            b = b + c;
        }


    }
}