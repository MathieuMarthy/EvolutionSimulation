using Raylib_CsLo;

namespace EvolutionSimulation.Elements.Field
{
    internal class Coin : Element
    {
        public int Value { get; set; }

        public Coin(int value, int size, int x, int y, Color color) : base(size, x, y, color)
        {
            Value = value;
        }
    }
}
