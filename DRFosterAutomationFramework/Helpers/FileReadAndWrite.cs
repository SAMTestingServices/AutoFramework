using System;
using System.IO;

namespace DRFosterAutomationFramework.Helpers
{
    public class FileReadAndWrite
    {
        public static void fileWriter()
        {
            // Example #1: Write the whole array to a file
            string[] lines = { "First line", "Second line", "Third line" };

            var fileLocation = @"C:\Dev\test-automation\test-automation\testResults\TextFiles\";

            using (StreamWriter file = new StreamWriter($"{fileLocation}WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

        }
    }
}