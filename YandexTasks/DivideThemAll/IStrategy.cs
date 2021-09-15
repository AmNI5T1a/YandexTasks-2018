using System;
using System.Numerics;

namespace YandexTasks.DivideThemAll
{
    public interface IStrategy
    {
        Vector2 FindCenterCoordinate(string stroke);
    }
}