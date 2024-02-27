using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = @"E:\Programming\digits";

        // Count the occurrences of digits in the specified directory
        int[] digitCounts = CountDigits(directoryPath);

        // Print the counts
        Console.WriteLine("Digit Counts:");
        for (int i = 0; i < digitCounts.Length; i++)
        {
            Console.WriteLine($"{i}: {digitCounts[i]}");
        }

        // Send the counts and solution code via email
        // You can implement email sending functionality here
    }

    static int[] CountDigits(string directoryPath)
    {
        int[] digitCounts = new int[10];

        foreach (string filePath in Directory.EnumerateFiles(directoryPath))
        {
            string content = File.ReadAllText(filePath);
            foreach (char c in content)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0'; // Convert char to digit
                    digitCounts[digit]++;
                }
            }
        }

        return digitCounts;
    }
}
