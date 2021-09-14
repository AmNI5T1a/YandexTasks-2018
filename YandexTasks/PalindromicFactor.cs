using System;
using System.Linq;


namespace YandexTasks
{
    public class PalinromicFactor
    {
        public PalinromicFactor()
        {
            Console.WriteLine(FindPalindromOfTheStroke("kazak"));
            Console.WriteLine(FindPalindromOfTheStroke("yandex"));
        }

        private void GetInputFromUser()
        {
            bool userInputIsCorrect = false;
            string userInput = null;

            while (!userInputIsCorrect)
            {
                userInput = Console.ReadLine();

                if (userInput.Length < 2 || userInput.Length >= 200000)
                    System.Console.WriteLine("Min size of stroke is: 2 \nMax size of stroke is: 200,000");
                else
                    userInputIsCorrect = true;
            }
        }

        private string FindPalindromOfTheStroke(string userInput)
        {
            uint minPossibleLettersInPalindrom = 2;

            bool answerIsFound = false;

            while (!answerIsFound)
            {
                string[] splittedUserStroke = SplitStringByCharacter(userInput);
                string underStroke = null;
                int saveCurrentStartPositionToCreateUnderStroke = 0;

                for (int j = 0; j <= userInput.Length - minPossibleLettersInPalindrom;)
                {
                    underStroke = null;
                    for (int i = 0; i < minPossibleLettersInPalindrom; i++)
                    {
                        underStroke = underStroke + splittedUserStroke[j];
                        j++;
                    }

                    if (underStroke == ReverseString(underStroke))
                    {
                        answerIsFound = true;
                        return underStroke;
                    }
                    else
                    {
                        saveCurrentStartPositionToCreateUnderStroke++;
                        j = saveCurrentStartPositionToCreateUnderStroke;

                        if (saveCurrentStartPositionToCreateUnderStroke - 1 == userInput.Length - minPossibleLettersInPalindrom)
                        {
                            minPossibleLettersInPalindrom++;

                            if (minPossibleLettersInPalindrom - 1 == userInput.Length)
                            {
                                return new string("-1");
                            }
                        }
                    }
                }
            }

            return new string("-1");
        }


        private string[] SplitStringByCharacter(string strokeToSplitByCharacter)
        {
            char[] arr = strokeToSplitByCharacter.ToCharArray();
            string[] splittedStringArray = new string[arr.Length];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                splittedStringArray[i] = Convert.ToString(arr[i]);
            }

            return splittedStringArray;
        }
        private string ReverseString(string strokeToReverse)
        {
            char[] arr = strokeToReverse.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}