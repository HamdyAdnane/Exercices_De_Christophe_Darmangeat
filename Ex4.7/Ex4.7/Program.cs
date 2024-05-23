using System;
class Program
{
    static void Main(string[] args)
    {
        int age, perm, acc, assur;
        bool C1, C2, C3;
        string situ;
        Console.WriteLine("Entrez l’âge: ");
        age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez le nombre d'années de permis: ");
        perm = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez le nombre d'accidents: ");
        acc = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez le nombre d'années d'assurance: ");
        assur = Convert.ToInt16(Console.ReadLine());
        C1 = age >= 25;
        C2 = perm >= 2;
        C3 = assur > 5;
        if (!C1 && !C2)
        {
            if (acc == 0)
            {
                situ = "Rouge";
            }
            else
            {
                situ = "Refusé";
            }
        }
        else if ((!C1 && C2) || (C1 && !C2))
        {
            if (acc == 0)
            {
                situ = "Orange";
            }
            else if (acc == 1)
            {
                situ = "Rouge";
            }
            else
            {
                situ = "Refusé";
            }
        }
        else
        {
            if (acc == 0)
            {
                situ = "Vert";
            }
            else if (acc == 1)
            {
                situ = "Orange";
            }
            else if ( acc == 2)
            {
                situ = "Rouge";
            }
            else
            {
                situ = "Refusé";
            }
        }
        if (C3)
        {
            if (situ == "Rouge")
            {
                situ = "Orange";
            }
            else if (situ == "Orange")
            {
                situ = "Vert";
            }
            else if (situ == "Vert")
            {
                situ = "Bleu";
            }
        }
        Console.WriteLine("Votre situation :" +situ);
    }
}
