using System;
class Program
{
    static void Main(string[] args)
    {
        int N,Somme;
        Console.WriteLine("Entrez un nombre : ");
        N = Convert.ToInt32(Console.ReadLine());
        Somme = 0;
        for (int i = 1; i <= N; i++)
        {
            Somme=Somme+i;
        }
        Console.WriteLine("La somme est : " + Somme);
    }
}
