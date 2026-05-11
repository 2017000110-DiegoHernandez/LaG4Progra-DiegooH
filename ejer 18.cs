//ejer 18

internal class Program
{
    private static void Main(string[] args)
    {
       
        double a, b, c;

        b = 0;
        c = 0;

        do 
        {
            Console.WriteLine("Ingrese la denominacion del billete");
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 100)
            {
                b = b + 1;
                c = c + 1;
                Console.WriteLine("Billetes contados " + b);
                Console.WriteLine("Total acumulado " + (b * 100));
            }
            

        } while (c != 1000);
        
    }
}