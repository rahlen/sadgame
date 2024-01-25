﻿using SadConsole.Configuration;

Settings.WindowTitle = "My SadConsole Game";

Builder configuration = new Builder()
    .SetScreenSize(90, 30)
    .UseDefaultConsole()
    .OnStart(Startup)
    ;

Game.Create(configuration);
Game.Instance.Run();
Game.Instance.Dispose();

static void Startup(object? sender, GameHost host)
{
    if (Game.Instance.StartingConsole is null)
        throw new NullReferenceException("You should never have this error if you used the UseDefaultConsole startup code.");

    Console startingConsole = Game.Instance.StartingConsole;

    startingConsole.Cursor.PrintAppearanceMatchesHost = false;

    startingConsole.Cursor
        .SetPrintAppearanceToHost()
        .Move(0, 21)
        .Print("Kato is my favorite dog")
        .SetPrintAppearance(Color.Green)
        .NewLine()
        .Print("No, Birdie is my favorite dog");

       
    startingConsole.Cursor.IsVisible = true;
    startingConsole.Cursor.IsEnabled = true;
}