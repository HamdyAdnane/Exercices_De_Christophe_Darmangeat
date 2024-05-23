using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, i;
        bool Flag;
        int[] T;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        for (i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
        }
        Flag = true;
        for (i = 1; i <= Nb - 1; i++)
        {
            if (T[i] != T[i - 1] + 1)
            {
                Flag = false;
            }
        }
        if (Flag)
        {
            Console.WriteLine("Les nombres sont consécutifs");
        }
        else
        {
            Console.WriteLine("Les nombres ne sont pas consécutifs");
        }
    }
}