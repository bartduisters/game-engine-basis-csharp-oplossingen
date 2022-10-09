for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"i is momenteel {i}");
}

// Herschrijf bovenstaande code met een while-loop
// Gebruik `j` i.p.v. `i`
int j = 0;
while (j < 3)
{
    Console.WriteLine($"j is momenteel {j}");
    j++;
}

/*
* Wanneer `dotnet run Program.cs` wordt uitgevoerd, moet de volgende output verschijnen:
*/

// i is momenteel 0
// i is momenteel 1
// i is momenteel 2
// j is momenteel 0
// j is momenteel 1
// j is momenteel 2