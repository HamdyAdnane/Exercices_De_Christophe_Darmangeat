class Program
{
    static void Main(string[] args)
    {
        int[,] T = new int[4, 2];
        int k, m;
        // Partie de T[k, m] ← 2 * k + [m + 1]
        for (k = 0; k < 4; k++)
        {
            for (m = 0; m < 2; m++)
            {
                T[k, m] = (2 * k) + (m + 1);
            }
        }
        for (k = 0; k < 4; k++)
        {
            for (m = 0; m < 2; m++)
            {
                Console.WriteLine(T[k, m]);
            }
        }
        // Partie de T[k, m] ← [k + 1] + 4 * m
        for (k = 0; k < 4; k++)
        {
            for (m = 0; m < 2; m++)
            {
                T[k, m] = (k + 1) + (4 * m);
            }
        }
        for (k = 0; k < 4; k++)
        {
            for (m = 0; m < 2; m++)
            {
                Console.WriteLine(T[k, m]);
            }
        }
    }
}
