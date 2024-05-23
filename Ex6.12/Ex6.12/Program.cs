using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb;
        int[] T;
        Console.WriteLine("Entrez le nombre de valeurs : ");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        
        for (int i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° "+ (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Nouveau tableau : ");
        for (int i = 0; i <= Nb - 1; i++)
        {
            T[i] = T[i] + 1;
            Console.WriteLine(T[i]);
        }
    }
}