using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[] Suite = new int[8];
        Suite[0] = 1;
        Suite[1] = 1;
        for (int i = 2; i <= 7; i++)
        {
            Suite[i] = Suite[i - 1] + Suite[i - 2];
        }
        for (int i = 0; i <= 7; i++)
        {
            Console.WriteLine(Suite[i]);
        }
    }
}