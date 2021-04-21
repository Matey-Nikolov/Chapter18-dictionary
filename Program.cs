namespace Chapter18_dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - Exit.");
                Console.WriteLine("2 - Count number.");
                Console.WriteLine("3 - Count number 2.");
                Console.WriteLine("4 - Count words.");
                Console.WriteLine("5 - Company users.");
                Console.WriteLine("6 - Students academy.");
                Console.WriteLine("----------------");

                Console.Write("Enter ONLY digits of 1 to 6. ");
                int option = 0;


                int.TryParse(Console.ReadLine(), out option);


                if (option < 1 || 6 < option)
                    continue;
                else
                    option.ToString();

                if (option == 1)
                {
                    return;
                }

                switch (option)
                {
                    case 2:
                        Number countNum = new Number();
                        countNum.CountNum();
                        Console.WriteLine("----------------");
                        break;
                    case 3:
                        Number removeNum = new Number();
                        removeNum.RemoveOddNumberCount();
                        Console.WriteLine("----------------");
                        break;
                    case 4:
                        TextFilter text = new TextFilter();
                        text.CountWords();
                        Console.WriteLine("----------------");
                        break;
                    case 5:
                        Company softUni = new Company();
                        softUni.UsersSortByCompany();
                        Console.WriteLine("----------------");
                        break;
                    case 6:

                        Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            string name = Console.ReadLine();
                            double grade = double.Parse(Console.ReadLine());

                            if (!studentsGrades.ContainsKey(name))
                            {
                                studentsGrades.Add(name, new List<double>());
                            }
                            studentsGrades[name].Add(grade);
                        }

                        foreach (var student in studentsGrades
                            .Where(x => x.Value.Average() >= 4.50)
                            .OrderByDescending(x => x.Value.Average()))
                        {
                            Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                        }
                        Console.WriteLine("----------------");
                        break;
                }
            }
        }
    }
}
