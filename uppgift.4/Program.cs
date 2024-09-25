
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
    static int KastaTärning() // Metod för att simulera ett tärningskast med 6 sidor (standardtärning)
    {
        return dice.Next(1, 7);
    }
    static int KastaTärning(int TärningsSidor) // Överlagrad metod för att simulera ett tärningskast med ett specifikt antal sidor
    {
        return dice.Next(1, TärningsSidor + 1); // Genererar ett slumptal mellan 1 och det antal sidor som tärningen har
    }
    static void Main() // Huvudmetoden som körs när programmet startas
    {
        int AntalSidor = HelTal("Ange Tärningens antal sidor: ");
        int AntalKast = HelTal("Ange Tärningskast: ");
        int summan = 0;


        for (int i = 1; i <= AntalKast; i++) // En for-loop som körs lika många gånger som användaren vill kasta tärningen
        {
            int resultat = KastaTärning(AntalSidor);
            Console.WriteLine("Kast " + i + ": " + resultat); // Lägger till resultatet av kastet till summan
            summan += resultat;
        }
        Console.WriteLine("Summan blir: Resultat " + summan); // När alla kast är gjorda, skriv ut den totala summan av alla kast
    }
}