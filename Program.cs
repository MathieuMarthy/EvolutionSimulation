using EvolutionSimulation.Elements;
using EvolutionSimulation.Elements.Field;
using EvolutionSimulation.Elements.Forms;
using Raylib_CsLo;

public static class Program
{
    public static Task Main(string[] args)
    {

        Raylib.InitWindow(1200, 800, "Course des formes");
        Raylib.SetTargetFPS(60);


        Field field = new Field();
        field.GenerateElements();


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib.BLACK);

            // --- Draw elements ---
            foreach (Form element in field.Forms)
            {
                Raylib.DrawCircleV(element.Draw(), element.Size, element.Color);

                element.Move();
            }
            // --- End drawing elements ---

            Raylib.EndDrawing();
        }

        return Task.CompletedTask;
    }
}
