using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.Models;
using Vildmark.Graphics.Rendering;
using Vildmark.Graphics.Shapes;

namespace GGJ2021
{
    public class MapTileType
    {
        public static MapTileType Grass { get; private set; }

        public string Name { get; }

        public Material Material { get; }

        protected MapTileType(string name, Material material)
        {
            Name = name;
            Material = material;
        }

        public static void Initialize()
        {
            Grass = new MapTileType("Grass", Textures.Terrain[6, 3]);
        }
    }
}
