class Program
{
    public static void Main(string[] args)
    {
        Principale();
    }
    public static bool TousDifferentes(int[] Tableau_vérification)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = i + 1; j < 9; j++)
            {
                if (Tableau_vérification[i] == Tableau_vérification[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static void RemplitGrille(int[,] Tableau_Tous_Cases)
    {
        Random rnd = new Random();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Tableau_Tous_Cases[i, j] = rnd.Next(1, 10);
            }
        }
    }
    public static bool VerifLignes(int[,] Grille)
    {
        int[] Ligne = new int[9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Ligne[j] = Grille[i, j];
            }
            if (!TousDifferentes(Ligne))
            {
                return false;
            }
        }
        return true;
    }
    public static bool VerifColonnes(int[,] Grille)
    {
        int[] Colonne = new int[9];
        for (int j = 0; j < 9; j++)
        {
            for (int i = 0; i < 9; i++)
            {
                Colonne[i] = Grille[i, j];
            }
            if (!TousDifferentes(Colonne))
            {
                return false;
            }
        }
        return true;
    }
    public static bool VerifSousGrilles(int[,] Grille)
    {
        int[] SousGrille = new int[9];
        for (int i = 0; i < 7; i = i + 3)
        {
            for (int j = 0; j < 7; j = j + 3)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    for (int jj = 0; jj < 3; jj++)
                    {
                        SousGrille[ii * 3 + jj] = Grille[i + ii, j + jj];
                    }
                }
                if (!TousDifferentes(SousGrille))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static void Principale()
    {
        int[,] Sudok = new int[9,9];
        RemplitGrille(Sudok);
        while (!VerifLignes(Sudok) || !VerifColonnes(Sudok) || !VerifSousGrilles(Sudok))
        {
            RemplitGrille(Sudok);
        }
    }

}