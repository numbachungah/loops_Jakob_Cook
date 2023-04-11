using System;

namespace loops_Jakob_Cook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why doo you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");



            static int CountNumberOfSpaces(string sentence)

                int numberOfSpaces = 0;
            foreach(char character in sentence)

                if (character == ' ')

                    numberOfSpaces++;

            return numberOfSpaces;



            static int SumOfDigits(string number)

                int sum = 0;
            foreach(char digit in number)

                sum += (int)Char.GetNumericValue(digit);
        }
    }
}
