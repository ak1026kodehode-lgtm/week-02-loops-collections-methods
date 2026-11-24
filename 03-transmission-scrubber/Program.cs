string transmission = "AX?19??Q";
int markerCount = 0;

// TODO: Bruk for og transmission[i].

for (int i = 0; i <= transmission.Length - 1; i++)
{
    Console.WriteLine($"Mark: {transmission[i]} at index {i}");

    markerCount++;
}

Console.WriteLine($"Marker count: {markerCount}");
