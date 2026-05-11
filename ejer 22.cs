//ejer 22

internal class Program
{
    private static void Main(string[] args)
    {
        

        double a, c;
        Console.WriteLine("Ingrese un número: ");
        a = Convert.ToDouble(Console.ReadLine());

        for (double b = 1; b <= 20; b++){
            c = a * b;
            
            Console.WriteLine(c);
        }
    }
}