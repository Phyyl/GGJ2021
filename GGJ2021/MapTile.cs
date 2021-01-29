using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJ2021
{
    public record MapTile(MapTileType Type)
    {
        public const int Size = 16;

        public static implicit operator MapTile(MapTileType type)
        {
            return new MapTile(type);
        }
    }
}
