using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.Rendering;
using Vildmark.Graphics.Shapes;

namespace GGJ2021
{
    public class PlayerEntity : Entity
    {
        private RectangleShape rectangle;
        private Texture2D texture;

        public PlayerEntity()
        {
            texture = Textures.Chars[0, 3];
            rectangle = new RectangleShape(texture.Width, texture.Height);

            MovementSpeed = 16;
        }

        public override void Render(RenderContext2D renderContext)
        {
            renderContext.Render(rectangle.Mesh, texture, Transform.Matrix);
        }
    }
}
