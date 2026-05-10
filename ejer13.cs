internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Ingrese un número base");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese un número tope");
        b = Convert.ToDouble(Console.ReadLine());

        if (a < b) 
        {
            do
            {
                a = a + 4;
                Console.WriteLine(a);
            }while (b >= a);

           
        }
    }
}