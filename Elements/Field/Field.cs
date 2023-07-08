
using Raylib_CsLo;
using EvolutionSimulation.Elements.Forms;

namespace EvolutionSimulation.Elements.Field
{
    internal class Field
    {
        public List<Coin> Coins = new List<Coin>();
        public List<Form> Forms = new List<Form>();

        private int NumberOfCoins { get; set; } = 10;
        private int NumberOfForms { get; set; } = 5;

        private readonly int Limit = 100;

        private (int, int) GetClosestCoinPosition(int x, int y)
        {
            int minDistance = int.MaxValue;
            int closestCoinIndex = 0;
            for (int i = 0; i < Coins.Count; i++)
            {
                int distance = Coins[i].GetDistance(x, y);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestCoinIndex = i;
                }
            }
            return (Coins[closestCoinIndex].x, Coins[closestCoinIndex].y);
        }


        /// <summary>
        /// Déplace toutes les formes vers la pièce la plus proche
        /// </summary>
        public void MoveForms()
        {
            foreach (Form form in Forms)
            {
                (int x, int y) = GetClosestCoinPosition(form.x, form.y);
                form.Move(x, y);
            }
        }

        /// <summary>
        /// Récupère toutes les formes et pièces
        /// </summary>
        /// <returns></returns>
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
        public void GenerateForms()
        {
            for (int i = 0; i < NumberOfForms; i++)
            {
                Circle circle = new(
                    10,
                    RandomFormPositionOnAxe(),
                    RandomFormPositionOnAxe(),
                    Raylib.RED, 3);
                Forms.Add(circle);
            }
        }


        /// <summary>
        /// Rempli la liste de pièces
        /// </summary>
        public void GenerateCoins()
        {
            for (int i = 0; i < NumberOfCoins; i++)
            {
                Coin coin = new(
                    10, 5,
                    RandomCoinPositionOnAxe(),
                    RandomCoinPositionOnAxe(),
                    Raylib.GREEN);
                Coins.Add(coin);
            }
        }


        /// <summary>
        /// Génère une position aléatoire sur un axe pour les pièces
        /// </summary>
        /// <returns></returns>
        private int RandomCoinPositionOnAxe()
        {
            Random random = new();
            return random.Next(Limit, Config.WindowWidth - Limit);
        }


        /// <summary>
        /// Génère une position aléatoire sur un axe pour les formes
        /// </summary>
        /// <returns></returns>
        private int RandomFormPositionOnAxe()
        {
            Random random = new();
            if (random.Next(2) == 0)
            {
                return random.Next(10, Limit);
            }
            else
            {
                return random.Next(Config.WindowWidth - Limit, Config.WindowWidth - 10);
            }
        }
    }
}
