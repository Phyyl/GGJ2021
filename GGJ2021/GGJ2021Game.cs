using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.GLObjects;
using Vildmark.Graphics.Rendering;
using Vildmark.Graphics.Shapes;
using Vildmark.Resources;
using Vildmark.Windowing;

namespace GGJ2021
{
    public class GGJ2021Game : IWindowHandler
    {
        public const int Scale = 4;

        private IWindow window;
        private RenderContext2D renderContext;
        private KeyItemEntity keyItemEntity;

        public GGJ2021Game()
        {
            window = new Window(new WindowSettings(), this);
        }

        public void Load()
        {
            renderContext = new RenderContext2D()
            {
                ClearColor = Color4.Black
            };

            renderContext.Camera.Transform.Scale = Scale;

            Textures.Initialize();

            keyItemEntity = new KeyItemEntity();
        }

        public void Resize(int width, int height)
        {
            renderContext.Resize(width, height);
        }

        public void Unload()
        {
        }

        public void Update(float delta)
        {
        }

        public void Render(float delta)
        {
            renderContext.Clear();

            keyItemEntity.Render(renderContext);
        }

        public void Run()
        {
            window.Run();
        }
    }
}
