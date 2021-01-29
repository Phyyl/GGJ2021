using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics;
using Vildmark.Graphics.Rendering;

namespace GGJ2021
{
    public abstract class Entity
    {
        private Transform transform;

        public float MovementSpeed { get; init; }

        public ref Transform Transform => ref transform;

        public virtual void Update(float delta) { }
        public abstract void Render(RenderContext2D renderContext);
    }
}
