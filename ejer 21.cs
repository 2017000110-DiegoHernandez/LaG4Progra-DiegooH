//ejer 21

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Ingrese un numero");
        b = Convert.ToDouble(Console.ReadLine());

        c = 0;

        do
        {
            c++;

            a = b * c;
            Console.WriteLine(b+" x "+c+" = "+a);
        } while (c != 11);

       
    }
}