using System;

public class Texture
{
    public string FilePath { get; }

    public Texture(string filePath)
    {
        FilePath = filePath;
        Console.WriteLine($"Ładowanie tekstury ze ścieżki: {filePath}");
    }

    public void Apply()
    {
        Console.WriteLine($"Nakładanie tekstury ze ścieżki: {FilePath}");
    }
}
