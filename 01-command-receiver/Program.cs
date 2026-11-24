while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.

    switch (command)
    {
        case "EXIT":
        {
            return;
        }
        case "ay":
        {
            Console.WriteLine("Ayyy");
            break;    
        }
        default:
        {
            Console.WriteLine($"Received: {command}");
            break;
        }
    }
}

Console.WriteLine("Receiver stopped.");
