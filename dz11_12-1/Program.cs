namespace dz11_12_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write(" число словами (від zero до nine): ");
            string input = Console.ReadLine();

            try
            {
                int number = WordToNumber(input);
                Console.WriteLine($"Цифра: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        static int WordToNumber(string word)
        {
            switch (word.ToLower())
            {
                case "zero": return 0;
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                default:
                    throw new ArgumentException("некоректне слово.");
            }
        }
    }
}