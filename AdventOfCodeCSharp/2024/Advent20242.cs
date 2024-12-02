using System.Text;
namespace adventOfCodeCSharp._2024;

public class Advent20242
{
    public static void Run()
    {
        Dictionary<int, (int, string)> reports = new Dictionary<int, (int, string)>();
        string filePath = "input.txt";
        int goodReportCount = 0;


        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (ProcessLine(line, out bool isValidReport))
                    {
                        if (isValidReport) goodReportCount++;
                    }
                    Console.WriteLine(line);
                    Console.WriteLine(isValidReport);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine($"Number of Good reports: {goodReportCount}");


    } 
    static bool ProcessLine(string line, out bool isValidReport)
    {
        isValidReport = true;
        bool problemDampener = true; // Allows ignoring the first failure
        string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
        if (tokens.Length < 2)
        {
            isValidReport = false; // Not enough data to process
            return false;
        }
    
        bool ascending = int.Parse(tokens[1]) > int.Parse(tokens[0]); // Determine sequence trend
    
        for (int i = 1; i < tokens.Length; i++)
        {
            // Validate and parse current and previous tokens
            if (!int.TryParse(tokens[i], out int current) || !int.TryParse(tokens[i - 1], out int previous))
            {
                isValidReport = false; // Invalid input
                return false;
            }
    
            int diff = current - previous;
    
            // Check conditions for invalid report
            if ((ascending && (diff == 0 || diff > 3)))
            {
                if (problemDampener)
                {
                    Console.WriteLine("Problem Dampener Used");
                    problemDampener = false; // Use dampener for the first issue
                }
                else
                {
                    isValidReport = false; // Subsequent issues invalidate the report
                    break;
                }
            }
            else if ((!ascending && (diff == 0 || diff < -3)))
            {
                if (problemDampener)
                {
                    Console.WriteLine("Problem Dampener Used");
                    problemDampener = false; // Use dampener for the first issue
                }
                else
                {
                    isValidReport = false; // Subsequent issues invalidate the report
                    break;
                }
            }
        }
    
        return true; // Process completed successfully
    }
}

