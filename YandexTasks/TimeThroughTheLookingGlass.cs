using System;

namespace YandexTasks
{
    public class TimeThroughTheLookingGlass
    {
        public TimeThroughTheLookingGlass()
        {
            string[] generatedData = CalculateRealTimeTest();
            System.Console.WriteLine(generatedData[0] + " " + generatedData[1]);
        }

        private string[] CalculateRealTimeTest()
        {
            string[] userInput = Console.ReadLine().Split();

            int hoursFromInput = int.Parse(userInput[0]);
            int minutesFromInput = int.Parse(userInput[1]);

            return new string[] { Convert.ToString((12 - hoursFromInput) is 12 ? 0 : 12 - hoursFromInput),
                                  Convert.ToString((60 - minutesFromInput) is 60 ? 0 : 60 - minutesFromInput)
                                 };
        }
    }
}
