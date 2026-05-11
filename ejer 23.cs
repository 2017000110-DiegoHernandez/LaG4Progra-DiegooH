// ejer 23

internal class Program
{
    private static void Main(string[] args)
    {
        double acu, a, i;
        bool prim;

        acu = 0;

        for (a = 1; a <= 50; a++) 
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
            }
        }

        Console.WriteLine("Los primos suman: " + acu);


    }
}