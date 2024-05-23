using System;
class Program
{
    static void Main(string[] args)
    {
        int J, M, A;
        bool K1, K2, K3, K4, B;

        Console.WriteLine("Entrez le numéro du jour");
        J = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez le numéro du mois");
        M = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Entrez l'année");
        A = Convert.ToInt16(Console.ReadLine());

        B = (!(A / 100) && A / 4) || A / 400  ;
        K1 = (M == 1 || M == 3 || M == 5 || M == 7 || M == 8 || M == 10 || M == 12) && (J >= 1 && J <= 31);
        K2 = (M == 4 || M == 6 || M == 9 || M == 11) && (J >= 1 && J <= 31);
        K3 = M == 2 && B && J >= 1 && J <= 29;
        K4 = M == 2 && J >= 1 && J <= 28;

        if (K1 || K2 || K3 || K4)
        {
            Console.WriteLine("Date valide");
        }
        else
        {
            Console.WriteLine("Date non valide");
        }
    }
}
