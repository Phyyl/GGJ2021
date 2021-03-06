﻿using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark;
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
        private Map map;
        private EntityController controller;

        public GGJ2021Game()
        {
            window = new Window(new WindowSettings(), this);
        }

        public void Load()
        {
            Textures.Initialize();
            MapTileType.Initialize();

            renderContext = new BatchedRenderContext2D()
            {
                ClearColor = Color4.Black
            };

            renderContext.Camera.Transform.Scale = Scale;

            KeyItemEntity keyItemEntity = new KeyItemEntity();
            keyItemEntity.Transform.Position = new Vector3(32, 32, 0);

            PlayerEntity playerEntity = new PlayerEntity();
            controller = new EntityController(window, playerEntity);

            map = new Map(50, 20);

            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.BackgroundLayer[x, y] = MapTileType.Grass;
                }
            }

            map.AddEntities(keyItemEntity, playerEntity);
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
            controller.Update(delta);

            map.Update(delta);
        }

        public void Render(float delta)
        {
            using (renderContext.Begin())
            {
                map.Render(renderContext);
            }
        }

        public void Run()
        {
            window.Run();
        }
    }
}
