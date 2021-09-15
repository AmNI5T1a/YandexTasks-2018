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


        private void GetInputFromUser()
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
            List<int> pointsPositionInWorldSpace = new List<int>();

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
                else if (Convert.ToUInt32(valuesInStroke[0]) == 0)
                {
                    _context.SetStrategy(new RectangleStrategy());
                }

                pointsPositionInWorldSpace.Add(_context.ExecuteOperation(stroke));
            }
        }
    }
}