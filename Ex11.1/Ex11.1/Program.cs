class Program
{
    public static void Main(string[] args)
    {
        int Nombre1, Nombre2, Nombre3, Nombre4, Nombre5;
        Console.WriteLine("Entrer Cinq Nombres");
        Nombre1 = Convert.ToInt32(Console.ReadLine());
        Nombre2 = Convert.ToInt32(Console.ReadLine());
        Nombre3 = Convert.ToInt32(Console.ReadLine());
        Nombre4 = Convert.ToInt32(Console.ReadLine());
        Nombre5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La Somme de C'est Nombre est :" +Somme(Nombre1,Nombre2,Nombre3,Nombre4,Nombre5));
    }
    private static int Somme(int a, int b, int c, int d, int e)
    {
        return a+b+c+d+e;
    }
}
