// Vraag aan de gebruiker wat zijn/haar naam is en sla dit op in een variabele
Console.WriteLine("Wat is je naam?");
string name = Console.ReadLine() ?? string.Empty;

// Vraag aan de gebruiker wat zijn/haar leeftijd is en sla dit op in een variabele
Console.WriteLine("Wat is je leeftijd?");
int age = int.Parse(Console.ReadLine() ?? string.Empty);

// Zorg ervoor dat de gebruiker zijn/haar naam en leeftijd in de console ziet
Console.WriteLine($"Hallo {name}, je bent {age} jaar oud.");

// Zorg ervoor dat de gebruiker zijn/haar leeftijd over 5 jaar in de console ziet
Console.WriteLine($"Over 5 jaar ben je {age + 5} jaar oud.");

// Let op: zorg dat er geen waarschuwingen verschijnen in de console


/*
* Wanneer `dotnet run Program.cs` wordt uitgevoerd, moet de volgende output verschijnen:
*/

// Wat is je naam?
// (voorbeeld input) John Duck
// Wat is je leeftijd?
// (voorbeeld input) 31
// Hallo John Duck, je bent 31 jaar oud.
// Over 5 jaar ben je 36 jaar oud.