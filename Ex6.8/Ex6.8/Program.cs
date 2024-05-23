using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, Nbpos, Nbneg;
        int[] T;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        Nbpos = 0;
        Nbneg = 0;
        for (int i = 0; i <= Nb-1; i++)
        {
            Console.WriteLine("Entrez le nombre n° "+ (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
            if (T[i] > 0)
            {
                Nbpos = Nbpos + 1;
            }
            else 
            { 
                Nbneg = Nbneg + 1;
            }
        }
        Console.WriteLine("Nombre de valeurs positives : "+ Nbpos);
        Console.WriteLine("Nombre de valeurs négatives : "+ Nbneg);
    }
}