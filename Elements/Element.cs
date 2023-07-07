
using Raylib_CsLo;
using System.Numerics;

namespace EvolutionSimulation.Elements
{
    public abstract class Element
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }

        public Element(int size, int x, int y, Color color)
        {
            Size = size;
            this.x = x;
            this.y = y;
            Color = color;
        }

        public Vector2 Draw()
        {
            return new Vector2(x, y);
        }
    }
}
