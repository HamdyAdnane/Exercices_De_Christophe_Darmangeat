using System;
class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        Console.WriteLine("Entrez un nombre entre 1 et 3");
        while (N < 1 || N > 3)
        {
            N=Convert.ToInt32(Console.ReadLine());
            if (N < 1 || N > 3)
            {
                Console.WriteLine("Saisie erronée. Recommencez");
            }
        }
    }
}