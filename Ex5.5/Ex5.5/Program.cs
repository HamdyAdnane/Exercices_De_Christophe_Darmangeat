using System;
class Program
{
    static void Main(string[] args)
    {
        int N;
        Console.WriteLine("Entrez un nombre : ");
        N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La table de multiplication de ce nombre est : ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(N+ " x "+ i+ " = "+ N * i);
        }
    }
}