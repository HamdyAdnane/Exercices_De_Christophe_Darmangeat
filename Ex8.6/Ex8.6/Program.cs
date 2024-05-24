class Program
{
    static void Main(string[] args)
    {
        int[,] T = new int[12, 8];
        int iMax, jMax;
        iMax = 0;
        jMax = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.WriteLine("Entrer la valeur n°: " + (i+1)+"."+(j+1) );
                T[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // recherche la plus grande valeur
        for (int i=0; i<12; i++)
        {
            for(int j=0; j<8; j++)
            {
                if (T[i,j] > T[iMax,jMax])
                {
                    iMax = i;
                    jMax=j;
                }
            }
        }
        Console.WriteLine("Le plus grand élément est " + T[iMax, jMax]);
        Console.WriteLine("Il se trouve dans la valeur "+ (iMax+1)+"."+ (jMax+1));
    }
}