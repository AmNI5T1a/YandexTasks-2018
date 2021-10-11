using System;
using System.Numerics;

namespace YandexTasks
{
    public interface IStrategy
    {
        Vector2 FindCenterCoordinate(string stroke);
    }
}