//ejer 2

internal class Program
{
    private static void Main(string[] args)
    {

        double total, m;

        total = 0;

        while (total < 350) 
        {
            Console.WriteLine("Tienes "+ total + " monedas");
            Console.WriteLine("Nivel 5 bloqueado");
            Console.WriteLine("Ingrese sus monedas adicionales");
            m = Convert.ToDouble(Console.ReadLine());
            total = total + m;
            

        }
        Console.WriteLine("Nivel 5 desbloqueado");


    }
       

}