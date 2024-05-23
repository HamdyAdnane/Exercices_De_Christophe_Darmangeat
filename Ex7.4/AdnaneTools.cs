public static class AdnaneTools
{
    public static int GetPositifInt32(string message=null)
    {
        int result;
        while (true)
        {
            try
            {
                Console.Write(message ?? "Veuillez Saisir un nombre positif : ");
                result = Convert.ToInt32(Console.ReadLine());
                if (result >= 0)
                {
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Veuillez entrer un nombre entier");
            }
        }
        return result;
    }
}