//ejer 25

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;

        b = 0;
        c = 0;

        do 
        {
            Console.WriteLine("Ingrese 1 si es niño o 2 si es adulto");
            a = Convert.ToDouble(Console.ReadLine());
            b = b + 1;

            switch (a) 
            {
                case 1: c = c + 10; break;
                case 2: c = c + 15; break;
                    default : Console.WriteLine("Ingrese un numero valido"); break;
            }
            Console.WriteLine("Boletos vendidos "+b);
            Console.WriteLine("Dinero juntado "+c);
        } while (b!= 15);

        
    }
}