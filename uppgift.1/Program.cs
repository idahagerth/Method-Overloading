class Program
{
    static int readInt(string income)
    {
        bool inmatat = false; // Variabel som används för att hålla reda på om en korrekt inmatning har gjorts
        int timlon = 0; // Variabel för att spara den inmatade timlönen

        while (!inmatat) // En loop som körs tills användaren matar in ett giltigt heltal
        {
            Console.Write(income);
            inmatat = int.TryParse(Console.ReadLine(), out timlon); // Om inmatningen inte är ett giltigt heltal, skriv ut ett felmeddelande
            if (!inmatat)
                Console.WriteLine("mata gärna in ett heltal tack!");
        }
        return timlon; // Returnerar det inmatade talet när en korrekt inmatning har gjorts
    }
    static void Main(string[] args) // Huvudmetoden som körs när programmet startas
    {
        int inkomst = readInt("Ange din inkomst: "); // Använder readInt-metoden för att få användarens inkomst och sparar den i variabeln 'inkomst'
        int timmar = readInt("Ange antal timmar: ");

        Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");  // Beräknar timlönen genom att dela inkomst med timmar och skriver ut resultatet
        Console.ReadKey();
    }
}
