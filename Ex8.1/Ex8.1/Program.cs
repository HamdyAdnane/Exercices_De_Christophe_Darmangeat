using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        int[,] Truc = new int[5,12];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; i < 12; j++)
            {
                Truc[i, j] = 0;
            }
        }
    }
}