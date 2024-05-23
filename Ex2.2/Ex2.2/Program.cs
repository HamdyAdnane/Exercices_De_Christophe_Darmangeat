class Program
{
    static void Main(string[] args)
    {
        int Nombre, Carré;
        Console.WriteLine("Entrez un nombre :");
        Nombre = Convert.ToInt16(Console.ReadLine());
        Carré = Nombre * Nombre;
        Console.WriteLine("Son carré est : "+ Carré);
    }
}