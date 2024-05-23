using System;
class Program
{
    static void Main(string[] args)
    {
        int A ,B ,C ,D;
        bool C1, C2, C3, C4;
        Console.WriteLine("Entrez les scores des quatre prétendants :");
        A = Convert.ToInt16(Console.ReadLine());
        B = Convert.ToInt16(Console.ReadLine());
        C = Convert.ToInt16(Console.ReadLine());
        D = Convert.ToInt16(Console.ReadLine());

        C1 = A > 50;
        C2 = B > 50 || C > 50 || D > 50;
        C3 = A >= B && A >= C && A >= D;
        C4 = A >= 12.5;
        if (C1)
        {
            Console.WriteLine("Elu au premier tour");
        }
        else if (C2 || !C4)
        {
            Console.WriteLine("Battu, éliminé, sorti !!!");
        }
        else if (C3)
        {
            Console.WriteLine("Ballotage favorable");
        }
        else
        {
            Console.WriteLine("Ballotage défavorable");
        }
    }
}
