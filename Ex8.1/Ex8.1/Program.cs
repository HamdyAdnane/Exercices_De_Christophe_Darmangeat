class Program
{
    static void Main(string[] args)
    {
        int[,] T = new int[6, 13];
        int i, j, Val;
        Val = 1;
        for (i = 0; i <= 5; i++)
        {
            for (j = 0; j <= 12; j++)
            {
                T[i, j] = Val;
                Val++;
                Console.WriteLine(T[i, j]);
            }
        }
    }
}
