using System;
class Program
{
    static void Main(string[] args)
    {
        int E, somdue, M, Reste, Nb10E, Nb5E;
        E = 1;
        somdue = 0;
        while (E != 0)
        {
            Console.WriteLine("Entrez le montant : ");
            E = Convert.ToInt32(Console.ReadLine());
            somdue = somdue + E;
        }
        Console.Write("Vous devez :"+ somdue+ " euros ,");
        Console.WriteLine("Montant versé :");
        M = Convert.ToInt32(Console.ReadLine());
        Reste = M - somdue;
        Nb10E = 0;
        while (Reste >= 10)
        {
            Nb10E = Nb10E + 1;
            Reste = Reste - 10;
        }
        Nb5E = 0;
        if (Reste >= 5)
        {
            Nb5E = 1;
            Reste = Reste - 5;
        }
        Console.WriteLine("Rendu de la monnaie :");
        Console.WriteLine("Billets de 10 E : " + Nb10E);
        Console.WriteLine("Billets de  5 E : " + Nb5E);
        Console.WriteLine("Pièces de 1 E : " + Reste);
    }
}