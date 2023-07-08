
using Raylib_CsLo;
using EvolutionSimulation.Elements.Forms;

namespace EvolutionSimulation.Elements.Field
{
    internal class Field
    {
        public List<Coin> Coins = new List<Coin>();
        public List<Form> Forms = new List<Form>();

        private readonly int Limit = 30;
        private int NumberOfCoins { get; set; } = 30;


        public List<Element> GetAllElements()
        {
            List<Element> elements = new();
            elements.AddRange(Forms);
            elements.AddRange(Coins);

            return elements;
        }


        /// <summary>
        /// Rempli la liste de formes
        /// </summary>
        public void GenerateElements()
        {
            Circle circle = new(10, 100, 100, Raylib.RED, 3);
            Forms.Add(circle);
        }


        /// <summary>
        /// Rempli la liste de pièces
        /// </summary>
        public void GenerateCoins()
        {
            for (int i = 0; i < NumberOfCoins; i++)
            {
                (int x, int y) = GenerateRandomCoinPosition();
                Coin coin = new(10, 5, x, y, Raylib.GREEN);
                Coins.Add(coin);
            }
        }


        /// <summary>
        /// Génère une position aléatoire pour une pièce
        /// </summary>
        /// <returns></returns>
        private (int, int) GenerateRandomCoinPosition()
        {
            Random random = new();

            int x = random.Next(0 + Limit, Config.WindowWidth - Limit);
            int y = random.Next(0 + Limit, Config.WindowHeight - Limit);

            return (x, y);
        }
    }
}
