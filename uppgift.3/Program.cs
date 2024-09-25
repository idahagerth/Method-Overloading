using System;

class ThrowDice
{
    static Random dice = new Random(); // Skapar ett globalt Random-objekt för att simulera tärningskast

    static int HelTal(string inmatning) // Metod för att läsa in ett heltal från användaren
    {
        int value = 0; // Variabel som lagrar det inmatade värdet
        bool inmatat = false; // Variabel för att hålla reda på om inmatningen är korrekt

        do  // En do-while loop som fortsätter tills en korrekt inmatning har gjorts
        {
            Console.Write(inmatning);
            try
            {
                value = int.Parse(Console.ReadLine()); // Försöker omvandla användarens inmatning till ett heltal
                inmatat = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Du kan bara skriva in heltal! ");
                inmatat = false; // Loopen fortsätter om inmatningen är ogiltig
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
        return dice.Next(1, 7); // Genererar ett slumptal mellan 1 och 6 (inklusive)
    }
    static void Main()  // Huvudmetoden som körs när programmet startar
    {
        int AntalKast = HelTal("Ange Tärningskast: ");
        int summan = 0;

        for (int i = 1; i <= AntalKast; i++)  // En for-loop som körs så många gånger som användaren vill kasta tärningen
        {
            int resultat = KastaTärning();
            Console.WriteLine("Kast " + i + ": " + resultat);
            summan += resultat;
        }
        Console.WriteLine("Summan blir: Resultat " + summan); // När alla kast är gjorda, skriver ut den totala summan av alla kast
    }
}