using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int N1, N2, S;
        int[] T1;
        int[] T2;
        Console.WriteLine("Entrez le nombre de valeurs de tableau 1 :");
        N1 = Convert.ToInt16(Console.ReadLine());
        T1 = new int[N1];
        Console.WriteLine("Entrez le nombre de valeurs de tableau 2 :");
        N2 = Convert.ToInt16(Console.ReadLine());
        T2 = new int[N2];
        for (int i = 0; i <= N1 - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T1[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (int i = 0; i <= N2 - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T2[i] = Convert.ToInt16(Console.ReadLine());
        }
        S = 0;
        for (int i = 0; i <= N1 - 1; i++)
        {
            for (int j = 0; j <= N2 - 1; j++)
            {
                S = S + T1[i] * T2[j];
            }
        }
        Console.WriteLine("Le schtroumpf est : " + S);
    }
}