using System;

namespace YandexTasks.Tests
{
    public class test_TimeThroughLookingGlass
    {
        public bool Test()
        {
            TimeThroughTheLookingGlass firstTask = new TimeThroughTheLookingGlass();

            string[] answer = firstTask.CalculateRealTimeTest("2 45");
            string[] expectedResult = new string[] { "10", "15" };

            if (expectedResult[0] != answer[0] || expectedResult[1] != answer[1])
                return false;

            answer = firstTask.CalculateRealTimeTest("6 0");
            expectedResult = new string[] { "6", "0" };

            if (expectedResult[0] != answer[0] || expectedResult[1] != answer[1])
                return false;

            return true;
        }
    }
}