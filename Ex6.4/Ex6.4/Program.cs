using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[] Nb = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Nb[i] = i * i;
            Console.WriteLine(Nb[i]);
        }
    }
}