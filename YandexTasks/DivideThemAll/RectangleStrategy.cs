using System;
using System.Numerics;
using System.Collections.Generic;

namespace YandexTasks.DivideThemAll
{
    public class RectangleStrategy : IStrategy
    {
        public Vector2 FindCenterCoordinate(string stroke)
        {
            string[] splittedValuesInStroke = stroke.Split(' ');

            List<Vector2> listOfCoordinatePoints = new List<Vector2>();

            int xStartPositionInStringArray = 1;
            int yStartPositionInStringArray = 2;

            for (int i = 0; i < 4; i++)
            {
                listOfCoordinatePoints.Add(new Vector2(int.Parse(splittedValuesInStroke[xStartPositionInStringArray]), int.Parse(splittedValuesInStroke[yStartPositionInStringArray])));
                xStartPositionInStringArray = xStartPositionInStringArray + 2;
                yStartPositionInStringArray = yStartPositionInStringArray + 2;
            }

            Vector2 leftDownPoint = listOfCoordinatePoints[0];
            Vector2 rightTopPoint = listOfCoordinatePoints[0];

            foreach (Vector2 point in listOfCoordinatePoints)
            {
                if (leftDownPoint.X <= point.X && leftDownPoint.Y <= point.Y)
                {
                    leftDownPoint = point;
                }

                if (rightTopPoint.X >= point.X && rightTopPoint.Y >= point.Y)
                {
                    rightTopPoint = point;
                }
            }

            Vector2 centerPosition = new Vector2();
            centerPosition.X = leftDownPoint.X + ((rightTopPoint.X - leftDownPoint.X) / 2);
            centerPosition.Y = leftDownPoint.Y + ((rightTopPoint.Y - leftDownPoint.Y) / 2);


            return centerPosition;
        }
    }
}