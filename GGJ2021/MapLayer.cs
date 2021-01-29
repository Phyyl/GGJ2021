using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark;
using Vildmark.Graphics;
using Vildmark.Graphics.Models;
using Vildmark.Graphics.Rendering;
using Vildmark.Graphics.Shapes;

namespace GGJ2021
{
    public class MapLayer
    {
        private readonly Map map;
        private readonly MapTile[,] tiles;
        private readonly RectangleShape rectangle;

        public int Width { get; }
        public int Height { get; }

        public MapLayer(Map map)
        {
            this.map = map;

            Width = map.Width;
            Height = map.Height;

            tiles = new MapTile[Width, Height];
            rectangle = new RectangleShape(MapTile.Size, MapTile.Size);
        }

        public MapTile this[int x, int y]
        {
            get => GetTile(x, y);
            set => SetTile(x, y, value);
        }

        public void SetTile(int x, int y, MapTile value)
        {
            if (!IsValidPosition(x, y))
            {
                return;
            }

            tiles[x, y] = value;
        }

        public MapTile GetTile(int x, int y)
        {
            if (!IsValidPosition(x, y))
            {
                return null;
            }

            return tiles[x, y];
        }

        public void Render(RenderContext2D renderContext)
        {
            RectangleF viewport = renderContext.Camera.Viewport;

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    MapTile tile = tiles[x, y];

                    Vector2 position = new Vector2(x, y) * MapTile.Size;

                    if (tile is null || !viewport.IntersectsWith(new RectangleF(position.X, position.Y, MapTile.Size, MapTile.Size)))
                    {
                        continue;
                    }

                    renderContext.Render(rectangle.Mesh, tile.Type.Material, new Vector3(position));
                }
            }
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
