using System;

class Program
{
    static int Steps(string inmatning)
    {
        int value = 0;
        bool inmatat = false; // Variabel för att hålla reda på om en korrekt inmatning har gjorts

        do // En do-while loop som fortsätter tills en giltig inmatning görs
        {
            Console.Write(inmatning);
            try
            {
                value = int.Parse(Console.ReadLine()); // Försöker omvandla användarens inmatning till ett heltal
                inmatat = true; // Om inmatningen lyckas sätts inmatat till true och loopen bryts
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Mata in ett heltal! "); // Hanterar om användaren matar in en icke-numerisk text, och visar ett felmeddelande
                inmatat = false; // Loopen fortsätter om inmatningen misslyckas
            }
            catch (Exception ex)
            {
                Console.WriteLine("Försök igen med ett annat nummer" + ex.Message);
                inmatat = false;
            }
        } while (!inmatat); // Fortsätter tills inmatat är true, d.v.s. en korrekt inmatning har gjorts
        return value;
    }

    static void Main() // Huvudmetoden som körs när programmet startas
    {
        try
        {
            int start = Steps("Mata in start: ");  // Använder Steps-metoden för att få användarens input för start, stop och steg
            int stop = Steps("Mata in stop: ");
            int steg = Steps("Mata in steg: ");

            if ((steg == 0) || (start == 0) || (stop == 0)) // Kollar om någon av inmatningarna är 0, vilket är ogiltigt
            {
                Console.WriteLine("! OBS värdet får aldrig vara 0 !");
                return;
            }

            if (start >= stop) // Kollar om startvärdet är större än eller lika med stopvärdet
            {
                Console.WriteLine("! OBS stopvärdet är för lågt !");
                return;
            }

            TotalCount(start, stop, steg);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ett fel uppstod i huvudprogrammet: " + ex.Message);
        }
    }

    static void TotalCount(int start, int stop, int steg) // Metoden TotalCount räknar upp från start till stop med steg
    {
        try
        {
            for (int i = start; i <= stop; i += steg) // En loop som börjar från start och räknar upp till stop, med stegstorleken som tillägg varje gång
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ett fel uppstod under beräkningen: " + ex.Message); // Hanterar eventuella fel under uppräkningen och skriver ut ett felmeddelande
        }
    }
}
