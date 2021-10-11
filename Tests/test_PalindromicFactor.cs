namespace YandexTasks.Tests
{
    public class test_PalindromicFactor
    {
        public bool Test()
        {
            PalinromicFactor factor = new PalinromicFactor();

            string answer = factor.FindPalindromInWord("asadjfhbgjfdshgdf");
            string expectedResult = "asa";

            if (answer != expectedResult)
                return false;

            answer = factor.FindPalindromInWord("qwertyuiokazak");
            expectedResult = "aza";

            if (answer != expectedResult)
                return false;

            factor.ChangeMinimunPossibleCharactersInPalindrom(6);
            answer = factor.FindPalindromInWord("hdfjvhdjfbvhjkfdhhaahhfgkbsjadckfsda");
            expectedResult = "hhaahh";

            if (answer != expectedResult)
                return false;

            return true;
        }

    }
}