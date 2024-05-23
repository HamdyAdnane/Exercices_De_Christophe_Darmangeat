using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[] Notes = new int[8];
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Entrez la note numéro "+ (i + 1));
            Notes[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
}   