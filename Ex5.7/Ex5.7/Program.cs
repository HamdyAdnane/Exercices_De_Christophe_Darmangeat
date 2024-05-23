using System;
class Program
{
    static void Main(string[] args)
    {
        int N, F;
        Console.WriteLine("Entrez un nombre : ");
        N = Convert.ToInt32(Console.ReadLine());
        F = 1;
        for (int i = 2; i <= N; i++)
        {
            F = F* i;
        }
        Console.WriteLine("La factorielle est : "+ F);
    }
}