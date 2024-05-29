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
            Console.WriteLine("Entrez l'élement n° " + (i + 1));
            Tableau[i] = Convert.ToInt32(Console.ReadLine());
        }
        bool situation = TableauCroissant(Nombre_elements, Tableau);
        Console.WriteLine("La Croissant De Ces élemnts est "+situation);
    }
    public static bool TableauCroissant(int Taille_Tableau, int[] Tableau)
    {
        int i = 0;
        bool Flag = true;
        while (Flag && i< Taille_Tableau-1)
        {
            Flag = Tableau[i] < Tableau[i+1];
            i++;
        }
        return Flag;
    }
}