namespace Pizzakalkylator;

class Program
{
    static void Main(string[] args)
    {
        // Uppgift 3 – Pizzakalkylatorn
        // Du ska räkna ut priset på pizzor med moms.
        // Instruktioner:
        // Skapa en const som heter MOMS och sätt den till 0.12 (12%).
        const double Moms = 0.12;
        // Be användaren skriva in antal pizzor.
        Console.WriteLine("Hur många pizzor köpte ni?");
        string input1 = Console.ReadLine()!;
        int Pizza = Convert.ToInt32(input1);
        // Be användaren skriva in pris per pizza.
        Console.WriteLine("Vad var priset per pizza?");
        string input2 = Console.ReadLine()!;
        int Pris = Convert.ToInt32(input2);
        // Räkna ut:
        // Totalsumma utan moms
        int Totalsumma = Pizza * Pris;
        Console.WriteLine($"Totalt utan moms: {Totalsumma}");
        // Momsbelopp
        double MomsBelopp = Totalsumma * Moms;
        Console.WriteLine($"Moms: {MomsBelopp}");
        // Totalsumma med moms
        double TotaltMedMoms = Totalsumma + MomsBelopp;
        Console.WriteLine($"Totalt med moms: {TotaltMedMoms}");
        // Skriv ut alla tre resultaten på skärmen.
        // Tips:
        // Använd Convert.ToInt32() eller Convert.ToDouble() för att konvertera input
    }
}
