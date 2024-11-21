using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace AdventOfCodeCSharp._2015;

public class Advent20152
{
    public void Run()
    {
        string filePath = "tests/2015_2.txt";
        List<int> calcnumbers = new List<int>();
        int calculatedarea = 0;
        int calculatedribbon = 0;
        int totalsqrft = 0;
        int totalribbon = 0;
        string inputnum = "";
        int linecount = 0;
    
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int currentChar;
                int number;
                ;
                while ((currentChar = reader.Read()) != -1) // Read() returns -1 when EOF is reached
                {
                    char character = (char)currentChar;

                    switch (character)
                    {
                        case '\n':
                            number = int.Parse(inputnum);
                            calcnumbers.Add(number);
                            inputnum = "";
                            calculatedarea = CalculateArea(calcnumbers[0], calcnumbers[1], calcnumbers[2]);
                            totalsqrft += calculatedarea;
                            calculatedribbon = CalculateRibbon(calcnumbers[0], calcnumbers[1], calcnumbers[2]);
                            totalribbon += calculatedribbon;
                            calcnumbers.Clear();
                            linecount++;
                            Console.WriteLine($"Processed line: {linecount}");
                            break;
                        case '1':
                            inputnum += character;
                            break;
                        case '2':
                            inputnum += character;
                            break;
                        case '3':
                            inputnum += character;
                            break;
                        
                        case '4':
                            inputnum += character;
                            break;
                        case '5':
                            inputnum += character;
                            break;
                        case '6':
                            inputnum += character;
                            break;
                        case '7':
                            inputnum += character;
                            break;
                        case '8':
                            inputnum += character;
                            break;
                        case '9':
                            inputnum += character;
                            break;
                        case '0':
                            inputnum += character;
                            break;
                        case 'x':
                            number = int.Parse(inputnum);
                            calcnumbers.Add(number);
                            inputnum = "";
                            break;
                    }

                    
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.WriteLine(totalsqrft);
        Console.WriteLine(totalribbon);
    }

    private int CalculateArea(int l, int w, int h)
    {
        int side1 = l * w;
        int side2 = l * h;
        int side3 = w * h;

        // Calculate total area
        int surfaceArea = 2 * side1 + 2 * side2 + 2 * side3;

        // Add the smallest side
        int extraArea = Math.Min(side1, Math.Min(side2, side3));

        return surfaceArea + extraArea;
    }

    private int CalculateRibbon(int l, int w, int h)
    {
        // Sort dimensions to find the two smallest
        int[] dimensions = { l, w, h };
        Array.Sort(dimensions); // dimensions[0] and dimensions[1] are the smallest two

        int ribbonLength = 2 * (dimensions[0] + dimensions[1]); // Smallest perimeter
        int bowLength = l * w * h; // Bow is the box volume

        return ribbonLength + bowLength;
    }


}
