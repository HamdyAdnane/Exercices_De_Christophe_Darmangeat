using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, i, temp;
        int[] t;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        t = new int[Nb];
        for (i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            t[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (i = 0; i <= (Nb - 1) / 2; i++)
        {
            temp = t[i];
            t[i] = t[Nb - 1 - i];
            t[Nb - 1 - i] = temp;
        }
    }
}