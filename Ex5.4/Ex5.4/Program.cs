using System;
class Program
{
    static void Main(string[] args)
    {
        int N;
        Console.WriteLine("Entrez un nombre : ");
        N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Les 10 nombres suivants sont : ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(N + i);
        }
    }
}