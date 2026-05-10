internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Parqueo con 200 cupos");
        a = 0;

        do
        {
            a = a + 20;
            Console.WriteLine("Cupos ocupados " + a);
            Console.WriteLine("Espacio disponible");
            Console.ReadKey();

        } while (a != 180);

        Console.WriteLine("Cupos ocupados 200");
        Console.WriteLine("Espacio no disponible");

    }
}