using EvolutionSimulation;
using EvolutionSimulation.Elements;
using EvolutionSimulation.Elements.Field;
using EvolutionSimulation.Elements.Forms;
using Raylib_CsLo;

public static class Program
{
    public static Task Main(string[] args)
    {
        Raylib.InitWindow(Config.WindowWidth, Config.WindowHeight, "Course des formes");
        Raylib.SetTargetFPS(60);


        Field field = new Field();
        field.GenerateForms();
        field.GenerateCoins();


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib.BLACK);

            // --- Draw circle ---
            foreach (Element element in field.GetAllElements())
            {
                Raylib.DrawCircleV(element.Draw(), element.Size, element.Color);
            }

            field.MoveForms();
            // --- End drawing circle ---


            Raylib.EndDrawing();
        }

        return Task.CompletedTask;
    }
}
