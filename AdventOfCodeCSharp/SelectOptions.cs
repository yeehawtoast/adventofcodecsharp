
using AdventOfCodeCSharp._2015;
using adventOfCodeCSharp._2024;
using Terminal.Gui;

namespace adventOfCodeCSharp;

public class SelectOptions : Window
{
    public Button Adv2024 { get; }
    public SelectOptions(Toplevel top)
    {
        // Set the properties of the new screen
        this.Title = "Select Years";
        this.X = 0;
        this.Y = 0;
        this.Width = Dim.Fill();
        this.Height = Dim.Fill();

        // Add a label to the new screenBut
        var heading = new Label("Select Year")
        {
            X = Pos.Center(),
            Y = 0
        };
        this.Add(heading);
        
        
        //2024
        Adv2024 = new Button
        {
            Text = "2024",
            X = 0,
            Y = Pos.Bottom(heading)
        };
        this.Add(Adv2024);
        var notstarted2024 = new Label("Not started")
        {
            X = Pos.Right(Adv2024),
            Y = Pos.Bottom(heading)
            
        };
        this.Add(notstarted2024);
        Adv2024.Clicked += () =>
        {
            Switch2024(top);
        };
        
        
        //2023
        var adv2023 = new Button
        {
            Text = "2023",
            X = 0,
            Y = Pos.Bottom(Adv2024)
        };
        this.Add(adv2023);
        var notstarted2023 = new Label("Not started")
        {
            X = Pos.Right(adv2023),
            Y = Pos.Bottom(notstarted2024)
            
        };
        this.Add(notstarted2023);
        
        var adv2022 = new Button
        {
            Text = "2022",
            X = 0,
            Y = Pos.Bottom(adv2023)
        };
        this.Add(adv2022);
        var notstarted2022 = new Label("Not started")
        {
            X = Pos.Right(adv2022),
            Y = Pos.Bottom(notstarted2023)
            
        };
        this.Add(notstarted2022);
        
        var adv2021 = new Button
        {
            Text = "2021",
            X = 0,
            Y = Pos.Bottom(adv2022)
        };
        this.Add(adv2021);
        var notstarted2021 = new Label("Not started")
        {
            X = Pos.Right(adv2021),
            Y = Pos.Bottom(notstarted2022)
            
        };
        this.Add(notstarted2021);
        
        //2020
        var adv2020 = new Button
        {
            Text = "2020",
            X = 0,
            Y = Pos.Bottom(adv2021)
        };
        this.Add(adv2020);
        var notstarted2020 = new Label("Not started")
        {
            X = Pos.Right(adv2020),
            Y = Pos.Bottom(notstarted2021)
            
        };
        this.Add(notstarted2020);
        
        //2019
        var adv2019 = new Button
        {
            Text = "2019",
            X = 0,
            Y = Pos.Bottom(adv2020)
        };
        this.Add(adv2019);
        var notstarted2019 = new Label("Not started")
        {
            X = Pos.Right(adv2019),
            Y = Pos.Bottom(notstarted2020)
            
        };
        this.Add(notstarted2019);
        
        //2018
        var adv2018 = new Button
        {
            Text = "2018",
            X = 0,
            Y = Pos.Bottom(adv2019)
        };
        this.Add(adv2018);
        var notstarted2018 = new Label("Not started")
        {
            X = Pos.Right(adv2018),
            Y = Pos.Bottom(notstarted2019)
            
        };
        this.Add(notstarted2018);
        
        
        //2017
        var adv2017 = new Button
        {
            Text = "2017",
            X = 0,
            Y = Pos.Bottom(adv2018)
        };
        this.Add(adv2017);
        var notstarted2017 = new Label("Not started")
        {
            X = Pos.Right(adv2017),
            Y = Pos.Bottom(notstarted2018)
            
        };
        this.Add(notstarted2017);
        
        //2016
        var adv2016 = new Button
        {
            Text = "2016",
            X = 0,
            Y = Pos.Bottom(adv2017)
        };
        this.Add(adv2016);
        var notstarted2016 = new Label("Not started")
        {
            X = Pos.Right(adv2016),
            Y = Pos.Bottom(notstarted2017)
            
        };
        this.Add(notstarted2016);
        
        //2015
        var adv2015 = new Button
        {
            Text = "2015",
            X = 0,
            Y = Pos.Bottom(adv2016)
        };
        this.Add(adv2015);
        var notstarted2015 = new Label("In Progress")
        {
            X = Pos.Right(adv2015),
            Y = Pos.Bottom(notstarted2016)
            
        };
        this.Add(notstarted2015);
        adv2015.Clicked += () =>
        {
            Switch2015(top);
        };
        
        

    }
    static void Switch2015(Toplevel top)
    {
        top.Clear();
        // Instantiate the new screen (defined in a separate class)
        Options2015 newScreen = new Options2015(top);

        // Clear the current window and show the new screen
        
        top.Add(newScreen);
        
        Application.MainLoop.Invoke(() => {
            newScreen.Quiz1.SetFocus();
        });
    }
    static void Switch2024(Toplevel top)
    {
        top.Clear();
        // Instantiate the new screen (defined in a separate class)
        Options2024 newScreen = new Options2024(top);

        // Clear the current window and show the new screen

        top.Add(newScreen);
        
        Application.MainLoop.Invoke(() => {
            newScreen.Quiz1.SetFocus();
        });
    }
    
}