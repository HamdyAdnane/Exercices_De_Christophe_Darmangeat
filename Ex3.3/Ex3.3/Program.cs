using System;
class Program
{
    static void Main(string[] args)
    {
        string a, b, c;
        Console.WriteLine("Entrez successivement trois noms : ");
        a = Console.ReadLine();
        b = Console.ReadLine();
        c = Console.ReadLine();
        for (int i = 0; i < b.Length; i++)
        {
            if ((a[i] <= b[i]) && (b[i] <= c[i]))
            {
                Console.WriteLine("Ces noms sont classés alphabétiquement");
                break;
            }
            else
            {
                Console.WriteLine("Ces noms ne sont pas classés");
                break;
            }
        }
        

    }
}
