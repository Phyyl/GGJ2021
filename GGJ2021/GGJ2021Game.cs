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
        private IWindow window;
        private RenderContext2D renderContext;
        private GLTexture2D texture;
        private TextureAtlas textureAtlas;
        private RectangleShape rectangle;

        public GGJ2021Game()
        {
            window = new Window(new WindowSettings(), this);
        }

        public void Load()
        {
            renderContext = new RenderContext2D(window.Width, window.Height)
            {
                ClearColor = Color4.Black
            };

            texture = ResourceLoader.LoadEmbedded<GLTexture2D>("items.png");
            textureAtlas = new TextureAtlas(texture, 8, 8);

            rectangle = new RectangleShape(Vector2.Zero, texture.Size, textureAtlas[0,0]);
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

            renderContext.Render(rectangle);
        }

        public void Run()
        {
            window.Run();
        }
    }
}
