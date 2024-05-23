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

        if ( inf(a,b) && inf(b, c))
        {
            Console.WriteLine("Ces noms sont classés alphabétiquement");
        }
        else
        {
            Console.WriteLine("Ces noms ne sont pas classés");
        }

    }
    private static bool inf(string a, string b)
    {
        int ic = 0;
        while (ic < a.Length && ic < b.Length)
        {
            if (a[ic] < b[ic])
                return true;
            if (a[ic] > b[ic])
                return false;
            ic++;
        }
        bool aPlusPetitQueB = a.Length <= b.Length;
        return aPlusPetitQueB; 
    }
}
