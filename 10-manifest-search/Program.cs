List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));
Console.WriteLine(ContainsItem(manifest, "BIONICLE"));
Console.WriteLine(ContainsItem(manifest, "LENS"));

static bool ContainsItem(List<string> items, string search)
{
    foreach (string item in items)
    {
        if (item == search)
        {
            return true;
        }
    }

    return false;
}
