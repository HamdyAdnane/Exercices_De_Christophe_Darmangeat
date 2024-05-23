using System;
class Program
{
    static void Main(string[] args)
    {
        string sex;
        int age;
        bool C1, C2;
        Console.WriteLine("Entrez le sexe (M/F) : ");
        sex = Console.ReadLine();
        Console.WriteLine("Entrez l’âge: ");
        age = Convert.ToInt16(Console.ReadLine());

        C1 = sex == "M" && age > 20;
        C2 = sex == "F" && (age > 18 && age < 35);
        if (C1 || C2)
        {
            Console.WriteLine("Imposable");
        }
        else
        {
            Console.WriteLine("Non Imposable");
        }
    }
}

