class Program
{
    public static void Main(String[] args)
    {
        string Phrase;
        int Nombres_Voyelles;
        Console.WriteLine("Entrez une phrase : ");
        Phrase = Console.ReadLine();
        Nombres_Voyelles = 0;
        // Premier Methode : La première déploie une condition composée bien fastidieuse.
        for (int i = 0; i < Phrase.Length; i++)
        {
            if ((Phrase.Substring(i, 1) == "a") || (Phrase.Substring(i, 1) == "e") || (Phrase.Substring(i, 1) == "i")
             || (Phrase.Substring(i, 1) == "o") || (Phrase.Substring(i, 1) == "u") || (Phrase.Substring(i, 1) == "y"))
            {
                Nombres_Voyelles++;
            }
        }
        Console.WriteLine("Cette phrase compte " +Nombres_Voyelles+ " voyelles");
        // Deuxieme Methode : La deuxième, en utilisant la fonction Trouve, allège considérablement l'algorithme.
    }
}