using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Entrer un nombre: ");
        n = Convert.ToInt16(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("Ce Nombre est positif");
        }
        else
        {
            Console.WriteLine("Ce Nombre est Negatif");
        }
    }
}
