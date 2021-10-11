using System;
using YandexTasks;
using YandexTasks.Tests;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            test_PalindromicFactor palindromicFactorTEST = new test_PalindromicFactor();
            System.Console.WriteLine(palindromicFactorTEST.Test());

            test_TimeThroughLookingGlass test = new test_TimeThroughLookingGlass();
            System.Console.WriteLine(Convert.ToString(test.Test()));
        }
    }
}
