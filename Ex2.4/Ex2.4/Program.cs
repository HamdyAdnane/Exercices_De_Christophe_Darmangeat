class program
{
    static void Main(string[] args)
    {
        int Prix_Hors_Taxe, Nombre_Articles, Taux_TVA, Prix_Total_TTC;
        Console.WriteLine("Entrez le prix hors taxes :");
        Prix_Hors_Taxe= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrez le nombre d’articles :");
        Nombre_Articles= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrez le taux de TVA :");
        Taux_TVA= Convert.ToInt32(Console.ReadLine());
        Prix_Total_TTC = Nombre_Articles * Prix_Hors_Taxe * (1+ Taux_TVA);
        Console.WriteLine("Le prix toutes taxes est : "+ Prix_Total_TTC);
    }
}