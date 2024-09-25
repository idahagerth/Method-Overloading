
using System;

class ThrowDice
{
    static Random dice = new Random(); // Skapar ett globalt Random-objekt för att simulera tärningskast

    static int HelTal(string inmatning)
    {
        int value = 0;
        bool inmatat = false;

        do
        {
            Console.Write(inmatning);
            try
            {
                value = int.Parse(Console.ReadLine());
                inmatat = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Du kan bara skriva in heltal! ");
                inmatat = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("!Error! " + ex.Message);
                inmatat = false;
            }
        } while (!inmatat);
        return value;
    }
    static int KastaTärning()
    {
        return dice.Next(1, 7);
    }
    static int KastaTärning(int TärningsSidor)
    {
        return dice.Next(1, TärningsSidor + 1);
    }
    static string KastaTärning(string AntalKastSidor) // Överlagrad metod för att kasta en tärning med ett specifikt antal sidor
    {
        int AntalSidor = 0;
        int AntalKast = 0;
        int summan = 0;

        string[] Delar = AntalKastSidor.Split("T"); // Delar upp på "T", så att Delar[0] är antal kast och Delar[1] är antal sidor
       // Omvandlar delarna till heltal
        AntalKast = int.Parse(Delar[0]);
        AntalSidor = int.Parse(Delar[1]);

        for (int i = 1; i <= AntalKast; i++)
        {
            int resultat = KastaTärning(AntalSidor);
            Console.WriteLine("Kast " + i + ": " + resultat);
            summan += resultat;
        }
        return "Summan blir: Resultat " + summan;
    }
    static void Main()
    {
        Console.Write("Ange tärningskast: ");

        string Finishline = Console.ReadLine(); // Läser in användarens input som en sträng
        string TotalSum = KastaTärning(Finishline); // Kallar KastaTärning-metoden och får resultatet som en sträng

        Console.WriteLine(TotalSum);
    }

}