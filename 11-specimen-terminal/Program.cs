List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.

    if (command == "QUIT")
    {
        break;
    }
    else if (command == "ADD")
    {
        Console.Write("Add item: ");
        specimens.Add(Console.ReadLine());
    }
    else if (command == "REMOVE")
    {
        Console.Write("Remove item: ");

        specimens.Remove(Console.ReadLine());
    }
        else if (command == "LIST")
    {
        foreach (string specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
    else if (command == "COUNT")
    {
        Console.WriteLine(specimens.Count);
    }
    else
    {
        Console.WriteLine($"Unknown command: {command}");
    }
}
