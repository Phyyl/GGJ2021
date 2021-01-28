using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.Models;

namespace GGJ2021
{
    public class KeyItemEntity : ItemEntity
    {
        public KeyItemEntity()
            : base(Textures.ItemsAtlas[0, 0])
        {
        }
    }
}
