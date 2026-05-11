// ejer 20

internal class Program
{
    private static void Main(string[] args)
    {
        double e, a, i;
        bool prim;

        e = 0;

        for (a = 300; a >=1; a--) 
        {
            if (a < 2)
            {
                prim = false;
            }
            else 
            {
                prim = true;
                i = 2;

                while (i * i <= a && prim) 
                {
                    if (a % i == 0) 
                    {
                        prim = false;
                    }
                    i = i + 1;
                }
            }

            if (prim) 
            {
                Console.WriteLine(a);
            }

            if (a % 2 == 0) 
            {
                e = e + a;
            }
        }

        Console.WriteLine("Los pares suman: " + e);


    }
}