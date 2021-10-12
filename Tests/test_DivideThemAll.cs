using System;
using System.Numerics;
using System.Collections.Generic;

namespace YandexTasks.Tests
{
    public class test_DivideThemAll
    {
        public bool Test()
        {
            DivideThemAll divider = new DivideThemAll();

            divider.pointsPositionInWorldSpace = new List<Vector2>();
            divider.pointsPositionInWorldSpace.Add(new Vector2(3f, 3f));
            divider.pointsPositionInWorldSpace.Add(new Vector2(-4.5f, -4.5f));
            divider.pointsPositionInWorldSpace.Add(new Vector2(-9f, 9f));
            string answer = divider.CalculatePossibleToDivideThemIntoEqualParts();

            if (answer == "No")
                return false;

            divider.pointsPositionInWorldSpace = new List<Vector2>();
            divider.pointsPositionInWorldSpace.Add(new Vector2(0.5f, 0.5f));
            divider.pointsPositionInWorldSpace.Add(new Vector2(10f, 10f));
            divider.pointsPositionInWorldSpace.Add(new Vector2(2f, 3f));
            answer = divider.CalculatePossibleToDivideThemIntoEqualParts();

            if (answer == "Yes")
                return false;

            divider.pointsPositionInWorldSpace = new List<Vector2>();
            divider.pointsPositionInWorldSpace.Add(new Vector2(2f, 3f));
            answer = divider.CalculatePossibleToDivideThemIntoEqualParts();

            if (answer == "No")
                return false;

            return true;
        }
    }
}