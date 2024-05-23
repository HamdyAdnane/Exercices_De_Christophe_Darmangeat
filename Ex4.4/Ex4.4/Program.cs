using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        double p;
        Console.WriteLine("Nombre de photocopies : ");
        n = Convert.ToInt16(Console.ReadLine());
        if (n <= 10)
        {
            p = n * 0.1;
        }
        else if (n <= 30)
        {
            p = 10 * 0.1 + (n – 10) * 0.09 ;
        }
        else
        {
            p = (10 * 0.1) + (20 * 0.09) + ((n – 30) * 0.08) ;
        }
        Console.WriteLine("Le prix total est: "+ p);

    }
}
