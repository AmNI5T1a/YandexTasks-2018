using System;
using System.Numerics;


namespace YandexTasks.DivideThemAll
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public Vector2 ExecuteOperation(string stroke)
        {
            return _strategy.FindCenterCoordinate(stroke);
        }
    }
}