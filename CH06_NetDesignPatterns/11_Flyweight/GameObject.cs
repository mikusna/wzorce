public class GameObject
{
    public string Name { get; }
    private Texture _texture;

    public GameObject(string name, string textureFile)
    {
        Name = name;
        _texture = TextureManager.Instance.GetTexture(textureFile);
    }

    public void Render()
    {
        Console.WriteLine($"Obiekt {Name} jest renderowany.");
        _texture.Apply();
    }
}
