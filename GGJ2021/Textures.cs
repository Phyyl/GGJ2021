using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.GLObjects;
using Vildmark.Graphics.Rendering;
using Vildmark.Resources;

namespace GGJ2021
{
    public static class Textures
    {
        public static TextureAtlas Chars { get; private set; }
        public static TextureAtlas Items { get; private set; }
        public static TextureAtlas Objects { get; private set; }
        public static TextureAtlas Terrain { get; private set; }

        public static void Initialize()
        {
            Chars = new TextureAtlas(ResourceLoader.LoadEmbedded<Texture2D>("chars.png"), 16, 16);
            Items = new TextureAtlas(ResourceLoader.LoadEmbedded<Texture2D>("items.png"), 8, 8);
            Objects = new TextureAtlas(ResourceLoader.LoadEmbedded<Texture2D>("objects.png"), 16, 16);
            Terrain = new TextureAtlas(ResourceLoader.LoadEmbedded<Texture2D>("terrain.png"), 16, 16);
        }
    }
}
