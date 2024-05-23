using System;
using System.Net;
using System.Text;
using System.Threading.Channels;
using static AdnaneTools;
class Program
{
    static void Main(string[] args)
    {
        int totalValeurs, indexASupprimer;
        int[] tableauInitial;
        
        totalValeurs = GetPositifInt32("Entrez le nombre de valeurs :");
        tableauInitial = new int[totalValeurs];
        for (int i = 0; i <= totalValeurs - 1; i++)
        {
            tableauInitial[i] = GetPositifInt32("Entrez le nombre n° " + (i + 1));
        }
        
        indexASupprimer = GetPositifInt32("Rang de la valeur à supprimer ?");
        if(indexASupprimer > totalValeurs-1)
        {
            Console.WriteLine("Rang invalide. L'application va se terminer.");
            return;
        }

        int[] tableauRedimentionne = new int[totalValeurs - 1];

        int ic = 0;
        for (int i = 0; i <= totalValeurs - 1; i++)
        {
            if (i != indexASupprimer)
                tableauRedimentionne[ic++] = tableauInitial[i];
        }
        
        
        for (int i = 0; i <= tableauRedimentionne.Length; i++)
        {
            Console.WriteLine(tableauRedimentionne[i]);
        }
        
    }


}

/*
     for (int i = indexASupprimer; i <= totalValeurs - 2; i++)
            tableauInitial[i] = tableauInitial[i+1];

        for (int i = 0; i < totalValeurs-2; i++)
        {
            tableauRedimentionne[i] = tableauInitial[i];
        }
        */