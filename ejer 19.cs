//ejer 19

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;

        a = 0;
        b = 0;
        c = 0;

        do
        {
            c = c + 0.5;
            a = a + 7;
            b = b + a;

        
        } while (a != 140);

        Console.WriteLine("La suma de los primeros 20 multiplos de 7 es " + b);
        Console.WriteLine(c + " de estos numeros son pares");
       
    }
}