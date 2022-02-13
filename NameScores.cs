using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_namescores
{
    public class NameScores
    {
       public static int CalcNameScores(string filePath)
       {
           // Empty list used to store each name's score
            var nameScores = new List<int>();

            // Total which is later returned
            int totalScore = 0;

            // Read names from text file, add to string & remove double quotation marks - leaves "NAME1,NAME2,NAME3"
            string text = File.ReadAllText($"{filePath}").Replace("\"", "");

            // Split string at each comma into an array of names, then sort A-Z
            string[] names = text.Split(",");
            Array.Sort(names);

            // Loop through each name in array
            for(var i = 0; i < names.Length; i++)
            {
                int totalAlphaValue = 0;
                int score = 0;

                // Split name into character array
                char[] letters = names[i].ToCharArray();

                // For each letter, work out alphabetical position (i.e. A = 1, B = 2) and add to total
                foreach(char letter in letters)
                {
                    // Char code for A is 65 - so subtract 64 to get alphabetical position
                    int index = letter - 64;
                    totalAlphaValue += index;
                }

                // Calculate score for this name (i + 1 = actual position in names array) & add to nameScores list
                score = totalAlphaValue * (i + 1);
                nameScores.Add(score);
            }

            // Loop through each score in nameScores list & add to total score
            foreach(int score in nameScores)
            {
                totalScore += score;
            };

            return totalScore;
       }
    }
}