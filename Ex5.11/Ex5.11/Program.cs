using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int N, P, i, A, B;
        Console.WriteLine("Entrez le nombre de chevaux partants : ");
        N =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrez le nombre de chevaux joués : ");
        P = Convert.ToInt32(Console.ReadLine());
        A = 1;
        B = 1;
        for (i = 1; i <= P; i++)
        {
            A = A * (i + N - P);
            B = B * i;
        }
        Console.WriteLine("Dans l’ordre, une chance sur " + A);
        Console.WriteLine("Dans le désordre, une chance sur "+ A / B);
    }
}