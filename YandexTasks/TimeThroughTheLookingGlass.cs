using System;

namespace YandexTasks
{
    public class TimeThroughTheLookingGlass
    {
        public string[] CalculateRealTimeTest(string userInput)
        {
            string[] splittedStroke = SplitStrokeBySpace(userInput);
            splittedStroke = CheckInputBeforeCalculate(splittedStroke);

            int hoursFromInput = int.Parse(splittedStroke[0]);
            int minutesFromInput = int.Parse(splittedStroke[1]);

            return new string[] { Convert.ToString((12 - hoursFromInput) is 12 ? 0 : 12 - hoursFromInput),
                                  Convert.ToString((60 - minutesFromInput) is 60 ? 0 : 60 - minutesFromInput)
                                 };
        }

        private string[] CheckInputBeforeCalculate(string[] userInput)
        {
            bool userInputIsCorrect = true;

            if ((Convert.ToByte(userInput[0]) >= 12 && Convert.ToByte(userInput[0]) < 0) || (Convert.ToByte(userInput[1]) < 0 && Convert.ToByte(userInput[1]) > 60))
            {
                userInputIsCorrect = false;
            }

            while (!userInputIsCorrect)
            {
                string newUserInput = Console.ReadLine();
                string[] splittedInput = SplitStrokeBySpace(newUserInput);

                if ((Convert.ToByte(userInput[0]) >= 12 && Convert.ToByte(userInput[0]) < 0) || (Convert.ToByte(userInput[1]) < 0 && Convert.ToByte(userInput[1]) > 60))
                {
                    System.Console.WriteLine("Input is wrong");
                    System.Console.WriteLine("Example of input: 0 45 (first one is hours, second is minutes");
                }
                else
                {
                    userInputIsCorrect = true;
                    return splittedInput;
                }
            }

            return userInput;
        }

        private string[] SplitStrokeBySpace(string strokeToSplitBySpace)
        {
            string[] splittedStroke = strokeToSplitBySpace.Split();

            return splittedStroke;
        }
    }
}
