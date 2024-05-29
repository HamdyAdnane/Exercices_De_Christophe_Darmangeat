class Program
{
    public static void Main(string[] args)
    {
        int[] Tableau;
        int Nombre_elements;
        bool Choix;
        Console.WriteLine("Entrer Le Nombre Des élements Que Tu as Entrée :");
        Nombre_elements = Convert.ToInt32(Console.ReadLine());
        Tableau = new int[Nombre_elements];
        for (int i = 0; i <= Nombre_elements - 1; i++)
        {
            Console.WriteLine("Entrez l'élement n° " + (i + 1));
            Tableau[i] = Convert.ToInt32(Console.ReadLine());
        }
        Choix = true;
        Console.WriteLine("Le tri est effectué automatiquement Croissante si vous souhaitez modifier de tri en Decroissante Entrée zero '0', Sinon Entrée un '1'.");
        int Number_Choix = Convert.ToInt32(Console.ReadLine());
        if (Number_Choix == 0)
            Choix = false;
        TriTableau(Tableau, Nombre_elements, Choix);
    }
    public static void TriTableau(int[] Tableau, int taille_Tableau, bool Choix)
    {
        int changer, Position;
        for (int i = 0; i < taille_Tableau - 1; i++)
        {
            Position = i;
            for (int j = i + 1; j < taille_Tableau; j++)
            {
                if (Choix)
                {
                    if (Tableau[j] < Tableau[Position])
                    {
                        Position = j;
                    }
                }
                else
                {
                    if (Tableau[j] > Tableau[Position])
                    {
                        Position = j;
                    }
                }
            }
            changer = Tableau[Position];
            Tableau[Position] = Tableau[i];
            Tableau[i] = changer;
        }
        Console.WriteLine("le tri de tableau est suivante :");
        for (int i = 0; i < taille_Tableau; i++)
        {
            Console.WriteLine(Tableau[i]);
        }
    }
}