using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int A, B, Changer;
        Console.WriteLine("Entrez le 1er valeur :");
        A = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez la 2eme valeur :");
        B = Convert.ToInt16(Console.ReadLine());
        Changer = A;
        A = B;
        B = Changer;
    }
}