class Program
{
    static void Main(string[] args)
    {
        int A, B, C, Changer;
        Console.WriteLine("Entrez le 1er valeur :");
        A = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez la 2eme valeur :");
        B = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez la 2eme valeur :");
        C = Convert.ToInt16(Console.ReadLine());
        Changer = C;
        C = B;
        B = A;
        A = Changer;
    }
}