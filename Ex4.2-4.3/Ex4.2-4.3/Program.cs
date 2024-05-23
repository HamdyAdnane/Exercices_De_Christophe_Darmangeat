using System;
class Program
{
    static void Main(string[] args)
    {
        int h,m,s;
        Console.WriteLine("Entrez les heures, puis les minutes, puis les secondes : ");
        h = Convert.ToInt16(Console.ReadLine());
        m = Convert.ToInt16(Console.ReadLine());
        s = Convert.ToInt16(Console.ReadLine());
        s = s + 1;
        if (s == 60)
        {
            s = 0;
            m = m + 1;
        }
        m = m + 1;
        if (m == 60)
        {
            m = 0;
            h = h + 1;
        }
        if (h == 24)
        {
            h = 0;
        }
        Console.WriteLine("Dans une seconde il sera "+ h + "h "+ m + "m et "+ s+ "s");
        
    }
}
