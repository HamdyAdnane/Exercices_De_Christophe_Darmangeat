class Program
{
    public static void Main(string[] args)
    {
        int[] Tableau;
        int Nombre_elements;
        Console.WriteLine("Entrer Le Nombre Des élements Que Tu as Entrée :");
        Nombre_elements = Convert.ToInt32(Console.ReadLine());
        Tableau = new int[Nombre_elements];
        for (int i = 0; i <= Nombre_elements - 1; i++)
        {
            Console.WriteLine("Entrez l'élement n° " +(i + 1));
            Tableau[i] = Convert.ToInt32(Console.ReadLine());
        }
        TriTableau(Tableau, Nombre_elements);

    }
    public static void TriTableau(int[] Tableau, int taille_Tableau)
    {
        int changer, Position_Mini;
        for (int i = 0; i < taille_Tableau-1; i++)
        {
            Position_Mini = i;
            for (int j = i+1; j < taille_Tableau; j++)
            {
                if (Tableau[j] < Tableau[Position_Mini])
                {
                    Position_Mini=j;
                }
            }
            changer = Tableau[Position_Mini];
            Tableau[Position_Mini] = Tableau[i];
            Tableau[i] = changer;
        }
        Console.WriteLine("le tri de tableau est suivante :");
        for (int i = 0;i < taille_Tableau; i++)
        {
            Console.WriteLine(Tableau[i]);
        }
    }
}