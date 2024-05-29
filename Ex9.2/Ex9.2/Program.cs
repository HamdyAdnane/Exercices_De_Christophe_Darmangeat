class Program
{
    public static void Main(string[] args)
    {
        string Mot;
        Console.WriteLine("Entrer un mot , Stp!");
        Mot = Console.ReadLine();
        Nombre_Caractere(Mot);
    }
    private static void Nombre_Caractere(string Mot)
    {
        int ic = 0;
        while (ic < Mot.Length)
        {
            if (Mot != null)
            {
                ic++;
            }
        }
        Console.WriteLine("Ce mot compte "+ ic + " lettres");
    }
}

