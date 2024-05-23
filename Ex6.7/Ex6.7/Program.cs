using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[] Notes = new int[9];
        int S = 0;

        for (int i = 0; i <= 8; i++)
        {
            Console.WriteLine("Entrez la note n° "+ (i + 1));
            Notes[i] = Convert.ToInt16(Console.ReadLine());
            S = S + Notes[i];
        }
        Console.WriteLine("Moyenne :"+ (S / 9));
    }
}