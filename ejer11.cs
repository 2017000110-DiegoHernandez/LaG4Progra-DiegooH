internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Ingrese un número");
        a = Convert.ToDouble(Console.ReadLine());

        b = 1;
        a = a + 1;

        do
        {
            a = a - 1;
            b = b * a;
            Console.WriteLine(a);

        }while (a != 1);
        Console.WriteLine(b);

    }
}