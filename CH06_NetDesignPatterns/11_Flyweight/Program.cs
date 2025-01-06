using System;

public class Program
{
    public static void Main(string[] args)
    {
        GameObject player = new GameObject("Player", "textures/player.png");
        GameObject enemy = new GameObject("Wróg", "textures/enemy.png");
        GameObject tree = new GameObject("Drzewo", "textures/tree.png");
        GameObject rock = new GameObject("Kamień", "textures/tree.png");

        player.Render();
        enemy.Render();
        tree.Render();
        rock.Render();

        Console.WriteLine($"Ilość załadowanych tekstur: {TextureManager.Instance.GetLoadedTexturesCount()}");

        Console.ReadKey();
    }
}