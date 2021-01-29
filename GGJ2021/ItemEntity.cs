using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics;
using Vildmark.Graphics.Models;
using Vildmark.Graphics.Rendering;
using Vildmark.Graphics.Shapes;

namespace GGJ2021
{
    public abstract class ItemEntity : Entity
    {
        private const float bobbingHeight = 2;

        private readonly Texture2D texture;
        private RectangleShape rectangle;
        private float t;

        protected ItemEntity(Texture2D texture)
        {
            this.texture = texture;

            rectangle = new RectangleShape(texture.Width, texture.Height);

            Transform.OriginX = texture.Width / 2;
            Transform.OriginY = texture.Height;
        }

        public override void Update(float delta)
        {
            t += delta;

            base.Update(delta);
        }

        public override void Render(RenderContext2D renderContext)
        {
            float bobbingOffset = (float)Math.Cos(t * MathHelper.TwoPi) * bobbingHeight;

            renderContext.Render(rectangle.Mesh, texture, Transform.Matrix, new Vector3(0, bobbingOffset, 0));
        }
    }
}
