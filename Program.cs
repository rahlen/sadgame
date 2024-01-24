using SadConsole.Configuration;

Settings.WindowTitle = "My SadConsole Game";

Game.Create(90, 30, Startup);
Game.Instance.Run();
Game.Instance.Dispose();

static void Startup(object? sender, GameHost host)
{
    
    Game.Instance.StartingConsole!.FillWithRandomGarbage(SadConsole.Game.Instance.StartingConsole!.Font);
    Game.Instance.StartingConsole.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, Mirror.None);
    Game.Instance.StartingConsole.Print(4, 4, "Hello from SadConsole");
    Game.Instance.StartingConsole.DrawBox(new Rectangle(3, 3, 23, 3), ShapeParameters.CreateBorder(new ColoredGlyph(Color.Violet, Color.Black, 176)));
    Game.Instance.StartingConsole.DrawBox(new Rectangle(3, 3, 23, 3), ShapeParameters.CreateStyledBox(ICellSurface.ConnectedLineThin,
                                                    new ColoredGlyph(Color.Violet, Color.Black)));
    Game.Instance.StartingConsole.DrawCircle(new Rectangle(5, 8, 16, 8), ShapeParameters.CreateFilled(new ColoredGlyph(Color.Violet, Color.Black, 176),
                                                       new ColoredGlyph(Color.White, Color.Black)));
}