class Program
{
    public static void Main(string[] args)
    {
        string Phrase, Nouvelle_Phrase;
        int Indice_Caractere_Supprimer;
        Console.WriteLine("Entrez une phrase : ");
        Phrase = Console.ReadLine();
        Console.WriteLine("Entrez le rang du caractère à supprimer : ");
        Indice_Caractere_Supprimer = Convert.ToInt32(Console.ReadLine());
        Nouvelle_Phrase = Phrase.Remove((Indice_Caractere_Supprimer-1), 1);
        Console.WriteLine("La nouvelle phrase est :"+ Nouvelle_Phrase);
    }
}