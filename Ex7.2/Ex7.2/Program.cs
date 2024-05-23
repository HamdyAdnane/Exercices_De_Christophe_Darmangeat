using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, i, j, posmaxi, temp;
        int[] t;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        t = new int[Nb];
        for (i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            t[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (i = 0; i <= Nb - 2; i++)
        {
            posmaxi = i;
            for (j = i+1; j <= Nb - 1;)
            {
                if (t[j] > t[posmaxi])
                {
                    posmaxi = j;
                }
            }
            temp = t[posmaxi];
            t[posmaxi] = t[i];
            t[i] = temp;
        }
    }
}