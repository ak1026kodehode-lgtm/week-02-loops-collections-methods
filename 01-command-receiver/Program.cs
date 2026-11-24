while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.

    if (command == "EXIT")
    {
        break;
    }
}

Console.WriteLine("Receiver stopped.");
