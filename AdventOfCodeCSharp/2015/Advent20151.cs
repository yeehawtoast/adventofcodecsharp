namespace AdventOfCodeCSharp._2015;

public class Advent20151 {
    public void Run()
    {
        string filePath = "tests/2015_1.txt"; // Replace with your file path
        int level = 0;
        int position = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int currentChar;
;
                while ((currentChar = reader.Read()) != -1) // Read() returns -1 when EOF is reached
                {
                    char character = (char)currentChar;

                    if (character == '(')
                    {
                        level++;
                    }else if (character == ')')
                    {
                        level--;
                    }

                    position++;
                    if (level < 0)
                    {
                        Console.WriteLine($"Level is negative at position {position}");
                    }
                    
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.WriteLine(level);
        Console.WriteLine(position);
    }
    

}