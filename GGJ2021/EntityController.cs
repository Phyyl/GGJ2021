using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Windowing;

namespace GGJ2021
{
    public class EntityController
    {
        private readonly IWindow window;

        public Entity Entity { get; }

        public Keys ForwardKey { get; } = Keys.W;
        public Keys BackKey { get; } = Keys.S;
        public Keys LeftKey { get; } = Keys.A;
        public Keys RightKey { get; } = Keys.D;

        public EntityController(IWindow window, Entity entity)
        {
            this.window = window;
            Entity = entity;
        }

        public void Update(float delta)
        {
            Vector2 movementInput = default;

            if (window.IsKeyDown(ForwardKey))
            {
                movementInput.Y--;
            }

            if (window.IsKeyDown(BackKey))
            {
                movementInput.Y++;
            }

            if (window.IsKeyDown(LeftKey))
            {
                movementInput.X--;
            }

            if (window.IsKeyDown(RightKey))
            {
                movementInput.X++;
            }

            Entity.Transform.Position += new Vector3(movementInput) * Entity.MovementSpeed * delta;
        }
    }
}
