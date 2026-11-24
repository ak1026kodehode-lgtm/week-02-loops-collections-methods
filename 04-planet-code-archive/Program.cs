string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.

Console.WriteLine($"Elements in planetCodes: {planetCodes.Length}");
Console.WriteLine($"First Element in planetCodes: {planetCodes[0]}");
Console.WriteLine($"Last Element in planetCodes: {planetCodes[4]}");

for (int i = 0; i <= planetCodes.Length - 1; i++)
{
    if (planetCodes == 'KAPPA-9')
    {
        found = true;
    }
}
Console.WriteLine($"Found KAPPA-9: {found}");
