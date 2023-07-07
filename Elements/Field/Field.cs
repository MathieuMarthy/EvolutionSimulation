
using Raylib_CsLo;
using EvolutionSimulation.Elements.Forms;

namespace EvolutionSimulation.Elements.Field
{
    internal class Field
    {
        public List<Coin> Coins = new List<Coin>();
        public List<Form> Forms = new List<Form>();

        public void GenerateElements()
        {
            Circle circle = new Circle(10, 100, 100, Raylib.RED, 3);
            Forms.Add(circle);
        }

        public void GenerateCoins()
        {
        }
    }
}
