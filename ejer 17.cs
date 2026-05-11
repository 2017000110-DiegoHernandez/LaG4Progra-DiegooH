// ejer 17

internal class Program
{
    private static void Main(string[] args)
    {
        double e, a, i, acu;
        bool prim;

        acu = 0;
        e = 0;

        for (a = 1; a <= 100; a++) 
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
                acu = acu + a;
                Console.WriteLine(a);
                e = e + 1;
            }


        }
        Console.WriteLine("Hay " + e + " primos");
        Console.WriteLine("Los primos suman: " + acu);


    }
}