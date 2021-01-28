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
        public static Texture2D Chars { get; private set; }
        public static Texture2D Items { get; private set; }
        public static Texture2D Objects { get; private set; }
        public static Texture2D Terrain { get; private set; }

        public static TextureAtlas CharsAtlas { get; private set; }
        public static TextureAtlas ItemsAtlas { get; private set; }
        public static TextureAtlas ObjectsAtlas { get; private set; }
        public static TextureAtlas TerrainAtlas { get; private set; }

        public static void Initialize()
        {
            Chars = ResourceLoader.LoadEmbedded<Texture2D>("chars.png");
            Items = ResourceLoader.LoadEmbedded<Texture2D>("items.png");
            Objects = ResourceLoader.LoadEmbedded<Texture2D>("objects.png");
            Terrain = ResourceLoader.LoadEmbedded<Texture2D>("terrain.png");

            CharsAtlas = new TextureAtlas(Chars, 8, 8);
            ItemsAtlas = new TextureAtlas(Items, 8, 8);
            ObjectsAtlas = new TextureAtlas(Objects, 8, 8);
            TerrainAtlas = new TextureAtlas(Terrain, 8, 8);
        }
    }
}
