using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18_dictionary
{
    class Company
    {
        public void UsersSortByCompany()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] currentData = input.Split(":");

                string courseName = currentData[0];
                string studentName = currentData[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            Console.WriteLine(PrintOutput(courses));
        }

        public string PrintOutput(Dictionary<string, List<string>> courses)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var course in courses
                .OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine($"{course.Key}: {course.Value.Count}");

                foreach (var name in course.Value.OrderBy(x => x))
                {
                    sb.AppendLine($"--{name}");
                }
            }
            return sb.ToString();
        }
    }
}