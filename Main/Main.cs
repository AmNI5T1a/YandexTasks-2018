using System;
using YandexTasks;
using YandexTasks.Tests;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            test_PalindromicFactor TEST_PalindromicFactor = new test_PalindromicFactor();
            System.Console.WriteLine(TEST_PalindromicFactor.Test());

            test_TimeThroughLookingGlass TEST_TimeThroughLookingGlass = new test_TimeThroughLookingGlass();
            System.Console.WriteLine(Convert.ToString(TEST_TimeThroughLookingGlass.Test()));

            test_DivideThemAll test_DivideThemAll = new test_DivideThemAll();
            System.Console.WriteLine(Convert.ToString(test_DivideThemAll.Test()));
        }
    }
}
