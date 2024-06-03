class Program
{
    public static void Main(string[] args)
    {
        Random Nombre = new Random();
        int Glup1 = Nombre.Next(2);
        Console.WriteLine(Glup1);
        int Glup2 = Nombre.Next(-1,1);
        Console.WriteLine(Glup2);
        double Glup3 = Nombre.Next(135,165) * 0.01 ;
        Console.WriteLine(Glup3);
        int Glup4 = Nombre.Next(1,7);
        Console.WriteLine(Glup4);
        double Glup5 = Nombre.Next(-105, 65) * 0.1;
        Console.WriteLine(Glup5);
        int Glup6 = Nombre.Next(1, 7) + Nombre.Next(1, 7);
        Console.WriteLine(Glup6);
    }
}