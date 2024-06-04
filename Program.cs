namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser("Please enter a number.");
            GetNaturalNumbers(number);
        }

        static int GetNumberFromUser(string s)
        {
            string? userInput = "";

            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");
            return Convert.ToInt32(userInput);
        }

        static void GetNaturalNumbers(int num)
        {
            if (num > 0)
            {
                Console.Write($"{num} ");
                GetNaturalNumbers(num - 1);
            }
        }
    }
}
