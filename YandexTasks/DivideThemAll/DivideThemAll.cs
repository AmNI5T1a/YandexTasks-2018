using System;
using System.Numerics;
using System.Collections.Generic;

namespace YandexTasks
{
    public class DivideThemAll
    {
        public List<Vector2> pointsPositionInWorldSpace { get; set; }
        private Context _context = new Context();
        public void GetInputFromUser()
        {
            bool numberOfTargetPracticeIsFound = false;
            uint figuresCount = 0;
            pointsPositionInWorldSpace = new List<Vector2>();

            while (!numberOfTargetPracticeIsFound)
            {
                figuresCount = Convert.ToUInt16(Console.ReadLine());

                if (figuresCount >= 1 && figuresCount <= 100000)
                    numberOfTargetPracticeIsFound = true;
                else
                    System.Console.WriteLine("Number of target practice must be: (1 <= your input <= 100 000)");
            }

            List<string> listOfFiguresTypeAndTheirCoordinates = new List<string>();

            for (uint i = 0; i < figuresCount; i++)
            {
                listOfFiguresTypeAndTheirCoordinates.Add(Console.ReadLine());
            }

            foreach (string stroke in listOfFiguresTypeAndTheirCoordinates)
            {
                string[] valuesInStroke = stroke.Split(' ');

                if (Convert.ToUInt32(valuesInStroke[0]) == 0)
                {
                    _context.SetStrategy(new CircleStrategy());
                }
                else if (Convert.ToUInt32(valuesInStroke[0]) == 1)
                {
                    _context.SetStrategy(new RectangleStrategy());
                }

                pointsPositionInWorldSpace.Add(_context.ExecuteOperation(stroke));
            }
        }

        private Vector2 FindFarthestPointFromCenter()
        {
            Vector2 tempFarthestPointFromSpace = new Vector2(pointsPositionInWorldSpace[0].X, pointsPositionInWorldSpace[0].Y);

            foreach (Vector2 point in pointsPositionInWorldSpace)
            {
                if (Vector2.Distance(new Vector2(0, 0), point) > Vector2.Distance(new Vector2(0, 0), tempFarthestPointFromSpace))
                {
                    tempFarthestPointFromSpace = point;
                }
            }

            return tempFarthestPointFromSpace;
        }

        public string CalculatePossibleToDivideThemIntoEqualParts()
        {
            if (pointsPositionInWorldSpace.Count <= 2)
            {
                return "Yes";
            }
            else
            {
                Vector2[] farthestPointsInVector2Space = new Vector2[]
            {
                new Vector2(0,0),
                new Vector2(0,0)
            };

                farthestPointsInVector2Space[0] = FindFarthestPointFromCenter();
                pointsPositionInWorldSpace.Remove(farthestPointsInVector2Space[0]);
                farthestPointsInVector2Space[1] = FindFarthestPointFromCenter();
                pointsPositionInWorldSpace.Remove(farthestPointsInVector2Space[1]);


                foreach (Vector2 point in pointsPositionInWorldSpace)
                {
                    if ((((point.X - farthestPointsInVector2Space[0].X) * (farthestPointsInVector2Space[1].Y - farthestPointsInVector2Space[0].Y)) - ((farthestPointsInVector2Space[1].X - farthestPointsInVector2Space[0].X) * (point.Y - farthestPointsInVector2Space[0].Y))) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return "No";
                    }
                }

                return "Yes";
            }

        }
    }
}