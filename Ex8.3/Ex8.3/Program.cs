using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] X = new int[1, 2];
        int i, j, Val;
        Val = 1;
        for (i = 0; i <= 1; i++)
        {
            for (j = 0; i <= 2; j++)
            {
                X[i, j] = Val;
                Val++;
            }
        }
        for (j = 0; i <= 2; j++)
        {
            for (i = 0; i <= 1; i++)
            {
                Console.WriteLine(X[i, j]);
            }
        }

    }
}