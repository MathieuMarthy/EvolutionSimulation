

using Raylib_CsLo;

namespace EvolutionSimulation.Elements.Forms
{
    internal abstract class Form : Element
    {
        public int Speed { get; set; }

        public Form(int size, int x, int y, Color color, int speed) : base(size, x, y, color)
        {
            Speed = speed;
        }

        public void Move()
        {
            x += Speed;
        }
    }
}
