using System;
using System.Numerics;

namespace YandexTasks
{
    public class CircleStrategy : IStrategy
    {
        public Vector2 FindCenterCoordinate(string stroke)
        {
            string[] splittedValuesInStroke = stroke.Split(' ');
            return new Vector2(Convert.ToInt32(splittedValuesInStroke[2]), Convert.ToInt32(splittedValuesInStroke[3]));
        }
    }
}