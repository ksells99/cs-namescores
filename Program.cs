using System;

namespace csharp_namescores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get file path from command line argument
            // eg "dotnet run names.txt" would return filePath as "names.txt"
            var filePath = args[0];

            // Pass into method on NameScores.cs file
            int result = NameScores.CalcNameScores(filePath);

            // Log output to console
            Console.WriteLine($"Total name score is: {result}");
           
        }
    }
}
