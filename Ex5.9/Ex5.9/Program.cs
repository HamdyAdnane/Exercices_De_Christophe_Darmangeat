class Program
{
    static void Main(string[] args)
    {
        int N, i, PG, IPG;
        N = 1;
        PG = 0;
        i = 0;
        while(N != 0)
        {
            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());
            i++;
            if(N == 1 || N > PG)
            {
                PG = N;
                IPG = i;
            }
        }
        Console.WriteLine("Le nombre le plus grand était : " + PG);
        Console.WriteLine("Il a été saisi en position numéro "+ IPG);
    }
}
