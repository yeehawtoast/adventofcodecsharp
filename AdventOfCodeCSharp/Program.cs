using System;
using System.Diagnostics;
using adventOfCodeCSharp;
using AdventOfCodeCSharp;
using Terminal.Gui;
//TODO: VISUALIZE EACH YEAR WITH ITS COMPLETED DESIGN. THAT WOULD BE FUN


class Program
{
    static void Main()
    {
        Application.Init();
        Colors.Base.Normal = new Terminal.Gui.Attribute(Color.White, Color.Black);
        
        var top = Application.Top;

        var mainWindow = new Window("Advent of Code C#")
        {
            X = 0,
            Y = 0,
            Width = Dim.Fill(),
            Height = Dim.Fill(),
        };
        


        var mainTree = new Label(@"
    _\/_
     /\
     /\
    /  \
    /~~\o
   /o   \
  /~~*~~~\
 o/    o \
 /~~~~~~~~\~`
/__*_______\
     ||
   \====/
    \__/
")
        {
            X = Pos.Center(),
            Y = Pos.Center()
        };
        mainWindow.Add(mainTree);
        
        var mainLabel = new Label("Advent of Code C#")
        {
            X = Pos.Center(),
            Y = Pos.Bottom(mainTree),
        };
        mainWindow.Add(mainLabel);
        var exitLabel = new Label("Press ESC to exit")
        {
            X = 0,
            Y = 0,
        };
        mainWindow.Add(exitLabel);

        
        var btnYears = new Button
        {
            Text = "See Years",
            Y = Pos.Bottom (mainLabel) + 1,

            // center the login button horizontally
            X = Pos.Center (),
            IsDefault = true,
            ColorScheme = new ColorScheme()
            {
                Normal = new Terminal.Gui.Attribute(Color.White, Color.Black),
                Focus = new Terminal.Gui.Attribute(Color.Black, Color.White),
            }
        };
        
        mainWindow.Add(btnYears);
        
        var btnExit = new Button
        {
            Text = "Quit",
            Y = Pos.Bottom (btnYears),

            // center the login button horizontally
            X = Pos.Center (),
            IsDefault = true,
            ColorScheme = new ColorScheme()
            {
                Normal = new Terminal.Gui.Attribute(Color.White, Color.Black),
                Focus = new Terminal.Gui.Attribute(Color.Black, Color.White),
            }
        };
        mainWindow.Add(btnExit);
        
        top.Add(mainWindow);
        top.KeyPress += (View.KeyEventEventArgs args) =>
        {
            if (args.KeyEvent.Key == Key.Esc)
            {
                Application.RequestStop(); // Gracefully stops the application
            }
        };
        btnYears.Clicked += () =>
        {
            SwitchToNewScreen(top);
        };
        btnExit.Clicked += () =>
        {
            Application.RequestStop();
        };
        
        Application.Run();
    }
    static void SwitchToNewScreen(Toplevel top)
    {
        // Instantiate the new screen (defined in a separate class)
        SelectOptions newScreen = new SelectOptions(top);

        // Clear the current window and show the new screen
        top.Clear();
        top.Add(newScreen);
        
        Application.MainLoop.Invoke(() => {
            newScreen.Adv2024.SetFocus();
        });
    }
}

