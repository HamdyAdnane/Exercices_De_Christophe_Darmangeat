class Program
{
    static void Main(string[] args)
    {
        int[,] T = new int[4, 2];
        int k ,m ;
        for (k = 0; k < 4; k++)
        {
            for (m = 0; m < 2; m++)
            {
                T[k, m] = k+m;
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