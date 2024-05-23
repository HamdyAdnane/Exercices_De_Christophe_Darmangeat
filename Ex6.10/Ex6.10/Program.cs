using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb;
        int[] T1;
        int[] T2;
        int[] T3;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        T1 = new int[Nb];
        T2 = new int[Nb];
        T3 = new int[Nb];
        for (int i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T1[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (int i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T2[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (int i = 0; i <= Nb - 1; i++)
        {
            T3[i] = T1[i] + T2[i];
        }
    }
}