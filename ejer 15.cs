// ejer 15

internal class Program
{
    private static void Main(string[] args)
    {
       
        double a, b, c;

        b = 0;

        do 
        {
            Console.WriteLine("Ingrese un numero");
            a = Convert.ToDouble(Console.ReadLine());

            b = b + a;
        }while (a != 9);

        c = b - 9;

        Console.WriteLine("La suma total es de " + c);

        
    }
}