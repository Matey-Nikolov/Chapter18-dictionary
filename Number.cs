using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18_dictionary
{
    class Number
    {
        public void CountNum()
        {
            Dictionary<int, int> num = new Dictionary<int, int>();

            Console.WriteLine("Enter a numbers (1, 3, 3 ...).");
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (!num.ContainsKey(currentNumber))
                    num.Add(currentNumber, 1);
                else
                    num[currentNumber]++;
            }

            foreach (var kvp in num)
            {
                Console.WriteLine($"Count: {kvp.Key} -> {kvp.Value}");
            }
        }

        public void RemoveOddNumberCount()
        {
            Dictionary<int, int> countNum = new Dictionary<int, int>();

            Console.WriteLine("Enter a numbers (4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6...).");
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (!countNum.ContainsKey(currentNumber))
                    countNum.Add(currentNumber, 1);
                else
                    countNum[currentNumber]++;
            }

            Console.WriteLine($"Any numbers where they are repeated an even number of times.");
            foreach (var number in countNum
                .Where( x => x.Value % 2 == 0))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
