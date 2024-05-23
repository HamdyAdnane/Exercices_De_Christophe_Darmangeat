using System;

    class Program
    {
        static void Main(string[] args)
        {
        int n;
        Console.WriteLine("Entrez un nombre : ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Ce nombre est négatif");
        }else if (n == 0)
        {
            Console.WriteLine("Ce nombre est nul");
        }
        else
        {
            Console.WriteLine("Ce nombre est positif");
        }
    }
    }

