

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


        /// <summary>
        /// Déplace la forme vers la pièce la plus proche
        /// </summary>
        /// <param name="destinationX"></param>
        /// <param name="destinationY"></param>
        public void Move(int destinationX, int destinationY)
        {
            if (x < destinationX)
            {
                x += Speed;
            }
            else if (x > destinationX)
            {
                x -= Speed;
            }

            if (y < destinationY)
            {
                y += Speed;
            }
            else if (y > destinationY)
            {
                y -= Speed;
            }
        }
    }
}
