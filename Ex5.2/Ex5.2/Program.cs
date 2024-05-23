using System;
class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        Console.WriteLine("Entrez un nombre entre 10 et 20");
        while (N < 10 || N > 20)
        {
            N = Convert.ToInt32(Console.ReadLine());
            if (N < 10)
            {
                Console.WriteLine("Plus grand !");
            }
            else if (N > 20)
            {
                Console.WriteLine("Plus petit !");
            }
        }
    }
}