using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, i, Som, Moy, NbSup;
        int[] T;
        Console.WriteLine("Entrez le nombre de notes à saisir : ");
        Nb = Convert.ToInt16(Console.ReadLine());
        T = new int[Nb];
        for (i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            T[i] = Convert.ToInt16(Console.ReadLine());
        }
        Som = 0;
        for (i = 0; i <= Nb - 1; i++)
        {
            Som = Som + T[i];
        }
        Moy = Som / Nb;
        NbSup = 0;
        for (i = 0; i <= Nb - 1; i++)
        {
            if (T[i] > Moy)
            {
                NbSup = NbSup + 1;
            }
        }
        Console.WriteLine(NbSup+ " élèves dépassent la moyenne de la classe");
    }
}