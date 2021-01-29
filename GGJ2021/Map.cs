using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vildmark.Graphics.Rendering;

namespace GGJ2021
{
    public class Map
    {
        private readonly List<Entity> entities = new List<Entity>();

        public MapLayer BackgroundLayer { get; }
        public MapLayer ObjectLayer { get; }
        public MapLayer ForegroundLayer { get; }

        public int Width { get; init; }
        public int Height { get; init; }

        public IEnumerable<Entity> Entities => entities.ToArray();

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            BackgroundLayer = new MapLayer(this);
            ObjectLayer = new MapLayer(this);
            ForegroundLayer = new MapLayer(this);
        }

        public void AddEntities(params Entity[] entities)
        {
            foreach (var entity in entities)
            {
                if (entity is null)
                {
                    continue;
                }

                if (!this.entities.Contains(entity))
                {
                    this.entities.Add(entity);
                }
            }
        }

        public void Update(float delta)
        {
            foreach (var entity in entities)
            {
                entity.Update(delta);
            }
        }

        public void Render(RenderContext2D renderContext)
        {
            BackgroundLayer.Render(renderContext);
            ObjectLayer.Render(renderContext);

            foreach (var entity in entities)
            {
                entity.Render(renderContext);
            }

            ForegroundLayer.Render(renderContext);
        }
    }
}
