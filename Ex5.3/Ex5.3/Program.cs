using System;
class Program
{
    static void Main(string[] args)
    {
        int N, i;
        Console.WriteLine("Entrez un nombre : ");
        N = Convert.ToInt32(Console.ReadLine());
        i = 0;
        Console.WriteLine("Les 10 nombres suivants sont : ");
        while (i < 10)
        {
            i = i + 1;
            Console.WriteLine(N + i);
        }
    }
}