using System;
class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Entrez l’âge de l’enfant : ");
        age = Convert.ToInt32(Console.ReadLine());
        if (age >= 12)
        {
            Console.WriteLine("Catégorie Cadet");
        }
        else if (age >= 10)
        {
            Console.WriteLine("Catégorie Minime");
        }
        else if (age >= 8)
        {
            Console.WriteLine("Catégorie Pupille");
        }
        else if(age >= 6)
        {
            Console.WriteLine("Catégorie Poussin");
        }
    }
}
