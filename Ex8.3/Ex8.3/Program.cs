class Program
{
    static void Main(string[] args)
    {
        int[,] T = new int[2, 3];
        int i, j, Val;
        Val = 1;
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 3; j++)
            {
                T[i, j] = Val;
                Val++;
            }
        }
        for (j = 0; j < 3; j++)
        {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine(T[i, j]);
            }
        }

    }
}
