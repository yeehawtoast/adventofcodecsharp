using Terminal.Gui;

namespace adventOfCodeCSharp._2024;

public class Options2024 : Window
{
    public Button Quiz1 { get; }

    public Options2024(Toplevel top)
    {
        this.Title = "Advent of Code 2024";
        this.X = 0;
        this.Y = 0;
        this.Width = Dim.Fill();
        this.Height = Dim.Fill();
        
        //FRAMEVIEWS
        
        var leftColumn = new FrameView("Puzzles")
        {
            X = 0,
            Y = 0,
            Width = Dim.Percent(30),
            Height = Dim.Fill()
        };

        var rightColumn = new FrameView("Puzzle Output")
        {
            X = Pos.Right(leftColumn),
            Y = 0,
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        // TextView for dynamic output
        var outputTextView = new TextView()
        {
            X = 1,
            Y = 1,
            Width = Dim.Fill(2),
            Height = Dim.Fill(2),
            ReadOnly = true
        };

        rightColumn.Add(outputTextView);

        // Add buttons to the left column
        Quiz1 = new Button("Day 1")
        {
            X = 1,
            Y = 1
        };
        leftColumn.Add(Quiz1);
        
        //Day 2
        var quiz2 = new Button
        {
            Text = "Day 2",
            X = 0,
            Y = Pos.Bottom(Quiz1)
        };
        leftColumn.Add(quiz2);
        
        var quiz3 = new Button
        {
            Text = "Day 3",
            X = 0,
            Y = Pos.Bottom(quiz2)
        };
        leftColumn.Add(quiz3);
        
        var quiz4 = new Button
        {
            Text = "Day 4",
            X = 0,
            Y = Pos.Bottom(quiz3)
        };
        leftColumn.Add(quiz4);
        
        var quiz5 = new Button
        {
            Text = "Day 5",
            X = 0,
            Y = Pos.Bottom(quiz4)
        };
        leftColumn.Add(quiz5);
        
        var quiz6 = new Button
        {
            Text = "Day 6",
            X = 0,
            Y = Pos.Bottom(quiz5)
        };
        leftColumn.Add(quiz6);
        
        var quiz7 = new Button
        {
            Text = "Day 7",
            X = 0,
            Y = Pos.Bottom(quiz6)
        };
        leftColumn.Add(quiz7);
        
        var quiz8 = new Button
        {
            Text = "Day 8",
            X = 0,
            Y = Pos.Bottom(quiz7)
        };
        leftColumn.Add(quiz8);
        
        var quiz9 = new Button
        {
            Text = "Day 9",
            X = 0,
            Y = Pos.Bottom(quiz8)
        };
        leftColumn.Add(quiz9);
        
        var quiz10 = new Button
        {
            Text = "Day 10",
            X = 0,
            Y = Pos.Bottom(quiz9)
        };
        leftColumn.Add(quiz10);
        
        var quiz11 = new Button
        {
            Text = "Day 11",
            X = 0,
            Y = Pos.Bottom(quiz10)
        };
        leftColumn.Add(quiz11);
        
        var quiz12 = new Button
        {
            Text = "Day 12",
            X = 0,
            Y = Pos.Bottom(quiz11)
        };
        leftColumn.Add(quiz12);
        
        var quiz13 = new Button
        {
            Text = "Day 13",
            X = 0,
            Y = Pos.Bottom(quiz12)
        };
        leftColumn.Add(quiz13);
        
        var quiz14 = new Button
        {
            Text = "Day 14",
            X = 0,
            Y = Pos.Bottom(quiz13)
        };
        leftColumn.Add(quiz14);
        
        var quiz15 = new Button
        {
            Text = "Day 15",
            X = 0,
            Y = Pos.Bottom(quiz14)
        };
        leftColumn.Add(quiz15);
        
        var quiz16 = new Button
        {
            Text = "Day 16",
            X = 0,
            Y = Pos.Bottom(quiz15)
        };
        leftColumn.Add(quiz16);
        
        var quiz17 = new Button
        {
            Text = "Day 17",
            X = 0,
            Y = Pos.Bottom(quiz16)
        };
        leftColumn.Add(quiz17);
        
        var quiz18 = new Button
        {
            Text = "Day 18",
            X = 0,
            Y = Pos.Bottom(quiz17)
        };
        leftColumn.Add(quiz18);
        
        var quiz19 = new Button
        {
            Text = "Day 19",
            X = 0,
            Y = Pos.Bottom(quiz18)
        };
        leftColumn.Add(quiz19);
        
        var quiz20 = new Button
        {
            Text = "Day 20",
            X = 0,
            Y = Pos.Bottom(quiz19)
        };
        leftColumn.Add(quiz20);
        
        var quiz21 = new Button
        {
            Text = "Day 21",
            X = 0,
            Y = Pos.Bottom(quiz20)
        };
        leftColumn.Add(quiz21);
        
        var quiz22 = new Button
        {
            Text = "Day 22",
            X = 0,
            Y = Pos.Bottom(quiz21)
        };
        leftColumn.Add(quiz22);
        
        var quiz23 = new Button
        {
            Text = "Day 23",
            X = 0,
            Y = Pos.Bottom(quiz22)
        };
        leftColumn.Add(quiz23);
        
        var quiz24 = new Button
        {
            Text = "Day 24",
            X = 0,
            Y = Pos.Bottom(quiz23)
        };
        leftColumn.Add(quiz24);
        
        var quiz25 = new Button
        {
            Text = "Day 25",
            X = 0,
            Y = Pos.Bottom(quiz24)
        };
        leftColumn.Add(quiz25);
        
        this.Add(leftColumn);
        this.Add(rightColumn);
    }
}