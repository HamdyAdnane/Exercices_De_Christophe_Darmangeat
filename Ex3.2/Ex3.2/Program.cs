using System;
class Program
{
    static void Main(string[] args)
    {
        int m, n;
        Console.WriteLine("Entrez deux nombres : ");
        n = Convert.ToInt16(Console.ReadLine());
        m = Convert.ToInt16(Console.ReadLine());

        if ((m > 0 && n > 0) || (m < 0 && n < 0))
        {
            Console.WriteLine("Leur produit est positif");
        }
        else
        {
            Console.WriteLine("Leur produit est négatif");
        }
    }
}