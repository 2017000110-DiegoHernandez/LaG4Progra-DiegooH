//ejer 9

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, d;

        d = 0;

        for (a = 1; a <= 22; a++) 
        {
            c = 0;
            for (b = 1; b <= a; b++) 
            {
                if (a % b == 0) 
                {
                    c = c + 1;
                }
            }
            if (c == 2) { d = d + a;}
        }

        Console.WriteLine("Los primos entre 1 y 22 suman " + d);

    }
}