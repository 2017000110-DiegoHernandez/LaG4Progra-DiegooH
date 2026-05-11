//ejer 14

internal class Program
{
    private static void Main(string[] args)
    {
       
        double a, b, c;
        Console.WriteLine("Ingrese un numero base ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un numero tope ");
        b = Convert.ToDouble(Console.ReadLine());

        a = a - 1;

        c = 0;

        if (a < b) 
        {
            do 
            {
                a = a + 1;
                c = c + a;
                Console.WriteLine(a);
            }while(a < b);
            Console.WriteLine(c);
        }


        
    }
}