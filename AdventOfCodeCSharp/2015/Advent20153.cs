namespace AdventOfCodeCSharp._2015;
//TODO: FOR FUN, FIGURE OUT HOW TO DISPLAY THE PATH OF SANTA AND ROBOSANTA IN THE CONSOLE
public class Advent20153
{
    private Dictionary<int, (int, int)> _coords = new Dictionary<int, (int, int)>();
    public int Count;
    public bool Santa = true;
    public bool Robosanta = false;

    public (int, int) SantaPosition;
    public (int, int) RobosantaPosition;

    public void Run()
    {
         Count = 0;
         SantaPosition = (0, 0);
         RobosantaPosition = (0, 0);
        
        string filePath = "tests/2015_3.txt"; // Replace with your file path
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int currentChar;
                
                _coords.Add(0,(0,0));
                while ((currentChar = reader.Read()) != -1)
                {
                    char ch = (char)currentChar;
                    
                    switch (ch)
                    {
                        case '>':
                            if (Santa == true)
                            { 
                                GoRightSanta(Count);
                            } else if (Robosanta == true)
                            {
                                GoRightRobo(Count);
                            }
                            
                            break;
                        case '<':
                            if (Santa == true)
                            { 
                                GoLeftSanta(Count);
                            } else if (Robosanta == true)
                            {
                                GoLeftRobo(Count);
                            }
                            break;
                        case 'v':
                            if (Santa == true)
                            { 
                                GoDownSanta(Count);
                            } else if (Robosanta == true)
                            {
                                GoDownRobo(Count);
                            }
                            break;
                        case '^':
                            if (Santa == true)
                            { 
                                GoUpSanta(Count);
                            } else if (Robosanta == true)
                            {
                                GoUpRobo(Count);
                            }
                            break;
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Count++;
        Console.WriteLine($"Total  Original coords: {Count}");
        Console.WriteLine($"Total New Coords: {_coords.Count}");
    }

    public void GoLeftSanta(int count)
    {
        //determines the current coord values that we are at right now
        SantaPosition.Item1--;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(SantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! Santa's Current position: {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (SantaPosition.Item1, SantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By Santa at {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        Santa = false;
        Robosanta = true;
    }

    private void GoLeftRobo(int count)
    {
        RobosantaPosition.Item1--;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(RobosantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! RoboSanta's Current position: {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (RobosantaPosition.Item1, RobosantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By the Robot at {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");

        }
        Robosanta = false;
        Santa = true;
    }

    private void GoRightSanta(int count)
    {
        //determines the current coord values that we are at right now
        SantaPosition.Item1++;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(SantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! Santa's Current position: {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (SantaPosition.Item1, SantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By Santa at {SantaPosition.Item1} and {SantaPosition.Item2}");

        }

        Santa = false;
        Robosanta = true;
    }

    private void GoRightRobo(int count)
    {
        RobosantaPosition.Item1++;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(RobosantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! RoboSanta's Current position: {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (RobosantaPosition.Item1, RobosantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By the Robot at {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");

        }
        Robosanta = false;
        Santa = true;
    }




    

    private void GoUpSanta(int count)
    {
        //determines the current coord values that we are at right now
        SantaPosition.Item2++;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(SantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! Santa's Current position: {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (SantaPosition.Item1, SantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By Santa at {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        
        Santa = false;
        Robosanta = true;
    }

    private void GoUpRobo(int count)
    {
        RobosantaPosition.Item2++;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(RobosantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! RoboSanta's Current position: {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (RobosantaPosition.Item1, RobosantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By the Robot at {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");

        }
        Robosanta = false;
        Santa = true;
    }

    private void GoDownSanta(int count)
    {
        SantaPosition.Item2--;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(SantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! Santa's Current position: {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (SantaPosition.Item1, SantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered By Santa at {SantaPosition.Item1} and {SantaPosition.Item2}");
        }
        Santa = false;
        Robosanta = true;
    }

    private void GoDownRobo(int count)
    {
        RobosantaPosition.Item2--;
        int nextcount = Count + 1;
        
        if (_coords.ContainsValue(RobosantaPosition))
        {
            Console.WriteLine($" No Unique Present Delivered! RoboSanta's Current position: {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");
        }
        else
        {
            _coords.Add(nextcount, (RobosantaPosition.Item1, RobosantaPosition.Item2) );
            Count++;
            Console.WriteLine($"A Present has been delivered by the Robot at {RobosantaPosition.Item1} and {RobosantaPosition.Item2}");

        }
        Robosanta = false;
        Santa = true;
    }
}