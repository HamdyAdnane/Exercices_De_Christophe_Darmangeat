class Program
{
    public static void Main(string [] args)
    {
        string Phrase;
        int Nombres_Mots;
        Console.WriteLine("Entrez une phrase : ");
        Phrase = Console.ReadLine();
        Nombres_Mots = 0;
        for(int i = 0; i< Phrase.Length; i++)
        {
            if(Phrase.Substring(i,1) == " ")
            {
                Nombres_Mots++;
            }
        }
        Console.Write("Cette phrase compte " +(Nombres_Mots + 1) + " mots");
    }
}