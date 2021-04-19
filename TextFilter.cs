using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter18_dictionary
{
    class TextFilter
    {
        public void CountWords()
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            Console.WriteLine("Enter a text (this is, this is...).");
            string text = Console.ReadLine()
                .ToLower();

            char[] spearator = { ',', '.', '!', '?', ' ' };

           string[] strArray= text.Split(spearator,
           StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strArray.Length; i++)
            {
                string currentWord = strArray[i];

                if (!countWords.ContainsKey(currentWord))
                    countWords.Add(currentWord, 1);
                else
                    countWords[currentWord]++;
            }

            foreach (var kvp in countWords
                .OrderBy(x => x.Value))
            {
                Console.WriteLine($"Count: {kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
