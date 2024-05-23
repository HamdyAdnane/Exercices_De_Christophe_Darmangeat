using System;
class Program
{
    static void Main(string[] args)
    {
        int N, PG,IPG;
        PG = 0;
        IPG = 0;
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());
            if (i == 1 || N > PG)
            {
                PG = N;
                IPG = i;
            }
        }
        Console.WriteLine("Le nombre le plus grand était : "+ PG);
        Console.WriteLine("Il a été saisi en position numéro "+ IPG);
    }
}