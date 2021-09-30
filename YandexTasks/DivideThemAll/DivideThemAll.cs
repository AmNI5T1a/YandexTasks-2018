using System;
using System.Numerics;
using System.Collections.Generic;


namespace YandexTasks.DivideThemAll
{
    public class DivideThemAll
    {
        private Context _context = new Context();
        public DivideThemAll()
        {
            GetInputFromUser();
        }


        private string GetInputFromUser()
        {
            bool numberOfTargetPracticeIsFound = false;
            uint figuresCount = 0;

            while (!numberOfTargetPracticeIsFound)
            {
                figuresCount = Convert.ToUInt16(Console.ReadLine());

                if (figuresCount >= 1 && figuresCount <= 100000)
                    numberOfTargetPracticeIsFound = true;
                else
                    System.Console.WriteLine("Number of target practice must be: (1 <= your input <= 100 000)");
            }


            // TODO: 
            //! 1 - Rework to another method
            List<string> figureTypeAndCoordinatesFromUserInput = new List<string>();
            List<Vector2> pointsPositionInWorldSpace = new List<Vector2>();

            for (uint i = 0; i < figuresCount; i++)
            {
                figureTypeAndCoordinatesFromUserInput.Add(Console.ReadLine());
            }

            foreach (string stroke in figureTypeAndCoordinatesFromUserInput)
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

            Vector2[] twoPointsConnectedByALine = new Vector2[]
            {
                new Vector2(pointsPositionInWorldSpace[0].X,pointsPositionInWorldSpace[0].Y),
                new Vector2(pointsPositionInWorldSpace[1].X,pointsPositionInWorldSpace[1].Y),
            };

            foreach (Vector2 point in pointsPositionInWorldSpace)
            {
                if (Vector2.Distance(new Vector2(0, 0), point) > Vector2.Distance(new Vector2(0, 0), twoPointsConnectedByALine[0]))
                {
                    twoPointsConnectedByALine[0] = point;
                }
            }

            foreach (Vector2 point in pointsPositionInWorldSpace)
            {
                if (Vector2.Distance(new Vector2(0, 0), point) > Vector2.Distance(new Vector2(0, 0), twoPointsConnectedByALine[1]))
                {
                    if (point != twoPointsConnectedByALine[0])
                    {
                        twoPointsConnectedByALine[1] = point;
                    }
                }
            }

            foreach (Vector2 point in pointsPositionInWorldSpace)
            {
                if (point == twoPointsConnectedByALine[0] || point == twoPointsConnectedByALine[1])
                {
                    pointsPositionInWorldSpace.Remove(point);
                }
            }

            foreach (Vector2 point in pointsPositionInWorldSpace)
            {
                if ((((point.X - twoPointsConnectedByALine[0].X) * (twoPointsConnectedByALine[1].Y - twoPointsConnectedByALine[0].Y)) - ((twoPointsConnectedByALine[1].X - twoPointsConnectedByALine[0].X) * (point.Y - twoPointsConnectedByALine[0].Y))) == 0)
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