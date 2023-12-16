using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\Ragendhu\\source\\repos\\StudentDataRetrieval\\StudentDataRetrieval\\students.txt";

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Display each line (student data)
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Make sure the file exists and try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
