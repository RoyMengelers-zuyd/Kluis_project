using System.Drawing;

string welkomstBericht = 
$"""
================================================================
KLUISTOOL - CODE INSTELLEN
================================================================

Beschrijving:   Stel een nieuwe toeganscode in voor de kluis.
Voorwaarde:     Minimaal 4 tekens.

Voer een nieuwe toegangscode in (of 'X' om te annuleren)
""";
Console.WriteLine(welkomstBericht);
string nieuweCode = Console.ReadLine();
if (nieuweCode == "X")
{
    Console.WriteLine("U heeft gekozen om te annuleren.");
}
else
{
    bool codeIsNietOpgeslagen = true;
    while (codeIsNietOpgeslagen)
    {
        Kluis kluis = new Kluis();
        string bericht = kluis.CodeInstellen(nieuweCode);
        if (bericht.Contains("Code opgeslagen"))
        {
            codeIsNietOpgeslagen = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bericht);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(bericht);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voer aub alsnog een nieuwe toegangscode in (of 'X' om te annuleren)");
            nieuweCode = Console.ReadLine();
        }        
    }

}

Console.WriteLine("Druk op Enter om de applicatie te sluiten.");
Console.ReadKey();
