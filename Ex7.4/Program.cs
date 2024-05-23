using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int Nb, i, S;
        int[] t;
        Console.WriteLine("Entrez le nombre de valeurs :");
        Nb = Convert.ToInt16(Console.ReadLine());
        t = new int[Nb];
        for (i = 0; i <= Nb - 1; i++)
        {
            Console.WriteLine("Entrez le nombre n° " + (i + 1));
            t[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Rang de la valeur à supprimer ?");
        S = Convert.ToInt16(Console.ReadLine());
        for (i = S; i <= Nb - 2; i++)
        {
            t[i] = t[i+1];
        }
        for (i = 0; i <= Nb - 2; i++)
        {
            Console.WriteLine(t[i]);
        }
        
    }   
}