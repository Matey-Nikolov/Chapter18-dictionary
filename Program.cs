namespace Chapter18_dictionary
{
    using System;

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
                Console.WriteLine("----------------");

                Console.Write("Enter ONLY digits of 1 to 4. ");
                int option = 0;


                int.TryParse(Console.ReadLine(), out option);


                if (option < 1 || 4 < option)
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
                }
            }
        }
    }
}
