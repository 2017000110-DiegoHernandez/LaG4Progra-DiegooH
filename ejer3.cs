//ejer3

internal class Program
{
    private static void Main(string[] args)
    {
        double t, i;
        t = 21;
        Console.WriteLine("Ingrese un numero de 20 en adelante");
        i = Convert.ToDouble(Console.ReadLine());

        while (i > t) 
        {
            Console.WriteLine(t);

            t = t + 2;
        }


    }
}