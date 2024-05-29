class Program
{
    public static void Main(string[] args)
    {
        int nombre;
        Console.WriteLine("Entrez votre nombre : ");
        nombre = Convert.ToInt32(Console.ReadLine());
        Pair(nombre);
    }
    private static void Pair(int Nb)
    {
        if (Nb % 2 == 0)
        {
            Console.WriteLine("Le Nombre est pair");
        }
        else
        {
            Console.WriteLine("Le Nombre est impair");
        }
    }
}