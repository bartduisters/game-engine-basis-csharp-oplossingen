string input;
do
{
    Console.WriteLine("Blad, steen of schaar?");
    input = Console.ReadLine() ?? string.Empty;
    input = input.ToLower();
} while (input != "blad" && input != "steen" && input != "schaar");

string computerInput = new[] { "blad", "steen", "schaar" }[new Random().Next(0, 3)];

Console.WriteLine($"Je hebt {input} gekozen, de computer heeft {computerInput} gekozen.");

// Er is code om te zorgen dat de gebruiker een geldige input geeft (blad, steen of schaar)
// Er is code om te zorgen dat de computer een willekeurige keuze maakt (blad, steen of schaar)
// Schrijf code om te bepalen wie er gewonnen heeft
// Gebruik de volgende regels om te bepalen wie er gewonnen heeft:
// - Blad wint van steen
// - Steen wint van schaar
// - Schaar wint van blad
// - Als beide dezelfde keuze hebben gemaakt, is het gelijkspel

// Als de gebruiker gewonnen heeft, print "Jij wint!"
// Als de computer gewonnen heeft, print "De computer wint!"
// Als het gelijkspel is, print "Gelijkspel!"

if (input == computerInput)
{
    Console.WriteLine("Gelijkspel!");
}
else if (input == "blad" && computerInput == "steen")
{
    Console.WriteLine("Jij wint!");
}
else if (input == "steen" && computerInput == "schaar")
{
    Console.WriteLine("Jij wint!");
}
else if (input == "schaar" && computerInput == "blad")
{
    Console.WriteLine("Jij wint!");
}
else
{
    Console.WriteLine("De computer wint!");
}

