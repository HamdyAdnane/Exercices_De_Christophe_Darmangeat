using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[] N = new int[7];
        N[0] = 1;
        Console.WriteLine(N[0]);
        for (int k = 1; k <= 7; k++)
        {
            N[k] = N[k - 1] + 2;
            Console.WriteLine(N[k]);
        }
    }
}