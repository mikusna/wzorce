using System;
using System.Collections.Generic;

public class TextureManager
{
    private static TextureManager _instance;
    private Dictionary<string, Texture> _textures;

    private TextureManager()
    {
        _textures = new Dictionary<string, Texture>();
    }

    public static TextureManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TextureManager();
            }
            return _instance;
        }
    }

    public Texture GetTexture(string filePath)
    {
        if (!_textures.ContainsKey(filePath))
        {
            _textures[filePath] = new Texture(filePath);
        }

        return _textures[filePath];
    }

    public int GetLoadedTexturesCount()
    {
        return _textures.Count;
    }
}
