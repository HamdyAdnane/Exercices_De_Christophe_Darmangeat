using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, Posmaxi;
        int[] T;
        Console.WriteLine("Entrez le nombre de valeurs : ");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        for (int i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
        }
        Posmaxi = 0;
        for (int i = 0; i <= Nb - 1; i++)
        {
            if (T[i] > T[Posmaxi])
            {
                Posmaxi = i;
            }
        }
        Console.WriteLine("Element le plus grand : "+ T[Posmaxi]);
        Console.WriteLine("Position de cet élément : "+ (Posmaxi+1));
    }
}