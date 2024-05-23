using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Som, Nb;
        int[] T;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        Som = 0;
        for (int i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
            Som = Som + T[i];
        }
        Console.WriteLine("Somme des éléments du tableau : "+ Som);
    }
}