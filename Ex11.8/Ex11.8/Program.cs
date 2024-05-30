class Program
{
    public static void Main(string[] args)
    {
        int Nombre1, Nombre2;
        Console.WriteLine("Entrer Deux Nombres Stp!");
        Nombre1 = Convert.ToInt32(Console.ReadLine());
        Nombre2 = Convert.ToInt32(Console.ReadLine());
        Inversion(Nombre1, Nombre2);
    }
    public static void Inversion(int Valeur1, int Valeur2)
    {
        int Changer;
        Changer = Valeur1;
        Valeur1 = Valeur2;
        Valeur2 = Changer;
    }
}