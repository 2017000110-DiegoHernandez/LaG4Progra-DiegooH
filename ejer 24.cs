//ejer 24

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Ingrese un numero");
        a = Convert.ToDouble(Console.ReadLine());

        b = 1;
        c = 0;
        a = a + 1;

        while (a != b) 
        {
            a = a - 1;
            Console.WriteLine(a);
            c = c + a;
        }
        Console.WriteLine("La suma de todos los valores es: " + c);

    }
}