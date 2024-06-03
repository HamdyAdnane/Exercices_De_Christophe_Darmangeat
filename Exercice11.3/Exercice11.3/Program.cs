class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Trouve("je m'appel adnane hamdy", "y"));
    }
    public static int Trouve(string Phrase, string Caractere2)
    {
        int i = 1;
        while (i < Phrase.Length - Caractere2.Length && Caractere2 != Phrase.Substring(i, Caractere2.Length) )
        {
            i++;
        }
        if (Caractere2 != Phrase.Substring(i, Caractere2.Length))
        {
            return 0;
        }
        return i;
    }
}