// ejer 1

internal class Program
{
    private static void Main(string[] args)
    {

        double peso, m;

        m = 0;
        Console.WriteLine("Báscula de manzanas");

        while (m < 1000) 
        {
            Console.WriteLine("Ingrese el peso de su manzana");
            peso = Convert.ToDouble(Console.ReadLine());
            m = m + peso;
            Console.WriteLine("Usted lleva " + m + " gramos");

        }

        Console.WriteLine("Haz alcanzado el kilo de manzana");
       



    }
       

}